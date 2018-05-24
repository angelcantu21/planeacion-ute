drop procedure mostrarCabecera;
delimiter $

CREATE PROCEDURE mostrarCabecera(in idMate int, idper int, idMa int)
BEGIN
SELECT concat(temporada, ' (',meses,') ',año) as Periodo, materia, horasxsemana, concat(nombre,' ',apellido_P,' ',apellido_M) as Nombre, grupo, cuatrimestre, turno FROM cuatrimestres, grupos, maestros, materias, periodos, turnos WHERE idMateria = idMate AND FkGrupo = idGrupo AND FkTurno = idTurno AND FkCuatrimestre = idCuatrimestre AND idPeriodo=idper AND idMaestro = idMa;
end $

call mostrarCabecera(1,1,1);