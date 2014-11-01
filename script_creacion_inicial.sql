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
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.HOTELES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.HOTELES;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA_INVALIDA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA_INVALIDA;
				
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA_INVALIDA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA_INVALIDA;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.FACTURAS') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.FACTURAS;
				
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.FACTURAS_INVALIDAS') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.FACTURAS_INVALIDAS;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.ESTADIA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.ESTADIA;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.ESTADIA_INVALIDA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.ESTADIA_INVALIDA;
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.RESERVAS') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.RESERVAS;

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
	password					varchar(50) not null, 
	nombre						varchar(255) not null,
	apellido					varchar(255) not null,
	contador_intentos_login		numeric(1,0) default 0, -- 3 intentos
	tipoDocu					varchar(50) not null default 'DNI',
	numDocu						numeric(18,0) not null,
	mail						varchar(255),
	telefono					numeric(12),
	direccionCalle				varchar(255) not null,
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
	direccionCalle		varchar(255) not null,
	direccionNumero		numeric(18,0) not null,
	direccionPiso		numeric(18,0),
	direccionDepto		varchar(50),
	localidad			varchar(50) not null,
	nacionalidad		varchar(255) not null,
	fecNacimiento		datetime not null,
	campoBaja			bit	not null default 0
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

create table COMPUMUNDO_HIPER_MEGA_RED.RESERVASINVALIDAS
(
	codReserva	numeric(18),
	idHuesped	int,
	usr			varchar(50),
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
	fecCreacion		datetime not null,
	telefono		numeric(20) not null default '11111111',
	direccionCalle	varchar(255) not null,
	direccionNumero	numeric(18,0) not null,
	ciudad			varchar(255) not null,
	pais			varchar(50) not null default 'Argentina',
	cantEstrellas	numeric(18,0) not null,
	recargoEstrella numeric(18,0) not null,
	campoBaja		bit not null default 0
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

create table COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES
(
	tipoCodigo		numeric(18, 0) PRIMARY KEY,
	tipoDescripcion	varchar(50) not null,
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
	piso		numeric(2) not null,
	codRegimen	numeric(8) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.REGIMENES(codRegimen),
)
go
ALTER TABLE COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA ADD CONSTRAINT PK_Detalles_Reserva PRIMARY KEY(codReserva, codHotel, habitacion, piso);
--ALTER TABLE COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA ADD CONSTRAINT FK_Detalles_Reserva FOREIGN KEY (habitacion,piso) REFERENCES COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES(habitacion,piso);

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

/** 
 ** MIGRACION
 **/
 	
--//USUARIO, Administrador	
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.USUARIOS (usr,password, nombre, apellido, tipoDocu, numDocu, direccionCalle, direccionNumero, FecNacimiento) 
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

--//FUNCIONALIDADES_X_ROL
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
/*PARA QUE TENGA SENTIDO LA FECHA DE CREACION SERÁ EL PRIMERO DE NOVIEMBRE DE 2012
YA QUE LA RESERVA MAS ANTIGUA TIENE FECHA 27 DE DICIEMBRE DE 2012*/
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HOTELES(direccionCalle, direccionNumero, ciudad, cantEstrellas, recargoEstrella, fecCreacion)
	SELECT DISTINCT Hotel_Calle, Hotel_Nro_Calle, Hotel_Ciudad, Hotel_CantEstrella, Hotel_Recarga_Estrella, '01/11/2012'
	FROM  gd_esquema.Maestra
	WHERE Hotel_Calle IS NOT NULL
GO

--//TIPO_HABITACIONES
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES(tipoCodigo, tipoDescripcion, tipoPorcentual)
	SELECT DISTINCT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual
	FROM  gd_esquema.Maestra
	WHERE Habitacion_Tipo_Codigo IS NOT NULL
GO

--//HABITACIONES
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES(codHotel,habitacion, piso, ubicacion, tipoCodigo, descripcion)
	SELECT DISTINCT H.codHotel, M.Habitacion_Numero, M.Habitacion_Piso, M.Habitacion_Frente, M.Habitacion_Tipo_Codigo, M.Habitacion_Tipo_Descripcion
	FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES H, gd_esquema.Maestra M
	WHERE H.direccionCalle = M.Hotel_Calle AND 
		  H.direccionNumero = M.Hotel_Nro_Calle AND 
		  H.ciudad = M.Hotel_Ciudad AND 
		  H.direccionCalle IS NOT NULL
GO	

--//HUESPEDES
    INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES(tipoDocu, numDocu, apellido, nombre, fecNacimiento, mail, direccionCalle,
                                                   direccionNumero, direccionPiso, direccionDepto, localidad, nacionalidad)
    SELECT DISTINCT 'DNI', Cliente_Pasaporte_Nro , Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail,   
                    Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, 'CABA', Cliente_Nacionalidad
    FROM  gd_esquema.Maestra
	WHERE Cliente_Apellido IS NOT NULL AND Cliente_Nombre IS NOT NULL
GO

--//RESERVAS
/*SUPONEMOS QUE LAS RESERVAS FUERON REGISTRADAS POR EL ADMINISTRADOR
 * Y QUE FUERON REALIZADAS EL MISMO DÍA QUE DE SU INICIO.
 */
	
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva, idHuesped, usr, fecDesde, fecHasta, fecReserva)
	SELECT DISTINCT M.Reserva_Codigo , HUES.idHuesped, 'admin', M.Reserva_Fecha_Inicio, M.Reserva_Fecha_Inicio + M.Reserva_Cant_Noches, M.Reserva_Fecha_Inicio - 5
	FROM COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES HUES, gd_esquema.Maestra M
	WHERE M.Cliente_Pasaporte_Nro = HUES.numDocu AND
		  M.Cliente_Apellido = HUES.apellido AND
		  M.Cliente_Nombre = HUES.nombre AND
		  M.Reserva_Fecha_Inicio <= CURRENT_TIMESTAMP
