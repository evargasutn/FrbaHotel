USE [parcial]
GO

BEGIN TRANSACTION
-- CREA EL ESQUEMA SI NO EXISTIESE
IF NOT EXISTS ( SELECT  *
                FROM    sys.schemas
                WHERE   name = N'competencia' ) 
    EXEC('CREATE SCHEMA [competencia] AUTHORIZATION [gd]')
COMMIT;

-- DROP TABLAS VIEJAS
	
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('competencia.logs') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE competencia.logs;
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('competencia.rel_pais_pregunta') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE competencia.rel_pais_pregunta;
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('competencia.competiciones') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE competencia.competiciones;		
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('competencia.respuestas') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE competencia.respuestas;			
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('competencia.preguntas') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE competencia.preguntas;	
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('competencia.jugadores') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE competencia.jugadores;
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('competencia.categoria') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE competencia.categoria;
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('competencia.niveles') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE competencia.niveles;
		IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('competencia.paises') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
		DROP TABLE competencia.paises;				


--CREAMOS LAS TABLAS
CREATE TABLE competencia.paises
(
	idPais			int				IDENTITY(1,1) PRIMARY KEY,
	detalle			nvarchar(100)	UNIQUE,
)
GO

CREATE TABLE competencia.categoria
(
	idCategoria		int				IDENTITY(1,1) PRIMARY KEY,
	detalle			nvarchar(100),
)
GO

CREATE TABLE competencia.jugadores
(
	idJugador		int				IDENTITY(1,1) PRIMARY KEY,
	nombre			nvarchar(100)	UNIQUE NOT NULL,
	pais			int				NOT NULL,
	nick			nvarchar(100),
	totalJugados	int				DEFAULT 0,
	totalGanados	int				DEFAULT 0,	
	fechaAlta		datetime		NOT NULL,
)
GO

CREATE TABLE competencia.competiciones
(
	idCompeticion	int				IDENTITY(1,1) PRIMARY KEY,
	jugador1		int				NOT NULL,
	jugador2		int,
	jugador3		int,
	jugador4		int,
	jugador5		int,
	ganador			numeric(5, 0),
)
GO

CREATE TABLE competencia.preguntas
(
	idPregunta		int				IDENTITY(1,1) PRIMARY KEY,
	detalle			nvarchar(100),
	categoria		int				NOT NULL,
	nivel			int,
	fechaInicio		datetime		NOT NULL,
	fechaFin		datetime,
)
GO

CREATE TABLE competencia.niveles
(
	idNivel			int				IDENTITY(1,1) PRIMARY KEY,
	detalle			nvarchar(100),
)
GO

CREATE TABLE competencia.respuestas
(
	idRespuesta		int				IDENTITY(1,1) PRIMARY KEY,
	pregunta		int,			--Si no fue usada tiene valor de null
	letra			char,
	detalle			nvarchar(100),
	esCorrecta		bit				NOT NULL,
	porcentaje		int				DEFAULT 0 ,
)
GO

CREATE TABLE competencia.logs
(
	idLog			int				IDENTITY(1,1) PRIMARY KEY,
	pregunta		int				NOT NULL,
	respuesta		int				NOT NULL,
	jugador			int				NOT NULL,
	competicion		int				NOT NULL,
	fechaHora		datetime		NOT NULL,
)
GO

CREATE TABLE competencia.rel_pais_pregunta
(
	idPais			int,
	idPregunta		int				
	PRIMARY KEY(idPais,idPregunta)
)
GO

--CREAMOS LAS FK
ALTER TABLE competencia.jugadores  WITH CHECK ADD CONSTRAINT [FK_PAIS] FOREIGN KEY(pais) REFERENCES competencia.paises(idPais)

ALTER TABLE competencia.competiciones  WITH CHECK ADD CONSTRAINT [FK_JUGADOR1] FOREIGN KEY(jugador1) REFERENCES competencia.jugadores (idJugador)
ALTER TABLE competencia.competiciones  WITH CHECK ADD CONSTRAINT [FK_JUGADOR2] FOREIGN KEY(jugador2) REFERENCES competencia.jugadores (idJugador)
ALTER TABLE competencia.competiciones  WITH CHECK ADD CONSTRAINT [FK_JUGADOR3] FOREIGN KEY(jugador3) REFERENCES competencia.jugadores (idJugador)
ALTER TABLE competencia.competiciones  WITH CHECK ADD CONSTRAINT [FK_JUGADOR4] FOREIGN KEY(jugador4) REFERENCES competencia.jugadores (idJugador)
ALTER TABLE competencia.competiciones  WITH CHECK ADD CONSTRAINT [FK_JUGADOR5] FOREIGN KEY(jugador5) REFERENCES competencia.jugadores (idJugador)

