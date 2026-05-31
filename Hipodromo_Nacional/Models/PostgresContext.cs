using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hipodromo_Nacional.Models;

public partial class PostgresContext : DbContext
{
    public PostgresContext()
    {
    }

    public PostgresContext(DbContextOptions<PostgresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alerta> Alertas { get; set; }

    public virtual DbSet<AliDefault> AliDefaults { get; set; }

    public virtual DbSet<AliQ12025> AliQ12025s { get; set; }

    public virtual DbSet<AliQ12026> AliQ12026s { get; set; }

    public virtual DbSet<AliQ12027> AliQ12027s { get; set; }

    public virtual DbSet<AliQ12028> AliQ12028s { get; set; }

    public virtual DbSet<AliQ22025> AliQ22025s { get; set; }

    public virtual DbSet<AliQ22026> AliQ22026s { get; set; }

    public virtual DbSet<AliQ22027> AliQ22027s { get; set; }

    public virtual DbSet<AliQ22028> AliQ22028s { get; set; }

    public virtual DbSet<AliQ32025> AliQ32025s { get; set; }

    public virtual DbSet<AliQ32026> AliQ32026s { get; set; }

    public virtual DbSet<AliQ32027> AliQ32027s { get; set; }

    public virtual DbSet<AliQ32028> AliQ32028s { get; set; }

    public virtual DbSet<AliQ42025> AliQ42025s { get; set; }

    public virtual DbSet<AliQ42026> AliQ42026s { get; set; }

    public virtual DbSet<AliQ42027> AliQ42027s { get; set; }

    public virtual DbSet<AliQ42028> AliQ42028s { get; set; }

    public virtual DbSet<AsignacionesEstablo> AsignacionesEstablos { get; set; }

    public virtual DbSet<AuditLogEntry> AuditLogEntries { get; set; }

    public virtual DbSet<Barrio> Barrios { get; set; }

    public virtual DbSet<BitAlertDefault> BitAlertDefaults { get; set; }

    public virtual DbSet<BitAlertQ12025> BitAlertQ12025s { get; set; }

    public virtual DbSet<BitAlertQ12026> BitAlertQ12026s { get; set; }

    public virtual DbSet<BitAlertQ12027> BitAlertQ12027s { get; set; }

    public virtual DbSet<BitAlertQ22025> BitAlertQ22025s { get; set; }

    public virtual DbSet<BitAlertQ22026> BitAlertQ22026s { get; set; }

    public virtual DbSet<BitAlertQ22027> BitAlertQ22027s { get; set; }

    public virtual DbSet<BitAlertQ32025> BitAlertQ32025s { get; set; }

    public virtual DbSet<BitAlertQ32026> BitAlertQ32026s { get; set; }

    public virtual DbSet<BitAlertQ32027> BitAlertQ32027s { get; set; }

    public virtual DbSet<BitAlertQ42025> BitAlertQ42025s { get; set; }

    public virtual DbSet<BitAlertQ42026> BitAlertQ42026s { get; set; }

    public virtual DbSet<BitAlertQ42027> BitAlertQ42027s { get; set; }

    public virtual DbSet<BitAliDefault> BitAliDefaults { get; set; }

    public virtual DbSet<BitAliQ12025> BitAliQ12025s { get; set; }

    public virtual DbSet<BitAliQ12026> BitAliQ12026s { get; set; }

    public virtual DbSet<BitAliQ12027> BitAliQ12027s { get; set; }

    public virtual DbSet<BitAliQ22025> BitAliQ22025s { get; set; }

    public virtual DbSet<BitAliQ22026> BitAliQ22026s { get; set; }

    public virtual DbSet<BitAliQ22027> BitAliQ22027s { get; set; }

    public virtual DbSet<BitAliQ32025> BitAliQ32025s { get; set; }

    public virtual DbSet<BitAliQ32026> BitAliQ32026s { get; set; }

    public virtual DbSet<BitAliQ32027> BitAliQ32027s { get; set; }

    public virtual DbSet<BitAliQ42025> BitAliQ42025s { get; set; }

    public virtual DbSet<BitAliQ42026> BitAliQ42026s { get; set; }

    public virtual DbSet<BitAliQ42027> BitAliQ42027s { get; set; }

    public virtual DbSet<BitAsigDefault> BitAsigDefaults { get; set; }

    public virtual DbSet<BitAsigQ12025> BitAsigQ12025s { get; set; }

    public virtual DbSet<BitAsigQ12026> BitAsigQ12026s { get; set; }

    public virtual DbSet<BitAsigQ12027> BitAsigQ12027s { get; set; }

    public virtual DbSet<BitAsigQ22025> BitAsigQ22025s { get; set; }

    public virtual DbSet<BitAsigQ22026> BitAsigQ22026s { get; set; }

    public virtual DbSet<BitAsigQ22027> BitAsigQ22027s { get; set; }

    public virtual DbSet<BitAsigQ32025> BitAsigQ32025s { get; set; }

    public virtual DbSet<BitAsigQ32026> BitAsigQ32026s { get; set; }

    public virtual DbSet<BitAsigQ32027> BitAsigQ32027s { get; set; }

    public virtual DbSet<BitAsigQ42025> BitAsigQ42025s { get; set; }

    public virtual DbSet<BitAsigQ42026> BitAsigQ42026s { get; set; }

    public virtual DbSet<BitAsigQ42027> BitAsigQ42027s { get; set; }

    public virtual DbSet<BitCabDefault> BitCabDefaults { get; set; }

    public virtual DbSet<BitCabQ12025> BitCabQ12025s { get; set; }

    public virtual DbSet<BitCabQ12026> BitCabQ12026s { get; set; }

    public virtual DbSet<BitCabQ12027> BitCabQ12027s { get; set; }

    public virtual DbSet<BitCabQ22025> BitCabQ22025s { get; set; }

    public virtual DbSet<BitCabQ22026> BitCabQ22026s { get; set; }

    public virtual DbSet<BitCabQ22027> BitCabQ22027s { get; set; }

    public virtual DbSet<BitCabQ32025> BitCabQ32025s { get; set; }

    public virtual DbSet<BitCabQ32026> BitCabQ32026s { get; set; }

    public virtual DbSet<BitCabQ32027> BitCabQ32027s { get; set; }

    public virtual DbSet<BitCabQ42025> BitCabQ42025s { get; set; }

    public virtual DbSet<BitCabQ42026> BitCabQ42026s { get; set; }

    public virtual DbSet<BitCabQ42027> BitCabQ42027s { get; set; }

    public virtual DbSet<BitCertDefault> BitCertDefaults { get; set; }

    public virtual DbSet<BitCertQ12025> BitCertQ12025s { get; set; }

    public virtual DbSet<BitCertQ12026> BitCertQ12026s { get; set; }

    public virtual DbSet<BitCertQ12027> BitCertQ12027s { get; set; }

    public virtual DbSet<BitCertQ22025> BitCertQ22025s { get; set; }

    public virtual DbSet<BitCertQ22026> BitCertQ22026s { get; set; }

    public virtual DbSet<BitCertQ22027> BitCertQ22027s { get; set; }

    public virtual DbSet<BitCertQ32025> BitCertQ32025s { get; set; }

    public virtual DbSet<BitCertQ32026> BitCertQ32026s { get; set; }

    public virtual DbSet<BitCertQ32027> BitCertQ32027s { get; set; }

    public virtual DbSet<BitCertQ42025> BitCertQ42025s { get; set; }

    public virtual DbSet<BitCertQ42026> BitCertQ42026s { get; set; }

    public virtual DbSet<BitCertQ42027> BitCertQ42027s { get; set; }

    public virtual DbSet<BitEstDefault> BitEstDefaults { get; set; }

    public virtual DbSet<BitEstQ12025> BitEstQ12025s { get; set; }

    public virtual DbSet<BitEstQ12026> BitEstQ12026s { get; set; }

    public virtual DbSet<BitEstQ12027> BitEstQ12027s { get; set; }

    public virtual DbSet<BitEstQ22025> BitEstQ22025s { get; set; }

    public virtual DbSet<BitEstQ22026> BitEstQ22026s { get; set; }

    public virtual DbSet<BitEstQ22027> BitEstQ22027s { get; set; }

    public virtual DbSet<BitEstQ32025> BitEstQ32025s { get; set; }

    public virtual DbSet<BitEstQ32026> BitEstQ32026s { get; set; }

    public virtual DbSet<BitEstQ32027> BitEstQ32027s { get; set; }

    public virtual DbSet<BitEstQ42025> BitEstQ42025s { get; set; }

    public virtual DbSet<BitEstQ42026> BitEstQ42026s { get; set; }

    public virtual DbSet<BitEstQ42027> BitEstQ42027s { get; set; }

    public virtual DbSet<BitEvDefault> BitEvDefaults { get; set; }

    public virtual DbSet<BitEvQ12025> BitEvQ12025s { get; set; }

    public virtual DbSet<BitEvQ12026> BitEvQ12026s { get; set; }

    public virtual DbSet<BitEvQ12027> BitEvQ12027s { get; set; }

    public virtual DbSet<BitEvQ22025> BitEvQ22025s { get; set; }

    public virtual DbSet<BitEvQ22026> BitEvQ22026s { get; set; }

    public virtual DbSet<BitEvQ22027> BitEvQ22027s { get; set; }

    public virtual DbSet<BitEvQ32025> BitEvQ32025s { get; set; }

    public virtual DbSet<BitEvQ32026> BitEvQ32026s { get; set; }

    public virtual DbSet<BitEvQ32027> BitEvQ32027s { get; set; }

    public virtual DbSet<BitEvQ42025> BitEvQ42025s { get; set; }

    public virtual DbSet<BitEvQ42026> BitEvQ42026s { get; set; }

    public virtual DbSet<BitEvQ42027> BitEvQ42027s { get; set; }

    public virtual DbSet<BitFacDefault> BitFacDefaults { get; set; }

    public virtual DbSet<BitFacQ12025> BitFacQ12025s { get; set; }

    public virtual DbSet<BitFacQ12026> BitFacQ12026s { get; set; }

    public virtual DbSet<BitFacQ12027> BitFacQ12027s { get; set; }

    public virtual DbSet<BitFacQ22025> BitFacQ22025s { get; set; }

    public virtual DbSet<BitFacQ22026> BitFacQ22026s { get; set; }

    public virtual DbSet<BitFacQ22027> BitFacQ22027s { get; set; }

    public virtual DbSet<BitFacQ32025> BitFacQ32025s { get; set; }

    public virtual DbSet<BitFacQ32026> BitFacQ32026s { get; set; }

    public virtual DbSet<BitFacQ32027> BitFacQ32027s { get; set; }

    public virtual DbSet<BitFacQ42025> BitFacQ42025s { get; set; }

    public virtual DbSet<BitFacQ42026> BitFacQ42026s { get; set; }

    public virtual DbSet<BitFacQ42027> BitFacQ42027s { get; set; }

    public virtual DbSet<BitHvDefault> BitHvDefaults { get; set; }

    public virtual DbSet<BitHvQ12025> BitHvQ12025s { get; set; }

    public virtual DbSet<BitHvQ12026> BitHvQ12026s { get; set; }

    public virtual DbSet<BitHvQ12027> BitHvQ12027s { get; set; }

    public virtual DbSet<BitHvQ22025> BitHvQ22025s { get; set; }

    public virtual DbSet<BitHvQ22026> BitHvQ22026s { get; set; }

    public virtual DbSet<BitHvQ22027> BitHvQ22027s { get; set; }

    public virtual DbSet<BitHvQ32025> BitHvQ32025s { get; set; }

    public virtual DbSet<BitHvQ32026> BitHvQ32026s { get; set; }

    public virtual DbSet<BitHvQ32027> BitHvQ32027s { get; set; }

    public virtual DbSet<BitHvQ42025> BitHvQ42025s { get; set; }

    public virtual DbSet<BitHvQ42026> BitHvQ42026s { get; set; }

    public virtual DbSet<BitHvQ42027> BitHvQ42027s { get; set; }

    public virtual DbSet<BitInsDefault> BitInsDefaults { get; set; }

    public virtual DbSet<BitInsQ12025> BitInsQ12025s { get; set; }

    public virtual DbSet<BitInsQ12026> BitInsQ12026s { get; set; }

    public virtual DbSet<BitInsQ12027> BitInsQ12027s { get; set; }

    public virtual DbSet<BitInsQ22025> BitInsQ22025s { get; set; }

    public virtual DbSet<BitInsQ22026> BitInsQ22026s { get; set; }

    public virtual DbSet<BitInsQ22027> BitInsQ22027s { get; set; }

    public virtual DbSet<BitInsQ32025> BitInsQ32025s { get; set; }

    public virtual DbSet<BitInsQ32026> BitInsQ32026s { get; set; }

    public virtual DbSet<BitInsQ32027> BitInsQ32027s { get; set; }

    public virtual DbSet<BitInsQ42025> BitInsQ42025s { get; set; }

    public virtual DbSet<BitInsQ42026> BitInsQ42026s { get; set; }

    public virtual DbSet<BitInsQ42027> BitInsQ42027s { get; set; }

    public virtual DbSet<BitPropDefault> BitPropDefaults { get; set; }

    public virtual DbSet<BitPropQ12025> BitPropQ12025s { get; set; }

    public virtual DbSet<BitPropQ12026> BitPropQ12026s { get; set; }

    public virtual DbSet<BitPropQ12027> BitPropQ12027s { get; set; }

    public virtual DbSet<BitPropQ22025> BitPropQ22025s { get; set; }

    public virtual DbSet<BitPropQ22026> BitPropQ22026s { get; set; }

    public virtual DbSet<BitPropQ22027> BitPropQ22027s { get; set; }

    public virtual DbSet<BitPropQ32025> BitPropQ32025s { get; set; }

    public virtual DbSet<BitPropQ32026> BitPropQ32026s { get; set; }

    public virtual DbSet<BitPropQ32027> BitPropQ32027s { get; set; }

    public virtual DbSet<BitPropQ42025> BitPropQ42025s { get; set; }

    public virtual DbSet<BitPropQ42026> BitPropQ42026s { get; set; }

    public virtual DbSet<BitPropQ42027> BitPropQ42027s { get; set; }

    public virtual DbSet<BitProvDefault> BitProvDefaults { get; set; }

    public virtual DbSet<BitProvQ12025> BitProvQ12025s { get; set; }

    public virtual DbSet<BitProvQ12026> BitProvQ12026s { get; set; }

    public virtual DbSet<BitProvQ12027> BitProvQ12027s { get; set; }

    public virtual DbSet<BitProvQ22025> BitProvQ22025s { get; set; }

    public virtual DbSet<BitProvQ22026> BitProvQ22026s { get; set; }

    public virtual DbSet<BitProvQ22027> BitProvQ22027s { get; set; }

    public virtual DbSet<BitProvQ32025> BitProvQ32025s { get; set; }

    public virtual DbSet<BitProvQ32026> BitProvQ32026s { get; set; }

    public virtual DbSet<BitProvQ32027> BitProvQ32027s { get; set; }

    public virtual DbSet<BitProvQ42025> BitProvQ42025s { get; set; }

    public virtual DbSet<BitProvQ42026> BitProvQ42026s { get; set; }

    public virtual DbSet<BitProvQ42027> BitProvQ42027s { get; set; }

    public virtual DbSet<BitResDefault> BitResDefaults { get; set; }

    public virtual DbSet<BitResQ12025> BitResQ12025s { get; set; }

    public virtual DbSet<BitResQ12026> BitResQ12026s { get; set; }

    public virtual DbSet<BitResQ12027> BitResQ12027s { get; set; }

    public virtual DbSet<BitResQ22025> BitResQ22025s { get; set; }

    public virtual DbSet<BitResQ22026> BitResQ22026s { get; set; }

    public virtual DbSet<BitResQ22027> BitResQ22027s { get; set; }

    public virtual DbSet<BitResQ32025> BitResQ32025s { get; set; }

    public virtual DbSet<BitResQ32026> BitResQ32026s { get; set; }

    public virtual DbSet<BitResQ32027> BitResQ32027s { get; set; }

    public virtual DbSet<BitResQ42025> BitResQ42025s { get; set; }

    public virtual DbSet<BitResQ42026> BitResQ42026s { get; set; }

    public virtual DbSet<BitResQ42027> BitResQ42027s { get; set; }

    public virtual DbSet<BitSumDefault> BitSumDefaults { get; set; }

    public virtual DbSet<BitSumQ12025> BitSumQ12025s { get; set; }

    public virtual DbSet<BitSumQ12026> BitSumQ12026s { get; set; }

    public virtual DbSet<BitSumQ12027> BitSumQ12027s { get; set; }

    public virtual DbSet<BitSumQ22025> BitSumQ22025s { get; set; }

    public virtual DbSet<BitSumQ22026> BitSumQ22026s { get; set; }

    public virtual DbSet<BitSumQ22027> BitSumQ22027s { get; set; }

    public virtual DbSet<BitSumQ32025> BitSumQ32025s { get; set; }

    public virtual DbSet<BitSumQ32026> BitSumQ32026s { get; set; }

    public virtual DbSet<BitSumQ32027> BitSumQ32027s { get; set; }

    public virtual DbSet<BitSumQ42025> BitSumQ42025s { get; set; }

    public virtual DbSet<BitSumQ42026> BitSumQ42026s { get; set; }

    public virtual DbSet<BitSumQ42027> BitSumQ42027s { get; set; }

    public virtual DbSet<BitTrnDefault> BitTrnDefaults { get; set; }

    public virtual DbSet<BitTrnQ12025> BitTrnQ12025s { get; set; }

    public virtual DbSet<BitTrnQ12026> BitTrnQ12026s { get; set; }

    public virtual DbSet<BitTrnQ12027> BitTrnQ12027s { get; set; }

    public virtual DbSet<BitTrnQ22025> BitTrnQ22025s { get; set; }

    public virtual DbSet<BitTrnQ22026> BitTrnQ22026s { get; set; }

    public virtual DbSet<BitTrnQ22027> BitTrnQ22027s { get; set; }

    public virtual DbSet<BitTrnQ32025> BitTrnQ32025s { get; set; }

    public virtual DbSet<BitTrnQ32026> BitTrnQ32026s { get; set; }

    public virtual DbSet<BitTrnQ32027> BitTrnQ32027s { get; set; }

    public virtual DbSet<BitTrnQ42025> BitTrnQ42025s { get; set; }

    public virtual DbSet<BitTrnQ42026> BitTrnQ42026s { get; set; }

    public virtual DbSet<BitTrnQ42027> BitTrnQ42027s { get; set; }

    public virtual DbSet<BitUsrDefault> BitUsrDefaults { get; set; }

    public virtual DbSet<BitUsrQ12025> BitUsrQ12025s { get; set; }

    public virtual DbSet<BitUsrQ12026> BitUsrQ12026s { get; set; }

    public virtual DbSet<BitUsrQ12027> BitUsrQ12027s { get; set; }

    public virtual DbSet<BitUsrQ22025> BitUsrQ22025s { get; set; }

    public virtual DbSet<BitUsrQ22026> BitUsrQ22026s { get; set; }

    public virtual DbSet<BitUsrQ22027> BitUsrQ22027s { get; set; }

    public virtual DbSet<BitUsrQ32025> BitUsrQ32025s { get; set; }

    public virtual DbSet<BitUsrQ32026> BitUsrQ32026s { get; set; }

    public virtual DbSet<BitUsrQ32027> BitUsrQ32027s { get; set; }

    public virtual DbSet<BitUsrQ42025> BitUsrQ42025s { get; set; }

    public virtual DbSet<BitUsrQ42026> BitUsrQ42026s { get; set; }

    public virtual DbSet<BitUsrQ42027> BitUsrQ42027s { get; set; }

    public virtual DbSet<BitacoraDetalleF2025Q1> BitacoraDetalleF2025Q1s { get; set; }

    public virtual DbSet<BitacoraDetalleF2025Q2> BitacoraDetalleF2025Q2s { get; set; }

    public virtual DbSet<BitacoraDetalleF2025Q3> BitacoraDetalleF2025Q3s { get; set; }

    public virtual DbSet<BitacoraDetalleF2025Q4> BitacoraDetalleF2025Q4s { get; set; }

    public virtual DbSet<BitacoraDetalleF2026Q1> BitacoraDetalleF2026Q1s { get; set; }

    public virtual DbSet<BitacoraDetalleF2026Q2> BitacoraDetalleF2026Q2s { get; set; }

    public virtual DbSet<BitacoraDetalleF2026Q3> BitacoraDetalleF2026Q3s { get; set; }

    public virtual DbSet<BitacoraDetalleF2026Q4> BitacoraDetalleF2026Q4s { get; set; }

    public virtual DbSet<BitacoraDetalleF2027Q1> BitacoraDetalleF2027Q1s { get; set; }

    public virtual DbSet<BitacoraDetalleF2027Q2> BitacoraDetalleF2027Q2s { get; set; }

    public virtual DbSet<BitacoraDetalleF2027Q3> BitacoraDetalleF2027Q3s { get; set; }

    public virtual DbSet<BitacoraDetalleF2027Q4> BitacoraDetalleF2027Q4s { get; set; }

    public virtual DbSet<BitacoraDetalleFDefault> BitacoraDetalleFDefaults { get; set; }

    public virtual DbSet<Bucket> Buckets { get; set; }

    public virtual DbSet<BucketsAnalytic> BucketsAnalytics { get; set; }

    public virtual DbSet<BucketsVector> BucketsVectors { get; set; }

    public virtual DbSet<Caballo> Caballos { get; set; }

    public virtual DbSet<Canton> Cantons { get; set; }

    public virtual DbSet<CertificacionesSanitaria> CertificacionesSanitarias { get; set; }

    public virtual DbSet<CorreosUsuario> CorreosUsuarios { get; set; }

    public virtual DbSet<CustomOauthProvider> CustomOauthProviders { get; set; }

    public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }

