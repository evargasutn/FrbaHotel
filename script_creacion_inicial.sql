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
--/*	
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.REGIMENES_X_HOTEL') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.REGIMENES_X_HOTEL;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.REGIMENES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.REGIMENES;
				
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.CANCELACIONES_RESERVA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.CANCELACIONES_RESERVA;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.HOTELES_X_USUARIO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.HOTELES_X_USUARIO;
				
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.INHABILITACIONES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.INHABILITACIONES;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.HOTELES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.HOTELES;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA;
				
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA;
				IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.FACTURAS') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.FACTURAS;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.ESTADIA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.ESTADIA;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.RESERVAS') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.RESERVAS;
		
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

-- CREACION DE TABLAS

create table COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
(
	usr							varchar(50) PRIMARY KEY,
	password					varchar(50) not null, 
	nombre						varchar(50) not null,
	apellido					varchar(50) not null,
	contador_intentos_login		numeric(1,0) default 0, -- 3 intentos
	tipoDocu					numeric(8) not null,
	numDocu						numeric(18) not null,
	mail						varchar(50),
	telefono					numeric(12),
	direccionCalle				varchar(50) not null,
	direccionNumero				numeric(8) not null,
	direccionPiso				numeric(2),
	DireccionDepto				varchar(2),
	FecNacimiento				DateTime not null,
	campoBaja					bit	not null default 0
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
	tipoDocu			numeric(8) not null,
	numDocu				numeric(18) not null,
	nombre				varchar(50) not null,
	apellido			varchar(50) not null,
	mail				varchar(50),
	telefono			numeric(12),
	direccionCalle		varchar(50) not null,
	direccionNumero		numeric(8) not null,
	direccionPiso		numeric(2),
	DireccionDepto		varchar(2),
	localidad			varchar(50) not null,
	paisOrigen			varchar(50) not null,
	nacionalidad		varchar(50) not null,
	fecNacimiento		datetime not null,
	campo_baja			bit	not null default 0
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.RESERVAS
(
	codReserva	numeric(18) PRIMARY KEY,
	idHuesped	int FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES(idHuesped),
	usr			varchar(50) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.USUARIOS(usr),
	fecDesde	datetime,
	fecHasta	datetime,
	fecReserva	datetime
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.CANCELACIONES_RESERVA
(
	codReserva		numeric(18) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva),
	motivo			varchar(255) not null,
	fecCancelacion	datetime not null,
	usr				varchar(50) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.USUARIOS(usr),
	PRIMARY KEY (codReserva)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.HOTELES
(
	codHotel		numeric(8) identity(1,1) PRIMARY KEY,
	nombreHotel		varchar(50) not null default 'A',
	mail			varchar(50) default '',
	fecCreacion		datetime not null default GETDATE(),
	telefono		numeric(20) not null default '11111111',
	direccionCalle	varchar(50) not null,
	direccionNumero	numeric(8) not null,
	ciudad			varchar(50) not null default 'Buenos Aires',
	pais			varchar(50) not null default 'Argentina',
	cantEstrellas	numeric(1) not null
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

create table COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES
(
	codHotel		numeric(8),
	nombreHotel		varchar(50) not null,
	habitacion		numeric(4) PRIMARY KEY,
	piso			numeric(2),
	ubicacion		varchar(255) not null,
	tipoHabitacion	varchar(50) not null,
	descripcion		varchar(255) not null,
	campoBaja		bit	not null default 0,
)
go
ALTER TABLE COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES ADD CONSTRAINT Fk_Habitacion_Hotel FOREIGN KEY (codHotel) REFERENCES COMPUMUNDO_HIPER_MEGA_RED.HOTELES(codHotel);

create table COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA
(
	codReserva	numeric(18)FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva),
	codHotel	numeric(8) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.HOTELES(codHotel),
	habitacion	numeric(4) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES(habitacion),
	codRegimen	numeric(8) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.REGIMENES(codRegimen),
	PRIMARY KEY (codReserva, habitacion, codHotel)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.ESTADIA
(
	codReserva	numeric(18) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva),
	fecIngreso	datetime not null,
	usrIngreso	varchar(50) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.USUARIOS(usr),
	fecEgreso	datetime not null,
	usrEgreso	varchar(50) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.USUARIOS(usr),
	PRIMARY KEY (codReserva)
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
	numeroFactura	numeric(8) identity(1,1) PRIMARY KEY,
	codReserva		numeric(18) not null FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva),
	fecha			datetime not null,
	montoTotal		numeric(18,2) not null,
	idHuesped 		int not null FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES(idHuesped)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA
(
	numeroFactura	numeric(8) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.FACTURAS(numeroFactura),
	numeroItem		numeric(5) not null,
	descripcion		varchar(255) not null,
	monto			numeric(18,2) not null,
	PRIMARY KEY (numeroFactura, numeroItem)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.REGIMENES_X_HOTEL
(
	codHotel		numeric(8) not null FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.HOTELES(codHotel),
	codRegimen		numeric(8) not null FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.REGIMENES(codRegimen),
	PRIMARY KEY (codHotel, codRegimen)	
)
go

/** 
 ** MIGRACION
 **/
 	
