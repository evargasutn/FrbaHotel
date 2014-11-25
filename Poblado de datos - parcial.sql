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
EXEC competencia.insertPregunta '�Cual fue el primer Presidente Argentino?',1,2, '20141125', '20141130'
EXEC competencia.insertPregunta '�Con qu� pais limita el Principado de M�naco?',2,3, '20141124', '20141126'
EXEC competencia.insertPregunta '�Cuantos Mundiales fue semifinalista la selecci�n de Paises Bajos?',3,4, '20141125', '20141127'

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

--Insert Jugadores

--Insert Competiciones

--Insert Logs