GO

--//RESERVASINVALIDAS
/*SUPONEMOS QUE LAS RESERVAS FUERON REGISTRADAS POR EL ADMINISTRADOR
 * Y QUE FUERON REALIZADAS EL MISMO DÍA QUE DE SU INICIO.
 */
	
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.RESERVASINVALIDAS(codReserva, idHuesped, usr, fecDesde, fecHasta, fecReserva)
	SELECT DISTINCT M.Reserva_Codigo , HUES.idHuesped, 'admin', M.Reserva_Fecha_Inicio, M.Reserva_Fecha_Inicio + M.Reserva_Cant_Noches, M.Reserva_Fecha_Inicio - 5
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
	SELECT DISTINCT M.Consumible_Codigo, M.Consumible_Descripcion, M.Consumible_Precio
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
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA(codHotel, codReserva, codRegimen, habitacion, piso)
	SELECT DISTINCT H.codHotel, M.Reserva_Codigo, R.codRegimen, M.Habitacion_Numero, M.Habitacion_Piso
	FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES H, COMPUMUNDO_HIPER_MEGA_RED.REGIMENES R, gd_esquema.Maestra M
	WHERE H.direccionCalle = M.Hotel_Calle AND 
		  H.direccionNumero = M.Hotel_Nro_Calle AND 
		  H.ciudad = M.Hotel_Ciudad AND 
		  H.direccionCalle IS NOT NULL AND
		  R.descripcion = M.Regimen_Descripcion AND
		  R.precio = M.Regimen_Precio AND
		  M.Reserva_Fecha_Inicio <= CURRENT_TIMESTAMP
	ORDER BY H.codHotel
GO

