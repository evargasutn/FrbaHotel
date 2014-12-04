/*
* GESTION DE DATOS: SEGUNDO PARCIAL
* FECHA: 29/11/2014
* TOMAS FERRARO
* LEGAJO: 1465181
*/
USE [parcial]
GO

IF object_id(N'competencia.participoEnCompetencia', N'FN') IS NOT NULL
    DROP FUNCTION competencia.distintaCombinatoria
GO
--Si la pregunta 1 y la pregunta 2 tienen distinta combinatoria de respuestas, devuelve 1
CREATE FUNCTION competencia.distintaCombinatoria (@preg1 int, @preg2 int) 
RETURNS int
AS
BEGIN
	IF EXISTS(	SELECT *
				FROM competencia.respuestas r1
				JOIN competencia.respuestas r2
				ON r1.letra = r2.letra
				WHERE r1.pregunta = @preg1 AND r2.pregunta = @preg2
				AND	r1.detalle != r2.detalle)
		RETURN 1
		
	RETURN 0
END
GO

IF object_id(N'competencia.mayorPorcentaje', N'FN') IS NOT NULL
    DROP FUNCTION competencia.mayorPorcentaje
GO
CREATE FUNCTION competencia.mayorPorcentaje (@detalle varchar(100)) 
RETURNS int
AS
BEGIN
	RETURN(		SELECT MAX(r1.porcentaje)
				FROM competencia.respuestas r1
				JOIN competencia.preguntas p1
				ON r1.pregunta = p1.idPregunta
				WHERE p1.detalle = @detalle
				AND r1.esCorrecta = 1)
END
GO

IF object_id(N'competencia.descripcionRespuestaUnica', N'FN') IS NOT NULL
    DROP FUNCTION competencia.descripcionRespuestaUnica
GO
CREATE FUNCTION competencia.descripcionRespuestaUnica (@nivel int, @descrpPreg varchar(100), @detalle varchar(100)) 
RETURNS varchar(255)
AS
BEGIN
		RETURN (SELECT (CASE COUNT(r1.detalle) WHEN 1 THEN r1.detalle ELSE (r1.detalle + ' - Unica') END)
		FROM competencia.respuestas r1
		JOIN competencia.preguntas p1
		ON p1.idPregunta = r1.pregunta
		WHERE p1.nivel = @nivel AND p1.detalle = @descrpPreg
		and r1.esCorrecta = 1
		GROUP BY r1.detalle
		HAVING  r1.detalle = @detalle)
END
GO

SELECT	p1.nivel AS 'Nivel',
		p1.detalle AS 'Pregunta',
		r1.letra AS 'Letra',
		r1.porcentaje AS 'Porcentaje',
		competencia.descripcionRespuestaUnica(p1.nivel, p1.detalle, R1.detalle) AS 'Correcta'
FROM competencia.preguntas p1
	JOIN competencia.preguntas p2
		ON p1.nivel = p2.nivel AND p1.detalle = p2.detalle
	JOIN competencia.respuestas r1
		ON r1.pregunta = p1.idPregunta
WHERE	competencia.distintaCombinatoria(p1.idPregunta, p2.idPregunta) = 1
		AND r1.esCorrecta = 1	
GROUP BY p1.nivel, p1.detalle, r1.letra, r1.porcentaje, r1.detalle
HAVING r1.porcentaje = competencia.mayorPorcentaje(p1.detalle)
