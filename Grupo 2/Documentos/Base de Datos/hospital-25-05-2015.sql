CREATE TABLE moneda(
		id_moneda NUMERIC NOT NULL,
		descripcion VARCHAR(15),
		fecha VARCHAR(15),
		valor_compra VARCHAR(15),
		valor_venta VARCHAR(15),
		estado NUMERIC(1) NOT NULL,
		CONSTRAINT moneda_pk PRIMARY KEY(id_moneda)
);


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
                sexo VARCHAR(1) NOT NULL,
                identificacion_paciente NUMERIC NOT NULL,
                fecha_nacimiento_paciente VARCHAR(11) NOT NULL,
                estado NUMERIC(1) NOT NULL,
                CONSTRAINT paciente_pk PRIMARY KEY (id_pacientes)
);


CREATE TABLE examen_rutinario (
                id_exrutinario NUMERIC NOT NULL,
                presion VARCHAR(20) NOT NULL,
                colesterol VARCHAR(10) NOT NULL,
                glucosa VARCHAR(10) NOT NULL,
                altura FLOAT NOT NULL,
                peso VARCHAR(10) NOT NULL,
                estado_cavidad_bucal VARCHAR(10) NOT NULL,
                estado_oido VARCHAR(20) NOT NULL,
                id_pacientes NUMERIC NOT NULL,
                id_medico NUMERIC NOT NULL,
                sangre VARCHAR(2) NOT NULL,
                estado NUMERIC(1) NOT NULL,
                CONSTRAINT examen_rutinario_pk PRIMARY KEY (id_exrutinario)
);


CREATE TABLE receta_medica (
                id_recetamedica NUMERIC NOT NULL,
                id_medico NUMERIC NOT NULL,
                id_pacientes NUMERIC NOT NULL,
                nom_med VARCHAR(30) NOT NULL,
                categoria_med VARCHAR(30) NOT NULL,
                via_de_administracion VARCHAR(10) NOT NULL,
                dosis VARCHAR(15) NOT NULL,
                estado NUMERIC(1) NOT NULL,
                CONSTRAINT receta_medica_pk PRIMARY KEY (id_recetamedica)
);


CREATE TABLE tipo_examen (
                id_tipo_examen NUMERIC NOT NULL,
                nombre_tipo_examen VARCHAR(20) NOT NULL,
                descripcion_examen VARCHAR(25) NOT NULL,
                fecha_creacion VARCHAR(10) NOT NULL,
                fecha_modificacion VARCHAR(10) NOT NULL,
                estado NUMERIC(1) NOT NULL,
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
                codigo_perfil NUMERIC NOT NULL,
                id_modulo NUMERIC NOT NULL,
                fecha_creacion VARCHAR(10) NOT NULL,
                fecha_modificacion VARCHAR(10) NOT NULL,
                estado NUMERIC(1) NOT NULL,
                CONSTRAINT detalle_modulo_pk PRIMARY KEY (id_detmodulo)
);


CREATE TABLE usuario (
                id_usuario NUMERIC NOT NULL,
                codigo_perfil NUMERIC NOT NULL,
                alias_usuario VARCHAR(15) NOT NULL,
                contrasena_usuario VARCHAR(10) NOT NULL,
                nombre_usuario VARCHAR(15) NOT NULL,
                primer_apellido VARCHAR(10) NOT NULL,
                segundo_apellido VARCHAR(10) NOT NULL,
                direccion VARCHAR(25) NOT NULL,
                fecha_de_creacion VARCHAR(10) NOT NULL,
                fecha_de_modificacion VARCHAR(10) NOT NULL,
                estado NUMERIC(1) NOT NULL,
                CONSTRAINT usuario_pk PRIMARY KEY (id_usuario)
);


CREATE TABLE factura (
                numero_factura NUMERIC NOT NULL,
                nit_cliente VARCHAR(10) NOT NULL,
                id_usuario NUMERIC NOT NULL,
                id_pacientes NUMERIC NOT NULL,
                fecha VARCHAR(11) NOT NULL,
                CONSTRAINT factura_pk PRIMARY KEY (numero_factura)
);


CREATE TABLE det_fact (
                id_detfact NUMERIC NOT NULL,
                descripcion VARCHAR(20) NOT NULL,
                numero_factura NUMERIC NOT NULL,
                CONSTRAINT det_fact_pk PRIMARY KEY (id_detfact)
);


