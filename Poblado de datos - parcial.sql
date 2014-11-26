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
EXEC competencia.insertPregunta '¿Con qué pais limita el Principado de Mónaco?',2,3, '20141124', '20141126'
EXEC competencia.insertPregunta '¿Cuantos Mundiales de Futbol fue semifinalista la selección de Paises Bajos?',3,4, '20141125', '20141127'

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

EXEC competencia.insertRespuesta 2, 'A', 'Italia', 0
EXEC competencia.insertRespuesta 2, 'B', 'Francia', 1
EXEC competencia.insertRespuesta 2, 'C', 'Suiza', 0
EXEC competencia.insertRespuesta 2, 'D', 'Belgica', 0

EXEC competencia.insertRespuesta 2, 'A', '5', 0
EXEC competencia.insertRespuesta 2, 'B', '3', 0
EXEC competencia.insertRespuesta 2, 'C', '1', 0
EXEC competencia.insertRespuesta 2, 'D', '2', 1

--Insert Jugadores
EXEC competencia.insertJugador 'Nicolas', 'nico', 1
EXEC competencia.insertJugador 'Tabare', 'el lungo', 6
EXEC competencia.insertJugador 'Dominique', 'miki', 2
EXEC competencia.insertJugador 'Carlos', 'charlie', 1
EXEC competencia.insertJugador 'Gabriela', 'gabi', 1
EXEC competencia.insertJugador 'Alessandro', 'ale', 3

--Insert Competiciones
EXEC competencia.insertCompeticion 1
EXEC competencia.agregarJugadorCompeticion 3, 1
EXEC competencia.agregarJugadorCompeticion 4, 1
EXEC competencia.agregarJugadorCompeticion 5, 1

--Insert Logs
EXEC competencia.insertLog 1, 2, 1, 1
EXEC competencia.insertLog 1, 1, 3, 1
EXEC competencia.insertLog 1, 1, 4, 1
EXEC competencia.insertLog 1, 3, 4, 1
