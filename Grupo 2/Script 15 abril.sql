
CREATE TABLE medico (
                id_medico NUMERIC NOT NULL,
                nombre_medico VARCHAR(25) NOT NULL,
                priimer_apellido_medico VARCHAR(15) NOT NULL,
                medico_segundo_apellido VARCHAR(15) NOT NULL,
                fecha_ingreso VARCHAR(11) NOT NULL,
                estado NUMERIC(1) NOT NULL,
                CONSTRAINT medico_pk PRIMARY KEY (id_medico)
);


CREATE TABLE enfermedades_antecedentes (
                id_enfermedad NUMERIC NOT NULL,
                nombre_enfermedad VARCHAR(15) NOT NULL,
                estado NUMERIC(1) NOT NULL,
                CONSTRAINT enfermedades_antecedentes_pk PRIMARY KEY (id_enfermedad)
);


CREATE TABLE paciente (
                id_pacientes NUMERIC NOT NULL,
                nombre_paciente VARCHAR(25) NOT NULL,
                primer_apellido VARCHAR(15) NOT NULL,
                segundo_apellido VARCHAR(15) NOT NULL,
                direccion_paciente VARCHAR(30) NOT NULL,
                telefono_paciente VARCHAR(9) NOT NULL,
                estatura_paciente DECIMAL NOT NULL,
                peso_paciente DECIMAL NOT NULL,
                sangre_paciente VARCHAR(5) NOT NULL,
                identificacion_paciente NUMERIC NOT NULL,
                fecha_nacimiento_paciente VARCHAR(10) NOT NULL,
                estado INTEGER NOT NULL,
                CONSTRAINT paciente_pk PRIMARY KEY (id_pacientes)
);


CREATE TABLE tipo_examen (
                id_tipo_examen NUMERIC NOT NULL,
                nombre_tipo_examen VARCHAR(20) NOT NULL,
                descripcion_examen VARCHAR(25) NOT NULL,
                fecha_creacion VARCHAR(10) NOT NULL,
                fecha_modificacion VARCHAR(10) NOT NULL,
                estado INTEGER NOT NULL,
                CONSTRAINT tipo_examen_pk PRIMARY KEY (id_tipo_examen)
);


CREATE TABLE det_examen (
                id_det_examen NUMERIC NOT NULL,
                id_pacientes NUMERIC NOT NULL,
                id_tipo_examen NUMERIC NOT NULL,
                id_medico NUMERIC NOT NULL,
                CONSTRAINT det_examen_pk PRIMARY KEY (id_det_examen)
);


CREATE TABLE antecedentes_medicos (
                id_antecente_medico NUMERIC NOT NULL,
                id_pacientes NUMERIC NOT NULL,
                id_enfermedad NUMERIC NOT NULL,
                Descripcion VARCHAR(25) NOT NULL,
                CONSTRAINT antecedentes_medicos_pk PRIMARY KEY (id_antecente_medico)
);


CREATE TABLE modulo (
                id_modulo NUMERIC NOT NULL,
                nombre_modulo VARCHAR(25) NOT NULL,
                nombre_dll VARCHAR(25) NOT NULL,
                fecha_creacion VARCHAR(10) NOT NULL,
                fecha_modificacion VARCHAR(10) NOT NULL,
                estado NUMERIC(1) NOT NULL,
                CONSTRAINT modulo_pk PRIMARY KEY (id_modulo)
);


CREATE TABLE sub_modulo (
                id_submodulo NUMERIC NOT NULL,
                id_modulo NUMERIC NOT NULL,
                nombre_submodulo VARCHAR(30) NOT NULL,
                nombre_form VARCHAR(30) NOT NULL,
                fecha_creacion VARCHAR(10) NOT NULL,
                fecha_modificacion VARCHAR(10) NOT NULL,
                estado NUMERIC(1) NOT NULL,
                CONSTRAINT sub_modulo_pk PRIMARY KEY (id_submodulo)
);


CREATE TABLE perfil (
                codigo_perfil NUMERIC NOT NULL,
                nombre_perfil VARCHAR(15) NOT NULL,
                fecha_creacion VARCHAR(15) NOT NULL,
                fecha_modificacion VARCHAR(10) NOT NULL,
                estado NUMERIC(1) NOT NULL,
                CONSTRAINT perfil_pk PRIMARY KEY (codigo_perfil)
);


CREATE TABLE detalle_modulo (
                id_detmodulo NUMERIC NOT NULL,
                id_modulo NUMERIC NOT NULL,
                fecha_creacion VARCHAR(10) NOT NULL,
                fecha_modificacion VARCHAR(10) NOT NULL,
                estado NUMERIC(1) NOT NULL,
                codigo_perfil NUMERIC NOT NULL,
                CONSTRAINT detalle_modulo_pk PRIMARY KEY (id_detmodulo)
);