    public virtual DbSet<Distrito> Distritos { get; set; }

    public virtual DbSet<Establo> Establos { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<FlowState> FlowStates { get; set; }

    public virtual DbSet<HistorialTransaccione> HistorialTransacciones { get; set; }

    public virtual DbSet<HvDefault> HvDefaults { get; set; }

    public virtual DbSet<HvQ12025> HvQ12025s { get; set; }

    public virtual DbSet<HvQ12026> HvQ12026s { get; set; }

    public virtual DbSet<HvQ12027> HvQ12027s { get; set; }

    public virtual DbSet<HvQ12028> HvQ12028s { get; set; }

    public virtual DbSet<HvQ22025> HvQ22025s { get; set; }

    public virtual DbSet<HvQ22026> HvQ22026s { get; set; }

    public virtual DbSet<HvQ22027> HvQ22027s { get; set; }

    public virtual DbSet<HvQ22028> HvQ22028s { get; set; }

    public virtual DbSet<HvQ32025> HvQ32025s { get; set; }

    public virtual DbSet<HvQ32026> HvQ32026s { get; set; }

    public virtual DbSet<HvQ32027> HvQ32027s { get; set; }

    public virtual DbSet<HvQ32028> HvQ32028s { get; set; }

    public virtual DbSet<HvQ42025> HvQ42025s { get; set; }

    public virtual DbSet<HvQ42026> HvQ42026s { get; set; }

    public virtual DbSet<HvQ42027> HvQ42027s { get; set; }

    public virtual DbSet<HvQ42028> HvQ42028s { get; set; }

    public virtual DbSet<Identity> Identities { get; set; }

    public virtual DbSet<Inscripcione> Inscripciones { get; set; }

    public virtual DbSet<Instance> Instances { get; set; }

    public virtual DbSet<MfaAmrClaim> MfaAmrClaims { get; set; }

    public virtual DbSet<MfaChallenge> MfaChallenges { get; set; }

    public virtual DbSet<MfaFactor> MfaFactors { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<OauthAuthorization> OauthAuthorizations { get; set; }

    public virtual DbSet<OauthClient> OauthClients { get; set; }

    public virtual DbSet<OauthClientState> OauthClientStates { get; set; }

    public virtual DbSet<OauthConsent> OauthConsents { get; set; }

    public virtual DbSet<Object> Objects { get; set; }

    public virtual DbSet<OneTimeToken> OneTimeTokens { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<Propietario> Propietarios { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Provincium> Provincia { get; set; }

    public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

    public virtual DbSet<ResultadosCarrera> ResultadosCarreras { get; set; }

    public virtual DbSet<S3MultipartUpload> S3MultipartUploads { get; set; }

    public virtual DbSet<S3MultipartUploadsPart> S3MultipartUploadsParts { get; set; }

    public virtual DbSet<SamlProvider> SamlProviders { get; set; }

    public virtual DbSet<SamlRelayState> SamlRelayStates { get; set; }

    public virtual DbSet<SchemaMigration> SchemaMigrations { get; set; }

    public virtual DbSet<SchemaMigration1> SchemaMigrations1 { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<SsoDomain> SsoDomains { get; set; }

    public virtual DbSet<SsoProvider> SsoProviders { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    public virtual DbSet<Suministro> Suministros { get; set; }

    public virtual DbSet<TcEstadoAlertum> TcEstadoAlerta { get; set; }

    public virtual DbSet<TcEstadoCertificacion> TcEstadoCertificacions { get; set; }

    public virtual DbSet<TcEstadoEstablo> TcEstadoEstablos { get; set; }

    public virtual DbSet<TcEstadoEvento> TcEstadoEventos { get; set; }

    public virtual DbSet<TcEstadoInscripcion> TcEstadoInscripcions { get; set; }

    public virtual DbSet<TcEstadoPago> TcEstadoPagos { get; set; }

    public virtual DbSet<TcEstadoSalud> TcEstadoSaluds { get; set; }

    public virtual DbSet<TcMetodoPago> TcMetodoPagos { get; set; }

    public virtual DbSet<TcRaza> TcRazas { get; set; }

    public virtual DbSet<TcRolUsuario> TcRolUsuarios { get; set; }

    public virtual DbSet<TcSexo> TcSexos { get; set; }

    public virtual DbSet<TcTipoAlertum> TcTipoAlerta { get; set; }

    public virtual DbSet<TcTipoCarrera> TcTipoCarreras { get; set; }

    public virtual DbSet<TcTipoCorreo> TcTipoCorreos { get; set; }

    public virtual DbSet<TcTipoSuministro> TcTipoSuministros { get; set; }

    public virtual DbSet<TcTipoTelefono> TcTipoTelefonos { get; set; }

    public virtual DbSet<TcUnidadMedidum> TcUnidadMedida { get; set; }

    public virtual DbSet<TelefonosUsuario> TelefonosUsuarios { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VectorIndex> VectorIndexes { get; set; }

    public virtual DbSet<Veterinario> Veterinarios { get; set; }

    public virtual DbSet<VwAlertasPendiente> VwAlertasPendientes { get; set; }

    public virtual DbSet<VwCaballosDetalle> VwCaballosDetalles { get; set; }

    public virtual DbSet<VwEventosInscripcione> VwEventosInscripciones { get; set; }

    public virtual DbSet<VwFacturasDetalle> VwFacturasDetalles { get; set; }

    public virtual DbSet<VwPropietariosFrecuente> VwPropietariosFrecuentes { get; set; }

    public virtual DbSet<VwResultadosEvento> VwResultadosEventos { get; set; }

    public virtual DbSet<WebauthnChallenge> WebauthnChallenges { get; set; }

    public virtual DbSet<WebauthnCredential> WebauthnCredentials { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresEnum("auth", "aal_level", new[] { "aal1", "aal2", "aal3" })
            .HasPostgresEnum("auth", "code_challenge_method", new[] { "s256", "plain" })
            .HasPostgresEnum("auth", "factor_status", new[] { "unverified", "verified" })
            .HasPostgresEnum("auth", "factor_type", new[] { "totp", "webauthn", "phone" })
            .HasPostgresEnum("auth", "oauth_authorization_status", new[] { "pending", "approved", "denied", "expired" })
            .HasPostgresEnum("auth", "oauth_client_type", new[] { "public", "confidential" })
            .HasPostgresEnum("auth", "oauth_registration_type", new[] { "dynamic", "manual" })
            .HasPostgresEnum("auth", "oauth_response_type", new[] { "code" })
            .HasPostgresEnum("auth", "one_time_token_type", new[] { "confirmation_token", "reauthentication_token", "recovery_token", "email_change_token_new", "email_change_token_current", "phone_change_token" })
            .HasPostgresEnum("realtime", "action", new[] { "INSERT", "UPDATE", "DELETE", "TRUNCATE", "ERROR" })
            .HasPostgresEnum("realtime", "equality_op", new[] { "eq", "neq", "lt", "lte", "gt", "gte", "in" })
            .HasPostgresEnum("storage", "buckettype", new[] { "STANDARD", "ANALYTICS", "VECTOR" })
            .HasPostgresExtension("extensions", "pg_stat_statements")
            .HasPostgresExtension("extensions", "pgcrypto")
            .HasPostgresExtension("extensions", "uuid-ossp")
            .HasPostgresExtension("vault", "supabase_vault");

        modelBuilder.Entity<Alerta>(entity =>
        {
            entity.HasKey(e => e.IdAlerta).HasName("alertas_pkey");

            entity.ToTable("alertas");

            entity.HasIndex(e => e.IdPropietario, "idx_alert_prop");

            entity.Property(e => e.IdAlerta)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_alerta");
            entity.Property(e => e.FechaGeneracion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_generacion");
            entity.Property(e => e.FechaLectura)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_lectura");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoAlerta).HasColumnName("id_estado_alerta");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdTipoAlerta).HasColumnName("id_tipo_alerta");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.Alerta)
                .HasForeignKey(d => d.IdCaballo)
                .HasConstraintName("fk_alert_cab");

            entity.HasOne(d => d.IdEstadoAlertaNavigation).WithMany(p => p.Alerta)
                .HasForeignKey(d => d.IdEstadoAlerta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_alert_estado");

            entity.HasOne(d => d.IdPropietarioNavigation).WithMany(p => p.Alerta)
                .HasForeignKey(d => d.IdPropietario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_alert_prop");

            entity.HasOne(d => d.IdTipoAlertaNavigation).WithMany(p => p.Alerta)
                .HasForeignKey(d => d.IdTipoAlerta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_alert_tipo");
        });

        modelBuilder.Entity<AliDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_default_pkey");

            entity.ToTable("ali_default");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_default_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliDefaults)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliDefaults)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliDefaults)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q1_2025_pkey");

            entity.ToTable("ali_q1_2025");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q1_2025_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ12025s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ12025s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ12025s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q1_2026_pkey");

            entity.ToTable("ali_q1_2026");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q1_2026_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ12026s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ12026s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ12026s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q1_2027_pkey");

            entity.ToTable("ali_q1_2027");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q1_2027_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ12027s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ12027s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ12027s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ12028>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q1_2028_pkey");

            entity.ToTable("ali_q1_2028");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q1_2028_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ12028s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ12028s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ12028s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q2_2025_pkey");

            entity.ToTable("ali_q2_2025");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q2_2025_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ22025s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ22025s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ22025s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q2_2026_pkey");

            entity.ToTable("ali_q2_2026");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q2_2026_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ22026s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ22026s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ22026s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q2_2027_pkey");

            entity.ToTable("ali_q2_2027");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q2_2027_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ22027s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ22027s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ22027s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ22028>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q2_2028_pkey");

            entity.ToTable("ali_q2_2028");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q2_2028_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ22028s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ22028s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ22028s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q3_2025_pkey");

            entity.ToTable("ali_q3_2025");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q3_2025_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ32025s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ32025s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ32025s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q3_2026_pkey");

            entity.ToTable("ali_q3_2026");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q3_2026_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ32026s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ32026s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ32026s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q3_2027_pkey");

            entity.ToTable("ali_q3_2027");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q3_2027_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ32027s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ32027s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ32027s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ32028>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q3_2028_pkey");

            entity.ToTable("ali_q3_2028");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q3_2028_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ32028s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ32028s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ32028s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q4_2025_pkey");

            entity.ToTable("ali_q4_2025");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q4_2025_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ42025s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ42025s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ42025s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q4_2026_pkey");

            entity.ToTable("ali_q4_2026");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q4_2026_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ42026s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ42026s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ42026s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q4_2027_pkey");

            entity.ToTable("ali_q4_2027");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q4_2027_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ42027s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ42027s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ42027s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AliQ42028>(entity =>
        {
            entity.HasKey(e => new { e.IdAlimentacion, e.FechaAlimentacion }).HasName("ali_q4_2028_pkey");

            entity.ToTable("ali_q4_2028");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaAlimentacion }, "ali_q4_2028_id_caballo_fecha_alimentacion_idx");

            entity.Property(e => e.IdAlimentacion)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_alimentacion");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.IdUsuarioRegistro).HasColumnName("id_usuario_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AliQ42028s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_caballo");

            entity.HasOne(d => d.IdSuministroNavigation).WithMany(p => p.AliQ42028s)
                .HasForeignKey(d => d.IdSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_suministro");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.AliQ42028s)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ali_usuario");
        });

        modelBuilder.Entity<AsignacionesEstablo>(entity =>
        {
            entity.HasKey(e => e.IdAsignacion).HasName("asignaciones_establo_pkey");

            entity.ToTable("asignaciones_establo");

            entity.HasIndex(e => e.IdCaballo, "idx_asig_caballo").HasFilter("(activa = true)");

            entity.Property(e => e.IdAsignacion)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_asignacion");
            entity.Property(e => e.Activa)
                .HasDefaultValue(true)
                .HasColumnName("activa");
            entity.Property(e => e.FechaIngreso)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaSalida).HasColumnName("fecha_salida");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstablo).HasColumnName("id_establo");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.AsignacionesEstablos)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_asig_caballo");

            entity.HasOne(d => d.IdEstabloNavigation).WithMany(p => p.AsignacionesEstablos)
                .HasForeignKey(d => d.IdEstablo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_asig_establo");
        });

        modelBuilder.Entity<AuditLogEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("audit_log_entries_pkey");

            entity.ToTable("audit_log_entries", "auth", tb => tb.HasComment("Auth: Audit trail for user actions."));

            entity.HasIndex(e => e.InstanceId, "audit_logs_instance_id_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.InstanceId).HasColumnName("instance_id");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ip_address");
            entity.Property(e => e.Payload)
                .HasColumnType("json")
                .HasColumnName("payload");
        });

        modelBuilder.Entity<Barrio>(entity =>
        {
            entity.HasKey(e => e.IdBarrio).HasName("barrio_pkey");

            entity.ToTable("barrio");

            entity.HasIndex(e => new { e.IdDistrito, e.Nombre }, "uq_barrio").IsUnique();

            entity.Property(e => e.IdBarrio)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_barrio");
            entity.Property(e => e.IdDistrito).HasColumnName("id_distrito");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdDistritoNavigation).WithMany(p => p.Barrios)
                .HasForeignKey(d => d.IdDistrito)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_barrio_distrito");
        });

        modelBuilder.Entity<BitAlertDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_alert_default_pkey");

            entity.ToTable("bit_alert_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoAlerta).HasColumnName("id_estado_alerta");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoAlerta).HasColumnName("id_tipo_alerta");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAlertQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_alert_q1_2025_pkey");

            entity.ToTable("bit_alert_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoAlerta).HasColumnName("id_estado_alerta");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoAlerta).HasColumnName("id_tipo_alerta");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAlertQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_alert_q1_2026_pkey");

            entity.ToTable("bit_alert_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoAlerta).HasColumnName("id_estado_alerta");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoAlerta).HasColumnName("id_tipo_alerta");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAlertQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_alert_q1_2027_pkey");

            entity.ToTable("bit_alert_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoAlerta).HasColumnName("id_estado_alerta");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoAlerta).HasColumnName("id_tipo_alerta");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAlertQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_alert_q2_2025_pkey");

            entity.ToTable("bit_alert_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoAlerta).HasColumnName("id_estado_alerta");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoAlerta).HasColumnName("id_tipo_alerta");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAlertQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_alert_q2_2026_pkey");

            entity.ToTable("bit_alert_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoAlerta).HasColumnName("id_estado_alerta");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoAlerta).HasColumnName("id_tipo_alerta");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAlertQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_alert_q2_2027_pkey");

            entity.ToTable("bit_alert_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoAlerta).HasColumnName("id_estado_alerta");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoAlerta).HasColumnName("id_tipo_alerta");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAlertQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_alert_q3_2025_pkey");

            entity.ToTable("bit_alert_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoAlerta).HasColumnName("id_estado_alerta");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoAlerta).HasColumnName("id_tipo_alerta");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAlertQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_alert_q3_2026_pkey");

            entity.ToTable("bit_alert_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoAlerta).HasColumnName("id_estado_alerta");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoAlerta).HasColumnName("id_tipo_alerta");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAlertQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_alert_q3_2027_pkey");

            entity.ToTable("bit_alert_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoAlerta).HasColumnName("id_estado_alerta");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoAlerta).HasColumnName("id_tipo_alerta");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAlertQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_alert_q4_2025_pkey");

            entity.ToTable("bit_alert_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoAlerta).HasColumnName("id_estado_alerta");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoAlerta).HasColumnName("id_tipo_alerta");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAlertQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_alert_q4_2026_pkey");

            entity.ToTable("bit_alert_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoAlerta).HasColumnName("id_estado_alerta");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoAlerta).HasColumnName("id_tipo_alerta");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAlertQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_alert_q4_2027_pkey");

            entity.ToTable("bit_alert_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoAlerta).HasColumnName("id_estado_alerta");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoAlerta).HasColumnName("id_tipo_alerta");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAliDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ali_default_pkey");

            entity.ToTable("bit_ali_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAliQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ali_q1_2025_pkey");

            entity.ToTable("bit_ali_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAliQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ali_q1_2026_pkey");

            entity.ToTable("bit_ali_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAliQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ali_q1_2027_pkey");

            entity.ToTable("bit_ali_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAliQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ali_q2_2025_pkey");

            entity.ToTable("bit_ali_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAliQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ali_q2_2026_pkey");

            entity.ToTable("bit_ali_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAliQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ali_q2_2027_pkey");

            entity.ToTable("bit_ali_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAliQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ali_q3_2025_pkey");

            entity.ToTable("bit_ali_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAliQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ali_q3_2026_pkey");

            entity.ToTable("bit_ali_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAliQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ali_q3_2027_pkey");

            entity.ToTable("bit_ali_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAliQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ali_q4_2025_pkey");

            entity.ToTable("bit_ali_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAliQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ali_q4_2026_pkey");

            entity.ToTable("bit_ali_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAliQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ali_q4_2027_pkey");

            entity.ToTable("bit_ali_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad");
            entity.Property(e => e.FechaAlimentacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_alimentacion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdSuministro).HasColumnName("id_suministro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAsigDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_asig_default_pkey");

            entity.ToTable("bit_asig_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activa).HasColumnName("activa");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaSalida).HasColumnName("fecha_salida");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstablo).HasColumnName("id_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAsigQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_asig_q1_2025_pkey");

            entity.ToTable("bit_asig_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activa).HasColumnName("activa");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaSalida).HasColumnName("fecha_salida");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstablo).HasColumnName("id_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAsigQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_asig_q1_2026_pkey");

            entity.ToTable("bit_asig_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activa).HasColumnName("activa");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaSalida).HasColumnName("fecha_salida");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstablo).HasColumnName("id_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAsigQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_asig_q1_2027_pkey");

            entity.ToTable("bit_asig_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activa).HasColumnName("activa");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaSalida).HasColumnName("fecha_salida");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstablo).HasColumnName("id_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAsigQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_asig_q2_2025_pkey");

            entity.ToTable("bit_asig_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activa).HasColumnName("activa");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaSalida).HasColumnName("fecha_salida");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstablo).HasColumnName("id_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAsigQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_asig_q2_2026_pkey");

            entity.ToTable("bit_asig_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activa).HasColumnName("activa");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaSalida).HasColumnName("fecha_salida");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstablo).HasColumnName("id_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAsigQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_asig_q2_2027_pkey");

            entity.ToTable("bit_asig_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activa).HasColumnName("activa");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaSalida).HasColumnName("fecha_salida");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstablo).HasColumnName("id_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAsigQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_asig_q3_2025_pkey");

            entity.ToTable("bit_asig_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activa).HasColumnName("activa");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaSalida).HasColumnName("fecha_salida");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstablo).HasColumnName("id_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAsigQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_asig_q3_2026_pkey");

            entity.ToTable("bit_asig_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activa).HasColumnName("activa");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaSalida).HasColumnName("fecha_salida");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstablo).HasColumnName("id_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAsigQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_asig_q3_2027_pkey");

            entity.ToTable("bit_asig_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activa).HasColumnName("activa");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaSalida).HasColumnName("fecha_salida");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstablo).HasColumnName("id_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAsigQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_asig_q4_2025_pkey");

            entity.ToTable("bit_asig_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activa).HasColumnName("activa");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaSalida).HasColumnName("fecha_salida");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstablo).HasColumnName("id_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAsigQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_asig_q4_2026_pkey");

            entity.ToTable("bit_asig_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activa).HasColumnName("activa");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaSalida).HasColumnName("fecha_salida");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstablo).HasColumnName("id_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitAsigQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_asig_q4_2027_pkey");

            entity.ToTable("bit_asig_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activa).HasColumnName("activa");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaSalida).HasColumnName("fecha_salida");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstablo).HasColumnName("id_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCabDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cab_default_pkey");

            entity.ToTable("bit_cab_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoSalud).HasColumnName("id_estado_salud");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.PesoKg)
                .HasPrecision(8, 2)
                .HasColumnName("peso_kg");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCabQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cab_q1_2025_pkey");

            entity.ToTable("bit_cab_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoSalud).HasColumnName("id_estado_salud");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.PesoKg)
                .HasPrecision(8, 2)
                .HasColumnName("peso_kg");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCabQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cab_q1_2026_pkey");

            entity.ToTable("bit_cab_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoSalud).HasColumnName("id_estado_salud");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.PesoKg)
                .HasPrecision(8, 2)
                .HasColumnName("peso_kg");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCabQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cab_q1_2027_pkey");

            entity.ToTable("bit_cab_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoSalud).HasColumnName("id_estado_salud");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.PesoKg)
                .HasPrecision(8, 2)
                .HasColumnName("peso_kg");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCabQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cab_q2_2025_pkey");

            entity.ToTable("bit_cab_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoSalud).HasColumnName("id_estado_salud");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.PesoKg)
                .HasPrecision(8, 2)
                .HasColumnName("peso_kg");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCabQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cab_q2_2026_pkey");

            entity.ToTable("bit_cab_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoSalud).HasColumnName("id_estado_salud");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.PesoKg)
                .HasPrecision(8, 2)
                .HasColumnName("peso_kg");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCabQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cab_q2_2027_pkey");

            entity.ToTable("bit_cab_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoSalud).HasColumnName("id_estado_salud");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.PesoKg)
                .HasPrecision(8, 2)
                .HasColumnName("peso_kg");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCabQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cab_q3_2025_pkey");

            entity.ToTable("bit_cab_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoSalud).HasColumnName("id_estado_salud");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.PesoKg)
                .HasPrecision(8, 2)
                .HasColumnName("peso_kg");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCabQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cab_q3_2026_pkey");

            entity.ToTable("bit_cab_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoSalud).HasColumnName("id_estado_salud");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.PesoKg)
                .HasPrecision(8, 2)
                .HasColumnName("peso_kg");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCabQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cab_q3_2027_pkey");

            entity.ToTable("bit_cab_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoSalud).HasColumnName("id_estado_salud");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.PesoKg)
                .HasPrecision(8, 2)
                .HasColumnName("peso_kg");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCabQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cab_q4_2025_pkey");

            entity.ToTable("bit_cab_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoSalud).HasColumnName("id_estado_salud");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.PesoKg)
                .HasPrecision(8, 2)
                .HasColumnName("peso_kg");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCabQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cab_q4_2026_pkey");

            entity.ToTable("bit_cab_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoSalud).HasColumnName("id_estado_salud");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.PesoKg)
                .HasPrecision(8, 2)
                .HasColumnName("peso_kg");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCabQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cab_q4_2027_pkey");

            entity.ToTable("bit_cab_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoSalud).HasColumnName("id_estado_salud");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.PesoKg)
                .HasPrecision(8, 2)
                .HasColumnName("peso_kg");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCertDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cert_default_pkey");

            entity.ToTable("bit_cert_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.FechaEmision).HasColumnName("fecha_emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoCertificacion).HasColumnName("id_estado_certificacion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroCertificado)
                .HasMaxLength(50)
                .HasColumnName("numero_certificado");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCertQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cert_q1_2025_pkey");

            entity.ToTable("bit_cert_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.FechaEmision).HasColumnName("fecha_emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoCertificacion).HasColumnName("id_estado_certificacion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroCertificado)
                .HasMaxLength(50)
                .HasColumnName("numero_certificado");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCertQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cert_q1_2026_pkey");

            entity.ToTable("bit_cert_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.FechaEmision).HasColumnName("fecha_emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoCertificacion).HasColumnName("id_estado_certificacion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroCertificado)
                .HasMaxLength(50)
                .HasColumnName("numero_certificado");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCertQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cert_q1_2027_pkey");

            entity.ToTable("bit_cert_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.FechaEmision).HasColumnName("fecha_emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoCertificacion).HasColumnName("id_estado_certificacion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroCertificado)
                .HasMaxLength(50)
                .HasColumnName("numero_certificado");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCertQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cert_q2_2025_pkey");

            entity.ToTable("bit_cert_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.FechaEmision).HasColumnName("fecha_emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoCertificacion).HasColumnName("id_estado_certificacion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroCertificado)
                .HasMaxLength(50)
                .HasColumnName("numero_certificado");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCertQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cert_q2_2026_pkey");

            entity.ToTable("bit_cert_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.FechaEmision).HasColumnName("fecha_emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoCertificacion).HasColumnName("id_estado_certificacion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroCertificado)
                .HasMaxLength(50)
                .HasColumnName("numero_certificado");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCertQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cert_q2_2027_pkey");

            entity.ToTable("bit_cert_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.FechaEmision).HasColumnName("fecha_emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoCertificacion).HasColumnName("id_estado_certificacion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroCertificado)
                .HasMaxLength(50)
                .HasColumnName("numero_certificado");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCertQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cert_q3_2025_pkey");

            entity.ToTable("bit_cert_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.FechaEmision).HasColumnName("fecha_emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoCertificacion).HasColumnName("id_estado_certificacion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroCertificado)
                .HasMaxLength(50)
                .HasColumnName("numero_certificado");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCertQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cert_q3_2026_pkey");

            entity.ToTable("bit_cert_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.FechaEmision).HasColumnName("fecha_emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoCertificacion).HasColumnName("id_estado_certificacion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroCertificado)
                .HasMaxLength(50)
                .HasColumnName("numero_certificado");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCertQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cert_q3_2027_pkey");

            entity.ToTable("bit_cert_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.FechaEmision).HasColumnName("fecha_emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoCertificacion).HasColumnName("id_estado_certificacion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroCertificado)
                .HasMaxLength(50)
                .HasColumnName("numero_certificado");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCertQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cert_q4_2025_pkey");

            entity.ToTable("bit_cert_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.FechaEmision).HasColumnName("fecha_emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoCertificacion).HasColumnName("id_estado_certificacion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroCertificado)
                .HasMaxLength(50)
                .HasColumnName("numero_certificado");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCertQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cert_q4_2026_pkey");

            entity.ToTable("bit_cert_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.FechaEmision).HasColumnName("fecha_emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoCertificacion).HasColumnName("id_estado_certificacion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroCertificado)
                .HasMaxLength(50)
                .HasColumnName("numero_certificado");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitCertQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_cert_q4_2027_pkey");

            entity.ToTable("bit_cert_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.FechaEmision).HasColumnName("fecha_emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoCertificacion).HasColumnName("id_estado_certificacion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroCertificado)
                .HasMaxLength(50)
                .HasColumnName("numero_certificado");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEstDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_est_default_pkey");

            entity.ToTable("bit_est_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoEstablo).HasColumnName("id_estado_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .HasColumnName("ubicacion");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEstQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_est_q1_2025_pkey");

            entity.ToTable("bit_est_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoEstablo).HasColumnName("id_estado_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .HasColumnName("ubicacion");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEstQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_est_q1_2026_pkey");

            entity.ToTable("bit_est_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoEstablo).HasColumnName("id_estado_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .HasColumnName("ubicacion");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEstQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_est_q1_2027_pkey");

            entity.ToTable("bit_est_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoEstablo).HasColumnName("id_estado_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .HasColumnName("ubicacion");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEstQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_est_q2_2025_pkey");

            entity.ToTable("bit_est_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoEstablo).HasColumnName("id_estado_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .HasColumnName("ubicacion");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEstQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_est_q2_2026_pkey");

            entity.ToTable("bit_est_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoEstablo).HasColumnName("id_estado_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .HasColumnName("ubicacion");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEstQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_est_q2_2027_pkey");

            entity.ToTable("bit_est_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoEstablo).HasColumnName("id_estado_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .HasColumnName("ubicacion");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEstQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_est_q3_2025_pkey");

            entity.ToTable("bit_est_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoEstablo).HasColumnName("id_estado_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .HasColumnName("ubicacion");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEstQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_est_q3_2026_pkey");

            entity.ToTable("bit_est_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoEstablo).HasColumnName("id_estado_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .HasColumnName("ubicacion");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEstQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_est_q3_2027_pkey");

            entity.ToTable("bit_est_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoEstablo).HasColumnName("id_estado_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .HasColumnName("ubicacion");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEstQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_est_q4_2025_pkey");

            entity.ToTable("bit_est_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoEstablo).HasColumnName("id_estado_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .HasColumnName("ubicacion");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEstQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_est_q4_2026_pkey");

            entity.ToTable("bit_est_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoEstablo).HasColumnName("id_estado_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .HasColumnName("ubicacion");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEstQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_est_q4_2027_pkey");

            entity.ToTable("bit_est_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoEstablo).HasColumnName("id_estado_establo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .HasColumnName("ubicacion");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEvDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ev_default_pkey");

            entity.ToTable("bit_ev_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IdEstadoEvento).HasColumnName("id_estado_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoCarrera).HasColumnName("id_tipo_carrera");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.PremioTotal)
                .HasPrecision(14, 2)
                .HasColumnName("premio_total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEvQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ev_q1_2025_pkey");

            entity.ToTable("bit_ev_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IdEstadoEvento).HasColumnName("id_estado_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoCarrera).HasColumnName("id_tipo_carrera");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.PremioTotal)
                .HasPrecision(14, 2)
                .HasColumnName("premio_total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEvQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ev_q1_2026_pkey");

            entity.ToTable("bit_ev_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IdEstadoEvento).HasColumnName("id_estado_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoCarrera).HasColumnName("id_tipo_carrera");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.PremioTotal)
                .HasPrecision(14, 2)
                .HasColumnName("premio_total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEvQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ev_q1_2027_pkey");

            entity.ToTable("bit_ev_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IdEstadoEvento).HasColumnName("id_estado_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoCarrera).HasColumnName("id_tipo_carrera");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.PremioTotal)
                .HasPrecision(14, 2)
                .HasColumnName("premio_total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEvQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ev_q2_2025_pkey");

            entity.ToTable("bit_ev_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IdEstadoEvento).HasColumnName("id_estado_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoCarrera).HasColumnName("id_tipo_carrera");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.PremioTotal)
                .HasPrecision(14, 2)
                .HasColumnName("premio_total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEvQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ev_q2_2026_pkey");

            entity.ToTable("bit_ev_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IdEstadoEvento).HasColumnName("id_estado_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoCarrera).HasColumnName("id_tipo_carrera");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.PremioTotal)
                .HasPrecision(14, 2)
                .HasColumnName("premio_total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEvQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ev_q2_2027_pkey");

            entity.ToTable("bit_ev_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IdEstadoEvento).HasColumnName("id_estado_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoCarrera).HasColumnName("id_tipo_carrera");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.PremioTotal)
                .HasPrecision(14, 2)
                .HasColumnName("premio_total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEvQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ev_q3_2025_pkey");

            entity.ToTable("bit_ev_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IdEstadoEvento).HasColumnName("id_estado_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoCarrera).HasColumnName("id_tipo_carrera");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.PremioTotal)
                .HasPrecision(14, 2)
                .HasColumnName("premio_total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEvQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ev_q3_2026_pkey");

            entity.ToTable("bit_ev_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IdEstadoEvento).HasColumnName("id_estado_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoCarrera).HasColumnName("id_tipo_carrera");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.PremioTotal)
                .HasPrecision(14, 2)
                .HasColumnName("premio_total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEvQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ev_q3_2027_pkey");

            entity.ToTable("bit_ev_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IdEstadoEvento).HasColumnName("id_estado_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoCarrera).HasColumnName("id_tipo_carrera");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.PremioTotal)
                .HasPrecision(14, 2)
                .HasColumnName("premio_total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEvQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ev_q4_2025_pkey");

            entity.ToTable("bit_ev_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IdEstadoEvento).HasColumnName("id_estado_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoCarrera).HasColumnName("id_tipo_carrera");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.PremioTotal)
                .HasPrecision(14, 2)
                .HasColumnName("premio_total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEvQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ev_q4_2026_pkey");

            entity.ToTable("bit_ev_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IdEstadoEvento).HasColumnName("id_estado_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoCarrera).HasColumnName("id_tipo_carrera");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.PremioTotal)
                .HasPrecision(14, 2)
                .HasColumnName("premio_total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitEvQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ev_q4_2027_pkey");

            entity.ToTable("bit_ev_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IdEstadoEvento).HasColumnName("id_estado_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoCarrera).HasColumnName("id_tipo_carrera");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.PremioTotal)
                .HasPrecision(14, 2)
                .HasColumnName("premio_total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitFacDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_fac_default_pkey");

            entity.ToTable("bit_fac_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoPct)
                .HasPrecision(5, 2)
                .HasColumnName("descuento_pct");
            entity.Property(e => e.IdEstadoPago).HasColumnName("id_estado_pago");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Subtotal)
                .HasPrecision(14, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(14, 2)
                .HasColumnName("total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitFacQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_fac_q1_2025_pkey");

            entity.ToTable("bit_fac_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoPct)
                .HasPrecision(5, 2)
                .HasColumnName("descuento_pct");
            entity.Property(e => e.IdEstadoPago).HasColumnName("id_estado_pago");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Subtotal)
                .HasPrecision(14, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(14, 2)
                .HasColumnName("total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitFacQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_fac_q1_2026_pkey");

            entity.ToTable("bit_fac_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoPct)
                .HasPrecision(5, 2)
                .HasColumnName("descuento_pct");
            entity.Property(e => e.IdEstadoPago).HasColumnName("id_estado_pago");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Subtotal)
                .HasPrecision(14, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(14, 2)
                .HasColumnName("total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitFacQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_fac_q1_2027_pkey");

            entity.ToTable("bit_fac_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoPct)
                .HasPrecision(5, 2)
                .HasColumnName("descuento_pct");
            entity.Property(e => e.IdEstadoPago).HasColumnName("id_estado_pago");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Subtotal)
                .HasPrecision(14, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(14, 2)
                .HasColumnName("total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitFacQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_fac_q2_2025_pkey");

            entity.ToTable("bit_fac_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoPct)
                .HasPrecision(5, 2)
                .HasColumnName("descuento_pct");
            entity.Property(e => e.IdEstadoPago).HasColumnName("id_estado_pago");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Subtotal)
                .HasPrecision(14, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(14, 2)
                .HasColumnName("total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitFacQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_fac_q2_2026_pkey");

            entity.ToTable("bit_fac_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoPct)
                .HasPrecision(5, 2)
                .HasColumnName("descuento_pct");
            entity.Property(e => e.IdEstadoPago).HasColumnName("id_estado_pago");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Subtotal)
                .HasPrecision(14, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(14, 2)
                .HasColumnName("total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitFacQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_fac_q2_2027_pkey");

            entity.ToTable("bit_fac_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoPct)
                .HasPrecision(5, 2)
                .HasColumnName("descuento_pct");
            entity.Property(e => e.IdEstadoPago).HasColumnName("id_estado_pago");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Subtotal)
                .HasPrecision(14, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(14, 2)
                .HasColumnName("total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitFacQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_fac_q3_2025_pkey");

            entity.ToTable("bit_fac_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoPct)
                .HasPrecision(5, 2)
                .HasColumnName("descuento_pct");
            entity.Property(e => e.IdEstadoPago).HasColumnName("id_estado_pago");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Subtotal)
                .HasPrecision(14, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(14, 2)
                .HasColumnName("total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitFacQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_fac_q3_2026_pkey");

            entity.ToTable("bit_fac_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoPct)
                .HasPrecision(5, 2)
                .HasColumnName("descuento_pct");
            entity.Property(e => e.IdEstadoPago).HasColumnName("id_estado_pago");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Subtotal)
                .HasPrecision(14, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(14, 2)
                .HasColumnName("total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitFacQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_fac_q3_2027_pkey");

            entity.ToTable("bit_fac_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoPct)
                .HasPrecision(5, 2)
                .HasColumnName("descuento_pct");
            entity.Property(e => e.IdEstadoPago).HasColumnName("id_estado_pago");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Subtotal)
                .HasPrecision(14, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(14, 2)
                .HasColumnName("total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitFacQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_fac_q4_2025_pkey");

            entity.ToTable("bit_fac_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoPct)
                .HasPrecision(5, 2)
                .HasColumnName("descuento_pct");
            entity.Property(e => e.IdEstadoPago).HasColumnName("id_estado_pago");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Subtotal)
                .HasPrecision(14, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(14, 2)
                .HasColumnName("total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitFacQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_fac_q4_2026_pkey");

            entity.ToTable("bit_fac_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoPct)
                .HasPrecision(5, 2)
                .HasColumnName("descuento_pct");
            entity.Property(e => e.IdEstadoPago).HasColumnName("id_estado_pago");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Subtotal)
                .HasPrecision(14, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(14, 2)
                .HasColumnName("total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitFacQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_fac_q4_2027_pkey");

            entity.ToTable("bit_fac_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoPct)
                .HasPrecision(5, 2)
                .HasColumnName("descuento_pct");
            entity.Property(e => e.IdEstadoPago).HasColumnName("id_estado_pago");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Subtotal)
                .HasPrecision(14, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(14, 2)
                .HasColumnName("total");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitHvDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_hv_default_pkey");

            entity.ToTable("bit_hv_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitHvQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_hv_q1_2025_pkey");

            entity.ToTable("bit_hv_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitHvQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_hv_q1_2026_pkey");

            entity.ToTable("bit_hv_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitHvQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_hv_q1_2027_pkey");

            entity.ToTable("bit_hv_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitHvQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_hv_q2_2025_pkey");

            entity.ToTable("bit_hv_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitHvQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_hv_q2_2026_pkey");

            entity.ToTable("bit_hv_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitHvQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_hv_q2_2027_pkey");

            entity.ToTable("bit_hv_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitHvQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_hv_q3_2025_pkey");

            entity.ToTable("bit_hv_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitHvQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_hv_q3_2026_pkey");

            entity.ToTable("bit_hv_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitHvQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_hv_q3_2027_pkey");

            entity.ToTable("bit_hv_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitHvQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_hv_q4_2025_pkey");

            entity.ToTable("bit_hv_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitHvQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_hv_q4_2026_pkey");

            entity.ToTable("bit_hv_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitHvQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_hv_q4_2027_pkey");

            entity.ToTable("bit_hv_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitInsDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ins_default_pkey");

            entity.ToTable("bit_ins_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoInscripcion).HasColumnName("id_estado_inscripcion");
            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionSalida).HasColumnName("posicion_salida");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitInsQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ins_q1_2025_pkey");

            entity.ToTable("bit_ins_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoInscripcion).HasColumnName("id_estado_inscripcion");
            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionSalida).HasColumnName("posicion_salida");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitInsQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ins_q1_2026_pkey");

            entity.ToTable("bit_ins_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoInscripcion).HasColumnName("id_estado_inscripcion");
            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionSalida).HasColumnName("posicion_salida");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitInsQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ins_q1_2027_pkey");

            entity.ToTable("bit_ins_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoInscripcion).HasColumnName("id_estado_inscripcion");
            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionSalida).HasColumnName("posicion_salida");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitInsQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ins_q2_2025_pkey");

            entity.ToTable("bit_ins_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoInscripcion).HasColumnName("id_estado_inscripcion");
            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionSalida).HasColumnName("posicion_salida");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitInsQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ins_q2_2026_pkey");

            entity.ToTable("bit_ins_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoInscripcion).HasColumnName("id_estado_inscripcion");
            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionSalida).HasColumnName("posicion_salida");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitInsQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ins_q2_2027_pkey");

            entity.ToTable("bit_ins_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoInscripcion).HasColumnName("id_estado_inscripcion");
            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionSalida).HasColumnName("posicion_salida");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitInsQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ins_q3_2025_pkey");

            entity.ToTable("bit_ins_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoInscripcion).HasColumnName("id_estado_inscripcion");
            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionSalida).HasColumnName("posicion_salida");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitInsQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ins_q3_2026_pkey");

            entity.ToTable("bit_ins_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoInscripcion).HasColumnName("id_estado_inscripcion");
            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionSalida).HasColumnName("posicion_salida");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitInsQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ins_q3_2027_pkey");

            entity.ToTable("bit_ins_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoInscripcion).HasColumnName("id_estado_inscripcion");
            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionSalida).HasColumnName("posicion_salida");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitInsQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ins_q4_2025_pkey");

            entity.ToTable("bit_ins_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoInscripcion).HasColumnName("id_estado_inscripcion");
            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionSalida).HasColumnName("posicion_salida");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitInsQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ins_q4_2026_pkey");

            entity.ToTable("bit_ins_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoInscripcion).HasColumnName("id_estado_inscripcion");
            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionSalida).HasColumnName("posicion_salida");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitInsQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_ins_q4_2027_pkey");

            entity.ToTable("bit_ins_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoInscripcion).HasColumnName("id_estado_inscripcion");
            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionSalida).HasColumnName("posicion_salida");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitPropDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prop_default_pkey");

            entity.ToTable("bit_prop_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoProximaFactura).HasColumnName("descuento_proxima_factura");
            entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitPropQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prop_q1_2025_pkey");

            entity.ToTable("bit_prop_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoProximaFactura).HasColumnName("descuento_proxima_factura");
            entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitPropQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prop_q1_2026_pkey");

            entity.ToTable("bit_prop_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoProximaFactura).HasColumnName("descuento_proxima_factura");
            entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitPropQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prop_q1_2027_pkey");

            entity.ToTable("bit_prop_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoProximaFactura).HasColumnName("descuento_proxima_factura");
            entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitPropQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prop_q2_2025_pkey");

            entity.ToTable("bit_prop_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoProximaFactura).HasColumnName("descuento_proxima_factura");
            entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitPropQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prop_q2_2026_pkey");

            entity.ToTable("bit_prop_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoProximaFactura).HasColumnName("descuento_proxima_factura");
            entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitPropQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prop_q2_2027_pkey");

            entity.ToTable("bit_prop_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoProximaFactura).HasColumnName("descuento_proxima_factura");
            entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitPropQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prop_q3_2025_pkey");

            entity.ToTable("bit_prop_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoProximaFactura).HasColumnName("descuento_proxima_factura");
            entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitPropQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prop_q3_2026_pkey");

            entity.ToTable("bit_prop_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoProximaFactura).HasColumnName("descuento_proxima_factura");
            entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitPropQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prop_q3_2027_pkey");

            entity.ToTable("bit_prop_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoProximaFactura).HasColumnName("descuento_proxima_factura");
            entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitPropQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prop_q4_2025_pkey");

            entity.ToTable("bit_prop_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoProximaFactura).HasColumnName("descuento_proxima_factura");
            entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitPropQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prop_q4_2026_pkey");

            entity.ToTable("bit_prop_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoProximaFactura).HasColumnName("descuento_proxima_factura");
            entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitPropQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prop_q4_2027_pkey");

            entity.ToTable("bit_prop_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.DescuentoProximaFactura).HasColumnName("descuento_proxima_factura");
            entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitProvDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prov_default_pkey");

            entity.ToTable("bit_prov_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .HasColumnName("contacto");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .HasColumnName("correo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitProvQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prov_q1_2025_pkey");

            entity.ToTable("bit_prov_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .HasColumnName("contacto");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .HasColumnName("correo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitProvQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prov_q1_2026_pkey");

            entity.ToTable("bit_prov_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .HasColumnName("contacto");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .HasColumnName("correo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitProvQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prov_q1_2027_pkey");

            entity.ToTable("bit_prov_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .HasColumnName("contacto");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .HasColumnName("correo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitProvQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prov_q2_2025_pkey");

            entity.ToTable("bit_prov_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .HasColumnName("contacto");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .HasColumnName("correo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitProvQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prov_q2_2026_pkey");

            entity.ToTable("bit_prov_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .HasColumnName("contacto");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .HasColumnName("correo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitProvQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prov_q2_2027_pkey");

            entity.ToTable("bit_prov_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .HasColumnName("contacto");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .HasColumnName("correo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitProvQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prov_q3_2025_pkey");

            entity.ToTable("bit_prov_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .HasColumnName("contacto");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .HasColumnName("correo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitProvQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prov_q3_2026_pkey");

            entity.ToTable("bit_prov_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .HasColumnName("contacto");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .HasColumnName("correo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitProvQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prov_q3_2027_pkey");

            entity.ToTable("bit_prov_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .HasColumnName("contacto");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .HasColumnName("correo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitProvQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prov_q4_2025_pkey");

            entity.ToTable("bit_prov_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .HasColumnName("contacto");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .HasColumnName("correo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitProvQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prov_q4_2026_pkey");

            entity.ToTable("bit_prov_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .HasColumnName("contacto");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .HasColumnName("correo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitProvQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_prov_q4_2027_pkey");

            entity.ToTable("bit_prov_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .HasColumnName("contacto");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .HasColumnName("correo");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitResDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_res_default_pkey");

            entity.ToTable("bit_res_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Descalificado).HasColumnName("descalificado");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionFinal).HasColumnName("posicion_final");
            entity.Property(e => e.PremioObtenido)
                .HasPrecision(12, 2)
                .HasColumnName("premio_obtenido");
            entity.Property(e => e.TiempoSegundos)
                .HasPrecision(8, 3)
                .HasColumnName("tiempo_segundos");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitResQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_res_q1_2025_pkey");

            entity.ToTable("bit_res_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Descalificado).HasColumnName("descalificado");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionFinal).HasColumnName("posicion_final");
            entity.Property(e => e.PremioObtenido)
                .HasPrecision(12, 2)
                .HasColumnName("premio_obtenido");
            entity.Property(e => e.TiempoSegundos)
                .HasPrecision(8, 3)
                .HasColumnName("tiempo_segundos");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitResQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_res_q1_2026_pkey");

            entity.ToTable("bit_res_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Descalificado).HasColumnName("descalificado");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionFinal).HasColumnName("posicion_final");
            entity.Property(e => e.PremioObtenido)
                .HasPrecision(12, 2)
                .HasColumnName("premio_obtenido");
            entity.Property(e => e.TiempoSegundos)
                .HasPrecision(8, 3)
                .HasColumnName("tiempo_segundos");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitResQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_res_q1_2027_pkey");

            entity.ToTable("bit_res_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Descalificado).HasColumnName("descalificado");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionFinal).HasColumnName("posicion_final");
            entity.Property(e => e.PremioObtenido)
                .HasPrecision(12, 2)
                .HasColumnName("premio_obtenido");
            entity.Property(e => e.TiempoSegundos)
                .HasPrecision(8, 3)
                .HasColumnName("tiempo_segundos");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitResQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_res_q2_2025_pkey");

            entity.ToTable("bit_res_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Descalificado).HasColumnName("descalificado");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionFinal).HasColumnName("posicion_final");
            entity.Property(e => e.PremioObtenido)
                .HasPrecision(12, 2)
                .HasColumnName("premio_obtenido");
            entity.Property(e => e.TiempoSegundos)
                .HasPrecision(8, 3)
                .HasColumnName("tiempo_segundos");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitResQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_res_q2_2026_pkey");

            entity.ToTable("bit_res_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Descalificado).HasColumnName("descalificado");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionFinal).HasColumnName("posicion_final");
            entity.Property(e => e.PremioObtenido)
                .HasPrecision(12, 2)
                .HasColumnName("premio_obtenido");
            entity.Property(e => e.TiempoSegundos)
                .HasPrecision(8, 3)
                .HasColumnName("tiempo_segundos");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitResQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_res_q2_2027_pkey");

            entity.ToTable("bit_res_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Descalificado).HasColumnName("descalificado");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionFinal).HasColumnName("posicion_final");
            entity.Property(e => e.PremioObtenido)
                .HasPrecision(12, 2)
                .HasColumnName("premio_obtenido");
            entity.Property(e => e.TiempoSegundos)
                .HasPrecision(8, 3)
                .HasColumnName("tiempo_segundos");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitResQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_res_q3_2025_pkey");

            entity.ToTable("bit_res_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Descalificado).HasColumnName("descalificado");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionFinal).HasColumnName("posicion_final");
            entity.Property(e => e.PremioObtenido)
                .HasPrecision(12, 2)
                .HasColumnName("premio_obtenido");
            entity.Property(e => e.TiempoSegundos)
                .HasPrecision(8, 3)
                .HasColumnName("tiempo_segundos");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitResQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_res_q3_2026_pkey");

            entity.ToTable("bit_res_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Descalificado).HasColumnName("descalificado");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionFinal).HasColumnName("posicion_final");
            entity.Property(e => e.PremioObtenido)
                .HasPrecision(12, 2)
                .HasColumnName("premio_obtenido");
            entity.Property(e => e.TiempoSegundos)
                .HasPrecision(8, 3)
                .HasColumnName("tiempo_segundos");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitResQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_res_q3_2027_pkey");

            entity.ToTable("bit_res_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Descalificado).HasColumnName("descalificado");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionFinal).HasColumnName("posicion_final");
            entity.Property(e => e.PremioObtenido)
                .HasPrecision(12, 2)
                .HasColumnName("premio_obtenido");
            entity.Property(e => e.TiempoSegundos)
                .HasPrecision(8, 3)
                .HasColumnName("tiempo_segundos");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitResQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_res_q4_2025_pkey");

            entity.ToTable("bit_res_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Descalificado).HasColumnName("descalificado");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionFinal).HasColumnName("posicion_final");
            entity.Property(e => e.PremioObtenido)
                .HasPrecision(12, 2)
                .HasColumnName("premio_obtenido");
            entity.Property(e => e.TiempoSegundos)
                .HasPrecision(8, 3)
                .HasColumnName("tiempo_segundos");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitResQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_res_q4_2026_pkey");

            entity.ToTable("bit_res_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Descalificado).HasColumnName("descalificado");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionFinal).HasColumnName("posicion_final");
            entity.Property(e => e.PremioObtenido)
                .HasPrecision(12, 2)
                .HasColumnName("premio_obtenido");
            entity.Property(e => e.TiempoSegundos)
                .HasPrecision(8, 3)
                .HasColumnName("tiempo_segundos");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitResQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_res_q4_2027_pkey");

            entity.ToTable("bit_res_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Descalificado).HasColumnName("descalificado");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.PosicionFinal).HasColumnName("posicion_final");
            entity.Property(e => e.PremioObtenido)
                .HasPrecision(12, 2)
                .HasColumnName("premio_obtenido");
            entity.Property(e => e.TiempoSegundos)
                .HasPrecision(8, 3)
                .HasColumnName("tiempo_segundos");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitSumDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_sum_default_pkey");

            entity.ToTable("bit_sum_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CantidadDisponible)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad_disponible");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoSuministro).HasColumnName("id_tipo_suministro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitSumQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_sum_q1_2025_pkey");

            entity.ToTable("bit_sum_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CantidadDisponible)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad_disponible");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoSuministro).HasColumnName("id_tipo_suministro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitSumQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_sum_q1_2026_pkey");

            entity.ToTable("bit_sum_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CantidadDisponible)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad_disponible");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoSuministro).HasColumnName("id_tipo_suministro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitSumQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_sum_q1_2027_pkey");

            entity.ToTable("bit_sum_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CantidadDisponible)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad_disponible");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoSuministro).HasColumnName("id_tipo_suministro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitSumQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_sum_q2_2025_pkey");

            entity.ToTable("bit_sum_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CantidadDisponible)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad_disponible");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoSuministro).HasColumnName("id_tipo_suministro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitSumQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_sum_q2_2026_pkey");

            entity.ToTable("bit_sum_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CantidadDisponible)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad_disponible");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoSuministro).HasColumnName("id_tipo_suministro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitSumQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_sum_q2_2027_pkey");

            entity.ToTable("bit_sum_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CantidadDisponible)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad_disponible");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoSuministro).HasColumnName("id_tipo_suministro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitSumQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_sum_q3_2025_pkey");

            entity.ToTable("bit_sum_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CantidadDisponible)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad_disponible");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoSuministro).HasColumnName("id_tipo_suministro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitSumQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_sum_q3_2026_pkey");

            entity.ToTable("bit_sum_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CantidadDisponible)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad_disponible");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoSuministro).HasColumnName("id_tipo_suministro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitSumQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_sum_q3_2027_pkey");

            entity.ToTable("bit_sum_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CantidadDisponible)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad_disponible");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoSuministro).HasColumnName("id_tipo_suministro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitSumQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_sum_q4_2025_pkey");

            entity.ToTable("bit_sum_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CantidadDisponible)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad_disponible");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoSuministro).HasColumnName("id_tipo_suministro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitSumQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_sum_q4_2026_pkey");

            entity.ToTable("bit_sum_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CantidadDisponible)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad_disponible");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoSuministro).HasColumnName("id_tipo_suministro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitSumQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_sum_q4_2027_pkey");

            entity.ToTable("bit_sum_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.CantidadDisponible)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad_disponible");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdTipoSuministro).HasColumnName("id_tipo_suministro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitTrnDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_trn_default_pkey");

            entity.ToTable("bit_trn_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Monto)
                .HasPrecision(14, 2)
                .HasColumnName("monto");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitTrnQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_trn_q1_2025_pkey");

            entity.ToTable("bit_trn_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Monto)
                .HasPrecision(14, 2)
                .HasColumnName("monto");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitTrnQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_trn_q1_2026_pkey");

            entity.ToTable("bit_trn_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Monto)
                .HasPrecision(14, 2)
                .HasColumnName("monto");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitTrnQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_trn_q1_2027_pkey");

            entity.ToTable("bit_trn_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Monto)
                .HasPrecision(14, 2)
                .HasColumnName("monto");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitTrnQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_trn_q2_2025_pkey");

            entity.ToTable("bit_trn_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Monto)
                .HasPrecision(14, 2)
                .HasColumnName("monto");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitTrnQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_trn_q2_2026_pkey");

            entity.ToTable("bit_trn_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Monto)
                .HasPrecision(14, 2)
                .HasColumnName("monto");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitTrnQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_trn_q2_2027_pkey");

            entity.ToTable("bit_trn_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Monto)
                .HasPrecision(14, 2)
                .HasColumnName("monto");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitTrnQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_trn_q3_2025_pkey");

            entity.ToTable("bit_trn_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Monto)
                .HasPrecision(14, 2)
                .HasColumnName("monto");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitTrnQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_trn_q3_2026_pkey");

            entity.ToTable("bit_trn_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Monto)
                .HasPrecision(14, 2)
                .HasColumnName("monto");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitTrnQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_trn_q3_2027_pkey");

            entity.ToTable("bit_trn_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Monto)
                .HasPrecision(14, 2)
                .HasColumnName("monto");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitTrnQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_trn_q4_2025_pkey");

            entity.ToTable("bit_trn_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Monto)
                .HasPrecision(14, 2)
                .HasColumnName("monto");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitTrnQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_trn_q4_2026_pkey");

            entity.ToTable("bit_trn_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Monto)
                .HasPrecision(14, 2)
                .HasColumnName("monto");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitTrnQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_trn_q4_2027_pkey");

            entity.ToTable("bit_trn_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Monto)
                .HasPrecision(14, 2)
                .HasColumnName("monto");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitUsrDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_usr_default_pkey");

            entity.ToTable("bit_usr_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .HasColumnName("apellido1");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitUsrQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_usr_q1_2025_pkey");

            entity.ToTable("bit_usr_q1_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .HasColumnName("apellido1");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitUsrQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_usr_q1_2026_pkey");

            entity.ToTable("bit_usr_q1_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .HasColumnName("apellido1");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitUsrQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_usr_q1_2027_pkey");

            entity.ToTable("bit_usr_q1_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .HasColumnName("apellido1");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitUsrQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_usr_q2_2025_pkey");

            entity.ToTable("bit_usr_q2_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .HasColumnName("apellido1");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitUsrQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_usr_q2_2026_pkey");

            entity.ToTable("bit_usr_q2_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .HasColumnName("apellido1");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitUsrQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_usr_q2_2027_pkey");

            entity.ToTable("bit_usr_q2_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .HasColumnName("apellido1");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitUsrQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_usr_q3_2025_pkey");

            entity.ToTable("bit_usr_q3_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .HasColumnName("apellido1");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitUsrQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_usr_q3_2026_pkey");

            entity.ToTable("bit_usr_q3_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .HasColumnName("apellido1");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitUsrQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_usr_q3_2027_pkey");

            entity.ToTable("bit_usr_q3_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .HasColumnName("apellido1");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitUsrQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_usr_q4_2025_pkey");

            entity.ToTable("bit_usr_q4_2025");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .HasColumnName("apellido1");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitUsrQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_usr_q4_2026_pkey");

            entity.ToTable("bit_usr_q4_2026");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .HasColumnName("apellido1");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitUsrQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bit_usr_q4_2027_pkey");

            entity.ToTable("bit_usr_q4_2027");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .HasColumnName("apellido1");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitacoraDetalleF2025Q1>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bitacora_detalle_f_2025_q1_pkey");

            entity.ToTable("bitacora_detalle_f_2025_q1");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(12, 2)
                .HasColumnName("precio_unitario");
            entity.Property(e => e.SubtotalLinea)
                .HasPrecision(12, 2)
                .HasColumnName("subtotal_linea");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitacoraDetalleF2025Q2>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bitacora_detalle_f_2025_q2_pkey");

            entity.ToTable("bitacora_detalle_f_2025_q2");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(12, 2)
                .HasColumnName("precio_unitario");
            entity.Property(e => e.SubtotalLinea)
                .HasPrecision(12, 2)
                .HasColumnName("subtotal_linea");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitacoraDetalleF2025Q3>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bitacora_detalle_f_2025_q3_pkey");

            entity.ToTable("bitacora_detalle_f_2025_q3");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(12, 2)
                .HasColumnName("precio_unitario");
            entity.Property(e => e.SubtotalLinea)
                .HasPrecision(12, 2)
                .HasColumnName("subtotal_linea");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitacoraDetalleF2025Q4>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bitacora_detalle_f_2025_q4_pkey");

            entity.ToTable("bitacora_detalle_f_2025_q4");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(12, 2)
                .HasColumnName("precio_unitario");
            entity.Property(e => e.SubtotalLinea)
                .HasPrecision(12, 2)
                .HasColumnName("subtotal_linea");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitacoraDetalleF2026Q1>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bitacora_detalle_f_2026_q1_pkey");

            entity.ToTable("bitacora_detalle_f_2026_q1");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(12, 2)
                .HasColumnName("precio_unitario");
            entity.Property(e => e.SubtotalLinea)
                .HasPrecision(12, 2)
                .HasColumnName("subtotal_linea");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitacoraDetalleF2026Q2>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bitacora_detalle_f_2026_q2_pkey");

            entity.ToTable("bitacora_detalle_f_2026_q2");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(12, 2)
                .HasColumnName("precio_unitario");
            entity.Property(e => e.SubtotalLinea)
                .HasPrecision(12, 2)
                .HasColumnName("subtotal_linea");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitacoraDetalleF2026Q3>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bitacora_detalle_f_2026_q3_pkey");

            entity.ToTable("bitacora_detalle_f_2026_q3");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(12, 2)
                .HasColumnName("precio_unitario");
            entity.Property(e => e.SubtotalLinea)
                .HasPrecision(12, 2)
                .HasColumnName("subtotal_linea");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitacoraDetalleF2026Q4>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bitacora_detalle_f_2026_q4_pkey");

            entity.ToTable("bitacora_detalle_f_2026_q4");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(12, 2)
                .HasColumnName("precio_unitario");
            entity.Property(e => e.SubtotalLinea)
                .HasPrecision(12, 2)
                .HasColumnName("subtotal_linea");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitacoraDetalleF2027Q1>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bitacora_detalle_f_2027_q1_pkey");

            entity.ToTable("bitacora_detalle_f_2027_q1");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(12, 2)
                .HasColumnName("precio_unitario");
            entity.Property(e => e.SubtotalLinea)
                .HasPrecision(12, 2)
                .HasColumnName("subtotal_linea");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitacoraDetalleF2027Q2>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bitacora_detalle_f_2027_q2_pkey");

            entity.ToTable("bitacora_detalle_f_2027_q2");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(12, 2)
                .HasColumnName("precio_unitario");
            entity.Property(e => e.SubtotalLinea)
                .HasPrecision(12, 2)
                .HasColumnName("subtotal_linea");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitacoraDetalleF2027Q3>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bitacora_detalle_f_2027_q3_pkey");

            entity.ToTable("bitacora_detalle_f_2027_q3");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(12, 2)
                .HasColumnName("precio_unitario");
            entity.Property(e => e.SubtotalLinea)
                .HasPrecision(12, 2)
                .HasColumnName("subtotal_linea");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitacoraDetalleF2027Q4>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bitacora_detalle_f_2027_q4_pkey");

            entity.ToTable("bitacora_detalle_f_2027_q4");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(12, 2)
                .HasColumnName("precio_unitario");
            entity.Property(e => e.SubtotalLinea)
                .HasPrecision(12, 2)
                .HasColumnName("subtotal_linea");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<BitacoraDetalleFDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdBitacora, e.FechaRegistro }).HasName("bitacora_detalle_f_default_pkey");

            entity.ToTable("bitacora_detalle_f_default");

            entity.Property(e => e.IdBitacora)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_bitacora");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Accion)
                .HasMaxLength(10)
                .HasColumnName("accion");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(12, 2)
                .HasColumnName("precio_unitario");
            entity.Property(e => e.SubtotalLinea)
                .HasPrecision(12, 2)
                .HasColumnName("subtotal_linea");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(100)
                .HasDefaultValueSql("CURRENT_USER")
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<Bucket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("buckets_pkey");

            entity.ToTable("buckets", "storage");

            entity.HasIndex(e => e.Name, "bname").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllowedMimeTypes).HasColumnName("allowed_mime_types");
            entity.Property(e => e.AvifAutodetection)
                .HasDefaultValue(false)
                .HasColumnName("avif_autodetection");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.FileSizeLimit).HasColumnName("file_size_limit");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Owner)
                .HasComment("Field is deprecated, use owner_id instead")
                .HasColumnName("owner");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.Public)
                .HasDefaultValue(false)
                .HasColumnName("public");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<BucketsAnalytic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("buckets_analytics_pkey");

            entity.ToTable("buckets_analytics", "storage");

            entity.HasIndex(e => e.Name, "buckets_analytics_unique_name_idx")
                .IsUnique()
                .HasFilter("(deleted_at IS NULL)");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Format)
                .HasDefaultValueSql("'ICEBERG'::text")
                .HasColumnName("format");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<BucketsVector>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("buckets_vectors_pkey");

            entity.ToTable("buckets_vectors", "storage");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Caballo>(entity =>
        {
            entity.HasKey(e => e.IdCaballo).HasName("caballos_pkey");

            entity.ToTable("caballos");

            entity.HasIndex(e => e.Codigo, "caballos_codigo_key").IsUnique();

            entity.HasIndex(e => e.Activo, "idx_cab_activo").HasFilter("(activo = true)");

            entity.HasIndex(e => e.Nombre, "idx_cab_nombre");

            entity.HasIndex(e => e.IdPropietario, "idx_cab_propietario");

            entity.Property(e => e.IdCaballo)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_caballo");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdEstadoSalud).HasColumnName("id_estado_salud");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.IdSexo).HasColumnName("id_sexo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.PesoKg)
                .HasPrecision(8, 2)
                .HasColumnName("peso_kg");

            entity.HasOne(d => d.IdEstadoSaludNavigation).WithMany(p => p.Caballos)
                .HasForeignKey(d => d.IdEstadoSalud)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cab_salud");

            entity.HasOne(d => d.IdPropietarioNavigation).WithMany(p => p.Caballos)
                .HasForeignKey(d => d.IdPropietario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cab_propietario");

            entity.HasOne(d => d.IdRazaNavigation).WithMany(p => p.Caballos)
                .HasForeignKey(d => d.IdRaza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cab_raza");

            entity.HasOne(d => d.IdSexoNavigation).WithMany(p => p.Caballos)
                .HasForeignKey(d => d.IdSexo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cab_sexo");
        });

        modelBuilder.Entity<Canton>(entity =>
        {
            entity.HasKey(e => e.IdCanton).HasName("canton_pkey");

            entity.ToTable("canton");

            entity.HasIndex(e => new { e.IdProvincia, e.Nombre }, "uq_canton").IsUnique();

            entity.Property(e => e.IdCanton)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_canton");
            entity.Property(e => e.IdProvincia).HasColumnName("id_provincia");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.Cantons)
                .HasForeignKey(d => d.IdProvincia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_canton_provincia");
        });

        modelBuilder.Entity<CertificacionesSanitaria>(entity =>
        {
            entity.HasKey(e => e.IdCertificacion).HasName("certificaciones_sanitarias_pkey");

            entity.ToTable("certificaciones_sanitarias");

            entity.HasIndex(e => e.NumeroCertificado, "certificaciones_sanitarias_numero_certificado_key").IsUnique();

            entity.HasIndex(e => e.IdCaballo, "idx_cert_caballo");

            entity.HasIndex(e => e.FechaVencimiento, "idx_cert_vencimiento");

            entity.Property(e => e.IdCertificacion)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_certificacion");
            entity.Property(e => e.FechaEmision).HasColumnName("fecha_emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoCertificacion).HasColumnName("id_estado_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.NumeroCertificado)
                .HasMaxLength(50)
                .HasColumnName("numero_certificado");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.CertificacionesSanitaria)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cert_caballo");

            entity.HasOne(d => d.IdEstadoCertificacionNavigation).WithMany(p => p.CertificacionesSanitaria)
                .HasForeignKey(d => d.IdEstadoCertificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cert_estado");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.CertificacionesSanitaria)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cert_vet");
        });

        modelBuilder.Entity<CorreosUsuario>(entity =>
        {
            entity.HasKey(e => e.IdCorreo).HasName("correos_usuarios_pkey");

            entity.ToTable("correos_usuarios");

            entity.HasIndex(e => new { e.IdUsuario, e.Correo }, "uq_correo_usuario").IsUnique();

            entity.Property(e => e.IdCorreo)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_correo");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .HasColumnName("correo");
            entity.Property(e => e.IdTipoCorreo).HasColumnName("id_tipo_correo");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdTipoCorreoNavigation).WithMany(p => p.CorreosUsuarios)
                .HasForeignKey(d => d.IdTipoCorreo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_correo_tipo");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.CorreosUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("fk_correo_usuario");
        });

        modelBuilder.Entity<CustomOauthProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("custom_oauth_providers_pkey");

            entity.ToTable("custom_oauth_providers", "auth");

            entity.HasIndex(e => e.CreatedAt, "custom_oauth_providers_created_at_idx");

            entity.HasIndex(e => e.Enabled, "custom_oauth_providers_enabled_idx");

            entity.HasIndex(e => e.Identifier, "custom_oauth_providers_identifier_idx");

            entity.HasIndex(e => e.Identifier, "custom_oauth_providers_identifier_key").IsUnique();

            entity.HasIndex(e => e.ProviderType, "custom_oauth_providers_provider_type_idx");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.AcceptableClientIds)
                .HasDefaultValueSql("'{}'::text[]")
                .HasColumnName("acceptable_client_ids");
            entity.Property(e => e.AttributeMapping)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("attribute_mapping");
            entity.Property(e => e.AuthorizationParams)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("authorization_params");
            entity.Property(e => e.AuthorizationUrl).HasColumnName("authorization_url");
            entity.Property(e => e.CachedDiscovery)
                .HasColumnType("jsonb")
                .HasColumnName("cached_discovery");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.ClientSecret).HasColumnName("client_secret");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DiscoveryCachedAt).HasColumnName("discovery_cached_at");
            entity.Property(e => e.DiscoveryUrl).HasColumnName("discovery_url");
            entity.Property(e => e.EmailOptional).HasColumnName("email_optional");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(true)
                .HasColumnName("enabled");
            entity.Property(e => e.Identifier).HasColumnName("identifier");
            entity.Property(e => e.Issuer).HasColumnName("issuer");
            entity.Property(e => e.JwksUri).HasColumnName("jwks_uri");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.PkceEnabled)
                .HasDefaultValue(true)
                .HasColumnName("pkce_enabled");
            entity.Property(e => e.ProviderType).HasColumnName("provider_type");
            entity.Property(e => e.Scopes)
                .HasDefaultValueSql("'{}'::text[]")
                .HasColumnName("scopes");
            entity.Property(e => e.SkipNonceCheck).HasColumnName("skip_nonce_check");
            entity.Property(e => e.TokenUrl).HasColumnName("token_url");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserinfoUrl).HasColumnName("userinfo_url");
        });

        modelBuilder.Entity<DetalleFactura>(entity =>
        {
            entity.HasKey(e => e.IdDetalle).HasName("detalle_factura_pkey");

            entity.ToTable("detalle_factura");

            entity.HasIndex(e => new { e.IdFactura, e.IdInscripcion }, "uq_det_fac_ins").IsUnique();

            entity.Property(e => e.IdDetalle)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_detalle");
            entity.Property(e => e.Cantidad)
                .HasDefaultValue(1)
                .HasColumnName("cantidad");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(12, 2)
                .HasColumnName("precio_unitario");
            entity.Property(e => e.SubtotalLinea)
                .HasPrecision(12, 2)
                .HasColumnName("subtotal_linea");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.DetalleFacturas)
                .HasForeignKey(d => d.IdFactura)
                .HasConstraintName("fk_det_factura");

            entity.HasOne(d => d.IdInscripcionNavigation).WithMany(p => p.DetalleFacturas)
                .HasForeignKey(d => d.IdInscripcion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_det_inscripcion");
        });

        modelBuilder.Entity<Distrito>(entity =>
        {
            entity.HasKey(e => e.IdDistrito).HasName("distrito_pkey");

            entity.ToTable("distrito");

            entity.HasIndex(e => new { e.IdCanton, e.Nombre }, "uq_distrito").IsUnique();

            entity.Property(e => e.IdDistrito)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_distrito");
            entity.Property(e => e.IdCanton).HasColumnName("id_canton");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdCantonNavigation).WithMany(p => p.Distritos)
                .HasForeignKey(d => d.IdCanton)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_distrito_canton");
        });

        modelBuilder.Entity<Establo>(entity =>
        {
            entity.HasKey(e => e.IdEstablo).HasName("establos_pkey");

            entity.ToTable("establos");

            entity.HasIndex(e => e.Codigo, "establos_codigo_key").IsUnique();

            entity.Property(e => e.IdEstablo)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_establo");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.IdEstadoEstablo).HasColumnName("id_estado_establo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .HasColumnName("ubicacion");

            entity.HasOne(d => d.IdEstadoEstabloNavigation).WithMany(p => p.Establos)
                .HasForeignKey(d => d.IdEstadoEstablo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_establo_estado");
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.IdEvento).HasName("eventos_pkey");

            entity.ToTable("eventos");

            entity.HasIndex(e => e.CodigoEvento, "eventos_codigo_evento_key").IsUnique();

            entity.HasIndex(e => e.IdEstadoEvento, "idx_ev_estado");

            entity.HasIndex(e => e.FechaEvento, "idx_ev_fecha");

            entity.Property(e => e.IdEvento)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_evento");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.ComisionAdmin)
                .HasPrecision(5, 2)
                .HasDefaultValue(5.00m)
                .HasColumnName("comision_admin");
            entity.Property(e => e.DistanciaMetros).HasColumnName("distancia_metros");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IdEstadoEvento).HasColumnName("id_estado_evento");
            entity.Property(e => e.IdTipoCarrera).HasColumnName("id_tipo_carrera");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.PrecioInscripcion)
                .HasPrecision(10, 2)
                .HasColumnName("precio_inscripcion");
            entity.Property(e => e.PremioTotal)
                .HasPrecision(14, 2)
                .HasColumnName("premio_total");

            entity.HasOne(d => d.IdEstadoEventoNavigation).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.IdEstadoEvento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ev_estado");

            entity.HasOne(d => d.IdTipoCarreraNavigation).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.IdTipoCarrera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ev_tipo");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("facturas_pkey");

            entity.ToTable("facturas");

            entity.HasIndex(e => e.NumeroFactura, "facturas_numero_factura_key").IsUnique();

            entity.HasIndex(e => e.FechaFactura, "idx_fac_fecha");

            entity.HasIndex(e => e.IdPropietario, "idx_fac_propietario");

            entity.Property(e => e.IdFactura)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_factura");
            entity.Property(e => e.BaseImponible)
                .HasPrecision(14, 2)
                .HasColumnName("base_imponible");
            entity.Property(e => e.ComisionAdmin)
                .HasPrecision(14, 2)
                .HasColumnName("comision_admin");
            entity.Property(e => e.DescuentoPct)
                .HasPrecision(5, 2)
                .HasColumnName("descuento_pct");
            entity.Property(e => e.FechaFactura)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_factura");
            entity.Property(e => e.IdEstadoPago).HasColumnName("id_estado_pago");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.ImpuestoIva)
                .HasPrecision(14, 2)
                .HasColumnName("impuesto_iva");
            entity.Property(e => e.MontoDescuento)
                .HasPrecision(14, 2)
                .HasColumnName("monto_descuento");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Subtotal)
                .HasPrecision(14, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(14, 2)
                .HasColumnName("total");

            entity.HasOne(d => d.IdEstadoPagoNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdEstadoPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_fac_estado");

            entity.HasOne(d => d.IdPropietarioNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdPropietario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_fac_propietario");
        });

        modelBuilder.Entity<FlowState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("flow_state_pkey");

            entity.ToTable("flow_state", "auth", tb => tb.HasComment("Stores metadata for all OAuth/SSO login flows"));

            entity.HasIndex(e => e.CreatedAt, "flow_state_created_at_idx").IsDescending();

            entity.HasIndex(e => e.AuthCode, "idx_auth_code");

            entity.HasIndex(e => new { e.UserId, e.AuthenticationMethod }, "idx_user_id_auth_method");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AuthCode).HasColumnName("auth_code");
            entity.Property(e => e.AuthCodeIssuedAt).HasColumnName("auth_code_issued_at");
            entity.Property(e => e.AuthenticationMethod).HasColumnName("authentication_method");
            entity.Property(e => e.CodeChallenge).HasColumnName("code_challenge");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.EmailOptional).HasColumnName("email_optional");
            entity.Property(e => e.InviteToken).HasColumnName("invite_token");
            entity.Property(e => e.LinkingTargetId).HasColumnName("linking_target_id");
            entity.Property(e => e.OauthClientStateId).HasColumnName("oauth_client_state_id");
            entity.Property(e => e.ProviderAccessToken).HasColumnName("provider_access_token");
            entity.Property(e => e.ProviderRefreshToken).HasColumnName("provider_refresh_token");
            entity.Property(e => e.ProviderType).HasColumnName("provider_type");
            entity.Property(e => e.Referrer).HasColumnName("referrer");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<HistorialTransaccione>(entity =>
        {
            entity.HasKey(e => e.IdTransaccion).HasName("historial_transacciones_pkey");

            entity.ToTable("historial_transacciones");

            entity.Property(e => e.IdTransaccion)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_transaccion");
            entity.Property(e => e.FechaPago)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.Monto)
                .HasPrecision(14, 2)
                .HasColumnName("monto");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.HistorialTransacciones)
                .HasForeignKey(d => d.IdFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_trans_factura");

            entity.HasOne(d => d.IdMetodoPagoNavigation).WithMany(p => p.HistorialTransacciones)
                .HasForeignKey(d => d.IdMetodoPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_trans_metodo");
        });

        modelBuilder.Entity<HvDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_default_pkey");

            entity.ToTable("hv_default");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_default_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvDefaults)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvDefaults)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvDefaults)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ12025>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q1_2025_pkey");

            entity.ToTable("hv_q1_2025");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q1_2025_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ12025s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ12025s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ12025s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ12026>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q1_2026_pkey");

            entity.ToTable("hv_q1_2026");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q1_2026_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ12026s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ12026s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ12026s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ12027>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q1_2027_pkey");

            entity.ToTable("hv_q1_2027");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q1_2027_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ12027s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ12027s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ12027s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ12028>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q1_2028_pkey");

            entity.ToTable("hv_q1_2028");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q1_2028_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ12028s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ12028s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ12028s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ22025>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q2_2025_pkey");

            entity.ToTable("hv_q2_2025");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q2_2025_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ22025s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ22025s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ22025s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ22026>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q2_2026_pkey");

            entity.ToTable("hv_q2_2026");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q2_2026_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ22026s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ22026s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ22026s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ22027>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q2_2027_pkey");

            entity.ToTable("hv_q2_2027");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q2_2027_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ22027s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ22027s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ22027s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ22028>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q2_2028_pkey");

            entity.ToTable("hv_q2_2028");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q2_2028_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ22028s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ22028s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ22028s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ32025>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q3_2025_pkey");

            entity.ToTable("hv_q3_2025");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q3_2025_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ32025s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ32025s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ32025s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ32026>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q3_2026_pkey");

            entity.ToTable("hv_q3_2026");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q3_2026_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ32026s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ32026s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ32026s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ32027>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q3_2027_pkey");

            entity.ToTable("hv_q3_2027");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q3_2027_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ32027s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ32027s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ32027s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ32028>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q3_2028_pkey");

            entity.ToTable("hv_q3_2028");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q3_2028_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ32028s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ32028s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ32028s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ42025>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q4_2025_pkey");

            entity.ToTable("hv_q4_2025");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q4_2025_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ42025s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ42025s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ42025s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ42026>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q4_2026_pkey");

            entity.ToTable("hv_q4_2026");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q4_2026_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ42026s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ42026s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ42026s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ42027>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q4_2027_pkey");

            entity.ToTable("hv_q4_2027");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q4_2027_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ42027s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ42027s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ42027s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<HvQ42028>(entity =>
        {
            entity.HasKey(e => new { e.IdHistorial, e.FechaRevision }).HasName("hv_q4_2028_pkey");

            entity.ToTable("hv_q4_2028");

            entity.HasIndex(e => new { e.IdCaballo, e.FechaRevision }, "hv_q4_2028_id_caballo_fecha_revision_idx");

            entity.Property(e => e.IdHistorial)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, 0L, 0L, 0L, null, 0L)
                .HasColumnName("id_historial");
            entity.Property(e => e.FechaRevision)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_revision");
            entity.Property(e => e.Diagnostico).HasColumnName("diagnostico");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");
            entity.Property(e => e.IdVeterinario).HasColumnName("id_veterinario");
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.ProximoControl).HasColumnName("proximo_control");
            entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.HvQ42028s)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_caballo");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.HvQ42028s)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("fk_hv_certificacion");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.HvQ42028s)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hv_veterinario");
        });

        modelBuilder.Entity<Identity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("identities_pkey");

            entity.ToTable("identities", "auth", tb => tb.HasComment("Auth: Stores identities associated to a user."));

            entity.HasIndex(e => e.Email, "identities_email_idx").HasOperators(new[] { "text_pattern_ops" });

            entity.HasIndex(e => new { e.ProviderId, e.Provider }, "identities_provider_id_provider_unique").IsUnique();

            entity.HasIndex(e => e.UserId, "identities_user_id_idx");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasComputedColumnSql("lower((identity_data ->> 'email'::text))", true)
                .HasComment("Auth: Email is a generated column that references the optional email property in the identity_data")
                .HasColumnName("email");
            entity.Property(e => e.IdentityData)
                .HasColumnType("jsonb")
                .HasColumnName("identity_data");
            entity.Property(e => e.LastSignInAt).HasColumnName("last_sign_in_at");
            entity.Property(e => e.Provider).HasColumnName("provider");
            entity.Property(e => e.ProviderId).HasColumnName("provider_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Identities)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("identities_user_id_fkey");
        });

        modelBuilder.Entity<Inscripcione>(entity =>
        {
            entity.HasKey(e => e.IdInscripcion).HasName("inscripciones_pkey");

            entity.ToTable("inscripciones");

            entity.HasIndex(e => e.IdCaballo, "idx_ins_caballo");

            entity.HasIndex(e => e.IdEvento, "idx_ins_evento");

            entity.HasIndex(e => new { e.IdEvento, e.IdCaballo }, "uq_ins_ev_cab").IsUnique();

            entity.Property(e => e.IdInscripcion)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_inscripcion");
            entity.Property(e => e.FechaInscripcion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_inscripcion");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.IdEstadoInscripcion).HasColumnName("id_estado_inscripcion");
            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("observaciones");
            entity.Property(e => e.PosicionSalida).HasColumnName("posicion_salida");

            entity.HasOne(d => d.IdCaballoNavigation).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.IdCaballo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ins_caballo");

            entity.HasOne(d => d.IdEstadoInscripcionNavigation).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.IdEstadoInscripcion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ins_estado");

            entity.HasOne(d => d.IdEventoNavigation).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.IdEvento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ins_evento");
        });

        modelBuilder.Entity<Instance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("instances_pkey");

            entity.ToTable("instances", "auth", tb => tb.HasComment("Auth: Manages users across multiple sites."));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.RawBaseConfig).HasColumnName("raw_base_config");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.Uuid).HasColumnName("uuid");
        });

        modelBuilder.Entity<MfaAmrClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("amr_id_pk");

            entity.ToTable("mfa_amr_claims", "auth", tb => tb.HasComment("auth: stores authenticator method reference claims for multi factor authentication"));

            entity.HasIndex(e => new { e.SessionId, e.AuthenticationMethod }, "mfa_amr_claims_session_id_authentication_method_pkey").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AuthenticationMethod).HasColumnName("authentication_method");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.SessionId).HasColumnName("session_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Session).WithMany(p => p.MfaAmrClaims)
                .HasForeignKey(d => d.SessionId)
                .HasConstraintName("mfa_amr_claims_session_id_fkey");
        });

        modelBuilder.Entity<MfaChallenge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mfa_challenges_pkey");

            entity.ToTable("mfa_challenges", "auth", tb => tb.HasComment("auth: stores metadata about challenge requests made"));

            entity.HasIndex(e => e.CreatedAt, "mfa_challenge_created_at_idx").IsDescending();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FactorId).HasColumnName("factor_id");
            entity.Property(e => e.IpAddress).HasColumnName("ip_address");
            entity.Property(e => e.OtpCode).HasColumnName("otp_code");
            entity.Property(e => e.VerifiedAt).HasColumnName("verified_at");
            entity.Property(e => e.WebAuthnSessionData)
                .HasColumnType("jsonb")
                .HasColumnName("web_authn_session_data");

            entity.HasOne(d => d.Factor).WithMany(p => p.MfaChallenges)
                .HasForeignKey(d => d.FactorId)
                .HasConstraintName("mfa_challenges_auth_factor_id_fkey");
        });

        modelBuilder.Entity<MfaFactor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mfa_factors_pkey");

            entity.ToTable("mfa_factors", "auth", tb => tb.HasComment("auth: stores metadata about factors"));

            entity.HasIndex(e => new { e.UserId, e.CreatedAt }, "factor_id_created_at_idx");

            entity.HasIndex(e => e.LastChallengedAt, "mfa_factors_last_challenged_at_key").IsUnique();

            entity.HasIndex(e => new { e.FriendlyName, e.UserId }, "mfa_factors_user_friendly_name_unique")
                .IsUnique()
                .HasFilter("(TRIM(BOTH FROM friendly_name) <> ''::text)");

            entity.HasIndex(e => e.UserId, "mfa_factors_user_id_idx");

            entity.HasIndex(e => new { e.UserId, e.Phone }, "unique_phone_factor_per_user").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FriendlyName).HasColumnName("friendly_name");
            entity.Property(e => e.LastChallengedAt).HasColumnName("last_challenged_at");
            entity.Property(e => e.LastWebauthnChallengeData)
                .HasComment("Stores the latest WebAuthn challenge data including attestation/assertion for customer verification")
                .HasColumnType("jsonb")
                .HasColumnName("last_webauthn_challenge_data");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Secret).HasColumnName("secret");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.WebAuthnAaguid).HasColumnName("web_authn_aaguid");
            entity.Property(e => e.WebAuthnCredential)
                .HasColumnType("jsonb")
                .HasColumnName("web_authn_credential");

            entity.HasOne(d => d.User).WithMany(p => p.MfaFactors)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("mfa_factors_user_id_fkey");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("migrations_pkey");

            entity.ToTable("migrations", "storage");

            entity.HasIndex(e => e.Name, "migrations_name_key").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ExecutedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("executed_at");
            entity.Property(e => e.Hash)
                .HasMaxLength(40)
                .HasColumnName("hash");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<OauthAuthorization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oauth_authorizations_pkey");

            entity.ToTable("oauth_authorizations", "auth");

            entity.HasIndex(e => e.ExpiresAt, "oauth_auth_pending_exp_idx").HasFilter("(status = 'pending'::auth.oauth_authorization_status)");

            entity.HasIndex(e => e.AuthorizationCode, "oauth_authorizations_authorization_code_key").IsUnique();

            entity.HasIndex(e => e.AuthorizationId, "oauth_authorizations_authorization_id_key").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ApprovedAt).HasColumnName("approved_at");
            entity.Property(e => e.AuthorizationCode).HasColumnName("authorization_code");
            entity.Property(e => e.AuthorizationId).HasColumnName("authorization_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.CodeChallenge).HasColumnName("code_challenge");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.ExpiresAt)
                .HasDefaultValueSql("(now() + '00:03:00'::interval)")
                .HasColumnName("expires_at");
            entity.Property(e => e.Nonce).HasColumnName("nonce");
            entity.Property(e => e.RedirectUri).HasColumnName("redirect_uri");
            entity.Property(e => e.Resource).HasColumnName("resource");
            entity.Property(e => e.Scope).HasColumnName("scope");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Client).WithMany(p => p.OauthAuthorizations)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("oauth_authorizations_client_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.OauthAuthorizations)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("oauth_authorizations_user_id_fkey");
        });

        modelBuilder.Entity<OauthClient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oauth_clients_pkey");

            entity.ToTable("oauth_clients", "auth");

            entity.HasIndex(e => e.DeletedAt, "oauth_clients_deleted_at_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClientName).HasColumnName("client_name");
            entity.Property(e => e.ClientSecretHash).HasColumnName("client_secret_hash");
            entity.Property(e => e.ClientUri).HasColumnName("client_uri");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.GrantTypes).HasColumnName("grant_types");
            entity.Property(e => e.LogoUri).HasColumnName("logo_uri");
            entity.Property(e => e.RedirectUris).HasColumnName("redirect_uris");
            entity.Property(e => e.TokenEndpointAuthMethod).HasColumnName("token_endpoint_auth_method");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<OauthClientState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oauth_client_states_pkey");

            entity.ToTable("oauth_client_states", "auth", tb => tb.HasComment("Stores OAuth states for third-party provider authentication flows where Supabase acts as the OAuth client."));

            entity.HasIndex(e => e.CreatedAt, "idx_oauth_client_states_created_at");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CodeVerifier).HasColumnName("code_verifier");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.ProviderType).HasColumnName("provider_type");
        });

        modelBuilder.Entity<OauthConsent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oauth_consents_pkey");

            entity.ToTable("oauth_consents", "auth");

            entity.HasIndex(e => e.ClientId, "oauth_consents_active_client_idx").HasFilter("(revoked_at IS NULL)");

            entity.HasIndex(e => new { e.UserId, e.ClientId }, "oauth_consents_active_user_client_idx").HasFilter("(revoked_at IS NULL)");

            entity.HasIndex(e => new { e.UserId, e.ClientId }, "oauth_consents_user_client_unique").IsUnique();

            entity.HasIndex(e => new { e.UserId, e.GrantedAt }, "oauth_consents_user_order_idx").IsDescending(false, true);

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.GrantedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("granted_at");
            entity.Property(e => e.RevokedAt).HasColumnName("revoked_at");
            entity.Property(e => e.Scopes).HasColumnName("scopes");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Client).WithMany(p => p.OauthConsents)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("oauth_consents_client_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.OauthConsents)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("oauth_consents_user_id_fkey");
        });

        modelBuilder.Entity<Object>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("objects_pkey");

            entity.ToTable("objects", "storage");

            entity.HasIndex(e => new { e.BucketId, e.Name }, "bucketid_objname").IsUnique();

            entity.HasIndex(e => new { e.BucketId, e.Name }, "idx_objects_bucket_id_name").UseCollation(new[] { null, "C" });

            entity.HasIndex(e => e.Name, "name_prefix_search").HasOperators(new[] { "text_pattern_ops" });

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.BucketId).HasColumnName("bucket_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.LastAccessedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("last_accessed_at");
            entity.Property(e => e.Metadata)
                .HasColumnType("jsonb")
                .HasColumnName("metadata");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Owner)
                .HasComment("Field is deprecated, use owner_id instead")
                .HasColumnName("owner");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.PathTokens)
                .HasComputedColumnSql("string_to_array(name, '/'::text)", true)
                .HasColumnName("path_tokens");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserMetadata)
                .HasColumnType("jsonb")
                .HasColumnName("user_metadata");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Bucket).WithMany(p => p.Objects)
                .HasForeignKey(d => d.BucketId)
                .HasConstraintName("objects_bucketId_fkey");
        });

        modelBuilder.Entity<OneTimeToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("one_time_tokens_pkey");

            entity.ToTable("one_time_tokens", "auth");

            entity.HasIndex(e => e.RelatesTo, "one_time_tokens_relates_to_hash_idx").HasMethod("hash");

            entity.HasIndex(e => e.TokenHash, "one_time_tokens_token_hash_hash_idx").HasMethod("hash");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.RelatesTo).HasColumnName("relates_to");
            entity.Property(e => e.TokenHash).HasColumnName("token_hash");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.OneTimeTokens)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("one_time_tokens_user_id_fkey");
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasKey(e => e.IdPais).HasName("pais_pkey");

            entity.ToTable("pais");

            entity.HasIndex(e => e.CodigoIso, "pais_codigo_iso_key").IsUnique();

            entity.HasIndex(e => e.Nombre, "pais_nombre_key").IsUnique();

            entity.Property(e => e.IdPais)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_pais");
            entity.Property(e => e.CodigoIso)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("codigo_iso");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Propietario>(entity =>
        {
            entity.HasKey(e => e.IdPropietario).HasName("propietarios_pkey");

            entity.ToTable("propietarios");

            entity.HasIndex(e => e.IdUsuario, "propietarios_id_usuario_key").IsUnique();

            entity.Property(e => e.IdPropietario)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_propietario");
            entity.Property(e => e.DescuentoProximaFactura)
                .HasDefaultValue(false)
                .HasColumnName("descuento_proxima_factura");
            entity.Property(e => e.DireccionExacta)
                .HasMaxLength(255)
                .HasColumnName("direccion_exacta");
            entity.Property(e => e.FechaUltimaRevisionDescuento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_ultima_revision_descuento");
            entity.Property(e => e.IdBarrio).HasColumnName("id_barrio");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdBarrioNavigation).WithMany(p => p.Propietarios)
                .HasForeignKey(d => d.IdBarrio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_prop_barrio");

            entity.HasOne(d => d.IdUsuarioNavigation).WithOne(p => p.Propietario)
                .HasForeignKey<Propietario>(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_prop_usuario");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("proveedores_pkey");

            entity.ToTable("proveedores");

            entity.HasIndex(e => e.Nombre, "proveedores_nombre_key").IsUnique();

            entity.Property(e => e.IdProveedor)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_proveedor");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .HasColumnName("contacto");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .HasColumnName("correo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Provincium>(entity =>
        {
            entity.HasKey(e => e.IdProvincia).HasName("provincia_pkey");

            entity.ToTable("provincia");

            entity.HasIndex(e => new { e.IdPais, e.Nombre }, "uq_provincia").IsUnique();

            entity.Property(e => e.IdProvincia)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_provincia");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Provincia)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_provincia_pais");
        });

        modelBuilder.Entity<RefreshToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("refresh_tokens_pkey");

            entity.ToTable("refresh_tokens", "auth", tb => tb.HasComment("Auth: Store of tokens used to refresh JWT tokens once they expire."));

            entity.HasIndex(e => e.InstanceId, "refresh_tokens_instance_id_idx");

            entity.HasIndex(e => new { e.InstanceId, e.UserId }, "refresh_tokens_instance_id_user_id_idx");

            entity.HasIndex(e => e.Parent, "refresh_tokens_parent_idx");

            entity.HasIndex(e => new { e.SessionId, e.Revoked }, "refresh_tokens_session_id_revoked_idx");

            entity.HasIndex(e => e.Token, "refresh_tokens_token_unique").IsUnique();

            entity.HasIndex(e => e.UpdatedAt, "refresh_tokens_updated_at_idx").IsDescending();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.InstanceId).HasColumnName("instance_id");
            entity.Property(e => e.Parent)
                .HasMaxLength(255)
                .HasColumnName("parent");
            entity.Property(e => e.Revoked).HasColumnName("revoked");
            entity.Property(e => e.SessionId).HasColumnName("session_id");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("token");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id");

            entity.HasOne(d => d.Session).WithMany(p => p.RefreshTokens)
                .HasForeignKey(d => d.SessionId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("refresh_tokens_session_id_fkey");
        });

        modelBuilder.Entity<ResultadosCarrera>(entity =>
        {
            entity.HasKey(e => e.IdResultado).HasName("resultados_carrera_pkey");

            entity.ToTable("resultados_carrera");

            entity.HasIndex(e => e.IdInscripcion, "resultados_carrera_id_inscripcion_key").IsUnique();

            entity.Property(e => e.IdResultado)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_resultado");
            entity.Property(e => e.Descalificado)
                .HasDefaultValue(false)
                .HasColumnName("descalificado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.MotivoDescalificacion)
                .HasMaxLength(255)
                .HasColumnName("motivo_descalificacion");
            entity.Property(e => e.PosicionFinal).HasColumnName("posicion_final");
            entity.Property(e => e.PremioObtenido)
                .HasPrecision(12, 2)
                .HasDefaultValue(0m)
                .HasColumnName("premio_obtenido");
            entity.Property(e => e.TiempoSegundos)
                .HasPrecision(8, 3)
                .HasColumnName("tiempo_segundos");

            entity.HasOne(d => d.IdInscripcionNavigation).WithOne(p => p.ResultadosCarrera)
                .HasForeignKey<ResultadosCarrera>(d => d.IdInscripcion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_res_inscripcion");
        });

        modelBuilder.Entity<S3MultipartUpload>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("s3_multipart_uploads_pkey");

            entity.ToTable("s3_multipart_uploads", "storage");

            entity.HasIndex(e => new { e.BucketId, e.Key, e.CreatedAt }, "idx_multipart_uploads_list").UseCollation(new[] { null, "C", null });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BucketId).HasColumnName("bucket_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.InProgressSize).HasColumnName("in_progress_size");
            entity.Property(e => e.Key)
                .UseCollation("C")
                .HasColumnName("key");
            entity.Property(e => e.Metadata)
                .HasColumnType("jsonb")
                .HasColumnName("metadata");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.UploadSignature).HasColumnName("upload_signature");
            entity.Property(e => e.UserMetadata)
                .HasColumnType("jsonb")
                .HasColumnName("user_metadata");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Bucket).WithMany(p => p.S3MultipartUploads)
                .HasForeignKey(d => d.BucketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("s3_multipart_uploads_bucket_id_fkey");
        });

        modelBuilder.Entity<S3MultipartUploadsPart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("s3_multipart_uploads_parts_pkey");

            entity.ToTable("s3_multipart_uploads_parts", "storage");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.BucketId).HasColumnName("bucket_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Etag).HasColumnName("etag");
            entity.Property(e => e.Key)
                .UseCollation("C")
                .HasColumnName("key");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.PartNumber).HasColumnName("part_number");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.UploadId).HasColumnName("upload_id");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Bucket).WithMany(p => p.S3MultipartUploadsParts)
                .HasForeignKey(d => d.BucketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("s3_multipart_uploads_parts_bucket_id_fkey");

            entity.HasOne(d => d.Upload).WithMany(p => p.S3MultipartUploadsParts)
                .HasForeignKey(d => d.UploadId)
                .HasConstraintName("s3_multipart_uploads_parts_upload_id_fkey");
        });

        modelBuilder.Entity<SamlProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("saml_providers_pkey");

            entity.ToTable("saml_providers", "auth", tb => tb.HasComment("Auth: Manages SAML Identity Provider connections."));

            entity.HasIndex(e => e.EntityId, "saml_providers_entity_id_key").IsUnique();

            entity.HasIndex(e => e.SsoProviderId, "saml_providers_sso_provider_id_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AttributeMapping)
                .HasColumnType("jsonb")
                .HasColumnName("attribute_mapping");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.EntityId).HasColumnName("entity_id");
            entity.Property(e => e.MetadataUrl).HasColumnName("metadata_url");
            entity.Property(e => e.MetadataXml).HasColumnName("metadata_xml");
            entity.Property(e => e.NameIdFormat).HasColumnName("name_id_format");
            entity.Property(e => e.SsoProviderId).HasColumnName("sso_provider_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.SsoProvider).WithMany(p => p.SamlProviders)
                .HasForeignKey(d => d.SsoProviderId)
                .HasConstraintName("saml_providers_sso_provider_id_fkey");
        });

        modelBuilder.Entity<SamlRelayState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("saml_relay_states_pkey");

            entity.ToTable("saml_relay_states", "auth", tb => tb.HasComment("Auth: Contains SAML Relay State information for each Service Provider initiated login."));

            entity.HasIndex(e => e.CreatedAt, "saml_relay_states_created_at_idx").IsDescending();

            entity.HasIndex(e => e.ForEmail, "saml_relay_states_for_email_idx");

            entity.HasIndex(e => e.SsoProviderId, "saml_relay_states_sso_provider_id_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FlowStateId).HasColumnName("flow_state_id");
            entity.Property(e => e.ForEmail).HasColumnName("for_email");
            entity.Property(e => e.RedirectTo).HasColumnName("redirect_to");
            entity.Property(e => e.RequestId).HasColumnName("request_id");
            entity.Property(e => e.SsoProviderId).HasColumnName("sso_provider_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.FlowState).WithMany(p => p.SamlRelayStates)
                .HasForeignKey(d => d.FlowStateId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("saml_relay_states_flow_state_id_fkey");

            entity.HasOne(d => d.SsoProvider).WithMany(p => p.SamlRelayStates)
                .HasForeignKey(d => d.SsoProviderId)
                .HasConstraintName("saml_relay_states_sso_provider_id_fkey");
        });

        modelBuilder.Entity<SchemaMigration>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("schema_migrations_pkey");

            entity.ToTable("schema_migrations", "auth", tb => tb.HasComment("Auth: Manages updates to the auth system."));

            entity.Property(e => e.Version)
                .HasMaxLength(255)
                .HasColumnName("version");
        });

        modelBuilder.Entity<SchemaMigration1>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("schema_migrations_pkey");

            entity.ToTable("schema_migrations", "realtime");

            entity.Property(e => e.Version)
                .ValueGeneratedNever()
                .HasColumnName("version");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("inserted_at");
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sessions_pkey");

            entity.ToTable("sessions", "auth", tb => tb.HasComment("Auth: Stores session data associated to a user."));

            entity.HasIndex(e => e.NotAfter, "sessions_not_after_idx").IsDescending();

            entity.HasIndex(e => e.OauthClientId, "sessions_oauth_client_id_idx");

            entity.HasIndex(e => e.UserId, "sessions_user_id_idx");

            entity.HasIndex(e => new { e.UserId, e.CreatedAt }, "user_id_created_at_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FactorId).HasColumnName("factor_id");
            entity.Property(e => e.Ip).HasColumnName("ip");
            entity.Property(e => e.NotAfter)
                .HasComment("Auth: Not after is a nullable column that contains a timestamp after which the session should be regarded as expired.")
                .HasColumnName("not_after");
            entity.Property(e => e.OauthClientId).HasColumnName("oauth_client_id");
            entity.Property(e => e.RefreshTokenCounter)
                .HasComment("Holds the ID (counter) of the last issued refresh token.")
                .HasColumnName("refresh_token_counter");
            entity.Property(e => e.RefreshTokenHmacKey)
                .HasComment("Holds a HMAC-SHA256 key used to sign refresh tokens for this session.")
                .HasColumnName("refresh_token_hmac_key");
            entity.Property(e => e.RefreshedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("refreshed_at");
            entity.Property(e => e.Scopes).HasColumnName("scopes");
            entity.Property(e => e.Tag).HasColumnName("tag");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UserAgent).HasColumnName("user_agent");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.OauthClient).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.OauthClientId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("sessions_oauth_client_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("sessions_user_id_fkey");
        });

        modelBuilder.Entity<SsoDomain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sso_domains_pkey");

            entity.ToTable("sso_domains", "auth", tb => tb.HasComment("Auth: Manages SSO email address domain mapping to an SSO Identity Provider."));

            entity.HasIndex(e => e.SsoProviderId, "sso_domains_sso_provider_id_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Domain).HasColumnName("domain");
            entity.Property(e => e.SsoProviderId).HasColumnName("sso_provider_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.SsoProvider).WithMany(p => p.SsoDomains)
                .HasForeignKey(d => d.SsoProviderId)
                .HasConstraintName("sso_domains_sso_provider_id_fkey");
        });

        modelBuilder.Entity<SsoProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sso_providers_pkey");

            entity.ToTable("sso_providers", "auth", tb => tb.HasComment("Auth: Manages SSO identity provider information; see saml_providers for SAML."));

            entity.HasIndex(e => e.ResourceId, "sso_providers_resource_id_pattern_idx").HasOperators(new[] { "text_pattern_ops" });

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Disabled).HasColumnName("disabled");
            entity.Property(e => e.ResourceId)
                .HasComment("Auth: Uniquely identifies a SSO provider according to a user-chosen resource ID (case insensitive), useful in infrastructure as code.")
                .HasColumnName("resource_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_subscription");

            entity.ToTable("subscription", "realtime");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.ActionFilter)
                .HasDefaultValueSql("'*'::text")
                .HasColumnName("action_filter");
            entity.Property(e => e.Claims)
                .HasColumnType("jsonb")
                .HasColumnName("claims");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("timezone('utc'::text, now())")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.SubscriptionId).HasColumnName("subscription_id");
        });

        modelBuilder.Entity<Suministro>(entity =>
        {
            entity.HasKey(e => e.IdSuministro).HasName("suministros_pkey");

            entity.ToTable("suministros");

            entity.HasIndex(e => e.Activo, "idx_sum_activo").HasFilter("(activo = true)");

            entity.HasIndex(e => e.Codigo, "idx_sum_codigo");

            entity.HasIndex(e => e.Codigo, "suministros_codigo_key").IsUnique();

            entity.Property(e => e.IdSuministro)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_suministro");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.CantidadDisponible)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad_disponible");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.FechaIngreso)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdTipoSuministro).HasColumnName("id_tipo_suministro");
            entity.Property(e => e.IdUnidadMedida).HasColumnName("id_unidad_medida");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.StockMinimo)
                .HasPrecision(10, 2)
                .HasColumnName("stock_minimo");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Suministros)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sum_proveedor");

            entity.HasOne(d => d.IdTipoSuministroNavigation).WithMany(p => p.Suministros)
                .HasForeignKey(d => d.IdTipoSuministro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sum_tipo");

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.Suministros)
                .HasForeignKey(d => d.IdUnidadMedida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sum_unidad");
        });

        modelBuilder.Entity<TcEstadoAlertum>(entity =>
        {
            entity.HasKey(e => e.IdEstadoAlerta).HasName("tc_estado_alerta_pkey");

            entity.ToTable("tc_estado_alerta");

            entity.HasIndex(e => e.Descripcion, "tc_estado_alerta_descripcion_key").IsUnique();

            entity.Property(e => e.IdEstadoAlerta)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_estado_alerta");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TcEstadoCertificacion>(entity =>
        {
            entity.HasKey(e => e.IdEstadoCertificacion).HasName("tc_estado_certificacion_pkey");

            entity.ToTable("tc_estado_certificacion");

            entity.HasIndex(e => e.Descripcion, "tc_estado_certificacion_descripcion_key").IsUnique();

            entity.Property(e => e.IdEstadoCertificacion)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_estado_certificacion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TcEstadoEstablo>(entity =>
        {
            entity.HasKey(e => e.IdEstadoEstablo).HasName("tc_estado_establo_pkey");

            entity.ToTable("tc_estado_establo");

            entity.HasIndex(e => e.Descripcion, "tc_estado_establo_descripcion_key").IsUnique();

            entity.Property(e => e.IdEstadoEstablo)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_estado_establo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TcEstadoEvento>(entity =>
        {
            entity.HasKey(e => e.IdEstadoEvento).HasName("tc_estado_evento_pkey");

            entity.ToTable("tc_estado_evento");

            entity.HasIndex(e => e.Descripcion, "tc_estado_evento_descripcion_key").IsUnique();

            entity.Property(e => e.IdEstadoEvento)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_estado_evento");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TcEstadoInscripcion>(entity =>
        {
            entity.HasKey(e => e.IdEstadoInscripcion).HasName("tc_estado_inscripcion_pkey");

            entity.ToTable("tc_estado_inscripcion");

            entity.HasIndex(e => e.Descripcion, "tc_estado_inscripcion_descripcion_key").IsUnique();

            entity.Property(e => e.IdEstadoInscripcion)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_estado_inscripcion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TcEstadoPago>(entity =>
        {
            entity.HasKey(e => e.IdEstadoPago).HasName("tc_estado_pago_pkey");

            entity.ToTable("tc_estado_pago");

            entity.HasIndex(e => e.Descripcion, "tc_estado_pago_descripcion_key").IsUnique();

            entity.Property(e => e.IdEstadoPago)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_estado_pago");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TcEstadoSalud>(entity =>
        {
            entity.HasKey(e => e.IdEstadoSalud).HasName("tc_estado_salud_pkey");

            entity.ToTable("tc_estado_salud");

            entity.HasIndex(e => e.Descripcion, "tc_estado_salud_descripcion_key").IsUnique();

            entity.Property(e => e.IdEstadoSalud)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_estado_salud");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TcMetodoPago>(entity =>
        {
            entity.HasKey(e => e.IdMetodoPago).HasName("tc_metodo_pago_pkey");

            entity.ToTable("tc_metodo_pago");

            entity.HasIndex(e => e.Descripcion, "tc_metodo_pago_descripcion_key").IsUnique();

            entity.Property(e => e.IdMetodoPago)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_metodo_pago");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TcRaza>(entity =>
        {
            entity.HasKey(e => e.IdRaza).HasName("tc_raza_pkey");

            entity.ToTable("tc_raza");

            entity.HasIndex(e => e.Descripcion, "tc_raza_descripcion_key").IsUnique();

            entity.Property(e => e.IdRaza)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_raza");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
            entity.Property(e => e.Origen)
                .HasMaxLength(100)
                .HasColumnName("origen");
        });

        modelBuilder.Entity<TcRolUsuario>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("tc_rol_usuario_pkey");

            entity.ToTable("tc_rol_usuario");

            entity.HasIndex(e => e.Descripcion, "tc_rol_usuario_descripcion_key").IsUnique();

            entity.Property(e => e.IdRol)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_rol");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TcSexo>(entity =>
        {
            entity.HasKey(e => e.IdSexo).HasName("tc_sexo_pkey");

            entity.ToTable("tc_sexo");

            entity.HasIndex(e => e.Descripcion, "tc_sexo_descripcion_key").IsUnique();

            entity.Property(e => e.IdSexo)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_sexo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TcTipoAlertum>(entity =>
        {
            entity.HasKey(e => e.IdTipoAlerta).HasName("tc_tipo_alerta_pkey");

            entity.ToTable("tc_tipo_alerta");

            entity.HasIndex(e => e.Descripcion, "tc_tipo_alerta_descripcion_key").IsUnique();

            entity.Property(e => e.IdTipoAlerta)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_tipo_alerta");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TcTipoCarrera>(entity =>
        {
            entity.HasKey(e => e.IdTipoCarrera).HasName("tc_tipo_carrera_pkey");

            entity.ToTable("tc_tipo_carrera");

            entity.HasIndex(e => e.Descripcion, "tc_tipo_carrera_descripcion_key").IsUnique();

            entity.Property(e => e.IdTipoCarrera)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_tipo_carrera");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
            entity.Property(e => e.DistanciaMaxM).HasColumnName("distancia_max_m");
            entity.Property(e => e.DistanciaMinM).HasColumnName("distancia_min_m");
        });

        modelBuilder.Entity<TcTipoCorreo>(entity =>
        {
            entity.HasKey(e => e.IdTipoCorreo).HasName("tc_tipo_correo_pkey");

            entity.ToTable("tc_tipo_correo");

            entity.HasIndex(e => e.Descripcion, "tc_tipo_correo_descripcion_key").IsUnique();

            entity.Property(e => e.IdTipoCorreo)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_tipo_correo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TcTipoSuministro>(entity =>
        {
            entity.HasKey(e => e.IdTipoSuministro).HasName("tc_tipo_suministro_pkey");

            entity.ToTable("tc_tipo_suministro");

            entity.HasIndex(e => e.Descripcion, "tc_tipo_suministro_descripcion_key").IsUnique();

            entity.Property(e => e.IdTipoSuministro)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_tipo_suministro");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TcTipoTelefono>(entity =>
        {
            entity.HasKey(e => e.IdTipoTelefono).HasName("tc_tipo_telefono_pkey");

            entity.ToTable("tc_tipo_telefono");

            entity.HasIndex(e => e.Descripcion, "tc_tipo_telefono_descripcion_key").IsUnique();

            entity.Property(e => e.IdTipoTelefono)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_tipo_telefono");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TcUnidadMedidum>(entity =>
        {
            entity.HasKey(e => e.IdUnidadMedida).HasName("tc_unidad_medida_pkey");

            entity.ToTable("tc_unidad_medida");

            entity.HasIndex(e => e.Descripcion, "tc_unidad_medida_descripcion_key").IsUnique();

            entity.HasIndex(e => e.Simbolo, "tc_unidad_medida_simbolo_key").IsUnique();

            entity.Property(e => e.IdUnidadMedida)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_unidad_medida");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
            entity.Property(e => e.Simbolo)
                .HasMaxLength(10)
                .HasColumnName("simbolo");
        });

        modelBuilder.Entity<TelefonosUsuario>(entity =>
        {
            entity.HasKey(e => e.IdTelefono).HasName("telefonos_usuarios_pkey");

            entity.ToTable("telefonos_usuarios");

            entity.HasIndex(e => new { e.IdUsuario, e.Numero }, "uq_tel_usuario").IsUnique();

            entity.Property(e => e.IdTelefono)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_telefono");
            entity.Property(e => e.IdTipoTelefono).HasColumnName("id_tipo_telefono");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Numero)
                .HasMaxLength(20)
                .HasColumnName("numero");

            entity.HasOne(d => d.IdTipoTelefonoNavigation).WithMany(p => p.TelefonosUsuarios)
                .HasForeignKey(d => d.IdTipoTelefono)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tel_tipo");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TelefonosUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("fk_tel_usuario");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users", "auth", tb => tb.HasComment("Auth: Stores user login data within a secure schema."));

            entity.HasIndex(e => e.ConfirmationToken, "confirmation_token_idx")
                .IsUnique()
                .HasFilter("((confirmation_token)::text !~ '^[0-9 ]*$'::text)");

            entity.HasIndex(e => e.EmailChangeTokenCurrent, "email_change_token_current_idx")
                .IsUnique()
                .HasFilter("((email_change_token_current)::text !~ '^[0-9 ]*$'::text)");

            entity.HasIndex(e => e.EmailChangeTokenNew, "email_change_token_new_idx")
                .IsUnique()
                .HasFilter("((email_change_token_new)::text !~ '^[0-9 ]*$'::text)");

            entity.HasIndex(e => e.CreatedAt, "idx_users_created_at_desc").IsDescending();

            entity.HasIndex(e => e.Email, "idx_users_email");

            entity.HasIndex(e => e.LastSignInAt, "idx_users_last_sign_in_at_desc").IsDescending();

            entity.HasIndex(e => e.ReauthenticationToken, "reauthentication_token_idx")
                .IsUnique()
                .HasFilter("((reauthentication_token)::text !~ '^[0-9 ]*$'::text)");

            entity.HasIndex(e => e.RecoveryToken, "recovery_token_idx")
                .IsUnique()
                .HasFilter("((recovery_token)::text !~ '^[0-9 ]*$'::text)");

            entity.HasIndex(e => e.Email, "users_email_partial_key")
                .IsUnique()
                .HasFilter("(is_sso_user = false)");

            entity.HasIndex(e => e.InstanceId, "users_instance_id_idx");

            entity.HasIndex(e => e.IsAnonymous, "users_is_anonymous_idx");

            entity.HasIndex(e => e.Phone, "users_phone_key").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Aud)
                .HasMaxLength(255)
                .HasColumnName("aud");
            entity.Property(e => e.BannedUntil).HasColumnName("banned_until");
            entity.Property(e => e.ConfirmationSentAt).HasColumnName("confirmation_sent_at");
            entity.Property(e => e.ConfirmationToken)
                .HasMaxLength(255)
                .HasColumnName("confirmation_token");
            entity.Property(e => e.ConfirmedAt)
                .HasComputedColumnSql("LEAST(email_confirmed_at, phone_confirmed_at)", true)
                .HasColumnName("confirmed_at");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.EmailChange)
                .HasMaxLength(255)
                .HasColumnName("email_change");
            entity.Property(e => e.EmailChangeConfirmStatus)
                .HasDefaultValue((short)0)
                .HasColumnName("email_change_confirm_status");
            entity.Property(e => e.EmailChangeSentAt).HasColumnName("email_change_sent_at");
            entity.Property(e => e.EmailChangeTokenCurrent)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("email_change_token_current");
            entity.Property(e => e.EmailChangeTokenNew)
                .HasMaxLength(255)
                .HasColumnName("email_change_token_new");
            entity.Property(e => e.EmailConfirmedAt).HasColumnName("email_confirmed_at");
            entity.Property(e => e.EncryptedPassword)
                .HasMaxLength(255)
                .HasColumnName("encrypted_password");
            entity.Property(e => e.InstanceId).HasColumnName("instance_id");
            entity.Property(e => e.InvitedAt).HasColumnName("invited_at");
            entity.Property(e => e.IsAnonymous).HasColumnName("is_anonymous");
            entity.Property(e => e.IsSsoUser)
                .HasComment("Auth: Set this column to true when the account comes from SSO. These accounts can have duplicate emails.")
                .HasColumnName("is_sso_user");
            entity.Property(e => e.IsSuperAdmin).HasColumnName("is_super_admin");
            entity.Property(e => e.LastSignInAt).HasColumnName("last_sign_in_at");
            entity.Property(e => e.Phone)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("phone");
            entity.Property(e => e.PhoneChange)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("phone_change");
            entity.Property(e => e.PhoneChangeSentAt).HasColumnName("phone_change_sent_at");
            entity.Property(e => e.PhoneChangeToken)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("phone_change_token");
            entity.Property(e => e.PhoneConfirmedAt).HasColumnName("phone_confirmed_at");
            entity.Property(e => e.RawAppMetaData)
                .HasColumnType("jsonb")
                .HasColumnName("raw_app_meta_data");
            entity.Property(e => e.RawUserMetaData)
                .HasColumnType("jsonb")
                .HasColumnName("raw_user_meta_data");
            entity.Property(e => e.ReauthenticationSentAt).HasColumnName("reauthentication_sent_at");
            entity.Property(e => e.ReauthenticationToken)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("reauthentication_token");
            entity.Property(e => e.RecoverySentAt).HasColumnName("recovery_sent_at");
            entity.Property(e => e.RecoveryToken)
                .HasMaxLength(255)
                .HasColumnName("recovery_token");
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .HasColumnName("role");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("usuarios_pkey");

            entity.ToTable("usuarios");

            entity.HasIndex(e => e.Activo, "idx_usuario_activo").HasFilter("(activo = true)");

            entity.HasIndex(e => e.Identificacion, "idx_usuario_ident");

            entity.HasIndex(e => e.Identificacion, "usuarios_identificacion_key").IsUnique();

            entity.HasIndex(e => e.Usuario1, "usuarios_usuario_key").IsUnique();

            entity.Property(e => e.IdUsuario)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_usuario");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .HasColumnName("apellido1");
            entity.Property(e => e.Apellido2)
                .HasMaxLength(100)
                .HasColumnName("apellido2");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(255)
                .HasColumnName("contrasena");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(50)
                .HasColumnName("usuario");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuarios_rol");
        });

        modelBuilder.Entity<VectorIndex>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vector_indexes_pkey");

            entity.ToTable("vector_indexes", "storage");

            entity.HasIndex(e => new { e.Name, e.BucketId }, "vector_indexes_name_bucket_id_idx")
                .IsUnique()
                .UseCollation(new[] { "C", null });

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.BucketId).HasColumnName("bucket_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DataType).HasColumnName("data_type");
            entity.Property(e => e.Dimension).HasColumnName("dimension");
            entity.Property(e => e.DistanceMetric).HasColumnName("distance_metric");
            entity.Property(e => e.MetadataConfiguration)
                .HasColumnType("jsonb")
                .HasColumnName("metadata_configuration");
            entity.Property(e => e.Name)
                .UseCollation("C")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Bucket).WithMany(p => p.VectorIndices)
                .HasForeignKey(d => d.BucketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("vector_indexes_bucket_id_fkey");
        });

        modelBuilder.Entity<Veterinario>(entity =>
        {
            entity.HasKey(e => e.IdVeterinario).HasName("veterinarios_pkey");

            entity.ToTable("veterinarios");

            entity.HasIndex(e => e.IdUsuario, "veterinarios_id_usuario_key").IsUnique();

            entity.HasIndex(e => e.NumeroLicencia, "veterinarios_numero_licencia_key").IsUnique();

            entity.Property(e => e.IdVeterinario)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_veterinario");
            entity.Property(e => e.Especialidad)
                .HasMaxLength(100)
                .HasColumnName("especialidad");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.NumeroColegio)
                .HasMaxLength(50)
                .HasColumnName("numero_colegio");
            entity.Property(e => e.NumeroLicencia)
                .HasMaxLength(50)
                .HasColumnName("numero_licencia");

            entity.HasOne(d => d.IdUsuarioNavigation).WithOne(p => p.Veterinario)
                .HasForeignKey<Veterinario>(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_vet_usuario");
        });

        modelBuilder.Entity<VwAlertasPendiente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_alertas_pendientes");

            entity.Property(e => e.Caballo)
                .HasMaxLength(100)
                .HasColumnName("caballo");
            entity.Property(e => e.FechaGeneracion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_generacion");
            entity.Property(e => e.IdAlerta).HasColumnName("id_alerta");
            entity.Property(e => e.Mensaje).HasColumnName("mensaje");
            entity.Property(e => e.Propietario).HasColumnName("propietario");
            entity.Property(e => e.TipoAlerta)
                .HasMaxLength(100)
                .HasColumnName("tipo_alerta");
        });

        modelBuilder.Entity<VwCaballosDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_caballos_detalle");

            entity.Property(e => e.Caballo)
                .HasMaxLength(100)
                .HasColumnName("caballo");
            entity.Property(e => e.CertVigente).HasColumnName("cert_vigente");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.EdadAnios).HasColumnName("edad_anios");
            entity.Property(e => e.EstadoSalud)
                .HasMaxLength(100)
                .HasColumnName("estado_salud");
            entity.Property(e => e.IdCaballo).HasColumnName("id_caballo");
            entity.Property(e => e.PesoKg)
                .HasPrecision(8, 2)
                .HasColumnName("peso_kg");
            entity.Property(e => e.Propietario).HasColumnName("propietario");
            entity.Property(e => e.Raza)
                .HasMaxLength(100)
                .HasColumnName("raza");
            entity.Property(e => e.Sexo)
                .HasMaxLength(30)
                .HasColumnName("sexo");
        });

        modelBuilder.Entity<VwEventosInscripcione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_eventos_inscripciones");

            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.DistanciaMetros).HasColumnName("distancia_metros");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .HasColumnName("estado");
            entity.Property(e => e.Evento)
                .HasMaxLength(150)
                .HasColumnName("evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.PrecioInscripcion)
                .HasPrecision(10, 2)
                .HasColumnName("precio_inscripcion");
            entity.Property(e => e.PremioTotal)
                .HasPrecision(14, 2)
                .HasColumnName("premio_total");
            entity.Property(e => e.TipoCarrera)
                .HasMaxLength(100)
                .HasColumnName("tipo_carrera");
            entity.Property(e => e.TotalInscritos).HasColumnName("total_inscritos");
        });

        modelBuilder.Entity<VwFacturasDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_facturas_detalle");

            entity.Property(e => e.ComisionAdmin)
                .HasPrecision(14, 2)
                .HasColumnName("comision_admin");
            entity.Property(e => e.DescuentoPct)
                .HasPrecision(5, 2)
                .HasColumnName("descuento_pct");
            entity.Property(e => e.EstadoPago)
                .HasMaxLength(50)
                .HasColumnName("estado_pago");
            entity.Property(e => e.FechaFactura)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_factura");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.ImpuestoIva)
                .HasPrecision(14, 2)
                .HasColumnName("impuesto_iva");
            entity.Property(e => e.MontoDescuento)
                .HasPrecision(14, 2)
                .HasColumnName("monto_descuento");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(30)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Propietario).HasColumnName("propietario");
            entity.Property(e => e.Subtotal)
                .HasPrecision(14, 2)
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasPrecision(14, 2)
                .HasColumnName("total");
        });

        modelBuilder.Entity<VwPropietariosFrecuente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_propietarios_frecuentes");

            entity.Property(e => e.DescuentoProximaFactura).HasColumnName("descuento_proxima_factura");
            entity.Property(e => e.FechaUltimaRevisionDescuento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_ultima_revision_descuento");
            entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .HasColumnName("identificacion");
            entity.Property(e => e.Propietario).HasColumnName("propietario");
            entity.Property(e => e.TotalFacturado6m).HasColumnName("total_facturado_6m");
        });

        modelBuilder.Entity<VwResultadosEvento>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_resultados_evento");

            entity.Property(e => e.Caballo)
                .HasMaxLength(100)
                .HasColumnName("caballo");
            entity.Property(e => e.CodigoEvento)
                .HasMaxLength(30)
                .HasColumnName("codigo_evento");
            entity.Property(e => e.Descalificado).HasColumnName("descalificado");
            entity.Property(e => e.Evento)
                .HasMaxLength(150)
                .HasColumnName("evento");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.PosicionFinal).HasColumnName("posicion_final");
            entity.Property(e => e.PremioObtenido)
                .HasPrecision(12, 2)
                .HasColumnName("premio_obtenido");
            entity.Property(e => e.Propietario).HasColumnName("propietario");
            entity.Property(e => e.TiempoSegundos)
                .HasPrecision(8, 3)
                .HasColumnName("tiempo_segundos");
        });

        modelBuilder.Entity<WebauthnChallenge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("webauthn_challenges_pkey");

            entity.ToTable("webauthn_challenges", "auth");

            entity.HasIndex(e => e.ExpiresAt, "webauthn_challenges_expires_at_idx");

            entity.HasIndex(e => e.UserId, "webauthn_challenges_user_id_idx");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.ChallengeType).HasColumnName("challenge_type");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.ExpiresAt).HasColumnName("expires_at");
            entity.Property(e => e.SessionData)
                .HasColumnType("jsonb")
                .HasColumnName("session_data");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.WebauthnChallenges)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("webauthn_challenges_user_id_fkey");
        });

        modelBuilder.Entity<WebauthnCredential>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("webauthn_credentials_pkey");

            entity.ToTable("webauthn_credentials", "auth");

            entity.HasIndex(e => e.CredentialId, "webauthn_credentials_credential_id_key").IsUnique();

            entity.HasIndex(e => e.UserId, "webauthn_credentials_user_id_idx");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.Aaguid).HasColumnName("aaguid");
            entity.Property(e => e.AttestationType)
                .HasDefaultValueSql("''::text")
                .HasColumnName("attestation_type");
            entity.Property(e => e.BackedUp).HasColumnName("backed_up");
            entity.Property(e => e.BackupEligible).HasColumnName("backup_eligible");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.CredentialId).HasColumnName("credential_id");
            entity.Property(e => e.FriendlyName)
                .HasDefaultValueSql("''::text")
                .HasColumnName("friendly_name");
            entity.Property(e => e.LastUsedAt).HasColumnName("last_used_at");
            entity.Property(e => e.PublicKey).HasColumnName("public_key");
            entity.Property(e => e.SignCount).HasColumnName("sign_count");
            entity.Property(e => e.Transports)
                .HasDefaultValueSql("'[]'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("transports");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.WebauthnCredentials)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("webauthn_credentials_user_id_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
