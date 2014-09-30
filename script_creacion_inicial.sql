-- UTILIZACION DE LA BASE DE DATOS
USE [GD2C2014]
GO

-- CREA EL ESQUEMA SI NO EXISTIESE
IF NOT EXISTS ( SELECT  *
                FROM    sys.schemas
                WHERE   name = N'COMPUMUNDO_HIPER_MEGA_RED' ) 
    EXEC('CREATE SCHEMA [COMPUMUNDO_HIPER_MEGA_RED] AUTHORIZATION [gd]');
GO

-- ELIMINACION DE LOS STORED PROCEDURES
---- EJEMPLO
		/*
		IF OBJECT_ID('COMPUMUNDO_HIPER_MEGA_RED.Procedure') IS NOT NULL DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.Procedure
		*/

-- DROP FK
---- EJEMPLO
		/*
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.FK') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
		ALTER TABLE COMPUMUNDO_HIPER_MEGA_RED.TABLA DROP CONSTRAINT FK;
		*/

-- DROP TABLAS
---- EJEMPLO
		/*
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.TABLA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.TABLA;
		*/


-- CREACION DE TABLAS

create table COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
(
	usr							nvarchar(50),
	password					nvarchar(50)	not null, 
	nombre						nvarchar(50) not null,
	apellido					nvarchar(50) not null,
	contador_intentos_login		numeric(1,0)	default 0, -- 3 intentos
	tipoDocu					nvarchar(8) not null,
	numDocu						numeric(18,0) not null,
	mail						nvarchar(50),
	telefono					numeric(12,0),
	direccionCalle				nvarchar(50) not null,
	direccionNumero				numeric(8) not null,
	direccionPiso				numeric(2),
	DireccionDepto				numeric(2),
	FecNacimiento				datetime not null,
	campo_baja					bit	not null default 1,
	id_rol						numeric(18,0)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.ROLES
(
	nombreRol	varchar(15) unique NOT NULL, --ADMINISTRADOR RECEPCIONISTA O GUEST
	estado		bit NOT NULL default 1
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.ROLES_X_USUARIO
(
	nombreRol	varchar(15),
	usr			nvarchar(50) not null,
)go

create table COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES_X_ROL
(
	nombreRol		varchar(15),
	funcionalidad	nvarchar(255) not null
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES
(
	funcionalidad nvarchar(255)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
(
	idHuesped int identity(1,1) not null,
	tipoDocu					nvarchar(8) not null,
	numDocu						numeric(18,0) not null,
	nombre						nvarchar(50) not null,
	apellido					nvarchar(50) not null,
	mail						nvarchar(50),
	telefono					numeric(12,0),
	direccionCalle				nvarchar(50) not null,
	direccionNumero				numeric(8) not null,
	direccionPiso				numeric(2),
	DireccionDepto				numeric(2),
	localidad					nvarchar(50) not null,
	paisOrigen					nvarchar(50) not null,
	nacionalidad				nvarchar(50) not null,
	fecNacimiento				datetime not null,
	campo_baja					bit	not null default 1,
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.RESERVAS
(
	codReserva	numeric(18,0) not null,
	idHuesped	int identity(1,1) not null,
	usr			nvarchar(50) not null,
	fecDesde	datetime,
	fecHasta	datetime,
	fecReserva	datetime,
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.CANCELACIONES_RESERVAS
(
	codReserva		numeric(18,0) not null,
	motivo			nvarchar(255) not null,
	fecCancelacion	datetime not null,
	usr				nvarchar(50) not null,
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA
(
	codReserva	numeric(18,0),
	hotel		nvarchar(50) not null,
	habitacion	numeric(18,0) not null,
	codRegimen	int identity(1,1) not null,
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.ESTADIA
(
	codReserva	numeric(18,0),
	fecIngreso	datetime not null,
	usrIngreso	nvarchar(50) not null,
	fecEgreso	datetime not null,
	usrEgreso	nvarchar(50) not null,
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA
(
	codConsumible	numeric(18,0),
	codReserva		numeric(18,0) not null,
	cantidad		numeric(3) not null	
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES
(
	codConsumible	numeric(18,0),
	descripcion		nvarchar(255) not null,
	importe			numeric(18, 2) not null
)
go