CREATE TABLE usuario (
                id_usuario NUMERIC NOT NULL,
                alias_usuario VARCHAR(15) NOT NULL,
                contrasena_usuario VARCHAR(10) NOT NULL,
                nombre_usuario VARCHAR(15) NOT NULL,
                primer_apellido VARCHAR(10) NOT NULL,
                segundo_apellido VARCHAR(10) NOT NULL,
                direccion VARCHAR(25) NOT NULL,
                fecha_de_creacion VARCHAR(10) NOT NULL,
                fecha_de_modificacion VARCHAR(10) NOT NULL,
                codigo_perfil NUMERIC NOT NULL,
                estado NUMERIC(1) NOT NULL,
                CONSTRAINT usuario_pk PRIMARY KEY (id_usuario)
);


CREATE TABLE cita_medi (
                id_cita_medi NUMERIC NOT NULL,
                id_usuario NUMERIC NOT NULL,
                fecha_cita VARCHAR(10) NOT NULL,
                estado INTEGER NOT NULL,
                id_medico NUMERIC NOT NULL,
                id_pacientes NUMERIC NOT NULL,
                CONSTRAINT cita_medi_pk PRIMARY KEY (id_cita_medi)
);


CREATE TABLE bitacora_hospital (
                id_bitacora NUMERIC NOT NULL,
                id_usuario NUMERIC NOT NULL,
                hostname VARCHAR(20) NOT NULL,
                fecha VARCHAR(10) NOT NULL,
                hora VARCHAR(11) NOT NULL,
                ip VARCHAR(17) NOT NULL,
                descripcion VARCHAR(30) NOT NULL,
                CONSTRAINT bitacora_hospital_pk PRIMARY KEY (id_bitacora)
);


ALTER TABLE det_examen ADD CONSTRAINT medico_det_examen_fk
FOREIGN KEY (id_medico)
REFERENCES medico (id_medico)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;

ALTER TABLE cita_medi ADD CONSTRAINT medico_cita_medi_fk
FOREIGN KEY (id_medico)
REFERENCES medico (id_medico)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;

ALTER TABLE antecedentes_medicos ADD CONSTRAINT enfermedades_antecedentes_antecedentes_medicos_fk
FOREIGN KEY (id_enfermedad)
REFERENCES enfermedades_antecedentes (id_enfermedad)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;

ALTER TABLE antecedentes_medicos ADD CONSTRAINT paciente_antecedentes_medicos_fk
FOREIGN KEY (id_pacientes)
REFERENCES paciente (id_pacientes)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;

ALTER TABLE det_examen ADD CONSTRAINT paciente_det_examen_fk
FOREIGN KEY (id_pacientes)
REFERENCES paciente (id_pacientes)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;

ALTER TABLE cita_medi ADD CONSTRAINT paciente_cita_medi_fk
FOREIGN KEY (id_pacientes)
REFERENCES paciente (id_pacientes)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;

ALTER TABLE det_examen ADD CONSTRAINT tipo_examen_det_examen_fk
FOREIGN KEY (id_tipo_examen)
REFERENCES tipo_examen (id_tipo_examen)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;

ALTER TABLE detalle_modulo ADD CONSTRAINT modulo_detalle_modulo_fk
FOREIGN KEY (id_modulo)
REFERENCES modulo (id_modulo)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;

ALTER TABLE sub_modulo ADD CONSTRAINT modulo_sub_modulo_fk
FOREIGN KEY (id_modulo)
REFERENCES modulo (id_modulo)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;

ALTER TABLE usuario ADD CONSTRAINT perfil_usuario_fk
FOREIGN KEY (codigo_perfil)
REFERENCES perfil (codigo_perfil)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;

ALTER TABLE detalle_modulo ADD CONSTRAINT perfil_detalle_modulo_fk
FOREIGN KEY (codigo_perfil)
REFERENCES perfil (codigo_perfil)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;

ALTER TABLE bitacora_hospital ADD CONSTRAINT usuario_bitacora_hospital_fk
FOREIGN KEY (id_usuario)
REFERENCES usuario (id_usuario)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;

ALTER TABLE cita_medi ADD CONSTRAINT usuario_cita_medi_fk
FOREIGN KEY (id_usuario)
REFERENCES usuario (id_usuario)
ON DELETE NO ACTION
ON UPDATE NO ACTION
NOT DEFERRABLE;