--//DETALLES_RESERVA
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
	SELECT DISTINCT M.Factura_Nro,M.Reserva_Codigo, M.Factura_Fecha, SUM(M.Item_Factura_Monto), HUES.idHuesped, 'Efectivo',''
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
	SELECT DISTINCT M.Factura_Nro,M.Reserva_Codigo, M.Factura_Fecha, SUM(M.Item_Factura_Monto), HUES.idHuesped, 'Efectivo',''
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
	SELECT DISTINCT M.Factura_Nro, ROW_NUMBER() OVER (PARTITION BY M.Factura_Nro ORDER BY M.Factura_Nro) AS Item_Nro, CASE WHEN M.Consumible_Descripcion IS NULL THEN 'Recargos de Categoria Hotel y Regimen' ELSE M.Consumible_Descripcion END, M.Item_Factura_Monto, COUNT(*), (M.Item_Factura_Monto * COUNT(*))
	FROM gd_esquema.Maestra M
	WHERE M.Item_Factura_Monto IS NOT NULL AND
			  M.Item_Factura_Cantidad IS NOT NULL AND
			  M.Factura_Nro IS NOT NULL AND
			  M.Factura_Fecha <= CURRENT_TIMESTAMP
	GROUP BY M.Factura_Nro, M.Item_Factura_Monto, M.Consumible_Descripcion
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
PRINT 'EL SIGUIENTE QUERY DEMUESTRA LA RELACION FACTURA ITEM_FACTURA'
SELECT F.numeroFactura, F.codReserva, F.idHuesped, F.montoTotal, F.tipoPago FROM COMPUMUNDO_HIPER_MEGA_RED.FACTURAS F WHERE F.numeroFactura = 2396792
SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA I WHERE i.numeroFactura = 2396792
*/

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
	 IF (@unRol != '')
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
	VALUES(@nombreRol, @estado)
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
	UPDATE COMPUMUNDO_HIPER_MEGA_RED.ROLES
	SET estado = @estado
	WHERE nombreRol = @nombreRol
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
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES_X_ROL(idFuncionalidad, nombreRol)
	VALUES(@idFuncionalidad, @rol)
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
	ELSE
		SELECT FR.nombreRol,F.idFuncionalidad,F.descripcion
		FROM COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES_X_ROL FR
		JOIN COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES F
			ON FR.idFuncionalidad = F.idFuncionalidad
		WHERE fr.nombreRol = @nombreRol
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
	BEGIN
	 IF (@unUsr = '')
 		SELECT U.usr, U.nombre, U.apellido, U.FecNacimiento, U.tipoDocu, U.numDocu,U.direccionCalle, U.direccionNumero, U.direccionPiso, 
 				U.direccionDepto, U.mail, U.telefono, U.password
 		FROM COMPUMUNDO_HIPER_MEGA_RED.USUARIOS U WHERE U.campoBaja = 0
	 ELSE
		SELECT U.usr, U.nombre, U.apellido, U.FecNacimiento, U.tipoDocu, U.numDocu,U.direccionCalle, U.direccionNumero, U.direccionPiso, 
				U.direccionDepto, U.mail, U.telefono, U.password
		FROM COMPUMUNDO_HIPER_MEGA_RED.USUARIOS U
		WHERE U.usr = @unUsr
	END
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
	@direccionCalle varchar(255),
	@direccionNumero numeric(18,0),
	@direccionPiso numeric(18,0),
	@direccionDepto varchar(50),
	@FecNacimiento DateTime
AS
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.USUARIOS (usr, password, nombre, apellido, contador_intentos_login, tipoDocu, numDocu,
		mail, telefono, direccionCalle, direccionNumero, direccionPiso, direccionDepto, FecNacimiento, campoBaja)
	VALUES(@usr, @password, @nombre, @apellido, 0, @tipoDocu, @numDocu, @mail, @telefono, @direccionCalle, @direccionNumero, 
			@direccionPiso, @direccionDepto, @FecNacimiento, 0)
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
	@direccionCalle varchar(255),
	@direccionNumero numeric(18,0),
	@direccionPiso numeric(18,0),
	@direccionDepto varchar(50),
	@fecNacimiento DateTime
