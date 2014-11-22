-- UTILIZACION DE LA BASE DE DATOS
USE [GD2C2014]
GO

BEGIN TRANSACTION
-- CREA EL ESQUEMA SI NO EXISTIESE
IF NOT EXISTS ( SELECT  *
                FROM    sys.schemas
                WHERE   name = N'COMPUMUNDO_HIPER_MEGA_RED' ) 
    EXEC('CREATE SCHEMA [COMPUMUNDO_HIPER_MEGA_RED] AUTHORIZATION [gd]')
COMMIT;


-- DROP FK
---- EJEMPLO
		/*
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.FK') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
		ALTER TABLE COMPUMUNDO_HIPER_MEGA_RED.TABLA DROP CONSTRAINT FK;
		*/

-- DROP TABLAS
--/*	
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVAINVALIDA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVAINVALIDA;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.REGIMENES_X_HOTEL') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.REGIMENES_X_HOTEL;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.CANCELACIONES_RESERVA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.CANCELACIONES_RESERVA;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA;
						
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.FACTURAS') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.FACTURAS;
			
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.ESTADIA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.ESTADIA;
	
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.RESERVAS') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.RESERVAS;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.ESTADOS_RESERVA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.ESTADOS_RESERVA;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.REGIMENES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.REGIMENES;
				
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.HOTELES_X_USUARIO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.HOTELES_X_USUARIO;
				
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.INHABILITACIONES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.INHABILITACIONES;

		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.HOTELES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.HOTELES;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA_INVALIDA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA_INVALIDA;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA_INVALIDA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA_INVALIDA;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES;
						
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.FACTURAS_INVALIDAS') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.FACTURAS_INVALIDAS;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.ESTADIA_INVALIDA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.ESTADIA_INVALIDA;

		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.RESERVASINVALIDAS') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.RESERVASINVALIDAS;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES;
	
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES_X_ROL') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES_X_ROL;
	
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.ROLES_X_USUARIO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.ROLES_X_USUARIO;
	
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.ROLES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.ROLES;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.USUARIOS') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS;
		
		--*/


/* 
 *CREACION DE TABLAS
 */

