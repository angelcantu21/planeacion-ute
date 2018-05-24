drop procedure mostrarFechas;
delimiter $

CREATE PROCEDURE mostrarFechas(in idMate int, idper int)
BEGIN
SELECT semana, fecha_inicio, fecha_final, unidad, clave, descripcion FROM fechas, unidades WHERE fkMateria = idMate AND fkPeriodo = idper AND fkUnidad = idUnidad;
end $

call mostrarFechas(1,1);