CREATE TABLE cita_medi (
                id_cita_medi NUMERIC NOT NULL,
                id_usuario NUMERIC NOT NULL,
                id_medico NUMERIC NOT NULL,
                id_pacientes NUMERIC NOT NULL,
                fecha_cita VARCHAR(10) NOT NULL,
                tipo_cita VARCHAR(15) NOT NULL,
                estado NUMERIC(1) NOT NULL,
                CONSTRAINT cita_medi_pk PRIMARY KEY (id_cita_medi)
);


CREATE TABLE bitacora_hospital (
                id_bitacora NUMERIC NOT NULL,
                id_usuario NUMERIC NOT NULL,
                hostname VARCHAR(20) NOT NULL,
                fecha VARCHAR(10) NOT NULL,
                hora VARCHAR(11) NOT NULL,
                ip VARCHAR(17) NOT NULL,
                descripcion VARCHAR(40) NOT NULL,
                CONSTRAINT bitacora_hospital_pk PRIMARY KEY (id_bitacora)
);




ALTER TABLE det_examen ADD CONSTRAINT medico_det_examen_fk
FOREIGN KEY (id_medico)
REFERENCES medico (id_medico)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE cita_medi ADD CONSTRAINT medico_cita_medi_fk
FOREIGN KEY (id_medico)
REFERENCES medico (id_medico)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE receta_medica ADD CONSTRAINT medico_receta_medica_fk
FOREIGN KEY (id_medico)
REFERENCES medico (id_medico)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE examen_rutinario ADD CONSTRAINT medico_examen_rutinario_fk
FOREIGN KEY (id_medico)
REFERENCES medico (id_medico)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE antecedentes_medicos ADD CONSTRAINT enfermedades_antecedentes_antecedentes_medicos_fk
FOREIGN KEY (id_enfermedad)
REFERENCES enfermedades_antecedentes (id_enfermedad)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE antecedentes_medicos ADD CONSTRAINT paciente_antecedentes_medicos_fk
FOREIGN KEY (id_pacientes)
REFERENCES paciente (id_pacientes)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE det_examen ADD CONSTRAINT paciente_det_examen_fk
FOREIGN KEY (id_pacientes)
REFERENCES paciente (id_pacientes)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE cita_medi ADD CONSTRAINT paciente_cita_medi_fk
FOREIGN KEY (id_pacientes)
REFERENCES paciente (id_pacientes)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE factura ADD CONSTRAINT paciente_factura_fk
FOREIGN KEY (id_pacientes)
REFERENCES paciente (id_pacientes)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE receta_medica ADD CONSTRAINT paciente_receta_medica_fk
FOREIGN KEY (id_pacientes)
REFERENCES paciente (id_pacientes)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE examen_rutinario ADD CONSTRAINT paciente_examen_rutinario_fk
FOREIGN KEY (id_pacientes)
REFERENCES paciente (id_pacientes)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE det_examen ADD CONSTRAINT tipo_examen_det_examen_fk
FOREIGN KEY (id_tipo_examen)
REFERENCES tipo_examen (id_tipo_examen)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE detalle_modulo ADD CONSTRAINT modulo_detalle_modulo_fk
FOREIGN KEY (id_modulo)
REFERENCES modulo (id_modulo)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE sub_modulo ADD CONSTRAINT modulo_sub_modulo_fk
FOREIGN KEY (id_modulo)
REFERENCES modulo (id_modulo)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE usuario ADD CONSTRAINT perfil_usuario_fk
FOREIGN KEY (codigo_perfil)
REFERENCES perfil (codigo_perfil)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE detalle_modulo ADD CONSTRAINT perfil_detalle_modulo_fk
FOREIGN KEY (codigo_perfil)
REFERENCES perfil (codigo_perfil)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE bitacora_hospital ADD CONSTRAINT usuario_bitacora_hospital_fk
FOREIGN KEY (id_usuario)
REFERENCES usuario (id_usuario)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE cita_medi ADD CONSTRAINT usuario_cita_medi_fk
FOREIGN KEY (id_usuario)
REFERENCES usuario (id_usuario)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE factura ADD CONSTRAINT usuario_factura_fk
FOREIGN KEY (id_usuario)
REFERENCES usuario (id_usuario)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE det_fact ADD CONSTRAINT factura_det_fact_fk
FOREIGN KEY (numero_factura)
REFERENCES factura (numero_factura)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

Create view viewbitacora_hospital as (Select bh.id_bitacora, u.alias_usuario, u.nombre_usuario, u.primer_apellido, bh.hostname, bh.fecha, bh.hora, bh.ip, bh.descripcion
from bitacora_hospital bh
INNER JOIN usuario u ON u.id_usuario = bh.id_usuario);