create table COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
(
	usr							varchar(50) PRIMARY KEY,
	password					varchar(256) not null, 
	nombre						varchar(255) not null,
	apellido					varchar(255) not null,
	contador_intentos_login		numeric(2) default 0, -- 3 intentos
	tipoDocu					varchar(50) not null default 'DNI',
	numDocu						numeric(18,0) not null,
	mail						varchar(255),
	telefono					numeric(12),
	direccionCalle				varchar(100) not null,
	direccionNumero				numeric(18,0) not null,
	direccionPiso				numeric(18,0),
	direccionDepto				varchar(50),
	FecNacimiento				DateTime not null,
	campoBaja					bit	not null default 0,
	primerLog					bit not null default 1
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.ROLES
(
	nombreRol	varchar(15) PRIMARY KEY, --Administrador RECEPCIONISTA O GUEST
	estado		bit NOT NULL default 1
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.ROLES_X_USUARIO
(
	nombreRol	varchar(15) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.ROLES(nombreRol),
	usr			varchar(50) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.USUARIOS(usr),
	PRIMARY KEY(nombreRol, usr)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES
(
	idFuncionalidad numeric(2) PRIMARY KEY,
	descripcion		varchar(255) not null	
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES_X_ROL
(
	nombreRol		varchar(15) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.ROLES(nombreRol),
	idFuncionalidad	numeric(2) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES(idFuncionalidad),
	PRIMARY KEY (nombreRol, idFuncionalidad)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
(
	idHuesped 			int identity(1,1) PRIMARY KEY,
	tipoDocu			varchar(50),
	numDocu				numeric(18,0) not null,
	nombre				varchar(255) not null,
	apellido			varchar(255) not null,
	mail				varchar(255),
	telefono			numeric(18,0),
	direccionCalle		varchar(100) not null,
	direccionNumero		numeric(18,0) not null,
	direccionPiso		numeric(18,0),
	direccionDepto		varchar(50),
	localidad			varchar(50) not null,
	nacionalidad		varchar(255) not null,
	fecNacimiento		datetime not null,
	campoBaja			bit	not null default 0
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.REGIMENES
(
	codRegimen		numeric(8) identity(1,1) PRIMARY KEY,
	descripcion		varchar(255) not null,
	precio			numeric(18, 2) not null,
	estado			bit	not null default 1
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.ESTADOS_RESERVA
(
	codEstadoReserva int PRIMARY KEY,
	descripcion varchar(255),
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.RESERVAS
(
	codReserva	numeric(18) PRIMARY KEY,
	idHuesped	int FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES(idHuesped),
	codRegimen	numeric(8) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.REGIMENES(codRegimen),
	usr			varchar(50) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.USUARIOS(usr),
	fecDesde	datetime,
	fecHasta	datetime,
	fecReserva	datetime,
	estado		int FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.ESTADOS_RESERVA(codEstadoReserva),
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.RESERVASINVALIDAS
(
	codReserva	numeric(18),
	idHuesped	int,
	usr			varchar(50),
	fecDesde	datetime,
	fecHasta	datetime,
	fecReserva	datetime,
	estado		int,
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.CANCELACIONES_RESERVA
(
	codReserva		numeric(18) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva),
	motivo			varchar(255) not null,
	fecCancelacion	datetime not null,
	usr				varchar(50) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.USUARIOS(usr),
	estado			int FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.ESTADOS_RESERVA(codEstadoReserva),
	PRIMARY KEY (codReserva)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.HOTELES
(
	codHotel		numeric(8) identity(1,1) PRIMARY KEY,
	nombreHotel		varchar(400) not null unique,
	mail			varchar(50) default '',
	fecCreacion		datetime not null,
	telefono		numeric(20) not null default '11111111',
	direccionCalle	varchar(100) not null,
	direccionNumero	numeric(18,0) not null,
	ciudad			varchar(100) not null,
	pais			varchar(50) not null default 'Argentina',
	cantEstrellas	numeric(18,0) not null,
	recargoEstrella numeric(18,0) not null,
	campoBaja		bit not null default 0
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES
(
	tipoCodigo		numeric(18, 0) PRIMARY KEY,
	tipoDescripcion	varchar(50) not null,
	tipoCantidad	numeric(1), --Cantidad de Personas que admite el tipo
	tipoPorcentual	numeric(5,2) not null
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES
(
	codHotel		numeric(8) not null,
	habitacion		numeric(4) not null,
	piso			numeric(2) not null,
	ubicacion		varchar(255) not null,
	tipoCodigo		numeric(18, 0) not null,
	descripcion		varchar(255) not null default '',
	campoBaja		bit	not null default 0
)
go 
ALTER TABLE COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES ADD CONSTRAINT PK_Habitaciones PRIMARY KEY(codHotel, habitacion);
ALTER TABLE COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES ADD CONSTRAINT Fk_Habitacion_Hotel FOREIGN KEY (codHotel) REFERENCES COMPUMUNDO_HIPER_MEGA_RED.HOTELES(codHotel);
ALTER TABLE COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES ADD CONSTRAINT Fk_Codigo_Habitacion FOREIGN KEY (tipoCodigo) REFERENCES COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES(tipoCodigo);

create table COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA
(
	codReserva	numeric(18) not null FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva),
	codHotel	numeric(8) not null FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.HOTELES(codHotel),
	habitacion	numeric(4) not null,
	
)
go
ALTER TABLE COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA ADD CONSTRAINT PK_Detalles_Reserva PRIMARY KEY(codReserva, codHotel, habitacion);

create table COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVAINVALIDA
(
	codReserva	numeric(18),
	codHotel	numeric(8),
	habitacion	numeric(4),
	piso		numeric(2),
	codRegimen	numeric(8),
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.ESTADIA
(
	codReserva	numeric(18) NOT NULL FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva),
	fecIngreso	datetime not null,
	usrIngreso	varchar(50) not null FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.USUARIOS(usr),
	fecEgreso	datetime,
	usrEgreso	varchar(50) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.USUARIOS(usr),
	PRIMARY KEY (codReserva)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.ESTADIA_INVALIDA
(
	codReserva	numeric(18),
	fecIngreso	datetime,
	usrIngreso	varchar(50),
	fecEgreso	datetime,
	usrEgreso	varchar(50)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES
(
	codConsumible	numeric(18) identity(1,1) PRIMARY KEY,
	descripcion		varchar(255) not null,
	importe			numeric(18, 2) not null
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA
(
	codConsumible	numeric(18,0) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES(codConsumible),
	codReserva		numeric(18,0) not null FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva),
	cantidad		numeric(3) not null,
	PRIMARY KEY (codReserva, codConsumible)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA_INVALIDA
(
	codConsumible	numeric(18,0),
	codReserva		numeric(18,0),
	cantidad		numeric(3)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.INHABILITACIONES
(
	hotel			numeric(8) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.HOTELES(codHotel),
	fecInicio		datetime not null,
	fecFin			datetime not null,
	motivo			varchar(255) not null,
	PRIMARY KEY (hotel)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.HOTELES_X_USUARIO
(
	usr				varchar(50) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.USUARIOS(usr),
	codHotel		numeric(8)  FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.HOTELES(codHotel),
	PRIMARY KEY(codHotel, usr)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.FACTURAS
(
	numeroFactura	numeric(18, 0) PRIMARY KEY,
	codReserva		numeric(18) not null FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva),
	fecha			datetime not null,
	montoTotal		numeric(18,2) not null,
	idHuesped 		int not null FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES(idHuesped),
	tipoPago		varchar(50) not null,
	codTarjetaCredito varchar(19)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.FACTURAS_INVALIDAS
(
	numeroFactura	numeric(18),
	codReserva		numeric(18),
	fecha			datetime,
	montoTotal		numeric(18,2),
	idHuesped 		int,
	tipoPago		varchar(50),
	codTarjetaCredito varchar(19)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA
(
	numeroFactura	numeric(18,0) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.FACTURAS(numeroFactura),
	numeroItem		numeric(18) not null,
	descripcion		varchar(255) not null default '',
	montoUnitario	numeric(18,2) not null,
	cantidad		numeric(18,0) not null,
	montoTotal		numeric(18,2) not null,
	PRIMARY KEY (numeroFactura, numeroItem)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA_INVALIDA
(
	numeroFactura	numeric(18),
	numeroItem		numeric(18),
	descripcion		varchar(255),
	montoUnitario	numeric(18,2),
	cantidad		numeric(18),
	montoTotal		numeric(18,2) not null
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.REGIMENES_X_HOTEL
(
	codHotel		numeric(8) not null FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.HOTELES(codHotel),
	codRegimen		numeric(8) not null FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.REGIMENES(codRegimen),
	PRIMARY KEY (codHotel, codRegimen)	
)
go


/***************************************************************************
*AUXILIAR CORRIGE MAIL
***************************************************************************/
IF object_id(N'COMPUMUNDO_HIPER_MEGA_RED.corrigeMail', N'FN') IS NOT NULL
    DROP FUNCTION COMPUMUNDO_HIPER_MEGA_RED.corrigeMail
GO
CREATE FUNCTION COMPUMUNDO_HIPER_MEGA_RED.corrigeMail (@s varchar(256)) 
RETURNS varchar(256)
AS
BEGIN
   IF @s is null
      RETURN null
   
   DECLARE @s2 varchar(256)
   SET @s2 = ''
   DECLARE @l int
   SET @l = len(@s)
   DECLARE @p int
   SET @p = 1
   WHILE @p <= @l 
   BEGIN
      DECLARE @c int;
      SET @c = ascii(substring(@s, @p, 1))
      set @c = LOWER(@c)
      
      --si es espacio todo a la izquierda se descarta
      if (@c = 32) set @s2 = '';
      
	  if @c = ascii('ä') set @c = ascii('a')
	  if @c = ascii('ë') set @c = ascii('e')
	  if @c = ascii('ï') set @c = ascii('i')
	  if @c = ascii('ö') set @c = ascii('o')
      if @c = ascii('ü') set @c = ascii('u')
	  if @c = ascii('á') set @c = ascii('a')
      if @c = ascii('é') set @c = ascii('e')
	  if @c = ascii('í') set @c = ascii('i')
	  if @c = ascii('ó') set @c = ascii('o')
	  if @c = ascii('ú') set @c = ascii('u')
	  if @c = ascii('à') set @c = ascii('a')
      if @c = ascii('è') set @c = ascii('e')
	  if @c = ascii('ì') set @c = ascii('i')
	  if @c = ascii('ò') set @c = ascii('o')
	  if @c = ascii('ù') set @c = ascii('u')
	  if @c = ascii('ñ') set @c = ascii('n')

      if (@c between 48 and 57 or @c = 64 or @c = 45 or @c = 46 
      or @c = 95 or @c between 65 and 90 or @c between 97 and 122)
		
		SET @s2 = @s2 + char(@c)
      
      SET @p = @p + 1
   END
   IF len(@s2) = 0
      return null
   return @s2
END
GO


-- TRIGGERS
IF OBJECT_ID ('COMPUMUNDO_HIPER_MEGA_RED.TRtipoHabPersonas', 'TR') IS NOT NULL
   DROP TRIGGER COMPUMUNDO_HIPER_MEGA_RED.TRtipoHabPersonas;
GO
CREATE TRIGGER TRtipoHabPersonas
ON COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES
AFTER INSERT, UPDATE 
AS 
    SET NOCOUNT ON
    SET XACT_ABORT ON
	
    DECLARE @tipoDescripcion	varchar(50)    
	DECLARE @cantidad numeric(1)
	
    DECLARE cur CURSOR FORWARD_ONLY READ_ONLY LOCAL FOR
        SELECT tipoDescripcion FROM COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES
    OPEN cur												
    FETCH NEXT FROM cur INTO @tipoDescripcion
	
    WHILE @@FETCH_STATUS = 0 BEGIN
		SET @cantidad= (CASE @tipoDescripcion
						WHEN 'BASE SIMPLE' THEN 1
						WHEN 'BASE DOBLE' THEN 2
						WHEN 'BASE TRIPLE' THEN 3
						WHEN 'BASE CUADRUPLE' THEN 4
						WHEN 'KING' THEN 5
						END)			
		
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES
		SET tipoCantidad = @cantidad	
		WHERE tipoDescripcion = @tipoDescripcion
					
        FETCH NEXT FROM cur INTO @tipoDescripcion
    END
    CLOSE cur
    DEALLOCATE cur	
GO
IF OBJECT_ID ('COMPUMUNDO_HIPER_MEGA_RED.TRcorrigeMail_Hoteles', 'TR') IS NOT NULL
   DROP TRIGGER COMPUMUNDO_HIPER_MEGA_RED.TRcorrigeMail_Hoteles;
GO
CREATE TRIGGER TRcorrigeMail_Hoteles
ON COMPUMUNDO_HIPER_MEGA_RED.HOTELES
AFTER INSERT, UPDATE 
AS 
	UPDATE COMPUMUNDO_HIPER_MEGA_RED.HOTELES 
	SET mail = COMPUMUNDO_HIPER_MEGA_RED.corrigeMail(i.mail)
	FROM inserted i
	JOIN COMPUMUNDO_HIPER_MEGA_RED.HOTELES H ON H.codHotel = i.codHotel
	WHERE i.nombreHotel = H.nombreHotel
GO

IF OBJECT_ID ('COMPUMUNDO_HIPER_MEGA_RED.TRcorrigeMail_Huespedes', 'TR') IS NOT NULL
   DROP TRIGGER COMPUMUNDO_HIPER_MEGA_RED.TRcorrigeMail_Huespedes;
GO
CREATE TRIGGER TRcorrigeMail_Huespedes
ON COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
AFTER INSERT, UPDATE 
AS 
	UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES 
	SET mail = COMPUMUNDO_HIPER_MEGA_RED.corrigeMail(i.mail)
	FROM inserted i
	JOIN COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES H ON H.idHuesped = i.idHuesped
	WHERE i.apellido = H.apellido AND i.nombre = H.nombre AND i.numDocu = H.numDocu
GO

IF OBJECT_ID ('COMPUMUNDO_HIPER_MEGA_RED.TRcorrigeMail_Usuarios', 'TR') IS NOT NULL
   DROP TRIGGER COMPUMUNDO_HIPER_MEGA_RED.TRcorrigeMail_Usuarios;
GO
CREATE TRIGGER TRcorrigeMail_Usuarios
ON COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
AFTER INSERT, UPDATE 
AS 
	UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS 
	SET mail = COMPUMUNDO_HIPER_MEGA_RED.corrigeMail(i.mail)
	FROM inserted i
	JOIN COMPUMUNDO_HIPER_MEGA_RED.USUARIOS U ON U.usr = U.usr
	WHERE i.nombre = U.nombre AND i.apellido = U.apellido
GO


/** 
 ** MIGRACION
 **/
 	
--//USUARIO, Administrador	
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.USUARIOS (usr,password, nombre, apellido, tipoDocu, numDocu, direccionCalle, direccionNumero, FecNacimiento, mail) 
	VALUES 	('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7','ADMINISTRADOR General', 'GEREZ', 'DNI', '24264123', 'Av. Cordoba', '8834', 17-04-1981, 'admin@frbaHoteles.com.ar')
GO
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.USUARIOS (usr,password, nombre, apellido, tipoDocu, numDocu, direccionCalle, direccionNumero, FecNacimiento, mail) 
	VALUES 	('GUEST','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7','Invitado', 'Invitado', 'DNI', '37608533', 'Av. Cordoba', '8834', 17-04-1981, 'admin@frbaHoteles.com.ar')
GO


--//ROL
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ROLES (nombreRol) 
	VALUES ('ADMINISTRADOR'),
		   ('RECEPCIONISTA'),
		   ('GUEST')
GO	
	   
--//ROLES_X_USUARIO, CARGA PARA USR: Administrador
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ROLES_X_USUARIO (nombreRol, usr) 
	VALUES ('ADMINISTRADOR','admin')
GO
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ROLES_X_USUARIO (nombreRol, usr) 
	VALUES ('GUEST','GUEST')
GO
--//FUNCIONALIDADES
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES (idFuncionalidad, descripcion) 
	VALUES 	('1','ABM de Rol'), 
			('2','ABM de Usuario'), 
			('3','ABM de Huespedes'), 
			('4','ABM de Hotel'), 
			('5','ABM de Habitacion'), 
			('6','ABM de Regimen'), 
			('7','Generar o Modificar una Reserva'), 
			('8','Cancelar Reserva'), 
			('9','Registrar Estadia'), 
			('10','Registrar Consumibles'), 
			('11','Facturar Estadia'), 
			('12','Listado Estadistico')
GO	

--//FUNCIONALIDADES_X_ROL
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES_X_ROL (nombreRol, idFuncionalidad) 
	VALUES 	('ADMINISTRADOR','1'), 
			('ADMINISTRADOR','2'), 
			('ADMINISTRADOR','3'), 
			('ADMINISTRADOR','4'), 
			('ADMINISTRADOR','5'), 
			('ADMINISTRADOR','6'), 
			('ADMINISTRADOR','7'), 
			('ADMINISTRADOR','8'), 
			('ADMINISTRADOR','9'),
			('ADMINISTRADOR','10'),
			('ADMINISTRADOR','11'), 
			('ADMINISTRADOR','12'), 
			('RECEPCIONISTA','3'), 
			('RECEPCIONISTA','7'), 
			('RECEPCIONISTA','8'), 
			('RECEPCIONISTA','9'),
			('GUEST','7'), 
			('GUEST','8')
GO

--//ESTADOS QUE PUEDE TENER UNA RESERVA
INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ESTADOS_RESERVA(codEstadoReserva, descripcion)
VALUES	('1','Reserva correcta'),
		('2','Reserva modificada'),
		('3','Reserva cancelada por Recepción'),
		('4','Reserva cancelada por Cliente'),
		('5','Reserva cancelada por No-Show'),
		('6','Reserva efectivizada')
GO

--//REGIMENES
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.REGIMENES(descripcion, precio)
	SELECT DISTINCT UPPER(Regimen_Descripcion), Regimen_Precio
	FROM  gd_esquema.Maestra
	WHERE Regimen_Descripcion IS NOT NULL
GO

--//HOTELES
/*PARA QUE TENGA SENTIDO LA FECHA DE CREACION SERÁ EL PRIMERO DE NOVIEMBRE DE 2012
YA QUE LA RESERVA MAS ANTIGUA TIENE FECHA 27 DE DICIEMBRE DE 2012*/
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HOTELES(nombreHotel,direccionCalle, direccionNumero, ciudad, cantEstrellas, recargoEstrella, fecCreacion)
	SELECT DISTINCT UPPER(RTRIM(Hotel_Ciudad)+' '+RTRIM(Hotel_Calle)) AS nombreHotel,UPPER(Hotel_Calle), Hotel_Nro_Calle, UPPER(Hotel_Ciudad), Hotel_CantEstrella, Hotel_Recarga_Estrella, '01/11/2012'
	FROM  gd_esquema.Maestra
	WHERE Hotel_Calle IS NOT NULL
GO

--//HOTELES_X_USUARIO, Administrador
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HOTELES_X_USUARIO(usr,codHotel)
	VALUES ('admin','10')
GO

--//TIPO_HABITACIONES
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES(tipoCodigo, tipoDescripcion, tipoPorcentual)
	SELECT DISTINCT Habitacion_Tipo_Codigo, UPPER(Habitacion_Tipo_Descripcion), Habitacion_Tipo_Porcentual
	FROM  gd_esquema.Maestra
	WHERE Habitacion_Tipo_Codigo IS NOT NULL
GO

--//HABITACIONES
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES(codHotel,habitacion, piso, ubicacion, tipoCodigo, descripcion)
	SELECT DISTINCT H.codHotel, M.Habitacion_Numero, M.Habitacion_Piso, UPPER(M.Habitacion_Frente), M.Habitacion_Tipo_Codigo, UPPER(M.Habitacion_Tipo_Descripcion)
	FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES H, gd_esquema.Maestra M
	WHERE H.direccionCalle = M.Hotel_Calle AND 
		  H.direccionNumero = M.Hotel_Nro_Calle AND 
		  H.ciudad = M.Hotel_Ciudad AND 
		  H.direccionCalle IS NOT NULL
GO	

--//HUESPEDES
    INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES(tipoDocu, numDocu, apellido, nombre, fecNacimiento, mail, direccionCalle,
                                                   direccionNumero, direccionPiso, direccionDepto, localidad, nacionalidad)
    SELECT DISTINCT 'DNI', Cliente_Pasaporte_Nro , UPPER(Cliente_Apellido), UPPER(Cliente_Nombre), Cliente_Fecha_Nac, Cliente_Mail,   
                    UPPER(Cliente_Dom_Calle), Cliente_Nro_Calle, Cliente_Piso, UPPER(Cliente_Depto), 'CABA', 'ARGENTINA'
    FROM  gd_esquema.Maestra
	WHERE Cliente_Apellido IS NOT NULL AND Cliente_Nombre IS NOT NULL
GO

--//RESERVAS
/*SUPONEMOS QUE LAS RESERVAS FUERON REGISTRADAS POR EL ADMINISTRADOR
 * Y QUE FUERON REALIZADAS EL MISMO DÍA QUE DE SU INICIO.
 */
	
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva, idHuesped, codRegimen, estado, usr, fecDesde, fecHasta, fecReserva)
	SELECT DISTINCT M.Reserva_Codigo , HUES.idHuesped, R.codRegimen, CASE M.Factura_Nro WHEN NULL THEN '1' ELSE '6' END ,'admin', M.Reserva_Fecha_Inicio, M.Reserva_Fecha_Inicio + M.Reserva_Cant_Noches, M.Reserva_Fecha_Inicio - 5
	FROM COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES HUES, COMPUMUNDO_HIPER_MEGA_RED.REGIMENES R, gd_esquema.Maestra M
	WHERE M.Cliente_Pasaporte_Nro = HUES.numDocu AND
		  M.Cliente_Apellido = HUES.apellido AND
		  M.Cliente_Nombre = HUES.nombre AND
		  R.descripcion = M.Regimen_Descripcion AND
		  R.precio = M.Regimen_Precio AND
		  M.Reserva_Fecha_Inicio <= CURRENT_TIMESTAMP
GO

--//RESERVASINVALIDAS
/*SUPONEMOS QUE LAS RESERVAS FUERON REGISTRADAS POR EL ADMINISTRADOR
 * Y QUE FUERON REALIZADAS EL MISMO DÍA QUE DE SU INICIO.
 */
	
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.RESERVASINVALIDAS(codReserva, idHuesped, estado, usr, fecDesde, fecHasta, fecReserva)
	SELECT DISTINCT M.Reserva_Codigo , HUES.idHuesped, '5','admin', M.Reserva_Fecha_Inicio, M.Reserva_Fecha_Inicio + M.Reserva_Cant_Noches, M.Reserva_Fecha_Inicio - 5
	FROM COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES HUES, gd_esquema.Maestra M
	WHERE M.Cliente_Pasaporte_Nro = HUES.numDocu AND
		  M.Cliente_Apellido = HUES.apellido AND
		  M.Cliente_Nombre = HUES.nombre AND
		  M.Reserva_Fecha_Inicio > CURRENT_TIMESTAMP
		  
GO

--//CANCELACIONES_RESERVA
/* DE LA MIGRACION INICIAL REGISTRO AQUELLAS RESERVAS QUE NO SE EFECTIVIZARON
 * SUPONGO QUE SE REGISTRA 3 DÍAS DESPUES DE SU INICIO.
 */
	
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.CANCELACIONES_RESERVA (codReserva, motivo, usr, fecCancelacion)
	SELECT DISTINCT M.Reserva_Codigo , 'No se registra estadía', 'admin', M.Reserva_Fecha_Inicio + 3
	FROM gd_esquema.Maestra M
	WHERE M.Estadia_Fecha_Inicio IS NULL AND M.Reserva_Fecha_Inicio <= CURRENT_TIMESTAMP
		  
GO

--//REGIMENES_X_HOTEL
    INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.REGIMENES_X_HOTEL(codHotel, codRegimen)
	SELECT DISTINCT H.codHotel, R.codRegimen
	FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES H, COMPUMUNDO_HIPER_MEGA_RED.REGIMENES R, gd_esquema.Maestra M
	WHERE H.direccionCalle = M.Hotel_Calle AND 
		  H.direccionNumero = M.Hotel_Nro_Calle AND 
		  H.ciudad = M.Hotel_Ciudad AND 
		  H.direccionCalle IS NOT NULL AND
		  R.descripcion = M.Regimen_Descripcion AND
		  R.precio = M.Regimen_Precio
	ORDER BY H.codHotel ASC
GO	

--//ESTADIA
/*SUPONEMOS QUE LA ESTADIA FINALIZA Estadia_Cant_Noches LUEGO DE LA FECHA DE INICIO DE LA MISMA
 *Y QUE FUE REGISTRADA POR EL ADMINISTRADOR.
 */
  	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ESTADIA(codReserva,fecIngreso, fecEgreso, usrIngreso, usrEgreso)
	SELECT DISTINCT M.Reserva_Codigo, M.Estadia_Fecha_Inicio, M.Estadia_Fecha_Inicio + M.Estadia_Cant_Noches, 'admin', 'admin'
	FROM gd_esquema.Maestra M
	WHERE M.Estadia_Fecha_Inicio <= CURRENT_TIMESTAMP AND
		  M.Reserva_Codigo IS NOT NULL
GO

--//ESTADIA_INVALIDA
--//ESTADIAS NO VALIDAS POR TENER FECHA FUTURA A LA PRESENTE
  	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ESTADIA_INVALIDA(codReserva,fecIngreso, fecEgreso, usrIngreso, usrEgreso)
	SELECT DISTINCT M.Reserva_Codigo, M.Estadia_Fecha_Inicio, M.Estadia_Fecha_Inicio + M.Estadia_Cant_Noches, 'admin', 'admin'
	FROM gd_esquema.Maestra M
	WHERE M.Estadia_Fecha_Inicio > CURRENT_TIMESTAMP AND
		  M.Reserva_Codigo IS NOT NULL
GO

--//CONSUMIBLES
--PARA QUE TOME LOS CODIGOS YA EXISTENTE
	SET IDENTITY_INSERT COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES ON
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES(codConsumible, descripcion, importe)
	SELECT DISTINCT M.Consumible_Codigo, UPPER(M.Consumible_Descripcion), M.Consumible_Precio
	FROM gd_esquema.Maestra M
	WHERE M.Consumible_Codigo IS NOT NULL
	
/*RESETEO IDENTITY_INSERT, CUANDO HAYA NUEVOS INSERT SEGUIRÁ CON LA SECUENCIA DE CODIGO ULTIMO
  SI EL ULTIMO CODIGO CARGADO ES 2327 CUANDO HAGA INSERT SERA 2328*/
	SET IDENTITY_INSERT COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES OFF
GO

--//CONSUMIBLES_X_ESTADIA
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA(codConsumible, codReserva, cantidad)
	SELECT DISTINCT M.Consumible_Codigo, M.Reserva_Codigo, count(M.Consumible_Codigo)
	FROM gd_esquema.Maestra M
	WHERE M.Consumible_Codigo IS NOT NULL AND
		  M.Reserva_Codigo IS NOT NULL AND
		  M.Reserva_Fecha_Inicio <= CURRENT_TIMESTAMP
	GROUP BY M.Consumible_Codigo, M.Reserva_Codigo
	ORDER BY M.Reserva_Codigo ASC
GO	

--//CONSUMIBLES_X_ESTADIA_INVALIDA
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA_INVALIDA(codConsumible, codReserva, cantidad)
	SELECT DISTINCT M.Consumible_Codigo, M.Reserva_Codigo, count(M.Consumible_Codigo)
	FROM gd_esquema.Maestra M
	WHERE M.Consumible_Codigo IS NOT NULL AND
		  M.Reserva_Codigo IS NOT NULL AND
		  M.Reserva_Fecha_Inicio > CURRENT_TIMESTAMP
	GROUP BY M.Consumible_Codigo, M.Reserva_Codigo
	ORDER BY M.Reserva_Codigo ASC
GO

--//DETALLES_RESERVA
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA(codHotel, codReserva, habitacion)
	SELECT DISTINCT H.codHotel, M.Reserva_Codigo, M.Habitacion_Numero
	FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES H, gd_esquema.Maestra M
	WHERE H.direccionCalle = M.Hotel_Calle AND 
		  H.direccionNumero = M.Hotel_Nro_Calle AND 
		  H.ciudad = M.Hotel_Ciudad AND 
		  H.direccionCalle IS NOT NULL AND
		  M.Reserva_Fecha_Inicio <= CURRENT_TIMESTAMP
	ORDER BY H.codHotel
GO

--//DETALLES_RESERVA INVALIDA
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVAINVALIDA(codHotel, codReserva, codRegimen, habitacion, piso)
	SELECT DISTINCT H.codHotel, M.Reserva_Codigo, R.codRegimen, M.Habitacion_Numero, M.Habitacion_Piso
	FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES H, COMPUMUNDO_HIPER_MEGA_RED.REGIMENES R, gd_esquema.Maestra M
	WHERE H.direccionCalle = M.Hotel_Calle AND 
		  H.direccionNumero = M.Hotel_Nro_Calle AND 
		  H.ciudad = M.Hotel_Ciudad AND 
		  H.direccionCalle IS NOT NULL AND
		  R.descripcion = M.Regimen_Descripcion AND
		  R.precio = M.Regimen_Precio AND
		  M.Reserva_Fecha_Inicio > CURRENT_TIMESTAMP
	ORDER BY H.codHotel
GO

--//FACTURAS
/*CONSIDERO FACTURAS PAGAS EN EFECTIVO*/

	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.FACTURAS(numeroFactura, codReserva, fecha, montoTotal, idHuesped,tipoPago, codTarjetaCredito)
	SELECT DISTINCT M.Factura_Nro,M.Reserva_Codigo, M.Factura_Fecha, SUM(M.Item_Factura_Monto), HUES.idHuesped, 'EFECTIVO',''
	FROM COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES HUES, gd_esquema.Maestra M
	WHERE M.Factura_Nro IS NOT NULL AND
		  M.Cliente_Pasaporte_Nro = HUES.numDocu AND
		  M.Cliente_Apellido = HUES.apellido AND
		  M.Cliente_Nombre = HUES.nombre AND
		  M.Factura_Fecha <= CURRENT_TIMESTAMP
	GROUP BY M.Factura_Nro,M.Reserva_Codigo, M.Factura_Fecha, idHuesped
GO

--//FACTURAS_INVALIDAS
--//FACTURAS NO VALIDAS POR TENER FECHA FUTURA A LA PRESENTE
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.FACTURAS_INVALIDAS(numeroFactura, codReserva, fecha, montoTotal, idHuesped,tipoPago, codTarjetaCredito)
	SELECT DISTINCT M.Factura_Nro,M.Reserva_Codigo, M.Factura_Fecha, SUM(M.Item_Factura_Monto), HUES.idHuesped, 'EFECTIVO',''
	FROM COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES HUES, gd_esquema.Maestra M
	WHERE M.Factura_Nro IS NOT NULL AND
		  M.Cliente_Pasaporte_Nro = HUES.numDocu AND
		  M.Cliente_Apellido = HUES.apellido AND
		  M.Cliente_Nombre = HUES.nombre AND
		  M.Factura_Fecha > CURRENT_TIMESTAMP
	GROUP BY M.Factura_Nro,M.Reserva_Codigo, M.Factura_Fecha, idHuesped
GO

--//ITEMS_FACTURA
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA(numeroFactura, numeroItem, descripcion, montoUnitario, cantidad, montoTotal)
	SELECT DISTINCT M.Factura_Nro, ROW_NUMBER() OVER (PARTITION BY M.Factura_Nro ORDER BY M.Factura_Nro) AS Item_Nro, CASE WHEN M.Consumible_Descripcion IS NULL THEN 'Recargos de Categoria Hotel y Regimen' ELSE UPPER(M.Consumible_Descripcion) END, M.Item_Factura_Monto, COUNT(*), (M.Item_Factura_Monto * COUNT(*))
	FROM gd_esquema.Maestra M
	WHERE M.Item_Factura_Monto IS NOT NULL AND
			  M.Item_Factura_Cantidad IS NOT NULL AND
			  M.Factura_Nro IS NOT NULL AND
			  M.Factura_Fecha <= CURRENT_TIMESTAMP
	GROUP BY M.Factura_Nro, M.Item_Factura_Monto, M.Consumible_Descripcion
GO

--Funcion para calcular el ultimo item ingresado de una factura
IF object_id(N'COMPUMUNDO_HIPER_MEGA_RED.get_ultimoItemFactura', N'FN') IS NOT NULL
    DROP FUNCTION COMPUMUNDO_HIPER_MEGA_RED.get_ultimoItemFactura
GO
CREATE FUNCTION COMPUMUNDO_HIPER_MEGA_RED.get_ultimoItemFactura (@nroFactura numeric(18))
RETURNS numeric(1)
AS
	BEGIN
		return (select max(i.numeroItem) 
			   from COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA i
			   where i.numeroFactura = @nroFactura)
	END
GO


--//ITEMS_FACTURA_INVALIDA
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA_INVALIDA(numeroFactura, numeroItem, descripcion, montoUnitario, cantidad, montoTotal)
	SELECT DISTINCT M.Factura_Nro, ROW_NUMBER() OVER (PARTITION BY M.Factura_Nro ORDER BY M.Factura_Nro) AS Item_Nro, CASE WHEN M.Consumible_Descripcion IS NULL THEN 'Recargos de Categoria Hotel y Regimen' ELSE M.Consumible_Descripcion END, M.Item_Factura_Monto, COUNT(*), (M.Item_Factura_Monto * COUNT(*))
	FROM gd_esquema.Maestra M
	WHERE M.Item_Factura_Monto IS NOT NULL AND
			  M.Item_Factura_Cantidad IS NOT NULL AND
			  M.Factura_Nro IS NOT NULL AND
			  M.Factura_Fecha > CURRENT_TIMESTAMP
	GROUP BY M.Factura_Nro, M.Item_Factura_Monto, M.Consumible_Descripcion
GO

/*
 *PROCEDURES
 */
 --/PROC GETROL
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getRol', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getRol
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getRol
	@unRol VARCHAR(15)
AS
	BEGIN
	 --SI RECIBE VACIO, MUESTRA TODOS LOS ROLES HABILITADOS
	 IF (@unRol = '')
 		SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.ROLES R
	 ELSE
		SELECT * 
		FROM COMPUMUNDO_HIPER_MEGA_RED.ROLES R 
		WHERE R.nombreRol = @unRol
 
	END
GO
--//PROC INSERTROL
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.insertRol', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertRol
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertRol
	@nombreRol	varchar(15),
	@estado		bit
AS
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ROLES (nombreRol, estado)
	VALUES(UPPER(@nombreRol), @estado)
GO
--//PROC DELETEROL
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.deleteRol', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteRol
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteRol
	@nombreRol	varchar(15)
AS
	UPDATE COMPUMUNDO_HIPER_MEGA_RED.ROLES
	SET estado = 0
	WHERE nombreRol = @nombreRol
GO

--/PROC UPDATEROL
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.updateRol', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateRol
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateRol
	@nombreRol	varchar(15),
	@estado bit
AS
	IF(@nombreRol != '')
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.ROLES
		SET estado = @estado
		WHERE nombreRol = @nombreRol
GO


--//PROC INSERTROLUSUARIO
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.insertRolUsuario', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertRolUsuario
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertRolUsuario
	@rol varchar(50),
	@usr varchar(50)	
AS
	IF(@rol != '' AND @usr != '')
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ROLES_X_USUARIO (nombreRol, usr) 
	VALUES (UPPER(@rol), @usr)
GO

--//PROC DELETEROLUSUARIO
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.deleteRolUsuario', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteRolUsuario
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteRolUsuario
	@rol varchar(50),
	@usr varchar(50)	
AS
	DELETE FROM COMPUMUNDO_HIPER_MEGA_RED.ROLES_X_USUARIO 
	WHERE nombreRol = @rol AND usr = @usr
GO

--//PRC ADD ROL_X_FUNCIONALIDAD
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.addFuncionalidad', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.addFuncionalidad
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.addFuncionalidad
	@idFuncionalidad numeric(2),
	@rol varchar(15)	
AS
	IF(@idFuncionalidad != -1 AND @rol != '')
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES_X_ROL(idFuncionalidad, nombreRol)
	VALUES(@idFuncionalidad, UPPER(@rol))
GO

--//PROC REMOVE ROL_X_FUNCIONALIDAD
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.removeFuncionalidad', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.removeFuncionalidad
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.removeFuncionalidad
	@idFuncionalidad numeric(2),
	@rol varchar(15)	
AS
	DELETE FROM COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES_X_ROL
	WHERE idFuncionalidad = @idFuncionalidad AND nombreRol = @rol
GO

--//PROC GETFUNCIONALIDAD
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.[getFuncionalidad]', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.[getFuncionalidad]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [COMPUMUNDO_HIPER_MEGA_RED].[getFuncionalidad]
	@unaFuncionalidad NUMERIC(2)
AS
	BEGIN
	 IF (@unaFuncionalidad != -1)
 		SELECT F.idFuncionalidad, F.descripcion
 		FROM COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES F
 		WHERE F.idFuncionalidad = @unaFuncionalidad 
	 ELSE
		SELECT *
		FROM COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES F  
	END
GO

--//Trae las funcionalidades asociadas a un rol
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.JoinRolFunc', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.JoinRolFunc
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.JoinRolFunc
	@nombreRol varchar(15)
AS
	BEGIN
	 IF (@nombreRol != '')
 		SELECT FR.nombreRol,F.idFuncionalidad,F.descripcion
		FROM COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES_X_ROL FR
		JOIN COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES F
			ON FR.idFuncionalidad = F.idFuncionalidad
		WHERE FR.nombreRol = @nombreRol

	ELSE
		SELECT FR.nombreRol,F.idFuncionalidad,F.descripcion
		FROM COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES_X_ROL FR
		JOIN COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES F
			ON FR.idFuncionalidad = F.idFuncionalidad
END
GO

--//PROC GETUSUARIO
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getUsuario', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getUsuario
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getUsuario
	@unUsr VARCHAR(50)
AS
	 IF (@unUsr = '')
 		SELECT U.usr, RU.nombreRol, U.nombre, U.apellido, U.FecNacimiento, U.tipoDocu, U.numDocu,U.direccionCalle, U.direccionNumero, U.direccionPiso, 
 				U.direccionDepto, U.mail, U.telefono, U.password, U.campoBaja
 		FROM COMPUMUNDO_HIPER_MEGA_RED.USUARIOS U
		JOIN COMPUMUNDO_HIPER_MEGA_RED.ROLES_X_USUARIO RU ON RU.usr = U.usr
	 ELSE
		SELECT U.usr, RU.nombreRol, U.nombre, U.apellido, U.FecNacimiento, U.tipoDocu, U.numDocu,U.direccionCalle, U.direccionNumero, U.direccionPiso, 
				U.direccionDepto, U.mail, U.telefono, U.password, U.campoBaja
		FROM COMPUMUNDO_HIPER_MEGA_RED.USUARIOS U
		JOIN COMPUMUNDO_HIPER_MEGA_RED.ROLES_X_USUARIO RU ON RU.usr = U.usr
 		WHERE U.usr = @unUsr
GO

--/PROCEDIMIENTO INSERTAR USUARIO 
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.insertUsuario', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertUsuario
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertUsuario
	@usr varchar(50),
	@password varchar(50), 
	@nombre varchar(255),
	@apellido varchar(255),
	@tipoDocu varchar(50),
	@numDocu	numeric(18,0),
	@mail varchar(255),
	@telefono numeric(12),
	@direccionCalle varchar(100),
	@direccionNumero numeric(18,0),
	@direccionPiso numeric(18,0),
	@direccionDepto varchar(50),
	@FecNacimiento DateTime
AS
	IF(@usr != '' AND @password != '' AND @nombre != '' AND @apellido != '' AND @tipoDocu != '' AND
		@numDocu != -1 AND @mail != '' AND @telefono != -1 AND @direccionCalle != '' AND @direccionNumero != -1 
		AND @direccionPiso != -1 AND @direccionDepto != '' AND @FecNacimiento IS NOT NULL)
		
		BEGIN TRANSACTION
		
		INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.USUARIOS (usr, password, nombre, apellido, contador_intentos_login, tipoDocu, numDocu,
			mail, telefono, direccionCalle, direccionNumero, FecNacimiento, campoBaja)
		VALUES(@usr, @password, UPPER(@nombre), UPPER(@apellido), 0, @tipoDocu, @numDocu, LOWER(@mail), @telefono, UPPER(@direccionCalle), @direccionNumero, 
				@FecNacimiento, 0)

		IF(@direccionPiso != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
			SET direccionPiso = @direccionPiso
			WHERE usr = usr
		IF(@direccionDepto != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
			SET direccionDepto = @direccionDepto
			WHERE usr = usr			
		COMMIT TRANSACTION
GO


--//PROC DELETEUSUARIO
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.deleteUsuario', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteUsuario
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteUsuario
	@usr varchar(50)	
AS
	UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
	SET campoBaja = 1
	WHERE usr = @usr
GO
--//PROC UPDATEUSUARIO
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.updateUsuario', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateUsuario
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateUsuario
	@usr varchar(50),
	@password varchar(50), 
	@nombre varchar(255),
	@apellido varchar(255),
	@tipoDocu varchar(50),
	@numDocu	numeric(18,0),
	@mail varchar(255),
	@telefono numeric(12),
	@direccionCalle varchar(100),
	@direccionNumero numeric(18,0),
	@direccionPiso numeric(18,0),
	@direccionDepto varchar(50),
	@fecNacimiento DateTime,
	@campoBaja bit
AS
	IF (@usr != '')
	BEGIN
		IF(@password != '')
		BEGIN
			DECLARE @nueva_clave varchar(50)
			CREATE TABLE #TEMP_TABLA(
				temp_usr varchar(50), temp_password varchar(50), temp_primerLog bit
			)
			INSERT INTO #TEMP_TABLA SELECT U.usr, U.password, U.primerLog FROM COMPUMUNDO_HIPER_MEGA_RED.USUARIOS U WHERE U.usr = @usr
			IF (SELECT COUNT(TMP.temp_usr) FROM #TEMP_TABLA TMP WHERE TMP.temp_primerLog = 1) > 0
				/*SI ES EL PRIMER LOGUEO PUEDE HACER CAMBIO DE PASSWORD*/
				SET @nueva_clave = @password
			ELSE
				/*CONSERVA EL PASSWORD*/
				SET @nueva_clave = (SELECT TMP.temp_password FROM #TEMP_TABLA TMP)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
				SET password = @nueva_clave
					WHERE usr = @usr
			/*DROP TABLA TEMPORAL*/
			DROP TABLE ##TEMP_TABLA
		END
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
			SET primerLog = 0
				WHERE usr = @usr		
		IF(@nombre != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
				SET nombre = UPPER(@nombre)
					WHERE usr = @usr		
		IF(@apellido != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
				SET apellido = UPPER(@apellido)
					WHERE usr = @usr	
		IF(@tipoDocu != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
				SET tipoDocu = @tipoDocu
					WHERE usr = @usr	
		IF(@numDocu != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
				SET numDocu = @numDocu
					WHERE usr = @usr	
		IF(@mail != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
				SET mail = LOWER(@mail)
					WHERE usr = @usr	
		IF(@telefono != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
				SET telefono = @telefono
					WHERE usr = @usr
		IF(@direccionCalle != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
				SET direccionCalle = UPPER(@direccionCalle)
					WHERE usr = @usr	
		IF(@direccionNumero != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
				SET direccionNumero = @direccionNumero
					WHERE usr = @usr
		IF(@direccionPiso != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
				SET direccionPiso = @direccionPiso
					WHERE usr = @usr
		IF(@direccionDepto != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
				SET direccionDepto = UPPER(@direccionDepto)
					WHERE usr = @usr	
		IF(@fecNacimiento IS NOT NULL)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
				SET fecNacimiento = @fecNacimiento
					WHERE usr = @usr		
		IF(@campoBaja != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
				SET campoBaja = @campoBaja
					WHERE usr = @usr								
	END
GO

--//PROC GETINTENTOSFALLIDOSUSUARIO
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getFallidosUsuario', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getFallidosUsuario
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getFallidosUsuario
	@usr varchar(50)	
AS
	DECLARE @contador_actual numeric(2)
	SELECT U.contador_intentos_login FROM COMPUMUNDO_HIPER_MEGA_RED.USUARIOS U WHERE U.usr = @usr
GO


--//PROC INTENTOFALLIDOUSUARIO
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.intentoFallidoUsuario', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.intentoFallidoUsuario
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.intentoFallidoUsuario
	@usr varchar(50)	
AS
	DECLARE @contador_actual numeric(2)
	SET @contador_actual = (SELECT U.contador_intentos_login FROM COMPUMUNDO_HIPER_MEGA_RED.USUARIOS U WHERE U.usr = @usr)
	SET @contador_actual += 1 
		
	
	
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS 
		SET contador_intentos_login = @contador_actual
		WHERE usr = @usr
		
		IF(@contador_actual >= 3)
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS 
		SET campoBaja = 1
		WHERE usr = @usr	
GO


--//PROC RESETINTENTOS
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.resertIntentosUsuario', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.resertIntentosUsuario
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.resertIntentosUsuario
	@usr varchar(50)	
AS
	UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
	SET contador_intentos_login = 0, campoBaja = 0
	WHERE usr = @usr
GO

--/PROCEDIMIENTO GETHABITACION
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getHabitacion', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHabitacion
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHabitacion
	@habitacion numeric(4),
	@codHotel numeric(8)
AS
	BEGIN
			IF (@habitacion = -1)
				SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES H
				WHERE H.codHotel = @codHotel				
			ELSE
				SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES H
				WHERE H.habitacion = @habitacion AND H.codHotel = @codHotel				
	END
GO

--/PROCEDIMIENTO GETTIPOHABITACION
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getTipoHabitacion', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getTipoHabitacion
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getTipoHabitacion
	@tipoHabitacion numeric(18)
AS
	BEGIN
			IF (@tipoHabitacion = -1)
				SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES H
			ELSE
				SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES H
				WHERE H.tipoCodigo = @tipoHabitacion			
	END
GO


--/PROCEDIMIENTO INSERTAR HABITACION
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.insertHabitacion', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertHabitacion
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertHabitacion
	@codHotel numeric(8),
	@habitacion numeric(4),
	@piso numeric(2),
	@ubicacion varchar(255),
	@tipo numeric(18),
	@descripcion varchar(255)
AS
	IF(@codHotel != -1 AND @habitacion != -1 AND @piso != -1 AND @ubicacion != '' AND @tipo != -1 AND @descripcion != '')
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES (codHotel, habitacion, piso, ubicacion, tipoCodigo,
		descripcion, campoBaja)
VALUES(@codHotel, @habitacion, @piso, UPPER(@ubicacion), @tipo, UPPER(@descripcion), 0)
GO

--//PROC UPDATEHABITACION
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.updateHabitacion', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateHabitacion
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateHabitacion
	@codHotel numeric(8),
	@habitacion numeric(4),
	@piso numeric(2),
	@ubicacion varchar(255),
	@tipo numeric(18),
	@descripcion varchar(255),
	@campoBaja bit
AS
	IF(@habitacion != -1)
	BEGIN
		IF (@codHotel != -1)
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES
			SET codHotel = @codHotel
				WHERE habitacion = @habitacion
		IF(@piso != -1)
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES
			SET piso = @piso
				WHERE habitacion= @habitacion
		IF (@ubicacion != '')
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES	
			SET ubicacion = UPPER(@ubicacion)
				WHERE habitacion= @habitacion
		IF (@tipo != -1)
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES
			SET tipoCodigo = @tipo
				WHERE habitacion= @habitacion
		IF (@descripcion != '')		
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES
			SET descripcion = UPPER(@descripcion)
				WHERE habitacion= @habitacion
		IF (@campoBaja != -1)
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES
			SET campoBaja = @campoBaja
				WHERE habitacion= @habitacion
	END
GO

--//PROC DELETEHABITACION
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.deleteHabitacion', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteHabitacion
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteHabitacion
	@codHotel numeric(8),
	@habitacion numeric(4)
AS
	UPDATE COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES
	SET campoBaja = 1
	WHERE habitacion= @habitacion AND codHotel = @codHotel
GO

--/PROCEDIMIENTO GET REGIMEN BY HOTEL 
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getRegimenByHotel', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getRegimenByHotel
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getRegimenByHotel
@codigo numeric(8)
AS
		IF(@codigo != -1)
		SELECT reg.codRegimen, reg.descripcion, reg.estado, reg.precio
		FROM COMPUMUNDO_HIPER_MEGA_RED.REGIMENES reg 
		JOIN COMPUMUNDO_HIPER_MEGA_RED.REGIMENES_X_HOTEL hotel
		ON reg.codRegimen = hotel.codRegimen
		WHERE hotel.codHotel = @codigo
GO

--/PROCEDIMIENTO GET REGIMEN 
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getRegimen', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getRegimen
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getRegimen
@codigo numeric(8)
AS
	--SI RECIBE -1, MUESTRA TODOS LOS REGIMENES HABILITADOS
	IF (@codigo = -1)
		SELECT R.codRegimen, R.descripcion, R.precio, R.estado FROM COMPUMUNDO_HIPER_MEGA_RED.REGIMENES R
		WHERE R.estado = 1				
	ELSE
		SELECT R.codRegimen, R.descripcion, R.precio, R.estado FROM COMPUMUNDO_HIPER_MEGA_RED.REGIMENES R
		WHERE R.codRegimen = @codigo
GO

--/PROC INSERTREGIMEN 
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.insertRegimen', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertRegimen
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertRegimen
	@codigoRegimen numeric(8),
	@descripcion varchar(255),
	@precio numeric (18,2)
AS
	IF(@codigoRegimen != -1 AND @descripcion != '' AND @precio != -1)
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.REGIMENES(codRegimen, descripcion, precio, estado)
	VALUES (@codigoRegimen, UPPER(@descripcion), @precio, 1)
GO


--/PROC UPDATEREGIMEN
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.updateRegimen', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateRegimen
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateRegimen
	@codigoRegimen numeric(8),
	@descripcion varchar(255),
	@precio numeric (18,2),
	@estado bit
AS
	IF(@codigoRegimen != -1)
	BEGIN
		IF(@descripcion != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.REGIMENES
				SET descripcion = UPPER(@descripcion)
					WHERE codRegimen = @codigoRegimen
		IF(@precio != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.REGIMENES
				SET precio = @precio
					WHERE codRegimen = @codigoRegimen
		IF(@estado != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.REGIMENES
				SET estado = @estado
					WHERE codRegimen = @codigoRegimen
	END
GO

--/PROC DELETEREGIMEN
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.deleteRegimen', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteRegimen
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteRegimen
	@codigoRegimen numeric(8)
	AS
	   UPDATE COMPUMUNDO_HIPER_MEGA_RED.REGIMENES
	   SET  estado = 0
	   WHERE codRegimen = @codigoRegimen
GO

--/PROC INSERTREGIMENxHOTEL
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.insertRegimenXHotel', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertRegimenXHotel
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertRegimenXHotel
	@codigoRegimen numeric(8),
	@codHotel numeric(8)
AS
	IF(@codigoRegimen != -1 AND @codHotel != -1)
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.REGIMENES_X_HOTEL(codRegimen, codHotel)
	VALUES (@codigoRegimen, @codHotel)
GO

--/PROC DELETEREGIMENxHOTEL
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.deleteRegimenXHotel', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteRegimenXHotel
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteRegimenXHotel
	@codigoRegimen numeric(8),
	@codHotel numeric(8)
AS
	IF(@codigoRegimen != -1 AND @codHotel != -1)
	DELETE COMPUMUNDO_HIPER_MEGA_RED.REGIMENES_X_HOTEL
	WHERE codRegimen = @codigoRegimen AND codHotel = @codHotel
GO

--/PROCEDIMIENTO GET HOTEL BY USUARIO 
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getHotelByUsuario', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHotelByUsuario
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHotelByUsuario
@usuario varchar(50)
AS
	IF(@usuario != '')
	SELECT H.codHotel, H.nombreHotel, H.mail, H.fecCreacion,
		   H.telefono, H.direccionCalle, H.direccionNumero, H.ciudad,
		   H.pais, H.cantEstrellas, H.recargoEstrella
	FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES_X_USUARIO HU 
	JOIN COMPUMUNDO_HIPER_MEGA_RED.HOTELES H ON H.codHotel = HU.codHotel 
	WHERE HU.usr = @usuario  
GO

--/PROCEDIMIENTO GET HOTEL 
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getHotel', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHotel
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHotel
	@codigo numeric(8)
	AS
	--SI RECIBE -1, MUESTRA TODOS LOS HOTELES
	IF (@codigo = -1)
		SELECT H.codHotel, H.nombreHotel, H.mail, H.fecCreacion, H.telefono, H.direccionCalle,
		H.direccionNumero, H.ciudad, H.pais, H.cantEstrellas, H.recargoEstrella 
		FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES H
		ORDER BY H.nombreHotel ASC
	ELSE
		SELECT H.codHotel, H.nombreHotel, H.mail, H.fecCreacion, H.telefono, H.direccionCalle,
		H.direccionNumero, H.ciudad, H.pais, H.cantEstrellas, H.recargoEstrella
		FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES H
		WHERE H.codHotel = @codigo
		ORDER BY H.nombreHotel ASC
GO

--/PROCEDIMIENTO GET HOTEL BY NAME 
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getHotelByName', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHotelByName
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHotelByName
	@nombre varchar(400)
	AS
	--SI RECIBE '', MUESTRA TODOS LOS HOTELES
	IF (@nombre = '')
		SELECT H.codHotel, H.nombreHotel, H.mail, H.fecCreacion, H.telefono, H.direccionCalle,
		H.direccionNumero, H.ciudad, H.pais, H.cantEstrellas, H.recargoEstrella 
		FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES H
		ORDER BY H.nombreHotel ASC
	ELSE
		SELECT H.codHotel, H.nombreHotel, H.mail, H.fecCreacion, H.telefono, H.direccionCalle,
		H.direccionNumero, H.ciudad, H.pais, H.cantEstrellas, H.recargoEstrella
		FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES H
		WHERE H.nombreHotel = @nombre
		ORDER BY H.nombreHotel ASC
GO

--/PROCEDIMIENTO INSERTAR HOTEL 
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.insertHotel', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertHotel
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertHotel
	@nombreHotel varchar(400),
	@mail varchar(50),
	@telefono numeric(20),
	@direccionCalle varchar(100),
	@direccionNumero numeric(18,0),
	@ciudad varchar(100),
	@pais varchar(50),
	@cantEstrellas numeric(18,0),
	@recargoEstrella numeric(18,0)
AS
	IF(@nombreHotel != '' AND @mail != '' AND @telefono != -1 AND @direccionCalle != '' AND
		@direccionNumero != -1 AND @ciudad != '' AND @pais != '' AND @cantEstrellas != -1 AND @recargoEstrella != -1)
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HOTELES (nombreHotel, mail, fecCreacion, telefono, direccionCalle,
								direccionNumero, ciudad, pais, cantEstrellas, recargoEstrella)
	VALUES(UPPER(@nombreHotel), LOWER(@mail), GETDATE(), (CASE WHEN @telefono = -1 THEN NULL ELSE @telefono END), 
		UPPER(@direccionCalle), @direccionNumero, UPPER(@ciudad), 
		UPPER(@pais), @cantEstrellas ,@recargoEstrella)
GO

--/PROCEDIMIENTO DELETE HOTEL (EN REALIDAD CREA UNA INHABILITACION) 
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.deleteHotel', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteHotel
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteHotel
	@codHotel numeric(8),
	@fecInicio datetime,
	@fecFin datetime,
	@motivo varchar(255)
AS
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.INHABILITACIONES(hotel, fecInicio, fecFin, motivo)
	VALUES(@codHotel, @fecInicio, @fecFin, @motivo)
	
	UPDATE COMPUMUNDO_HIPER_MEGA_RED.HOTELES
	SET campoBaja = 0
	WHERE codHotel = @codHotel
GO

--//PROC UPDATEHOTEL
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.updateHotel', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateHotel
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateHotel
	@codHotel	numeric(8),
	@nombreHotel	varchar(400),
	@mail	varchar(50),
	@telefono	numeric(20),
	@direccionCalle	varchar(100),
	@direccionNumero	numeric(18),
	@ciudad	varchar(100),
	@pais	varchar(50),
	@cantEstrellas	numeric(18),
	@recargoEstrella	numeric(18),
	@estado bit
AS
	IF (@codHotel != -1)
	BEGIN
		IF(@nombreHotel != '') 
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HOTELES
				SET nombreHotel = UPPER(@nombreHotel)
					WHERE codHotel= @codHotel
		IF(@mail != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HOTELES
				SET mail = LOWER(@mail)
					WHERE codHotel= @codHotel
		IF(@telefono != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HOTELES
				SET telefono = @telefono
					WHERE codHotel= @codHotel
		IF(@direccionCalle != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HOTELES
				SET direccionCalle = UPPER(@direccionCalle)
					WHERE codHotel= @codHotel
		IF(@direccionNumero != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HOTELES
				SET @direccionNumero = @direccionNumero
					WHERE codHotel= @codHotel
		IF(@ciudad	!= '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HOTELES
				SET ciudad = UPPER(@ciudad)
					WHERE codHotel= @codHotel
		IF(@pais != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HOTELES
				SET pais = UPPER(@pais)
					WHERE codHotel= @codHotel
		IF(@cantEstrellas != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HOTELES
				SET cantEstrellas = @cantEstrellas
					WHERE codHotel= @codHotel
		IF(@recargoEstrella != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HOTELES
				SET recargoEstrella = @recargoEstrella
					WHERE codHotel= @codHotel
		IF(@estado != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HOTELES
				SET campoBaja = @estado
					WHERE codHotel= @codHotel
	END		
GO

--//PROC INSERTHOTELUSUARIO
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.insertHotelUsuario', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertHotelUsuario
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertHotelUsuario
	@usr varchar(50), @nombreHotel varchar(200)
AS
	IF(@usr != '') 
	DECLARE @idHotelBuscado numeric(8)
	SET @idHotelBuscado = (SELECT H.codHotel 
						   FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES H 
						   WHERE H.nombreHotel = @nombreHotel)
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HOTELES_X_USUARIO(usr, codHotel) 
	VALUES (@usr, @idHotelBuscado)
GO

--//PROC DELETEHOTELUSUARIO
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.deleteHotelUsuario', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteHotelUsuario
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteHotelUsuario
	@usr varchar(50), @nombreHotel varchar(200)
AS
	DECLARE @idHotelBuscado numeric(8)
	SET @idHotelBuscado = (SELECT H.codHotel 
						   FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES H 
						   WHERE H.nombreHotel = @nombreHotel)
	DELETE COMPUMUNDO_HIPER_MEGA_RED.HOTELES_X_USUARIO
	WHERE usr = @usr AND codHotel = @idHotelBuscado
GO

--/PROC GETRESERVA 
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getReserva', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getReserva
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getReserva
	@codReserva numeric(18)
	AS
	--SI RECIBE -1, MUESTRA TODOS LAS RESERVAS
	IF (@codReserva = -1)
		SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.RESERVAS R			
	ELSE
		SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.RESERVAS R	
		WHERE R.codReserva = @codReserva
GO

IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.JoinUsrRol', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.JoinUsrRol
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.JoinUsrRol
	@usr varchar(15)
AS
	 IF (@usr IS NULL OR @usr = '')
		SELECT R.nombreRol, R.estado
		FROM COMPUMUNDO_HIPER_MEGA_RED.ROLES_X_USUARIO RU
		JOIN COMPUMUNDO_HIPER_MEGA_RED.ROLES R
			ON RU.nombreRol = R.nombreRol
	ELSE
		SELECT R.nombreRol, R.estado
		FROM COMPUMUNDO_HIPER_MEGA_RED.ROLES_X_USUARIO RU
		JOIN COMPUMUNDO_HIPER_MEGA_RED.ROLES R
			ON RU.nombreRol = R.nombreRol
		WHERE RU.usr = @usr
GO


/*************************************************************************************
 *AUXILIAR PARA CODIGO DE RESERVA
 ************************************************************************************/
IF object_id(N'COMPUMUNDO_HIPER_MEGA_RED.get_ultimoCodigoReserva', N'FN') IS NOT NULL
    DROP FUNCTION COMPUMUNDO_HIPER_MEGA_RED.get_ultimoCodigoReserva
GO
CREATE FUNCTION COMPUMUNDO_HIPER_MEGA_RED.get_ultimoCodigoReserva ()
RETURNS numeric(18)
AS
	BEGIN
		DECLARE @insert_max_codReserva bigint
		DECLARE @max_cod_tblReserva bigint
		SET @max_cod_tblReserva = (SELECT MAX(R.codReserva) FROM COMPUMUNDO_HIPER_MEGA_RED.RESERVAS R)
		DECLARE @max_cod_tblReservaInvalida bigint
		SET @max_cod_tblReservaInvalida = (SELECT MAX(RI.codReserva) FROM COMPUMUNDO_HIPER_MEGA_RED.RESERVASINVALIDAS RI)

		RETURN (CASE WHEN @max_cod_tblReserva > @max_cod_tblReservaInvalida 
					  THEN @max_cod_tblReserva
					  ELSE @max_cod_tblReservaInvalida
				 END) 
	END
GO
 
--/PROC INSERTRESERVA
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.insertReserva', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertReserva
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertReserva
	@idHuesped int,
	@usr varchar(50), 
	@codRegimen numeric(8), 
	@fecDesde datetime, 
	@fecHasta datetime,
	@fecReserva datetime	
AS
	IF(@idHuesped != -1 AND @usr != '' AND
		@codRegimen != -1 AND @fecDesde IS NOT NULL AND @fecHasta IS NOT NULL AND
		@fecReserva IS NOT NULL)
	DECLARE @max_codReservaUltimo bigint
	
	--INSERT EN LA TABLA DE RESERVAS
	SET @max_codReservaUltimo = COMPUMUNDO_HIPER_MEGA_RED.get_ultimoCodigoReserva()
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva,idHuesped, estado, usr, codRegimen, fecDesde, fecHasta, fecReserva)
	VALUES(@max_codReservaUltimo + 1, @idHuesped, '1',@usr, @codRegimen, @fecDesde, @fecHasta, @fecReserva)
GO

--/PROC AGREGARDETALLERESERVA
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.insertDetalleReserva', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertDetalleReserva
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertDetalleReserva
	@codReserva int,
	@codHotel numeric(8),
	@habitacion numeric(4) 
AS
	IF(@codReserva != -1 AND @codHotel != '' AND
		@habitacion != -1)
	
	--INSERT EN LA TABLA DE DETALLE_RESERVAS
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA(codReserva,codHotel, habitacion)
	VALUES(@codReserva, @codHotel,@habitacion)
GO

--/PROC UPDATERESERVA
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.updateReserva', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateReserva
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateReserva
	@codReserva numeric(18),
	@usr varchar(50),
	@estado int,
	@fecInicio		DATETIME,
	@fecFin			DATETIME,
	@fechaReserva	DATETIME,
	@codRegimen		numeric(8),
	@codHotel		numeric(18),
	@habitacion		numeric(4)
AS
	IF(@codReserva != -1)
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.RESERVAS
		SET estado = @estado
		WHERE codReserva = @codReserva
	IF(@codRegimen != -1 AND @codReserva != -1)
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.RESERVAS
		SET codRegimen = @codRegimen
		WHERE codReserva = @codReserva
	IF(@usr != '' AND @codReserva != -1)
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.RESERVAS
		SET usr = @usr
		WHERE codReserva = @codReserva
	IF(@fecInicio IS NOT NULL AND @codReserva != -1)
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.RESERVAS
		SET fecDesde = @fecInicio
		WHERE codReserva = @codReserva
	IF(@fecFin IS NOT NULL AND @codReserva != -1)
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.RESERVAS
		SET fecHasta = @fecFin
		WHERE codReserva = @codReserva
	IF(@fechaReserva IS NOT NULL AND @codReserva != -1)
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.RESERVAS
		SET fecReserva = @fechaReserva
		WHERE codReserva = @codReserva
	IF(@codHotel != -1 AND @codReserva != -1)
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA
		SET codHotel = @codHotel
		WHERE codReserva = @codReserva
	IF(@habitacion != -1 AND @codReserva != -1)
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA
		SET habitacion = @habitacion
		WHERE codReserva = @codReserva
GO



--//PROC CANCELARRESERVA
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.cancelarReserva', 'P' ) IS NOT NULL 
DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.cancelarReserva;
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.cancelarReserva 
	--Toma la fecha del sistema al momento de agregar una cancelacion
	@codReserva		numeric,
	@motivo			varchar,
	@usr			varchar(50),
	@estado			int 
AS 
	IF(@codReserva != -1 AND @motivo != '' AND @usr != '' AND @estado != -1)
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.CANCELACIONES_RESERVA (codReserva, motivo, usr, estado,fecCancelacion)
	VALUES (@codReserva, @motivo, @usr, @estado,GETDATE())
GO

--/PROC GETHUESPED 
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getHuesped', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHuesped
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHuesped
	@idHuesped int
AS
	--SI RECIBE -1, MUESTRA TODOS LOS HUESPEDES
	IF (@idHuesped = -1)
		SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES H			
	ELSE
		SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES H	
		WHERE H.idHuesped = @idHuesped
GO

--/PROC INSERTHUESPED
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.insertHuesped', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertHuesped
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertHuesped
	@tipoDocu	varchar(50),
	@numDocu	numeric(18, 0),
	@nombre	varchar(255),
	@apellido	varchar(255),
	@mail	varchar(255),
	@telefono	numeric(18, 0),
	@direccionCalle	varchar(100),
	@direccionNumero	numeric(18, 0),
	@direccionPiso	numeric(18, 0), --PUEDE SER NULO
	@direccionDepto	varchar(50),	--PUEDE SER NULO
	@localidad	varchar(50),
	@nacionalidad	varchar(255),
	@fecNacimiento	datetime		
AS
	IF(@tipoDocu != '' AND @numDocu != -1 AND @nombre != '' AND @apellido != '' AND
	@mail != '' AND @telefono != -1 AND @direccionCalle != '' AND @direccionNumero != -1)
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES(tipoDocu, numDocu, nombre, apellido,
				mail, telefono, direccionCalle, direccionNumero, direccionPiso, direccionDepto,
				localidad, nacionalidad, fecNacimiento)
	VALUES(UPPER(@tipoDocu), @numDocu, UPPER(@nombre), UPPER(@apellido),
		   LOWER(@mail), (CASE WHEN @telefono = -1 THEN NULL ELSE @telefono END), 
		   UPPER(@direccionCalle), @direccionNumero, 
		   (CASE WHEN @direccionPiso = -1 THEN NULL ELSE @direccionPiso END), CASE WHEN @direccionDepto IS NULL THEN '' ELSE UPPER(@direccionDepto) END,
		   UPPER(@localidad), UPPER(@nacionalidad), @fecNacimiento)
GO
--//PROC DELETEHUESPED
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.deleteHuesped', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteHuesped
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.deleteHuesped
	@idHuesped int	
AS
	UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
	SET campoBaja = 1
	WHERE idHuesped = @idHuesped
GO
--//PROC UPDATEHUESPED
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.updateHuesped', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateHuesped
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateHuesped
	@idHuesped int,
	@nombre varchar(255),
	@apellido varchar(255),
	@tipoDocu varchar(50),
	@numDocu	numeric(18,0),
	@mail varchar(255),
	@telefono numeric(12),
	@direccionCalle varchar(100),
	@direccionNumero numeric(18,0),
	@direccionPiso numeric(18,0), --PUEDE SER NULO
	@direccionDepto varchar(50),  --PUEDE SER NULO
	@fecNacimiento DateTime,
	@localidad varchar(50),
	@nacionalidad varchar(255),
	@campoBaja bit
AS
	IF (@idHuesped != -1)
	BEGIN
		IF(@nombre != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
				SET nombre = UPPER(@nombre)
					WHERE idHuesped = @idHuesped
		IF(@apellido != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
				SET apellido = UPPER(@apellido)   	
					WHERE idHuesped = @idHuesped
		IF(@tipoDocu != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
				SET tipoDocu = UPPER(@tipoDocu)
					WHERE idHuesped = @idHuesped
		IF(@numDocu != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
				SET numDocu = @numDocu
					WHERE idHuesped = @idHuesped
		IF(@mail != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
				SET mail = LOWER(@mail)
					WHERE idHuesped = @idHuesped
		IF(@telefono != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
				SET telefono = @telefono
					WHERE idHuesped = @idHuesped
		IF(@direccionCalle != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
				SET direccionCalle = UPPER(@direccionCalle)
					WHERE idHuesped = @idHuesped
		IF(@direccionNumero != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
				SET direccionNumero = @direccionNumero
					WHERE idHuesped = @idHuesped
		IF(@fecNacimiento IS NOT NULL)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
				SET  fecNacimiento = @fecNacimiento
					WHERE idHuesped = @idHuesped
		IF(@localidad != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
				SET localidad = UPPER(@localidad)
					WHERE idHuesped = @idHuesped
		IF(@nacionalidad != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
				SET nacionalidad = UPPER(@nacionalidad)
					WHERE idHuesped = @idHuesped
		IF(@campoBaja IS NOT NULL)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
				SET campoBaja = @campoBaja
					WHERE idHuesped = @idHuesped
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
			SET direccionPiso = @direccionPiso
				WHERE idHuesped = @idHuesped
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
			SET direccionDepto = UPPER(@direccionDepto) 
				WHERE idHuesped = @idHuesped
	END
GO

--//PROC GETFACTURA
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getFactura', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getFactura
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getFactura
	@numeroFactura numeric(18)
AS
	 IF (@numeroFactura != -1)
		SELECT *
		FROM COMPUMUNDO_HIPER_MEGA_RED.FACTURAS F
		WHERE F.numeroFactura = @numeroFactura 
	 ELSE
		SELECT *
		FROM COMPUMUNDO_HIPER_MEGA_RED.FACTURAS  
GO
--//PROC GETFACTURA_RESERVA
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getFacturaReserva', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getFacturaReserva
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getFacturaReserva
	@codReserva numeric(18)
AS
	SELECT *
	FROM COMPUMUNDO_HIPER_MEGA_RED.FACTURAS F
	WHERE F.codReserva = @codReserva
GO
--//PROC GETFACTURAS_CLIENTE
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getFacturasCliente', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getFacturasCliente
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getFacturasCliente
	@idHuesped int
AS
	SELECT *
	FROM COMPUMUNDO_HIPER_MEGA_RED.FACTURAS F
	WHERE F.idHuesped = @idHuesped
GO


/************************************************************************************************************
 *AUXILIARES CALCULO DE RECARGOS
 ***********************************************************************************************************/
IF object_id(N'COMPUMUNDO_HIPER_MEGA_RED.reservaEs_allInclusive', N'FN') IS NOT NULL
    DROP FUNCTION COMPUMUNDO_HIPER_MEGA_RED.reservaEs_allInclusive
GO
CREATE FUNCTION COMPUMUNDO_HIPER_MEGA_RED.reservaEs_allInclusive (@codReserva	numeric(18))
RETURNS int
AS
	BEGIN
	DECLARE @resultado int
	SET @resultado = (SELECT COUNT(*) FROM COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA DR
						JOIN COMPUMUNDO_HIPER_MEGA_RED.RESERVAS R ON R.codReserva = DR.codReserva
						WHERE DR.codReserva = @codReserva AND R.codRegimen = 4)
	
	RETURN @resultado				
	END	
GO

IF object_id(N'COMPUMUNDO_HIPER_MEGA_RED.totalConsumibles', N'FN') IS NOT NULL
    DROP FUNCTION COMPUMUNDO_HIPER_MEGA_RED.totalConsumibles
GO
CREATE FUNCTION COMPUMUNDO_HIPER_MEGA_RED.totalConsumibles (@codReserva	numeric(18))
RETURNS numeric(18,2)
AS
	BEGIN
	RETURN (SELECT SUM(CE.cantidad*C.importe) 
			FROM COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA CE
			JOIN COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES C ON C.codConsumible = CE.codConsumible 
			WHERE CE.codReserva = @codReserva)
	END
GO

IF object_id(N'COMPUMUNDO_HIPER_MEGA_RED.recargoEstrella', N'FN') IS NOT NULL
    DROP FUNCTION COMPUMUNDO_HIPER_MEGA_RED.recargoEstrella
GO
CREATE FUNCTION COMPUMUNDO_HIPER_MEGA_RED.recargoEstrella (@codReserva	numeric(18))
RETURNS numeric(2)
AS
	BEGIN
	DECLARE @recargoEstrella numeric(18)
	SET @recargoEstrella =	(SELECT (H.recargoEstrella * H.cantEstrellas) 
							FROM COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA DR
							JOIN COMPUMUNDO_HIPER_MEGA_RED.HOTELES H ON H.codHotel = DR.codHotel
							WHERE DR.codReserva = @codReserva)
	RETURN @recargoEstrella
	END
GO

IF object_id(N'COMPUMUNDO_HIPER_MEGA_RED.precioRegimen', N'FN') IS NOT NULL
    DROP FUNCTION COMPUMUNDO_HIPER_MEGA_RED.precioRegimen
GO
CREATE FUNCTION COMPUMUNDO_HIPER_MEGA_RED.precioRegimen (@codReserva numeric(18))
RETURNS numeric(3,2)
AS
	BEGIN	
		DECLARE @precioRegimen numeric(18,2)
		SET @precioRegimen = (SELECT REG.precio FROM COMPUMUNDO_HIPER_MEGA_RED.REGIMENES REG
							 JOIN COMPUMUNDO_HIPER_MEGA_RED.RESERVAS RES ON RES.codRegimen = REG.codRegimen
							 WHERE RES.codReserva = @codReserva)
		RETURN @precioRegimen
	END
GO

IF object_id(N'COMPUMUNDO_HIPER_MEGA_RED.porcentualHabitacion', N'FN') IS NOT NULL
    DROP FUNCTION COMPUMUNDO_HIPER_MEGA_RED.porcentualHabitacion
GO
CREATE FUNCTION COMPUMUNDO_HIPER_MEGA_RED.porcentualHabitacion(@codReserva	numeric(18))
RETURNS numeric(2,2)
AS
	BEGIN
		DECLARE @porcentualHabitacionTipo numeric(5,2)
		SET @porcentualHabitacionTipo = (SELECT DISTINCT TH.tipoPorcentual 
				FROM COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA DR
				JOIN COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES H ON DR.codHotel = H.codHotel
				JOIN COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES ON DR.habitacion = H.habitacion
				JOIN COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES TH ON TH.tipoCodigo = H.tipoCodigo
		WHERE DR.codReserva = @codReserva)
		RETURN @porcentualHabitacionTipo
	END
GO
/************************************************************************************************************/	

/******************************************************
 *AUXILIAR PARA NUMERO DE FACTURA
 ******************************************************/
IF object_id(N'COMPUMUNDO_HIPER_MEGA_RED.get_ultimoNumeroFactura', N'FN') IS NOT NULL
    DROP FUNCTION COMPUMUNDO_HIPER_MEGA_RED.get_ultimoNumeroFactura
GO
CREATE FUNCTION COMPUMUNDO_HIPER_MEGA_RED.get_ultimoNumeroFactura ()
RETURNS numeric(18)
AS
	BEGIN
		DECLARE @max_numFactura_tblFacturas numeric(18)
		SET @max_numFactura_tblFacturas = (SELECT MAX(F.numeroFactura) FROM COMPUMUNDO_HIPER_MEGA_RED.FACTURAS F)
		DECLARE @max_numFactura_tblFacturasInvalidas numeric(18)
		SET @max_numFactura_tblFacturasInvalidas = (SELECT MAX(FI.numeroFactura) FROM COMPUMUNDO_HIPER_MEGA_RED.FACTURAS_INVALIDAS FI)

		RETURN (CASE WHEN @max_numFactura_tblFacturas > @max_numFactura_tblFacturasInvalidas 
					  THEN @max_numFactura_tblFacturas
					  ELSE @max_numFactura_tblFacturasInvalidas
				 END) 
	END
GO

--/PROC INSERTITEMFACTURA
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.insertItemFactura', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertItemFactura
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertItemFactura
	@numeroFactura  numeric(18),
	@codReserva		numeric(18)     
AS
	DECLARE @nroItem numeric(18)
	SET @nroItem = 1 
	
	IF(@numeroFactura != -1 AND @codReserva != -1)
	BEGIN
		--Guardo primero RECARGOS
		DECLARE @totalRecargos numeric(18,2)
		SET @totalRecargos = COMPUMUNDO_HIPER_MEGA_RED.precioRegimen(@codReserva)*COMPUMUNDO_HIPER_MEGA_RED.porcentualHabitacion(@codReserva)
							+ COMPUMUNDO_HIPER_MEGA_RED.recargoEstrella(@codReserva)
		INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA(numeroFactura, numeroItem, cantidad, montoUnitario, montoTotal, descripcion)
		VALUES(@numeroFactura, @nroItem, 1, @totalRecargos, @totalRecargos, 'Recargos de Categoria Hotel y Régimen')
		
		--Guardo los consumibles
		INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA(numeroFactura, numeroItem, cantidad, montoUnitario, montoTotal, descripcion)
		SELECT DISTINCT @numeroFactura, @nroItem + 1, CE.cantidad, C.importe, CE.cantidad * C.importe, UPPER(C.descripcion)
		FROM COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA CE
		JOIN COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES C ON C.codConsumible = CE.codConsumible
		
		SET @nroItem = @nroItem + 1
		--Si la reserva es All Inclusive, agrego un item más detallando que no se considera recargo de consumibles
		DECLARE @esAllInclusive int
		SET @esAllInclusive = COMPUMUNDO_HIPER_MEGA_RED.reservaEs_allInclusive(@codReserva)
		IF(@esAllInclusive > 0)
			BEGIN	
				DECLARE @totalConsumiblesDescontar numeric(18,2)
				SET @totalConsumiblesDescontar = COMPUMUNDO_HIPER_MEGA_RED.totalConsumibles(@codReserva)
			
				INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA(numeroFactura, numeroItem, cantidad, montoUnitario, montoTotal, descripcion)
				VALUES(@numeroFactura, @nroItem, 1, @totalConsumiblesDescontar, @totalConsumiblesDescontar, 'Descuento por Régimen de Estadía')
			END
	END
GO


--//AGREGA DETALLE SOBRE FACTURAS DE RESERVAS CON REGIMEN ALL INCLUSIVE
	/*Step 1: Declare variables to hold the output from the cursor.*/
	DECLARE @numeroFactura numeric(18);
	DECLARE @codReserva numeric(18);
	
	/*Step 2: Declare the cursor object*/
	DECLARE @Cursor_allInclusive as CURSOR;
	
	/*Step 3: Assign the query to the cursor.*/
	SET @Cursor_allInclusive = CURSOR FOR
		SELECT DISTINCT F.numeroFactura,  R.codReserva
		FROM COMPUMUNDO_HIPER_MEGA_RED.FACTURAS F
		JOIN COMPUMUNDO_HIPER_MEGA_RED.RESERVAS R ON R.codReserva = F.codReserva
		WHERE R.codRegimen = 4
		GROUP BY F.numeroFactura, R.codReserva
		ORDER BY F.numeroFactura, R.codReserva
	
	/*Step 4: Open the cursor.*/
	OPEN @Cursor_allInclusive
		/*Step 5: Fetch the first row.*/
		FETCH NEXT FROM @Cursor_allInclusive INTO @numeroFactura, @codReserva;
		/*Step 6: Loop until there are no more results. */
		WHILE @@FETCH_STATUS = 0
			BEGIN
			DECLARE @nroItem numeric(18)
			SET @nroItem = COMPUMUNDO_HIPER_MEGA_RED.get_ultimoItemFactura(@numeroFactura) + 1
			
			DECLARE @totalConsumiblesDescontar numeric(18,2)
			SET @totalConsumiblesDescontar = COMPUMUNDO_HIPER_MEGA_RED.totalConsumibles(@codReserva)
			
			--Agrego item que detalla el descuento por tener Regimen All Inclusive
			INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA(numeroFactura, numeroItem, cantidad, montoUnitario, montoTotal, descripcion)
			VALUES(@numeroFactura, @nroItem, 1, @totalConsumiblesDescontar, @totalConsumiblesDescontar, 'Descuento por Régimen de Estadía')

			--Update sobre la factura para reflejar el descuento
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.FACTURAS
			SET montoTotal = montoTotal - @totalConsumiblesDescontar
			WHERE numeroFactura = @numeroFactura
			
			
			FETCH NEXT FROM @Cursor_allInclusive INTO @numeroFactura, @codReserva;
		END
	/*Step 7: Close the cursor.*/
	CLOSE @Cursor_allInclusive
	/*Step 7: Deallocate the cursor to free up any memory or open result sets.*/
	DEALLOCATE @Cursor_allInclusive
GO

--//PROC FACTURAR
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.facturar', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.facturar
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.facturar
	@codReserva	numeric(18),
	@tipoPago	varchar(50),
	@codTarjetaCredito	varchar(19)
AS
	IF(@codReserva != -1 AND @tipoPago != '' AND @codTarjetaCredito != '')
	BEGIN
		DECLARE @totalConsumibles numeric(18,2)
		SET @totalConsumibles = COMPUMUNDO_HIPER_MEGA_RED.totalConsumibles(@codReserva)
		
		DECLARE @recargoEstrella numeric(18)
		SET @recargoEstrella = COMPUMUNDO_HIPER_MEGA_RED.recargoEstrella(@codReserva)

		DECLARE @precioRegimen numeric(3,2)
		SET @precioRegimen = COMPUMUNDO_HIPER_MEGA_RED.precioRegimen (@codReserva)
		
		DECLARE @porcentualHabitacionTipo numeric(2,2)
		SET @porcentualHabitacionTipo = COMPUMUNDO_HIPER_MEGA_RED.porcentualHabitacion (@codReserva)
		
		DECLARE @totalRegimenHabitacion numeric(18,2)
		SET @totalRegimenHabitacion = @precioRegimen * @porcentualHabitacionTipo
		
		DECLARE @montoTotal numeric(18,2)
		DECLARE @es_allInclusive int
		SET @es_allInclusive = COMPUMUNDO_HIPER_MEGA_RED.reservaEs_allInclusive(@codReserva)

		IF(@es_allInclusive > 0)
			SET @montoTotal = @totalRegimenHabitacion + @recargoEstrella
		ELSE
			SET @montoTotal = @totalConsumibles + @totalRegimenHabitacion + @recargoEstrella
		
		DECLARE @idHuesped int
		SET @idHuesped = (SELECT R.idHuesped FROM COMPUMUNDO_HIPER_MEGA_RED.RESERVAS R
							WHERE R.codReserva = @codReserva)
		
		/*INSERTO EN LA TABLA FACTURA*/
		DECLARE @numeroFactura  numeric(18)
		SET @numeroFactura = COMPUMUNDO_HIPER_MEGA_RED.get_ultimoNumeroFactura()
		SET @numeroFactura = @numeroFactura + 1
		
		INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.FACTURAS(numeroFactura, codReserva, fecha, idHuesped, montoTotal, tipoPago, codTarjetaCredito)
		VALUES(@numeroFactura,@codReserva, GETDATE(), @idHuesped, @montoTotal, @tipoPago, CASE WHEN @tipoPago LIKE 'Efectivo' THEN '' ELSE @codTarjetaCredito END)
		
		--INSERT EN LA TABLA ITEMS_FACTURA
		EXEC COMPUMUNDO_HIPER_MEGA_RED.insertItemFactura @numeroFactura, @codReserva
	
	END
GO

--/PROC INSERTESTADIA
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.insertEstadia', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertEstadia
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertEstadia
	@codReserva numeric(18),
	@usr varchar(50)		
AS
	IF(@codReserva != -1 AND @usr != '')
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ESTADIA(codReserva, usrIngreso, fecIngreso)
	VALUES(@codReserva, @usr, CURRENT_TIMESTAMP)
GO
--/PROC UPDATEESTADIA
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.updateEstadia', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateEstadia
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateEstadia
	@codReserva numeric(18),
	@usr varchar(50)		
AS
	IF(@codReserva != -1)
	BEGIN
		IF(@usr != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.ESTADIA
				SET usrEgreso = @usr 
					WHERE codReserva = @codReserva
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.ESTADIA
			SET fecEgreso = CURRENT_TIMESTAMP
				WHERE codReserva = @codReserva
	END
GO

--/PROC AGREGAR CONSUMIBLE A UNA ESTADIA
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.agregarConsumible', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.agregarConsumible
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.agregarConsumible
	@codReserva numeric(18),
	@codConsumible numeric(18), @cantidad numeric(3)		
AS
	IF(@codConsumible != -1 AND @codReserva != -1 AND @cantidad != -1)
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA(codReserva, codConsumible, cantidad)
	VALUES(@codReserva, @codConsumible, @cantidad)
GO

--/PROC GETCONSUMIBLES
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getConsumibles', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getConsumibles
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getConsumibles
	@codConsumible numeric(18)		
AS
	IF (@codConsumible = -1)
		SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES C
	ELSE
		SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES C WHERE C.codConsumible = @codConsumible

GO

--/PROC INSERTCONSUMIBLE 
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.insertConsumible', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertConsumible
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.insertConsumible
	@descripcion varchar(255),
	@importe numeric(18,2)
AS
	IF(@descripcion != '' AND @importe != -1)
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES(descripcion, importe)
	VALUES (UPPER(@descripcion), @importe)
GO

--//PROC UPDATECONSUMIBLE
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.updateConsumible', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateConsumible
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.updateConsumible
	@codConsumible numeric(18,0),
	@descripcion varchar(255),
	@importe numeric(18,2)
AS
	IF (@codConsumible != -1)
	BEGIN
		IF(@descripcion != '')
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES
				SET descripcion = UPPER(@descripcion)
					WHERE codConsumible = @codConsumible
		IF(@importe != -1)
			UPDATE COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES
				SET importe = @importe
					WHERE codConsumible = @codConsumible
	END
GO
/*****************************************************************************************
*LISTADO ESTADISTICO
*****************************************************************************************/
--/PROC GETHOTELESMAYORDIASINHABILITADO

IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getHotelesMayorDiasInhabilitado', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHotelesMayorDiasInhabilitado
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHotelesMayorDiasInhabilitado
	@opcion  numeric(1),
	@anio	 numeric(4)
	--1 Enero a Marzo
	--2 Abril a Junio
	--3 Julio a Septiembre
	--4 Octubre a Diciembre
	--5 El año 
	/* LOS 5 HOTELES CON MAS DIAS INHABILITADOS*/    
AS
	DECLARE @iniPeriodo int
	SET @iniPeriodo =  (CASE @opcion
							   WHEN 1 | 5 THEN 1
							   WHEN 2 THEN 4
							   WHEN 3 THEN 7
							   WHEN 4 THEN 10
						  END )
	DECLARE @finPeriodo int
	SET @iniPeriodo =  (CASE @opcion
						   WHEN 1 THEN 3
						   WHEN 2 THEN 6
						   WHEN 3 THEN 9
						   WHEN 4 | 5 THEN 12
						END )
	
	SELECT TOP 5 (I.hotel) AS Hotel, SUM(DATEDIFF(day,I.fecInicio,I.fecFin)) as Dias FROM COMPUMUNDO_HIPER_MEGA_RED.INHABILITACIONES I
	
	WHERE MONTH (I.fecInicio) BETWEEN @iniPeriodo AND @iniPeriodo
		   AND YEAR (I.fecInicio) = @anio
			 	
	GROUP BY I.hotel
	
	ORDER BY 2 DESC
GO


--/PROC GETHOTELESMAYORCANCELACIONES
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getHotelesMayorCancelaciones', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHotelesMayorCancelaciones
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHotelesMayorCancelaciones
	@opcion  numeric(1),
	@anio	 numeric(4)
	--1 Enero a Marzo
	--2 Abril a Junio
	--3 Julio a Septiembre
	--4 Octubre a Diciembre
	--5 El año 
	/* LOS 5 HOTELES CON MAS CANCELACIONES*/    
AS
	DECLARE @iniPeriodo int
	SET @iniPeriodo =  (CASE @opcion
							   WHEN 1 | 5 THEN 1
							   WHEN 2 THEN 4
							   WHEN 3 THEN 7
							   WHEN 4 THEN 10
						  END )
	DECLARE @finPeriodo int
	SET @iniPeriodo =  (CASE @opcion
						   WHEN 1 THEN 3
						   WHEN 2 THEN 6
						   WHEN 3 THEN 9
						   WHEN 4 | 5 THEN 12
						END )
						
	SELECT TOP 5 (DR.codHotel) AS codHotel, H.nombreHotel, COUNT(H.codHotel) AS Cancelaciones 
	FROM COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA DR
	
	JOIN COMPUMUNDO_HIPER_MEGA_RED.CANCELACIONES_RESERVA C ON C.codReserva = DR.codReserva
	JOIN COMPUMUNDO_HIPER_MEGA_RED.HOTELES H ON H.codHotel = DR.codHotel
	
	WHERE MONTH (C.fecCancelacion) BETWEEN @iniPeriodo AND @iniPeriodo
		   AND YEAR (C.fecCancelacion) = @anio
	
	GROUP BY DR.codHotel, H.nombreHotel
	
	ORDER BY 3 DESC
GO


--/PROC GETHOTELESMAYORCONSUMIBLESFACTURADOS
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getHotelesMayorConsumiblesFacturados', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHotelesMayorConsumiblesFacturados
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHotelesMayorConsumiblesFacturados
	@opcion  numeric(1),
	@anio	 numeric(4)
	--1 Enero a Marzo
	--2 Abril a Junio
	--3 Julio a Septiembre
	--4 Octubre a Diciembre
	--5 El año 
	/* LOS 5 HOTELES CON MAS CANTIDAD DE CONSUMIBLES FACTURADOS*/    
AS

	DECLARE @iniPeriodo int
	SET @iniPeriodo =  (CASE @opcion
							   WHEN 1 | 5 THEN 1
							   WHEN 2 THEN 4
							   WHEN 3 THEN 7
							   WHEN 4 THEN 10
						  END )
	DECLARE @finPeriodo int
	SET @iniPeriodo =  (CASE @opcion
						   WHEN 1 THEN 3
						   WHEN 2 THEN 6
						   WHEN 3 THEN 9
						   WHEN 4 | 5 THEN 12
						END )
						
	SELECT TOP 5 (DR.codHotel) AS codHotel, H.nombreHotel, SUM(CE.cantidad) AS Cantidad_Consumibles_Facturados 
					FROM COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA CE
	
	JOIN COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA DR ON DR.codReserva = CE.codReserva
    JOIN COMPUMUNDO_HIPER_MEGA_RED.HOTELES H ON H.codHotel = DR.codHotel
    JOIN COMPUMUNDO_HIPER_MEGA_RED.ESTADIA E ON E.codReserva = CE.codReserva
	
	WHERE MONTH (E.fecIngreso) BETWEEN @iniPeriodo AND @iniPeriodo
		   AND YEAR (E.fecIngreso) = @anio
							 	
	GROUP BY DR.codHotel, H.nombreHotel
	
	ORDER BY 3 DESC
GO

--/PROC GETHABITACIONESMAYORCANTOCUPADAS
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getHabitacionesMayorCantOcupadas', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHabitacionesMayorCantOcupadas
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getHabitacionesMayorCantOcupadas
	@opcion  numeric(1),
	@anio	 numeric(4)
	--1 Enero a Marzo
	--2 Abril a Junio
	--3 Julio a Septiembre
	--4 Octubre a Diciembre
	--5 El año 
	/* LAS 5 HABITACIONES CON MAYOR CANTIDAD DE DÍAS OCUPADAS*/    
AS

	DECLARE @iniPeriodo int
	SET @iniPeriodo =  (CASE @opcion
							   WHEN 1 | 5 THEN 1
							   WHEN 2 THEN 4
							   WHEN 3 THEN 7
							   WHEN 4 THEN 10
						  END )
	DECLARE @finPeriodo int
	SET @iniPeriodo =  (CASE @opcion
						   WHEN 1 THEN 3
						   WHEN 2 THEN 6
						   WHEN 3 THEN 9
						   WHEN 4 | 5 THEN 12
						END )
	
	SELECT DISTINCT TOP 5 (DR.habitacion) AS Habitacion, DR.codHotel, H.nombreHotel, 
						  SUM(DATEDIFF(day,E.fecIngreso,E.fecEgreso))  AS Cantidad_Dias_Ocupado,
						  COUNT(DR.Habitacion) as Veces_Ocupado
	FROM COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA DR
	
	JOIN COMPUMUNDO_HIPER_MEGA_RED.ESTADIA E ON E.codReserva = DR.codReserva
	JOIN COMPUMUNDO_HIPER_MEGA_RED.HOTELES H ON H.codHotel = DR.codHotel
	
	WHERE MONTH (E.fecIngreso) BETWEEN @iniPeriodo AND @iniPeriodo
		   AND YEAR (E.fecIngreso) = @anio
							 	
	GROUP BY DR.habitacion, DR.codHotel, H.nombreHotel
	
	ORDER BY 4 DESC
GO


--/PROC GETMEJORCLIENTE
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.getMejorCliente', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getMejorCliente
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.getMejorCliente
	@opcion  int,
	@anio	 int
	--1 Enero a Marzo
	--2 Abril a Junio
	--3 Julio a Septiembre
	--4 Octubre a Diciembre
	--5 El año 
	/* LAS 5 HABITACIONES CON MAYOR CANTIDAD DE DÍAS OCUPADAS*/    
AS

	DECLARE @iniPeriodo int
	SET @iniPeriodo =  (CASE @opcion
							   WHEN 1 | 5 THEN 1
							   WHEN 2 THEN 4
							   WHEN 3 THEN 7
							   WHEN 4 THEN 10
					  END )
	DECLARE @finPeriodo int
	SET @iniPeriodo =  (CASE @opcion
						   WHEN 1 THEN 3
						   WHEN 2 THEN 6
						   WHEN 3 THEN 9
						   WHEN 4 | 5 THEN 12
				    END )
				    
	SELECT DISTINCT TOP 5 (HUES.idHuesped) AS idHuesped, HUES.Apellido, HUES.Nombre,
						SUM(CASE WHEN ITEMS.descripcion LIKE 'Recargos%' THEN ITEMS.montoTotal / 10 ELSE ITEMS.montoTotal / 5  END)  AS Puntos_Acumulados
					 FROM COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA ITEMS
		
	 JOIN COMPUMUNDO_HIPER_MEGA_RED.FACTURAS F ON F.numeroFactura = ITEMS.numeroFactura
	 JOIN COMPUMUNDO_HIPER_MEGA_RED.RESERVAS R ON R.codReserva = F.codReserva
	 JOIN COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES HUES ON HUES.idHuesped = R.idHuesped

	 WHERE MONTH (F.fecha) BETWEEN @iniPeriodo AND @iniPeriodo
		   AND YEAR (F.fecha) = @anio
							 	
	GROUP BY HUES.idHuesped, HUES.Apellido, HUES.Nombre
	
	ORDER BY 4 DESC			 
GO

--Procedure Auxiliar para chequear si el hotel se puede dar de baja
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.hotelEstaVacio', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.hotelEstaVacio
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.hotelEstaVacio
@hotel	int,
@inicio datetime,
@fin	datetime
AS
BEGIN
	DECLARE @Cantidad int
	
	SET @Cantidad = (	SELECT COUNT(*) 
						FROM COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA r
						WHERE r.codHotel = @hotel
						AND EXISTS (SELECT * 
									FROM COMPUMUNDO_HIPER_MEGA_RED.RESERVAS reserva
									WHERE R.codReserva = reserva.codReserva
									AND ((reserva.fecDesde BETWEEN @inicio AND @fin)
									OR reserva.fecHasta BETWEEN @inicio AND @fin)))
	IF(@Cantidad > 0)
		RETURN 0
	ELSE
		RETURN 1	
	
END
GO