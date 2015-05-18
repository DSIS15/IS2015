
CREATE TABLE contrato (
                codigo_contrato VARCHAR(5),
                tipo_contrato VARCHAR(20),
                fechainicio_contrato DATE,
                PRIMARY KEY (codigo_contrato)
);


CREATE TABLE puesto (
                codigo_puesto VARCHAR(5),
                nombre_puesto VARCHAR(40),
                jefeinmediato_puesto VARCHAR(40),
                PRIMARY KEY (codigo_puesto)
);



CREATE TABLE departamento (
                codigo_departamento VARCHAR(5),
		nombre_departamento VARCHAR(30),
                encargado_departamento VARCHAR(40),
                PRIMARY KEY (codigo_departamento)
);


CREATE TABLE empleado (
                codigo_empleado VARCHAR(5),
                nombre_empleado VARCHAR(40),
                apellido_empleado VARCHAR(40),
                telefono_empleado NUMERIC(8),
                fechanacimiento_empleado DATE,
                estadocivil_empleado VARCHAR(15),
                sexo_empleado VARCHAR(15),
                estudios_empleado VARCHAR(15),
                codigo_departamento VARCHAR(5),
                codigo_puesto VARCHAR(5),
                codigo_contrato VARCHAR(5),
                PRIMARY KEY (codigo_empleado)
);


ALTER TABLE empleado ADD CONSTRAINT contrato_empleado_fk
FOREIGN KEY (codigo_contrato)
REFERENCES contrato (codigo_contrato)
;

ALTER TABLE empleado ADD CONSTRAINT puesto_empleado_fk
FOREIGN KEY (codigo_puesto)
REFERENCES puesto (codigo_puesto)
;

ALTER TABLE empleado ADD CONSTRAINT departamento_empleado_fk
FOREIGN KEY (codigo_departamento)
REFERENCES departamento (codigo_departamento)
;