AS
	IF (@usr IS NOT NULL AND @password IS NOT NULL AND
		@nombre IS NOT NULL AND @apellido IS NOT NULL AND
		@tipoDocu IS NOT NULL AND @numDocu IS NOT NULL AND
		@mail IS NOT NULL AND @telefono IS NOT NULL AND
		@direccionCalle IS NOT NULL AND @direccionNumero IS NOT NULL AND
		@direccionPiso IS NOT NULL AND @direccionDepto IS NOT NULL AND
		@fecNacimiento IS NOT NULL)
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
		
		/*ACTUALIZO LOS DATOS Y SETEO BANDERA PRIMER_LOG EN FALSO*/
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
		SET 
				password = @nueva_clave, nombre = @nombre, apellido = @apellido, tipoDocu = @tipoDocu, 
				numDocu = @numDocu, mail = @mail, telefono = @telefono, direccionCalle = @direccionCalle, direccionNumero = @direccionNumero, 
				direccionPiso = @direccionPiso, direccionDepto = @direccionDepto, fecNacimiento = @fecNacimiento, primerLog = 0
		WHERE usr = @usr
		
		/*DROP TABLA TEMPORAL*/
		DROP TABLE ##TEMP_TABLA
	END
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
	
	UPDATE COMPUMUNDO_HIPER_MEGA_RED.USUARIOS
	SET contador_intentos_login = (CASE WHEN @contador_actual < 3 THEN contador_intentos_login + 1 ELSE 0 END)
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
				WHERE H.campoBaja = 0 AND H.codHotel = @codHotel				
			ELSE
				SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES H
				WHERE H.habitacion = @habitacion AND H.codHotel = @codHotel				
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
	@tipo varchar(50),
	@descripcion varchar(255)
AS
	DECLARE @codTipo numeric(8)
	SELECT @codTipo = tipoCodigo from COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES 
	WHERE tipoDescripcion = @tipo
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HABITACIONES (codHotel, habitacion, piso, ubicacion, tipoCodigo,
		descripcion, campoBaja)
VALUES(@codHotel, @habitacion, @piso, @ubicacion, @codTipo, @descripcion, 0)
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
		SELECT R.codRegimen FROM COMPUMUNDO_HIPER_MEGA_RED.REGIMENES_X_HOTEL R 
		WHERE R.codHotel = @codigo  
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
		BEGIN
		--SI RECIBE -1, MUESTRA TODOS LOS REGIMENES HABILITADOS
			IF (@codigo = -1)
				SELECT R.codRegimen, R.descripcion, R.precio FROM COMPUMUNDO_HIPER_MEGA_RED.REGIMENES R
				WHERE R.estado = 1				
			ELSE
				SELECT R.codRegimen, R.descripcion, R.precio FROM COMPUMUNDO_HIPER_MEGA_RED.REGIMENES R
				WHERE R.codRegimen = @codigo
		END 
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
		BEGIN
		   INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.REGIMENES(codRegimen, descripcion, precio, estado)
		   VALUES (@codigoRegimen, @descripcion, @precio, 1)
		END 
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
		BEGIN
		   UPDATE COMPUMUNDO_HIPER_MEGA_RED.REGIMENES
		   SET  descripcion = @descripcion,
				precio = @precio,
				estado = @estado
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
		BEGIN
		   UPDATE COMPUMUNDO_HIPER_MEGA_RED.REGIMENES
		   SET  estado = 0
		   WHERE codRegimen = @codigoRegimen
		END 
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
		SELECT H.codHotel FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES_X_USUARIO H 
		WHERE H.usr = @usuario  
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
		BEGIN
		--SI RECIBE -1, MUESTRA TODOS LOS HOTELES
			IF (@codigo = -1)
				SELECT H.codHotel, H.nombreHotel, H.mail, H.fecCreacion, H.telefono, H.direccionCalle,
				H.direccionNumero, H.ciudad, H.pais, H.cantEstrellas, H.recargoEstrella 
				FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES H
			ELSE
				SELECT H.codHotel, H.nombreHotel, H.mail, H.fecCreacion, H.telefono, H.direccionCalle,
				H.direccionNumero, H.ciudad, H.pais, H.cantEstrellas, H.recargoEstrella
				FROM COMPUMUNDO_HIPER_MEGA_RED.HOTELES H
				WHERE H.codHotel = @codigo
		END 
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
	@nombreHotel varchar(50),
	@mail varchar(50),
	@telefono numeric(20),
	@direccionCalle varchar(255),
	@direccionNumero numeric(18,0),
	@ciudad varchar(255),
	@pais varchar(50),
	@cantEstrellas numeric(18,0),
	@recargoEstrella numeric(18,0)