ALTER TABLE competencia.preguntas WITH CHECK ADD CONSTRAINT [FK_CATEGORIA] FOREIGN KEY(categoria) REFERENCES competencia.categoria(idCategoria)
ALTER TABLE competencia.preguntas WITH CHECK ADD CONSTRAINT [FK_NIVEL] FOREIGN KEY(nivel) REFERENCES competencia.niveles(idNivel)

ALTER TABLE competencia.respuestas WITH CHECK ADD CONSTRAINT [FK_PREGUNTA] FOREIGN KEY(pregunta) REFERENCES competencia.preguntas (idPregunta)

ALTER TABLE competencia.logs WITH CHECK ADD CONSTRAINT [FK_LOG_PREGUNTA] FOREIGN KEY(pregunta) REFERENCES competencia.preguntas(idPregunta)
ALTER TABLE competencia.logs WITH CHECK ADD CONSTRAINT [FK_LOG_RESPUESTA] FOREIGN KEY(respuesta) REFERENCES competencia.respuestas (idRespuesta)
ALTER TABLE competencia.logs WITH CHECK ADD CONSTRAINT [FK_LOG_JUGADOR] FOREIGN KEY(jugador) REFERENCES competencia.jugadores (idJugador)
ALTER TABLE competencia.logs WITH CHECK ADD CONSTRAINT [FK_LOG_COMPETICION] FOREIGN KEY(competicion) REFERENCES competencia.competiciones (idCompeticion)

ALTER TABLE competencia.rel_pais_pregunta  WITH CHECK ADD CONSTRAINT [FK_REL_PAIS] FOREIGN KEY(idPais) REFERENCES competencia.paises(idPais)
ALTER TABLE competencia.rel_pais_pregunta  WITH CHECK ADD CONSTRAINT [FK_REL_PREGUNTA] FOREIGN KEY(idPregunta) REFERENCES competencia.preguntas(idPregunta)

--Trigger para calcular los porcentajes de las respuestas   
IF OBJECT_ID ('competencia.actualizarPorcentaje', 'TR') IS NOT NULL
   DROP TRIGGER competencia.actualizarPorcentaje;
GO
CREATE TRIGGER actualizarPorcentaje
ON competencia.logs
AFTER INSERT, UPDATE 
AS  
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DECLARE @pregunta	int
	DECLARE @total		int
    DECLARE @cantRespA	int
    DECLARE @cantRespB	int
    DECLARE @cantRespC	int
    DECLARE @cantRespD	int
    
    DECLARE cur CURSOR FORWARD_ONLY READ_ONLY LOCAL FOR
        SELECT idPregunta FROM competencia.preguntas
    OPEN cur												
    FETCH NEXT FROM cur INTO @pregunta
	
    WHILE @@FETCH_STATUS = 0 BEGIN
	
		SET @cantRespA = (	SELECT COUNT(*) 
							FROM logs l
							JOIN respuestas r
							ON r.idRespuesta = l.respuesta 
							WHERE r.pregunta = @pregunta AND r.letra = 'A')
		SET @cantRespB = (	SELECT COUNT(*) 
							FROM logs l
							JOIN respuestas r
							ON r.idRespuesta = l.respuesta
							WHERE r.pregunta = @pregunta AND r.letra = 'B')
		SET @cantRespC = (	SELECT COUNT(*) 
							FROM logs l
							JOIN respuestas r
							ON r.idRespuesta = l.respuesta
							WHERE r.pregunta = @pregunta AND r.letra = 'C')
		SET @cantRespD = (	SELECT COUNT(*) 
							FROM logs l
							JOIN respuestas r
							ON r.idRespuesta = l.respuesta
							WHERE r.pregunta = @pregunta AND r.letra = 'D')		
											
		SET @total = @cantRespA + @cantRespB + @cantRespC + @cantRespD
		
		IF(@total != 0)
		BEGIN
			SET @cantRespA =  @cantRespA * 100 / @total
			SET @cantRespB =  @cantRespB * 100 / @total
			SET @cantRespC =  @cantRespC * 100 / @total
			SET @cantRespD =  @cantRespD * 100 / @total
			
			UPDATE respuestas
			SET porcentaje = @cantRespA
			WHERE pregunta = @pregunta AND letra = 'A'				

			UPDATE respuestas
			SET porcentaje = @cantRespB
			WHERE pregunta = @pregunta AND letra = 'B'	
			
			UPDATE respuestas
			SET porcentaje = @cantRespC
			WHERE pregunta = @pregunta AND letra = 'C'	
			
			UPDATE respuestas
			SET porcentaje = @cantRespD
			WHERE pregunta = @pregunta AND letra = 'D'
		END			
        FETCH NEXT FROM cur INTO @pregunta
    END

    CLOSE cur
    DEALLOCATE cur
