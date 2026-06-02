-- Diagnostic script for PostgreSQL procedure public.sp_insert_usuario
-- Goal: confirm whether latency/locks are inside the procedure path.

-- 1) Confirm procedure exists and inspect definition.
SELECT n.nspname AS schema_name,
       p.proname AS routine_name,
       pg_get_function_identity_arguments(p.oid) AS args,
       pg_get_functiondef(p.oid) AS routine_definition
FROM pg_proc p
JOIN pg_namespace n ON n.oid = p.pronamespace
WHERE n.nspname = 'public'
  AND p.proname = 'sp_insert_usuario';

-- 2) Check indexes and constraints on likely hot table.
SELECT indexname, indexdef
FROM pg_indexes
WHERE schemaname = 'public'
  AND tablename = 'usuarios'
ORDER BY indexname;

SELECT conname,
       contype,
       pg_get_constraintdef(oid) AS constraint_def
FROM pg_constraint
WHERE conrelid = 'public.usuarios'::regclass
ORDER BY contype, conname;

-- 3) Check triggers on usuarios (possible hidden work).
SELECT trigger_name,
       action_timing,
       event_manipulation,
       action_statement
FROM information_schema.triggers
WHERE event_object_schema = 'public'
  AND event_object_table = 'usuarios'
ORDER BY trigger_name;

-- 4) Real-time blocked vs blocker map (run while app is hanging).
SELECT a.pid AS waiting_pid,
       a.usename AS waiting_user,
       a.wait_event_type,
       a.wait_event,
       now() - a.query_start AS waiting_for,
       a.state AS waiting_state,
       pg_blocking_pids(a.pid) AS blocking_pids,
       a.query AS waiting_query
FROM pg_stat_activity a
WHERE a.datname = current_database()
  AND a.state <> 'idle'
ORDER BY a.query_start;

-- 5) Lock inventory for active sessions (run while app is hanging).
SELECT l.pid,
       a.usename,
       a.application_name,
       a.client_addr,
       l.locktype,
       l.mode,
       l.granted,
       l.relation::regclass AS relation_name,
       now() - a.query_start AS running_for,
       a.query
FROM pg_locks l
JOIN pg_stat_activity a ON a.pid = l.pid
WHERE a.datname = current_database()
ORDER BY l.granted, running_for DESC;

-- 6) Long-running statements currently executing.
SELECT pid,
       usename,
       application_name,
       state,
       wait_event_type,
       wait_event,
       now() - query_start AS running_for,
       query
FROM pg_stat_activity
WHERE datname = current_database()
  AND state <> 'idle'
ORDER BY running_for DESC;

-- 7) Optional: statement stats for procedure calls (requires pg_stat_statements).
-- If extension is not installed, this query will fail and can be skipped.
SELECT query,
       calls,
       total_exec_time,
       mean_exec_time,
       min_exec_time,
       max_exec_time,
       rows
FROM pg_stat_statements
WHERE query ILIKE '%sp_insert_usuario%'
ORDER BY total_exec_time DESC;

-- 8) Table health indicators for usuarios.
SELECT relname,
       n_live_tup,
       n_dead_tup,
       last_vacuum,
       last_autovacuum,
       last_analyze,
       last_autoanalyze
FROM pg_stat_user_tables
WHERE relname = 'usuarios';

-- 9) Call this only in a dedicated test environment with known safe values.
-- IMPORTANT: replace placeholders before execution.
-- CALL public.sp_insert_usuario(
--   2,
--   'diag_user_12345',
--   'Abc12345!',
--   'Diag',
--   'Usuario',
--   'Prueba',
--   '119912345'
-- );

-- 10) If a call is hanging, identify and optionally cancel only the waiting backend.
-- SELECT pg_cancel_backend(<waiting_pid>);
-- Use pg_terminate_backend(<pid>) only as last resort.