--//USUARIO, Administrador	
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.USUARIOS (usr,password, nombre, apellido, tipoDocu, numDocu, direccionCalle, direccionNumero, FecNacimiento) 
/*Agrego un apellido para que no me chille por estar en NULL*/
	VALUES 	('admin','w23e','Administrador General', 'Gerez', 'DNI', '24264123', 'Av. Cordoba', '8834', '17/04/1981')
GO
	
--//ROL
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ROLES (nombreRol) 
	VALUES ('Administrador'),
		   ('Recepcionista'),
		   ('Guest')
GO	
	   
--//ROLES_X_USUARIO, CARGA PARA USR: Administrador
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ROLES_X_USUARIO (nombreRol, usr) 
	VALUES ('Administrador','admin')
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

--//ROL_FUNCIONALIDADES
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES_X_ROL (nombreRol, idFuncionalidad) 
	VALUES 	('Administrador','1'), 
			('Administrador','2'), 
			('Administrador','3'), 
			('Administrador','4'), 
			('Administrador','5'), 
			('Administrador','6'), 
			('Administrador','7'), 
			('Administrador','8'), 
			('Administrador','9'),
			('Administrador','10'),
			('Administrador','11'), 
			('Administrador','12'), 
			('Recepcionista','3'), 
			('Recepcionista','7'), 
			('Recepcionista','8'), 
			('Recepcionista','9'),
			('Guest','7'), 
			('Guest','8')
GO


/*Migracion de Regimenes no hace falta usar Cursor*/
/*
--//REGIMENES - MIGRACION DE DATOS USANDO CURSOR PARA GENERAR CODREGIMEN
	/*Step 1: Declare variables to hold the output from the cursor.*/
	DECLARE @descripcion as varchar(255);
	DECLARE @precio as numeric(18,2);
	DECLARE @codRegimen as numeric(2);
	SET @codRegimen = '00';
	
	/*Step 2: Declare the cursor object*/
	DECLARE @Cursor_Regimen as CURSOR;
	
	/*Step 3: Assign the query to the cursor.*/
	SET @Cursor_Regimen = CURSOR FOR
		SELECT DISTINCT Regimen_Descripcion, Regimen_Precio
		FROM  gd_esquema.Maestra
		WHERE Regimen_Descripcion IS NOT NULL
	
	/*Step 4: Open the cursor.*/
	OPEN @Cursor_Regimen
		/*Step 5: Fetch the first row.*/
		FETCH NEXT FROM @Cursor_Regimen INTO @descripcion, @precio;
		/*Step 6: Loop until there are no more results. */
		WHILE @@FETCH_STATUS = 0
			BEGIN
				SET @codRegimen = @codRegimen+1;
				INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.REGIMENES(codRegimen, descripcion, precio)
				VALUES (@codRegimen, @descripcion, @precio)
			FETCH NEXT FROM @Cursor_Regimen INTO @descripcion, @precio;
		END
	/*Step 7: Close the cursor.*/
	CLOSE @Cursor_Regimen
	/*Step 7: Deallocate the cursor to free up any memory or open result sets.*/
	DEALLOCATE @Cursor_Regimen
GO*/	
	
--//REGIMENES
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.REGIMENES(descripcion, precio)
	SELECT DISTINCT Regimen_Descripcion, Regimen_Precio
	FROM  gd_esquema.Maestra
	WHERE Regimen_Descripcion IS NOT NULL
GO
		
--//HOTELES
/*No es posible tomar nombreHotel como PK porque en la tabla maestra no estan los nombres de los hoteles*/
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HOTELES(direccionCalle, direccionNumero, ciudad, cantEstrellas)
	SELECT DISTINCT Hotel_Calle, Hotel_Nro_Calle, Hotel_Ciudad, Hotel_CantEstrella
	FROM  gd_esquema.Maestra
	WHERE Hotel_Calle IS NOT NULL
GO