AS
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HOTELES (nombreHotel, mail, fecCreacion, telefono, direccionCalle,
								direccionNumero, ciudad, pais, cantEstrellas, recargoEstrella)
	VALUES(@nombreHotel, @mail, GETDATE(), (CASE WHEN @telefono = -1 THEN NULL ELSE @telefono END), 
		@direccionCalle, (CASE WHEN @direccionNumero = -1 THEN NULL ELSE @direccionNumero END), @ciudad, 
		@pais, (CASE WHEN @cantEstrellas = -1 THEN NULL ELSE @cantEstrellas END), 
		(CASE WHEN @recargoEstrella = -1 THEN NULL ELSE @recargoEstrella END))
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
	@nombreHotel	varchar(50),
	@mail	varchar(50),
	@telefono	numeric(20),
	@direccionCalle	varchar(255),
	@direccionNumero	numeric(18),
	@ciudad	varchar(255),
	@pais	varchar(50),
	@cantEstrellas	numeric(18),
	@recargoEstrella	numeric(18),
	@estado bit
AS
	IF (@codHotel IS NOT NULL AND @nombreHotel IS NOT NULL AND
	@mail IS NOT NULL AND @telefono	IS NOT NULL AND
	@direccionCalle IS NOT NULL AND	@direccionNumero IS NOT NULL AND
	@ciudad	IS NOT NULL AND	@pais IS NOT NULL AND
	@cantEstrellas IS NOT NULL AND	@recargoEstrella IS NOT NULL AND
	@estado IS NOT NULL) 
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.HOTELES
		SET nombreHotel = @nombreHotel,
			mail = @mail,
			telefono = @telefono,
			direccionCalle = @direccionCalle,
			@direccionNumero = @direccionNumero,
			ciudad = @ciudad,
			pais = @pais,
			cantEstrellas = @cantEstrellas,
			recargoEstrella = @recargoEstrella,
			campoBaja = @estado
		WHERE codHotel= @codHotel
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
		BEGIN
		--SI RECIBE -1, MUESTRA TODOS LAS RESERVAS
		IF (@codReserva = -1)
			SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.RESERVAS R			
		ELSE
			SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.RESERVAS R	
			WHERE R.codReserva = @codReserva
		END 
GO

/******************************************************
 *AUXILIAR PARA CODIGO DE RESERVA
 ******************************************************/
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
	@habitacion numeric(4), 
	@piso numeric(2), 
	@codHotel numeric(8), 
	@codRegimen numeric(8), 
	@fecDesde datetime, 
	@fecHasta datetime,
	@fecReserva datetime	
AS
	DECLARE @max_codReservaUltimo bigint
	
	--INSERT EN LA TABLA DE RESERVAS
	SET @max_codReservaUltimo = COMPUMUNDO_HIPER_MEGA_RED.get_ultimoCodigoReserva()
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva,idHuesped, usr, fecDesde, fecHasta, fecReserva)
	VALUES(@max_codReservaUltimo + 1, @idHuesped, @usr, @fecDesde, @fecHasta, @fecReserva)
	
	--INSERT EN LA TABLA DE DETALLES_RESERVA
	SET @max_codReservaUltimo = COMPUMUNDO_HIPER_MEGA_RED.get_ultimoCodigoReserva()
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA(codHotel, codReserva, habitacion, piso, codRegimen)
	VALUES (@codHotel, @max_codReservaUltimo, @habitacion, @piso, @codRegimen)