INSERT INTO moneda(id_moneda,descripcion,fecha,valor_compra,valor_venta,estado) VALUES (1,'Quetzal','25/05/2015','1','1',1);
INSERT INTO moneda(id_moneda,descripcion,fecha,valor_compra,valor_venta,estado) VALUES (2,'Dolar','25/05/2015','8','8',1);
 
INSERT INTO perfil (codigo_perfil, nombre_perfil, fecha_creacion, fecha_modificacion, estado) VALUES (1,'admin','18/05/2015','18/05/2015',1 );

INSERT INTO usuario (id_usuario, codigo_perfil, alias_usuario, contrasena_usuario, nombre_usuario, primer_apellido, segundo_apellido, direccion, fecha_de_creacion, fecha_de_modificacion, estado) VALUES (1,1,'admin','admin','admin','admin','admin','admin','18/05/2015','18/05/2015',1);

INSERT INTO modulo (id_modulo, nombre_modulo, nombre_dll, fecha_creacion, fecha_modificacion, estado) VALUES (1,'Inicio','','18/05/2015','18/05/2015',1);
INSERT INTO modulo (id_modulo, nombre_modulo, nombre_dll, fecha_creacion, fecha_modificacion, estado) VALUES (2,'Seguridad','dll_seguridad','18/05/2015','18/05/2015',1); 
INSERT INTO modulo (id_modulo, nombre_modulo, nombre_dll, fecha_creacion, fecha_modificacion, estado) VALUES (3,'Bitacora','dll_bitacora','18/05/2015','18/05/2015',1); 
INSERT INTO modulo (id_modulo, nombre_modulo, nombre_dll, fecha_creacion, fecha_modificacion, estado) VALUES (4,'Paciente','dll_paciente','18/05/2015','18/05/2015',1);
INSERT INTO modulo (id_modulo, nombre_modulo, nombre_dll, fecha_creacion, fecha_modificacion, estado) VALUES (5,'Medico','dll_medico','18/05/2015','18/05/2015',1);

INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (1,1,'Ordenar modo cascada','','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (2,1,'Ordenar modo Horizontal','','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (3,1,'Ordenar modo Vertical','','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (4,1,'Cerrar Sesion','','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (5,1,'Salir','','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (6,2,'Usuario','wfUsuario','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (7,2,'Modulo','wfModulo','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (8,2,'Sub Modulo','wfSubMod','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (9,2,'Perfil','wfPerfiles','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (10,2,'Administracion de Recursos','wfDetMod','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (11,3,'Bitacora','wfBitacora','15/05/2015','15/05/2015',1);

INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (12,4,'Administracion de Paciente','wfPaciente','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (13,4,'Antecedentes Medicos','wfAntecedentesMed','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (14,4,'Enfermedades','wfEnfermedadesAnt','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (15,4,'Examen Rutinario','wfExamenRutinario','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (16,4,'Receta Medica','wfRecetaMedica','15/05/2015','15/05/2015',1);

INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (17,5,'Medico','wfMedico','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (18,5,'Cita Medica','wfCitaMedica','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (19,5,'Tipo Examen','wfTipoExamen','15/05/2015','15/05/2015',1);
INSERT INTO sub_modulo (id_submodulo, id_modulo, nombre_submodulo, nombre_form, fecha_creacion, fecha_modificacion, estado) VALUES (20,5,'Detalle Examen','wfDetalleExamen','15/05/2015','15/05/2015',1);


INSERT INTO detalle_modulo (id_detmodulo, id_modulo, codigo_perfil, fecha_creacion, fecha_modificacion, estado) VALUES (1,1,1,'18/05/2015','18/05/2015',1);
INSERT INTO detalle_modulo (id_detmodulo, id_modulo, codigo_perfil, fecha_creacion, fecha_modificacion, estado) VALUES (2,2,1,'18/05/2015','18/05/2015',1);
INSERT INTO detalle_modulo (id_detmodulo, id_modulo, codigo_perfil, fecha_creacion, fecha_modificacion, estado) VALUES (3,3,1,'18/05/2015','18/05/2015',1);
INSERT INTO detalle_modulo (id_detmodulo, id_modulo, codigo_perfil, fecha_creacion, fecha_modificacion, estado) VALUES (4,4,1,'18/05/2015','18/05/2015',1);
INSERT INTO detalle_modulo (id_detmodulo, id_modulo, codigo_perfil, fecha_creacion, fecha_modificacion, estado) VALUES (5,5,1,'18/05/2015','18/05/2015',1);
