USE [stores7]

--1. Obtener un listado de todos los clientes y sus direcciones.
SELECT c.customer_num, c.address1, c.address2 
FROM customer c
GO
--2.Obtener el listado anterior pero sólo los clientes que viven en el estado de California “CA”.
SELECT c.customer_num, c.address1, c.address2 
FROM customer c 
WHERE C.state = 'CA'
GO
--3.Listar todas las ciudades (city) de la tabla clientes que pertenecen al estado de “CA”
-- y mostrar sólo una vez cada ciudad.
SELECT DISTINCT c.city 
FROM customer c 
WHERE C.state = 'CA'
GO
--4.Ordenar la lista anterior alfabéticamente
SELECT DISTINCT c.city 
FROM customer c 
WHERE C.state = 'CA'
ORDER BY c.city ASC
GO
--5.Mostrar la dirección sólo del cliente 103. (customer_num)
SELECT c.address1, c.address2
FROM customer c
WHERE c.customer_num = 103
GO
--6.Que productos del fabricante “ANZ” existen en la tabla stock? Mostrar la lista con los
--datos de la tabla ordenados por el campo descripción. (description)
SELECT *
FROM stock s
WHERE s.manu_code = 'ANZ'
ORDER BY s.description ASC
GO
--7.Listar los códigos de fabricantes que tengan alguna orden de pedido ingresada,
--ordenados alfabéticamente y no repetidos.
SELECT DISTINCT i.manu_code
FROM items i
WHERE EXISTS (SELECT 1 
				FROM orders o
				WHERE o.order_num = i.order_num)
ORDER BY i.manu_code ASC
GO
--ESTA BIEN? MEH

--8.Escribir una sentencia SELECT que devuelva el número de orden, fecha de orden, número
--de cliente y fecha de embarque de todas las órdenes que no han sido pagadas (paid_date
--es nulo), pero fueron embarcadas (ship_date) durante los primeros nueve meses de 1998.
SELECT o.order_num, o.order_date, o.customer_num, o.ship_date
FROM orders o
WHERE o.paid_date IS NULL 
AND o.ship_date >= CONVERT(DATETIME,'01/01/1998',103) 
AND o.ship_date < CONVERT(DATETIME,'01/10/1998',103)
GO
--9.Obtener de la tabla cliente (customer) el número del cliente y el nombre de la compañía,
--la cual debe contener en su nombre la palabra “town”.
SELECT c.customer_num, c.company
FROM customer c
WHERE c.company LIKE '%town%'
GO
--10.Obtener el precio máximo y mínimo que se pagó por todos los embarques. También el
--promedio de lo pagado. Se pide obtener la información de la tabla ordenes(orders).
SELECT MAX(i.total_price) AS 'MAX', MIN(i.total_price) AS 'MIN', AVG(i.total_price) AS 'PROMEDIO',
o.order_num, o.order_date, o.customer_num, o.ship_instruct, o.backlog, o.po_num, o.ship_weight, o.ship_charge, o.ship_date
FROM orders o, items i
GROUP BY o.order_num, o.order_date, o.customer_num, o.ship_instruct, o.backlog, o.po_num, o.ship_weight, o.ship_charge, o.ship_date
GO
--11.Realizar una consulta que muestre el número de orden, fecha de orden y fecha de
--embarque de todas que fueron embarcadas (ship_date) en el mismo mes que fue dada
--de alta la orden (order_date).
SELECT o.order_num, o.order_date, o.ship_date
FROM orders o
WHERE MONTH(o.order_date) = MONTH(o.ship_date)
AND YEAR(o.order_date) = YEAR(o.ship_date)
GO
--12.Escribir una consulta que devuelva la siguiente información:
--El número de cliente
--El total del costo (ship_charge) por embarque.
--Ordenar los resultados por el total de costo en orden inverso
SELECT c.customer_num, SUM(o.ship_charge) AS 'Total'
FROM customer c, orders o
WHERE o.customer_num = c.customer_num 
GROUP BY c.customer_num
ORDER BY SUM(o.ship_charge) DESC
GO
--13.Se requiere una lista de cada grupo de clientes cuya suma total del peso de sus
--embarques supere las 30 libras.
--Ordenar el resultado por el total del peso en orden inverso.
SELECT *
FROM customer c
	INNER JOIN (SELECT c.customer_num, SUM(o.ship_weight) AS 'Peso'
				FROM customer c, orders o
				WHERE o.customer_num = c.customer_num 
				GROUP BY c.customer_num) AS aux
ON c.customer_num = aux.customer_num
WHERE aux.Peso > 30
ORDER BY aux.Peso DESC
GO	
--14.Escribir una consulta que liste todos los clientes que vivan en California ordenados por
--compañía. (En una tabla temporaria llamada forsam)
--Escribir otra sentencia SELECT que liste los datos de esa tabla para verificar si son
--correctos.
SELECT * INTO #forsam 
FROM customer C 
WHERE C.state = 'CA'
ORDER BY C.company
GO 
SELECT * FROM #forsam
GO
--15.Obtener un listado con la cantidad de productos únicos vendidos de cada fabricante (de
--todos los productos que el fabricante tiene en stock cuantos fueron comprados), en
--donde el total vendido a cada fabricante sea mayor a 1500$. El listado deberá estar
--ordenado por cantidad de productos comprados de mayor a menor.
--Fabricante ProductosUnicos
--   XXX         99
SELECT m.manu_code AS 'Fabricante', COUNT(s.stock_num) AS 'ProductorUnicos'
FROM stock s
	JOIN manufact m