GO

--//PROC CANCELARRESERVA
IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.cancelarReserva', 'P' ) IS NOT NULL 
DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.cancelarReserva;
GO
CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.cancelarReserva 
	--Toma la fecha del sistema al momento de agregar una cancelacion
	@codReserva		numeric,
	@motivo			varchar,
	@usr			varchar(50) 
AS 
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.CANCELACIONES_RESERVA (codReserva, motivo, usr, fecCancelacion)
	VALUES (@codReserva, @motivo, @usr, GETDATE())
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
	BEGIN
	--SI RECIBE -1, MUESTRA TODOS LOS HUESPEDES
	IF (@idHuesped = -1)
		SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES H			
	ELSE
		SELECT * FROM COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES H	
		WHERE H.idHuesped = @idHuesped
	END 
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
	@idHuesped	int,
	@tipoDocu	varchar(50),
	@numDocu	numeric(18, 0),
	@nombre	varchar(255),
	@apellido	varchar(255),
	@mail	varchar(255),
	@telefono	numeric(18, 0),
	@direccionCalle	varchar(255),
	@direccionNumero	numeric(18, 0),
	@direccionPiso	numeric(18, 0),
	@direccionDepto	varchar(50),
	@localidad	varchar(50),
	@nacionalidad	varchar(255),
	@fecNacimiento	datetime		
AS
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES(idHuesped, tipoDocu, numDocu, nombre, apellido,
				mail, telefono, direccionCalle, direccionNumero, direccionPiso, direccionDepto,
				localidad, nacionalidad, fecNacimiento)
	VALUES(@idHuesped, @tipoDocu, @numDocu, @nombre, @apellido,
		   @mail, (CASE WHEN @telefono = -1 THEN NULL ELSE @telefono END), 
		   @direccionCalle, @direccionNumero, 
		   (CASE WHEN @direccionPiso = -1 THEN NULL ELSE @direccionPiso END), @direccionDepto,
		   @localidad, @nacionalidad, @fecNacimiento)
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
	@direccionCalle varchar(255),
	@direccionNumero numeric(18,0),
	@direccionPiso numeric(18,0),
	@direccionDepto varchar(50),
	@fecNacimiento DateTime,
	@localidad varchar(50),
	@nacionalidad varchar(255)
AS
	IF (@idHuesped IS NOT NULL AND 
		@nombre IS NOT NULL AND @apellido IS NOT NULL AND
		@tipoDocu IS NOT NULL AND @numDocu IS NOT NULL AND
		@mail IS NOT NULL AND @telefono IS NOT NULL AND
		@direccionCalle IS NOT NULL AND @direccionNumero IS NOT NULL AND
		@direccionPiso IS NOT NULL AND @direccionDepto IS NOT NULL AND
		@fecNacimiento IS NOT NULL AND @localidad IS NOT NULL AND
		@nacionalidad IS NOT NULL)
	BEGIN
		
		UPDATE COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES
		SET 
				nombre = @nombre, apellido = @apellido, tipoDocu = @tipoDocu, 
				numDocu = @numDocu, mail = @mail, telefono = @telefono, direccionCalle = @direccionCalle, direccionNumero = @direccionNumero, 
				direccionPiso = @direccionPiso, direccionDepto = @direccionDepto, fecNacimiento = @fecNacimiento, 
				localidad = @localidad, nacionalidad = @nacionalidad
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
	BEGIN
	 IF (@numeroFactura != -1)
 		SELECT *
 		FROM COMPUMUNDO_HIPER_MEGA_RED.FACTURAS F
 		WHERE F.numeroFactura = @numeroFactura 
	 ELSE
		SELECT *
		FROM COMPUMUNDO_HIPER_MEGA_RED.FACTURAS  
	END
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
	BEGIN
		SELECT *
 		FROM COMPUMUNDO_HIPER_MEGA_RED.FACTURAS F
 		WHERE F.codReserva = @codReserva
	END
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
	BEGIN
		SELECT *
 		FROM COMPUMUNDO_HIPER_MEGA_RED.FACTURAS F
 		WHERE F.idHuesped = @idHuesped
	END
