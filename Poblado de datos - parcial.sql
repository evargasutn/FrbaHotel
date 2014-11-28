USE [parcial]
GO

--Insert de Paises
INSERT competencia.paises(detalle)
VALUES ('Argentina')
INSERT competencia.paises(detalle)
VALUES ('Chile')
INSERT competencia.paises(detalle)
VALUES ('Paraguay')
INSERT competencia.paises(detalle)
VALUES ('Brasil')
INSERT competencia.paises(detalle)
VALUES ('Ecuador')
INSERT competencia.paises(detalle)
VALUES ('Uruguay')
INSERT competencia.paises(detalle)
VALUES ('Colombia')
INSERT competencia.paises(detalle)
VALUES ('Venezuela')
INSERT competencia.paises(detalle)
VALUES ('Peru')
INSERT competencia.paises(detalle)
VALUES ('Bolivia')
GO

--Insert de Categorias
EXEC competencia.insertCategoria 'Historia'
EXEC competencia.insertCategoria 'Geografia'
EXEC competencia.insertCategoria 'Deportes'
EXEC competencia.insertCategoria 'Arte'
EXEC competencia.insertCategoria 'Miscelaneo'

--Insert Niveles
EXEC competencia.insertNivel 'Principiante'
EXEC competencia.insertNivel 'Normal'
EXEC competencia.insertNivel 'Dificil'
EXEC competencia.insertNivel 'Experto'

--Insert Preguntas
EXEC competencia.insertPregunta '¿Cual fue el primer Presidente Argentino?',1,2, '20141125', '20141130'
EXEC competencia.insertPregunta '¿Cual fue el primer Presidente Argentino?',1,3, '20141125', '20141130'

--Insert Paises X Preguntas
INSERT competencia.rel_pais_pregunta (idPais, idPregunta)
VALUES(1,1)
INSERT competencia.rel_pais_pregunta (idPais, idPregunta)
VALUES(1,2)
INSERT competencia.rel_pais_pregunta (idPais, idPregunta)
VALUES(1,3)
INSERT competencia.rel_pais_pregunta (idPais, idPregunta)
VALUES(2,1)
INSERT competencia.rel_pais_pregunta (idPais, idPregunta)
VALUES(3,1)
INSERT competencia.rel_pais_pregunta (idPais, idPregunta)
VALUES(4,1)
INSERT competencia.rel_pais_pregunta (idPais, idPregunta)
VALUES(2,2)

--Insert Respuestas
EXEC competencia.insertRespuesta 1, 'A', 'Julio Argentino Roca', 0
EXEC competencia.insertRespuesta 1, 'B', 'Manuel Belgrano', 0
EXEC competencia.insertRespuesta 1, 'C', 'Bernardino Rivadavia', 1
EXEC competencia.insertRespuesta 1, 'D', 'Domingo Faustino Sarmiento', 0

EXEC competencia.insertRespuesta 2, 'A', 'Julio Argentino Roca', 0
EXEC competencia.insertRespuesta 2, 'B', 'Bernardino Rivadavia', 1
EXEC competencia.insertRespuesta 2, 'C', 'Manuel Belgrano', 0
EXEC competencia.insertRespuesta 2, 'D', 'Domingo Faustino Sarmiento', 0

--Insert Jugadores
EXEC competencia.insertJugador 'Nicolas', 'nico', 1
--Insert Competiciones
EXEC competencia.insertCompeticion 1
EXEC competencia.insertCompeticion 1

--Insert Logs
EXEC competencia.insertLog 1, 3, 1, 1
EXEC competencia.insertLog 2, 1, 1, 2

	INSERT INTO competencia.logs(pregunta, respuesta, jugador, competicion, fechaHora)
	VALUES (2, 1, 1, 2, GETDATE())