GO

IF object_id(N'competencia.participoEnCompetencia', N'FN') IS NOT NULL
    DROP FUNCTION competencia.participoEnCompetencia
GO
CREATE FUNCTION competencia.participoEnCompetencia (@jugador int, @competencia int) 
RETURNS int
AS
BEGIN
	IF((SELECT COUNT(*) FROM competiciones c WHERE c.idCompeticion = @competencia AND @jugador IN (c.jugador1, c.jugador2, c.jugador3, c.jugador4, c.jugador5)) > 0) 
		RETURN 1
	
	RETURN 0
END
GO

--Funcion para obtener si el jugador GANO una competencia dada
IF object_id(N'competencia.ganoCompetencia', N'FN') IS NOT NULL
    DROP FUNCTION competencia.ganoCompetencia
GO
CREATE FUNCTION competencia.ganoCompetencia (@jugador int, @competencia int) 
RETURNS bit
AS
BEGIN
	IF((SELECT COUNT(*) FROM competiciones c WHERE	c.idCompeticion = @competencia
													AND c.jugador1 = @jugador
													AND ISNULL(c.ganador,0) = 1) > 0) 
		RETURN 1
	IF((SELECT COUNT(*) FROM competiciones c WHERE	c.idCompeticion = @competencia
													AND c.jugador2 = @jugador
													AND ISNULL(c.ganador,0) = 2) > 0) 
		RETURN 1
	IF((SELECT COUNT(*) FROM competiciones c WHERE	c.idCompeticion = @competencia
													AND c.jugador3 = @jugador
													AND ISNULL(c.ganador,0) = 3) > 0) 
		RETURN 1				
	IF((SELECT COUNT(*) FROM competiciones c WHERE	c.idCompeticion = @competencia
													AND c.jugador4 = @jugador
													AND ISNULL(c.ganador,0) = 4) > 0) 
		RETURN 1
	IF((SELECT COUNT(*) FROM competiciones c WHERE	c.idCompeticion = @competencia
													AND c.jugador5 = @jugador
													AND ISNULL(c.ganador,0) = 5) > 0) 
		RETURN 1
	RETURN 0
END
GO

--Trigger de partidas jugadas y ganadas de Jugador
IF OBJECT_ID ('competencia.actualizarCompeticionesJugador', 'TR') IS NOT NULL
   DROP TRIGGER competencia.actualizarCompeticionesJugador;
GO
CREATE TRIGGER actualizarCompeticionesJugador
ON competencia.competiciones
AFTER INSERT, UPDATE 
AS  
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DECLARE @jugador	int
	DECLARE @jugados	int
    DECLARE @ganados	int
    
    DECLARE cur CURSOR FORWARD_ONLY READ_ONLY LOCAL FOR
        SELECT idJugador FROM competencia.jugadores
    OPEN cur												
    FETCH NEXT FROM cur INTO @jugador
	
    WHILE @@FETCH_STATUS = 0 BEGIN
		
		SET @jugados = (SELECT COUNT(*) FROM competiciones c
						WHERE competencia.participoEnCompetencia(@jugador, c.idCompeticion) != 0)
		SET @ganados = (SELECT COUNT(*) FROM competiciones c
						WHERE competencia.ganoCompetencia(@jugador, c.idCompeticion) != 0)
			
		UPDATE jugadores
		SET totalJugados = @jugados, totalGanados = @ganados
		WHERE idJugador = @jugador	
					
        FETCH NEXT FROM cur INTO @jugador
    END

    CLOSE cur
    DEALLOCATE cur	
GO

--Crear competicion - 1 jugador
IF OBJECT_ID ( 'competencia.insertCompeticion', 'P' ) IS NOT NULL 
		DROP PROCEDURE competencia.insertCompeticion
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE competencia.insertCompeticion
	@jugador int		
AS
	INSERT INTO competencia.competiciones(jugador1)
	VALUES (@jugador)
GO
--Agregar jugador a competicion
IF OBJECT_ID ( 'competencia.agregarJugadorCompeticion', 'P' ) IS NOT NULL 
		DROP PROCEDURE competencia.agregarJugadorCompeticion
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE competencia.agregarJugadorCompeticion
	@jugador int, @competicion int		
