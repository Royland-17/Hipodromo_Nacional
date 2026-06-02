# sp_insert_usuario diagnosis runbook

This runbook is focused on proving whether slowness is inside public.sp_insert_usuario.

## Scope
- App connectivity is healthy for regular catalog queries.
- Create flow hangs around user insert path.
- Goal: capture hard DB evidence (locks, blockers, runtime, trigger/index impact).

## How to run
1. Open your SQL client against the same database used by the app.
2. Run sections 1 to 3 from docs/db/sp_insert_usuario_diagnostico.sql.
3. Start a real create request from the app.
4. While request is waiting, run sections 4 to 6 repeatedly every 2 to 5 seconds.
5. If available, run section 7 (pg_stat_statements).
6. Run section 8 for table health.

## What confirms SP bottleneck
- waiting_query references call public.sp_insert_usuario(...)
- wait_event_type is Lock or IO for waiting backend.
- blocking_pids is not empty.
- high mean_exec_time/max_exec_time for statements linked to sp_insert_usuario.
- heavy trigger activity on public.usuarios.

## What to send back
- Output of sections 4, 5, and 6 captured during one hanging request.
- Output of sections 2 and 3 (indexes, constraints, triggers on usuarios).
- Output of section 7 if pg_stat_statements exists.

## Fast mitigation options for DBA
1. Add or fix missing indexes used by validations/joins inside the procedure.
2. Move expensive non-critical logic from trigger/procedure to async processing.
3. Reduce lock scope and transaction duration inside procedure.
4. Replace broad scans with key lookups and deterministic upsert patterns.
5. Vacuum/analyze if dead tuples are high.