ON s.manu_code = m.manu_code
WHERE NOT EXISTS(	SELECT * FROM stock s2
					WHERE s2.manu_code != s.manu_code 
					AND s.stock_num = s2.stock_num)
	AND 1500 < (	SELECT SUM(i.total_price)
					FROM items i
					WHERE i.manu_code = s.manu_code 
					AND i.stock_num = s.stock_num)
GROUP BY m.manu_code
ORDER BY ProductorUnicos DESC
GO
--16.Obtener un listado con el código de fabricante, nro de producto, la cantidad vendida
--(quantity), y el total vendido (total_price), para los fabricantes cuyo código tiene una “R”
--como segunda letra. Ordenados por código de fabricante y nro de producto.
--Fabricante Producto Cantidad Vendida Total Vendido
--    XXX      999          9999          999.99
SELECT i.manu_code AS 'Fabricante', i.stock_num AS 'Producto', SUM(i.quantity) AS 'Cantidad Vendida', SUM(i.total_price) AS 'Total Vendido'
FROM items i
WHERE SUBSTRING(i.manu_code,2,1) = 'R'
GROUP BY i.manu_code, i.stock_num
GO
--17.Crear una tabla temporal OrdenesTemp con la cantidad de órdenes por cada cliente, la
--fecha primera (order_date) y la fecha última de compra.
--Realizar una consulta de la tabla tempOrdenesTemp en donde la primer fecha de compra
--sea anterior a '1998-05-23 00:00:00.000'. Ordenar la consulta por fechaUltimaCompra en forma descendente.
--Resultado:
--Customer_num	CantidadCompras	fechaPrimerCompra		fechaUltimaCompra
--106				2			1998-05-22 00:00:00.000 1998-06-25 00:00:00.000
--104				4			1998-05-20 00:00:00.000 1998-06-22 00:00:00.000
--101				1			1998-05-21 00:00:00.000 1998-05-21 00:00:00.000
SELECT	o.customer_num AS 'Customer_num',
		COUNT(o.order_num) AS 'CantidadCompras',
		MIN(o.order_date) AS 'fechaPrimerCompra',
		MAX(o.order_date) AS 'fechaUltimaCompra'
INTO #OrdenesTemp
FROM orders o
GROUP BY o.customer_num
GO

SELECT *
FROM #OrdenesTemp ord
WHERE ord.fechaPrimerCompra < '1998-05-23 00:00:00.000'
ORDER BY ord.fechaUltimaCompra DESC
GO
--18.Consultar la tabla temporal del punto anterior y obtener la cantidad de clientes con igual
--cantidad de compras. Ordenar el listado por cantidad de compras en orden descendente
--Resultado:
--CantidadCompras	CantidadClientes
--		4					1
--		2					3
--		1					13
SELECT o.CantidadCompras, COUNT(o.Customer_num)
FROM #OrdenesTemp o
WHERE EXISTS(	SELECT *
				FROM #OrdenesTemp o2
				WHERE o.CantidadCompras = o2.CantidadCompras)
GROUP BY o.CantidadCompras
ORDER BY o.CantidadCompras DESC
GO
--19.Desconectarse de la sesión. Volver a conectarse.
--Ejecutar SELECT * from #ordenesTemp
--Que pasó???
SELECT * from #OrdenesTemp
--Invalid object name '#OrdenesTemp'. Como se cerro la sesion
--Se borraron las tablas temporales, por lo que tiro error

--20.Se desean obtener la cantidad de clientes por cada state y city, donde los clientes
--contengan el string ‘ts’ en el nombre de compañía, el código postal este entre 93000 y
--94100 y la ciudad no sea 'Mountain View'. Se desea el listado ordenado por ciudad
--Formato
--	Estado		ciudad		cantidadClientes
--	xx		xxxxxxxxxxxxxx		999
SELECT c.state, c.city, COUNT(c.customer_num) AS 'cantidadClientes'
FROM customer c
WHERE	c.company LIKE '%ts%'
		AND c.zipcode > 93000 AND c.zipcode < 94100
		AND c.city != 'Mountain View'
GROUP BY c.state, c.city
ORDER BY c.city
--21.Obtener el número de cliente, la compañía, y número de orden de todos los clientes que
--tengan órdenes. Ordenar el resultado por número de cliente.
SELECT c.customer_num, c.company, o.order_num
FROM customer c
	JOIN orders o
ON o.customer_num = c.customer_num	
ORDER BY o.order_num
--22.Listar los ítems de la orden número 1004, incluyendo una descripción de cada uno. El
--listado debe contener: Número de orden (order_num), Número de Item (item_num),
--Descripción del producto (stock.description), Código del fabricante
--(manu_code),Cantidad (quantity), Precio total (total_price)
SELECT o.order_num, i.item_num, s.description, s.manu_code, i.quantity, i.total_price
FROM orders o
	JOIN items i
ON o.order_num = i.order_num
	JOIN stock s
ON	i.manu_code = s.manu_code
AND i.stock_num = s.stock_num	
WHERE o.order_num = 1004
GROUP BY o.order_num, i.item_num, s.description, s.manu_code, i.quantity, i.total_price
GO