AS
	SELECT * INTO #CompTemp
	FROM competencia.competiciones	
	WHERE idCompeticion = @competicion
	
	IF (SELECT c.jugador2 FROM #CompTemp c) IS NULL
	BEGIN
		UPDATE competencia.competiciones
		SET jugador2 = @jugador
		WHERE idCompeticion = @competicion
		RETURN
	END
	IF (SELECT c.jugador3 FROM #CompTemp c) IS NULL
	BEGIN
		UPDATE competencia.competiciones
		SET jugador3 = @jugador
		WHERE idCompeticion = @competicion
		RETURN
	END	
	IF (SELECT c.jugador4 FROM #CompTemp c) IS NULL
	BEGIN
		UPDATE competencia.competiciones
		SET jugador4 = @jugador
		WHERE idCompeticion = @competicion
		RETURN
	END
	IF (SELECT c.jugador5 FROM #CompTemp c) IS NULL
	BEGIN
		UPDATE competencia.competiciones
		SET jugador5 = @jugador
		WHERE idCompeticion = @competicion
		RETURN
	END	
GO
--Log trigger en before para evitar que un extrangero participe en la pregunta si el pais es determinad
IF OBJECT_ID ('competencia.chequearPaisPregunta', 'TR') IS NOT NULL
   DROP TRIGGER competencia.chequearPaisPregunta;
GO
CREATE TRIGGER chequearPaisPregunta
ON competencia.logs
FOR INSERT, UPDATE 
AS  
	IF((SELECT COUNT(rel.idPais) 
		FROM inserted i
		JOIN competencia.preguntas preg
		ON i.pregunta = preg.idPregunta
		JOIN competencia.rel_pais_pregunta rel
		ON preg.idPregunta = rel.idPregunta) > 0)
	BEGIN
		IF((SELECT COUNT(*) 
			FROM inserted i
			JOIN competencia.rel_pais_pregunta rel
			ON i.pregunta = rel.idPregunta
			JOIN competencia.jugadores j
			ON i.jugador = j.idJugador
			WHERE j.pais = rel.idPais) = 0)
		BEGIN
			ROLLBACK
			RAISERROR ('Pregunta no disponible para el pais del jugador.', -- Message text.
						16, -- Severity.
						1 -- State.
						);	
		END
	END
GO

-- Insert categoria
IF OBJECT_ID ( 'competencia.insertCategoria', 'P' ) IS NOT NULL 
		DROP PROCEDURE competencia.insertCategoria
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE competencia.insertCategoria
	@detalle varchar(255)		
AS
	INSERT INTO competencia.categoria(detalle)
	VALUES (@detalle)
GO

-- Insert nivel
IF OBJECT_ID ( 'competencia.insertNivel', 'P' ) IS NOT NULL 
		DROP PROCEDURE competencia.insertNivel
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE competencia.insertNivel
	@detalle varchar(255)		
AS
	INSERT INTO competencia.niveles(detalle)
	VALUES (@detalle)
GO

-- Insert respuesta
IF OBJECT_ID ( 'competencia.insertRespuesta', 'P' ) IS NOT NULL 
		DROP PROCEDURE competencia.insertRespuesta
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE competencia.insertRespuesta
	@pregunta int, @letra char(1), @detalle nvarchar(100), @correcta bit	
AS
	INSERT INTO competencia.respuestas(pregunta, letra, detalle, esCorrecta)
	VALUES (@pregunta, @letra,@detalle, @correcta)
GO

-- Insert pregunta
IF OBJECT_ID ( 'competencia.insertPregunta', 'P' ) IS NOT NULL 
		DROP PROCEDURE competencia.insertPregunta
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE competencia.insertPregunta
	 @detalle varchar(255), @categoria int, @nivel int, 
	@fechaInicio datetime, @fechaFin datetime
AS
	INSERT INTO competencia.preguntas(detalle, categoria, nivel,fechaInicio, fechaFin)
	VALUES (@detalle, @categoria, @nivel, @fechaInicio, @fechaFin)
GO

-- Insert Jugador
IF OBJECT_ID ( 'competencia.insertJugador', 'P' ) IS NOT NULL 
		DROP PROCEDURE competencia.insertJugador
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE competencia.insertJugador
	 @nombre nvarchar(100), @nick nvarchar(100), @pais int
AS
	INSERT INTO competencia.jugadores(nombre, nick, pais, fechaAlta)
	VALUES (@nombre, @nick, @pais, GETDATE())
GO

-- Insert Log
IF OBJECT_ID ( 'competencia.insertLog', 'P' ) IS NOT NULL 
		DROP PROCEDURE competencia.insertLog
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE competencia.insertLog
	 @pregunta int,
	 @respuesta int,
	 @jugador int,
	 @competicion int
AS
	INSERT INTO competencia.logs(pregunta, respuesta, jugador, competicion, fechaHora)
	VALUES (@pregunta, @respuesta, @jugador, @competicion, GETDATE())
GO
