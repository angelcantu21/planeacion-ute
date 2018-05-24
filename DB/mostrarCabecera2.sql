drop procedure mostrarCabecera;
delimiter $

CREATE PROCEDURE mostrarCabecera(in idMate int, idper int, idMa int, idGru int)
BEGIN
SELECT concat(temporada, ' (',meses,') ',año) as Periodo, materia, horasxsemana, concat(nombre,' ',apellido_P,' ',apellido_M) as Nombre, grupo, cuatrimestre, turno FROM cuatrimestres, grupos, maestros, materias, periodos, turnos, GrupoMaterias, MateriaMaestros WHERE MateriaMaestros.FKMateria=idMate AND FKMaestro = idMa AND idMateria=idMate AND idMaestro=idMa AND GrupoMaterias.FKGrupo = idGru AND idGrupo = idGru AND GrupoMaterias.FKMateria = idMate AND FkTurno = idTurno AND FkCuatrimestre = idCuatrimestre AND idPeriodo=idper;
end $

call mostrarCabecera(2,1,2,14);