GO


/************************************************************************************************************
 *AUXILIARES CALCULO DE RECARGOS
 ***********************************************************************************************************/
IF object_id(N'COMPUMUNDO_HIPER_MEGA_RED.totalConsumibles', N'FN') IS NOT NULL
    DROP FUNCTION COMPUMUNDO_HIPER_MEGA_RED.totalConsumibles
GO
CREATE FUNCTION COMPUMUNDO_HIPER_MEGA_RED.totalConsumibles (@codReserva	numeric(18))
RETURNS numeric(3,2)
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
		SET @precioRegimen = (SELECT R.precio FROM COMPUMUNDO_HIPER_MEGA_RED.DETALLES_RESERVA DR
							 JOIN COMPUMUNDO_HIPER_MEGA_RED.REGIMENES R ON R.codRegimen= DR.codRegimen
							 WHERE DR.codReserva = @codReserva)
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
	BEGIN
	DECLARE @totalConsumibles numeric(3,2)
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
	SET @montoTotal = @totalConsumibles + @totalRegimenHabitacion + @recargoEstrella
	
	DECLARE @idHuesped int
	SET @idHuesped = (SELECT R.idHuesped FROM COMPUMUNDO_HIPER_MEGA_RED.RESERVAS R
						WHERE R.codReserva = @codReserva)
	
	/*INSERTO EN LA TABLA FACTURA*/
	DECLARE @numeroFactura  numeric(18)
	SET @numeroFactura = COMPUMUNDO_HIPER_MEGA_RED.get_ultimoNumeroFactura()

	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.FACTURAS(numeroFactura, codReserva, fecha, idHuesped, montoTotal, tipoPago, codTarjetaCredito)
	VALUES(@numeroFactura + 1,@codReserva, GETDATE(), @idHuesped, @montoTotal, @tipoPago, CASE WHEN @tipoPago LIKE 'Efectivo' THEN '' ELSE @codTarjetaCredito END)
	
	SET @numeroFactura = @numeroFactura + 1
	--INSERT EN LA TABLA ITEMS_FACTURA
	EXEC COMPUMUNDO_HIPER_MEGA_RED.insertItemFactura @numeroFactura, @codReserva
	
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
	DECLARE @nroItem numeric(2)
	SET @nroItem = 0 
	
	--Guardo primero RECARGOS
	DECLARE @totalRecargos numeric(5,2)
	SET @totalRecargos = COMPUMUNDO_HIPER_MEGA_RED.precioRegimen(@codReserva)*COMPUMUNDO_HIPER_MEGA_RED.porcentualHabitacion(@codReserva)
						+ COMPUMUNDO_HIPER_MEGA_RED.recargoEstrella(@codReserva)
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA(numeroFactura, numeroItem, cantidad, montoUnitario, montoTotal, descripcion)
	VALUES(@numeroFactura, @nroItem+1, 1, @totalRecargos, @totalRecargos, 'Recargos de Categoria Hotel y Regimen')
	
	--Guardo los consumibles
	SET @nroItem = @nroItem + 1
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA(numeroFactura, numeroItem, cantidad, montoUnitario, montoTotal, descripcion)
	SELECT DISTINCT @numeroFactura, @nroItem + 1, CE.cantidad, C.importe, CE.cantidad * C.importe, C.descripcion
	FROM COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES_X_ESTADIA CE
	JOIN COMPUMUNDO_HIPER_MEGA_RED.CONSUMIBLES C ON C.codConsumible = CE.codConsumible
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

