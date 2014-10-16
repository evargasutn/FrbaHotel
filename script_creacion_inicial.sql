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
		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE COMPUMUNDO_HIPER_MEGA_RED.TIPO_HABITACIONES;
		
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
	DireccionDepto				varchar(50),
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
	tipoDocu			varchar(50),
	numDocu				numeric(18,0) not null,
	nombre				varchar(255) not null,
	apellido			varchar(255) not null,
	mail				varchar(255),
	telefono			numeric(18,0),
	direccionCalle		varchar(255) not null,
	direccionNumero		numeric(18,0) not null,
	direccionPiso		numeric(18,0),
	DireccionDepto		varchar(50),
	localidad			varchar(50) not null,
	paisOrigen			varchar(50) not null,
	nacionalidad		varchar(255) not null,
	fecNacimiento		datetime not null,
	campo_baja			bit	not null default 0
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.RESERVAS
(
	codReserva	numeric(18) identity(1,1) PRIMARY KEY,
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
	direccionCalle	varchar(255) not null,
	direccionNumero	numeric(18,0) not null,
	ciudad			varchar(255) not null,
	pais			varchar(50) not null default 'Argentina',
	cantEstrellas	numeric(18,0) not null,
	recargoEstrella numeric(18,0) not null
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

create table COMPUMUNDO_HIPER_MEGA_RED.ESTADIA
(
	codReserva	numeric(18) NOT NULL FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva),
	fecIngreso	datetime not null,
	usrIngreso	varchar(50) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.USUARIOS(usr),
	fecEgreso	datetime,
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
	numeroFactura	numeric(18, 0) identity(1,1) PRIMARY KEY,
	codReserva		numeric(18) not null FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva),
	fecha			datetime not null,
	montoTotal		numeric(18,2) not null,
	idHuesped 		int not null FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES(idHuesped)
)
go

create table COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA
(
	numeroFactura	numeric(18,0) FOREIGN KEY REFERENCES COMPUMUNDO_HIPER_MEGA_RED.FACTURAS(numeroFactura),
	numeroItem		numeric(5) identity(1,1) not null,
	descripcion		varchar(255) not null default '',
	monto			numeric(18,2) not null,
	cantidad		numeric(18,0) not null,
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
/*No es posible tomar nombreHotel como PK porque en la tabla maestra no estan los nombres de los hoteles*/
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.HOTELES(direccionCalle, direccionNumero, ciudad, cantEstrellas, recargoEstrella)
	SELECT DISTINCT Hotel_Calle, Hotel_Nro_Calle, Hotel_Ciudad, Hotel_CantEstrella, Hotel_Recarga_Estrella
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
                                                   direccionNumero, direccionPiso, direccionDepto, localidad, nacionalidad, paisOrigen)
    SELECT DISTINCT 'DNI', Cliente_Pasaporte_Nro , Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac, Cliente_Mail,   
                    Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, 'CABA', Cliente_Nacionalidad, 'Argentina'
    FROM  gd_esquema.Maestra
	WHERE Cliente_Apellido IS NOT NULL AND Cliente_Nombre IS NOT NULL
GO

--//RESERVAS
/*SUPONEMOS QUE LAS RESERVAS FUERON REGISTRADAS POR EL ADMINISTRADOR
  Y QUE FUERON REALIZADAS 5 DÍAS ANTES DE SU INICIO.
  NO SE TRATAN LAS FECHAS REGISTRADAS EN EL FUTURO*/
	
	--PARA QUE TOME LOS CODIGOS YA EXISTENTE
	SET IDENTITY_INSERT COMPUMUNDO_HIPER_MEGA_RED.RESERVAS ON

	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.RESERVAS(codReserva, idHuesped, usr, fecDesde, fecHasta, fecReserva)
	SELECT DISTINCT M.Reserva_Codigo , HUES.idHuesped, 'admin', M.Reserva_Fecha_Inicio, M.Reserva_Fecha_Inicio + M.Reserva_Cant_Noches, M.Reserva_Fecha_Inicio - 5
	FROM COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES HUES, gd_esquema.Maestra M
	WHERE M.Cliente_Pasaporte_Nro = HUES.numDocu AND
		  M.Cliente_Apellido = HUES.apellido AND
		  M.Cliente_Nombre = HUES.nombre
		  
	--RESET IDENTITY_INSERT PARA QUE VUELVA A INSERTAR VALORES AUTOMATICAMENTE
	SET IDENTITY_INSERT COMPUMUNDO_HIPER_MEGA_RED.RESERVAS OFF
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
  Y QUE FUE REGISTRADA POR EL ADMINISTRADOR.
  NO SE TRATAN LAS FECHAS REGISTRADAS EN EL FUTURO*/
  	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ESTADIA(codReserva,fecIngreso, fecEgreso, usrIngreso, usrEgreso)
	SELECT DISTINCT M.Reserva_Codigo, M.Estadia_Fecha_Inicio, M.Estadia_Fecha_Inicio + M.Estadia_Cant_Noches, 'admin', 'admin'
	FROM gd_esquema.Maestra M
	WHERE M.Estadia_Fecha_Inicio IS NOT NULL AND
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
		  M.Reserva_Codigo IS NOT NULL
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
		  R.precio = M.Regimen_Precio
	ORDER BY H.codHotel
GO

--//CANCELACIONES_RESERVA
	IF OBJECT_ID ( 'COMPUMUNDO_HIPER_MEGA_RED.P_CANCELA_RESERVA', 'P' ) IS NOT NULL 
		DROP PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.P_CANCELA_RESERVA;
GO
	CREATE PROCEDURE COMPUMUNDO_HIPER_MEGA_RED.P_CANCELA_RESERVA 
		--Toma la fecha del sistema al momento de agregar una cancelacion
		@codReserva		numeric,
		@motivo			varchar,
		@usr			varchar(50)
	     
	AS 
		INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.CANCELACIONES_RESERVA (codReserva, motivo, usr, fecCancelacion)
		VALUES (@codReserva, @motivo, @usr, GETDATE())
GO

--//FACTURAS
	--PARA QUE TOME LOS NROS. FACTURAS YA EXISTENTE
	SET IDENTITY_INSERT COMPUMUNDO_HIPER_MEGA_RED.FACTURAS ON

	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.FACTURAS(numeroFactura, codReserva, fecha, montoTotal, idHuesped)
	SELECT DISTINCT M.Factura_Nro,M.Reserva_Codigo, M.Factura_Fecha, M.Factura_Total, HUES.idHuesped
	FROM COMPUMUNDO_HIPER_MEGA_RED.HUESPEDES HUES, gd_esquema.Maestra M
	WHERE M.Factura_Nro IS NOT NULL AND
		  M.Cliente_Pasaporte_Nro = HUES.numDocu AND
		  M.Cliente_Apellido = HUES.apellido AND
		  M.Cliente_Nombre = HUES.nombre
		  
  	SET IDENTITY_INSERT COMPUMUNDO_HIPER_MEGA_RED.FACTURAS ON
GO

--//ITEMS_FACTURA
	INSERT INTO COMPUMUNDO_HIPER_MEGA_RED.ITEMS_FACTURA(numeroFactura, monto, cantidad, descripcion)
	SELECT DISTINCT M.Factura_Nro, M.Item_Factura_Monto, M.Item_Factura_Cantidad, ''
	FROM gd_esquema.Maestra M
	WHERE M.Item_Factura_Monto IS NOT NULL AND
		  M.Item_Factura_Cantidad IS NOT NULL AND
		  M.Factura_Nro IS NOT NULL
	ORDER BY M.Factura_Nro ASC
GO