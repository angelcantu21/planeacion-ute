use proyectoint;

select * from turnos;

INSERT INTO turnos (turno) VALUES('MATUTINO');
INSERT INTO turnos (turno) VALUES('VESPERTINO');
INSERT INTO turnos (turno) VALUES('NOCTURNO');

SELECT * FROM cuatrimestres;

INSERT INTO cuatrimestres (cuatrimestre) VALUES('CERO');
INSERT INTO cuatrimestres (cuatrimestre) VALUES('PRIMERO');
INSERT INTO cuatrimestres (cuatrimestre) VALUES('SEGUNDO');
INSERT INTO cuatrimestres (cuatrimestre) VALUES('TERCERO');
INSERT INTO cuatrimestres (cuatrimestre) VALUES('CUARTO');
INSERT INTO cuatrimestres (cuatrimestre) VALUES('QUINTO');
INSERT INTO cuatrimestres (cuatrimestre) VALUES('SEXTO');
INSERT INTO cuatrimestres (cuatrimestre) VALUES('SEPTIMO');
INSERT INTO cuatrimestres (cuatrimestre) VALUES('OCTAVO');
INSERT INTO cuatrimestres (cuatrimestre) VALUES('NOVENO');
INSERT INTO cuatrimestres (cuatrimestre) VALUES('DECIMO');
INSERT INTO cuatrimestres (cuatrimestre) VALUES('ONCEAVO');

SELECT * FROM grupos;

SELECT * FROM materias;

SELECT * FROM GrupoMaterias;

SELECT idMateria as Numero_Materia, Materia,horasXsemana as Horas_X_Semana, grupo FROM grupos, materias, grupomaterias WHERE FKMateria=idMateria AND Fkgrupo=idGrupo;

SELECT * FROM MateriaMaestros;

SELECT idMaestro,concat(nombre,' ',apellido_P,' ',apellido_M) as Nombre, materia FROM materiamaestros, materias, maestros WHERE idMateria=1 AND FKMateria=1;

SELECT * FROM maestros;

SELECT * FROM periodos;

SELECT * FROM fechas;

SELECT * FROM fechas WHERE fkMateria = 1 AND fkPeriodo = 1;
SELECT idPeriodo, concat(temporada, ' (',meses,') ',año) as Periodo FROM periodos;
SELECT concat(temporada, ' (',meses,') ',año) as Periodo, materia, horasxsemana, concat(nombre,' ',apellido_P,' ',apellido_M) as Nombre, grupo, cuatrimestre, turno, semana, fecha_inicio, fecha_final FROM cuatrimestres, grupos, maestros, materias, periodos, turnos, fechas WHERE maestros.fkMateria = idMateria AND FkGrupo = idGrupo AND FkTurno = idTurno AND FkCuatrimestre = idCuatrimestre AND fechas.FKPeriodo=idPeriodo AND fechas.FKMateria = idMateria;

INSERT INTO unidades (unidad, clave, descripcion) VALUES ('I. Patrones de Diseño','UI.AA1','Caracteristicas de un patron de diseño.');
INSERT INTO unidades (unidad, clave, descripcion) VALUES ('I. Patrones de Diseño','UI.AA2','Patron MVC.');
INSERT INTO unidades (unidad, clave, descripcion) VALUES ('I. Patrones de Diseño','UI.RA1','Asigancion del patron MVC.');

INSERT INTO unidades (unidad, clave, descripcion) VALUES ('II. Manejo de Archivos','UI.AA1','Acceso secuencial');
INSERT INTO unidades (unidad, clave, descripcion) VALUES ('II. Menejo de Archivos','UI.AA2','Acceso exponencial');
INSERT INTO unidades (unidad, clave, descripcion) VALUES ('II. Manejo de Archivos','UI.RA1','Acceso aleatorio de archivos');

INSERT INTO unidades (unidad, clave, descripcion) VALUES ('III. Manipulacion de datos','UI.AA1','Aplicacion con conexion a base de datos');
INSERT INTO unidades (unidad, clave, descripcion) VALUES ('III. Manipulacion de datos','UI.RA1','Aplicacion con reportes');

INSERT INTO unidades (unidad, clave, descripcion) VALUES ('IV. Desarrollo Multicapa','UIV.AA1','Sockets');
INSERT INTO unidades (unidad, clave, descripcion) VALUES ('IV. Desarrollo Multicapa','UIV.AA2','Hilos');
INSERT INTO unidades (unidad, clave, descripcion) VALUES ('IV. Desarrollo Multicapa','UIV.RA1','Aplicacion multicapa');
SELECT * FROM unidades;

SELECT semana, fecha_inicio, fecha_final,unidad, clave, descripcion FROM fechas, unidades, materias, periodos WHERE fkMateria = idMateria AND fkPeriodo = idPeriodo AND fkUnidad = idUnidad;

INSERT INTO administradores (nombre, usuario, contraseña, tipo) VALUES('Jose Angel Cantu Ramirez','admin','admin','Administrador');
INSERT INTO administradores (nombre, usuario, contraseña, tipo) VALUES('Brenda Mezquitic Gallardo','invitado','admin','Maestro');

SELECT idMaestro,concat(nombre,' ',apellido_P,' ',apellido_M) as Nombre, materia, idMateria FROM materiamaestros, materias, maestros WHERE FkMateria=1 AND FKMateria=idMateria AND FKMaestro=idMaestro; -- VER MAESTRO APARTIR DE UNA MATERIA
SELECT idMateria as Numero_Materia, Materia,horasXsemana as Horas_X_Semana, grupo FROM grupos, materias, grupomaterias WHERE FkMateria=2 AND FKMateria=idMateria AND Fkgrupo=idGrupo; -- VER GRUPOS APARTIR DE UNA MATERIA
SELECT idGrupo,grupo, idCuatrimestre,cuatrimestre FROM grupos,cuatrimestres, turnos WHERE idGrupo=1 AND FKCuatrimestre=idCuatrimestre AND FKTurno=idTurno;
SELECT turno FROM grupos,cuatrimestres, turnos WHERE idGrupo=1 AND FKCuatrimestre=idCuatrimestre AND FKTurno=idTurno;

INSERT INTO apuntes (nombre, contenido, FKUsuario) VALUES ('apuntes1','Esta es una prueba',1);


select * from apuntes;

/*DIA*/
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('ERIKA PATRICIA', 'LUCIO', 'AYALA');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('VERONICA', 'MEDINA', 'TAMEZ');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('IRMA IVONNE', 'MARTINEZ', 'DIMAS');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('MARIA ELENA', 'HERNANDEZ', 'CHAVEZ');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('RICARDO LEONARDO', 'ARZATE', 'RAMIREZ');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('ARACELY', 'PONCE', 'TRUJILLO');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('OMAR', 'AVILA', 'CABRERA');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('FELIPE DE JESUS', 'ROSALES', 'MANDUJANO');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('HUGO ALONSO', 'LEYVA', 'RODRIGUEZ');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('JUAN IGNACIO', 'CERVANTES', 'GONZALEZ');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('JUANA LIZETH', 'ROSALES', 'NEVAREZ');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('SUSANA ESMERALDA', 'MACIEL', 'SALAS');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('JUAN LUIS', 'ARELLANO', 'ESCAMILLA');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('MARCO ANTONIO', 'ORTEGA', 'ROSALES');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('HORACIO ENRIQUE', 'CASTILLO', 'PUENTE');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('MARY CARMEN', 'VAQUERA', 'GARCIA');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('RAMIRO', 'MARTINEZ', 'ALVARADO');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('SERGIO', 'ESCOBEDO', NULL);
/*NOCHE*/
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('ALEJANDRA', 'ALONSO', 'FUENTES');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('EVER CARLOS', 'JIMENEZ', 'MARTINEZ');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('FABIOLA ABIGAIL', 'CONTRERAS', 'ARENAS');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('JOSE GILBERTO', 'CAZARES', 'RAMIREZ');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('JOSE LUIS', 'LOPEZ', 'SALAS');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('JOSE LUIS', 'CRUZ', 'ORTEGA');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('ORLANDO DANIEL', 'CHAIRES', 'MARTINEZ');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('SUSANA ESMERALDA', 'MACIEL SALAS', 'FUENTES');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('JOSUE JORAI', 'HERNANDEZ', 'COLORADO');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('SAUL IVAN', 'GOMEZ', 'JUAREZ');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('ANDRES APOLINAR', 'ROJAS', 'DE ANDA');
insert into maestros (Nombre, Apellido_P, Apellido_M) values ('JUAN ADAN', 'GONZALEZ', 'ESCOBEDO');

insert into Materias (Materia, horasXsemana) values ('Inglés', 1, 10);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Desarrollo de Habilidades de Pensamiento Lógico', 2, 3);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Soporte Técnico', 2, 4);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Metodología de la Programación', 2, 3);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Ofirmática', 2, 3);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Fundamentos de Redes', 2, 6);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Expresión Oral y Escrita I', 2, 3);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Inglés I', 2, 3);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Formación Sociocultural I', 2, 2);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Dessarrollo de Haábilidades de Pensamiento Matemático', 3, 5);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Programación', 3, 5);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Base de Datos I', 3, 7);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Introducción al Analisis y Dessarrollo de Sistemas I', 3, 4);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Redes de Area Local', 3, 6);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Inglés II', 3, 2);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Formación Sociocultural II', 3, 3);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Desarrollo de Aplicaciones Web', 4, 2);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Desarrollo de Aplicaciones I', 4, 4);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Base de Datos II', 4, 8);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Sistemas Operativos', 4, 4);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Administración de la Función Informática', 4, 3);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Integradora I', 4, 2);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Inglés III', 4, 2);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Formación Sociocultural III', 4, 2);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Desarrollo de Aplicaciones II', 5, 5);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Estructura de Datos', 5, 6);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Ingeniería de Software I', 5, 4);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Administración de Base de Datos', 5, 4);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Inglés IV', 5, 3);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Formación Sociocultural IV', 5, 3);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Desarrollo de Aplicaiones III', 6, 5);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Ingeniería de Software II', 6, 4);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Calidad en el Desarrollo de Software', 6, 5);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Administración de Proyectos', 6, 2);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Integradora II', 6, 2);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Expresión Oral y Escrita II', 6, 3);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Inglés V', 6, 2);
INSERT INTO Materias (Materia, horasXsemana) VALUES ('Estadía', 7, 1);

SELECT semana, fecha_inicio, fecha_final, unidad, clave, descripcion FROM fechas, unidades WHERE fkMateria = 1 AND fkPeriodo = 1 AND fkUnidad = idUnidad AND semana=1;
SELECT unidad, clave, descripcion FROM fechas, unidades WHERE fkMateria = 1 AND fkPeriodo = 1 AND fkUnidad = idUnidad AND semana=1