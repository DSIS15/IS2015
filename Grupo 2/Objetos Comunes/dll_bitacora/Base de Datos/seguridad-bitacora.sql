
CREATE TABLE roll (
                id_roll INT AUTO_INCREMENT NOT NULL,
                nombre_roll VARCHAR(15) NOT NULL,
                descripcion VARCHAR(20) NOT NULL,
                fecha_creacion DATE NOT NULL,
                fecha_modificacion DATE NOT NULL,
                estado BOOLEAN NOT NULL,
                PRIMARY KEY (id_roll)
);


CREATE TABLE modulo (
                id_modulo INT AUTO_INCREMENT NOT NULL,
                nombre_modulo VARCHAR(25) NOT NULL,
                nombre_dll VARCHAR(15) NOT NULL,
                fecha_creacion DATE NOT NULL,
                fecha_modificacion DATE NOT NULL,
                estado BOOLEAN,
                PRIMARY KEY (id_modulo)
);


CREATE TABLE sub_modulo (
                id_submodulo INT AUTO_INCREMENT NOT NULL,
                id_modulo INT NOT NULL,
                nombre_submodulo VARCHAR(25) NOT NULL,
                nombre_form VARCHAR(25) NOT NULL,
                fecha_creacion DATE NOT NULL,
                fecha_modificacion DATE NOT NULL,
                estado BOOLEAN NOT NULL,
                PRIMARY KEY (id_submodulo)
);


CREATE TABLE perfil (
                codigo_perfil INT AUTO_INCREMENT NOT NULL,
                nombre_perfil VARCHAR(15) NOT NULL,
                fecha_creacion DATE NOT NULL,
                fecha_modificacion DATE NOT NULL,
                estado BOOLEAN NOT NULL,
                PRIMARY KEY (codigo_perfil)
);


CREATE TABLE usuario (
                id_usuario INT AUTO_INCREMENT NOT NULL,
                codigo_perfil INT NOT NULL,
                id_roll INT NOT NULL,
                alias_usuario VARCHAR(15) NOT NULL,
                contrasena_usuario VARCHAR(10) NOT NULL,
                nombre_usuario VARCHAR(15) NOT NULL,
                primer_apellido VARCHAR(10) NOT NULL,
                segundo_apellido VARCHAR(10) NOT NULL,
                direccion VARCHAR(25) NOT NULL,
                fecha_de_creacion DATE NOT NULL,
                fecha_de_modificacion DATE NOT NULL,
                estado BOOLEAN NOT NULL,
                PRIMARY KEY (id_usuario)
);


CREATE TABLE Bitacora (
                id_bitacora INT NOT NULL,
                hostname VARCHAR NOT NULL,
                fecha_hora DATE NOT NULL,
                descripcion VARCHAR NOT NULL,
                ip INT NOT NULL,
                id_usuario INT NOT NULL,
                PRIMARY KEY (id_bitacora)
);


CREATE TABLE detalle_modulo (
                id_detmod INT AUTO_INCREMENT NOT NULL,
                id_modulo INT NOT NULL,
                codigo_perfil INT NOT NULL,
                fecha_creacion DATE NOT NULL,
                fecha_modificacion DATE NOT NULL,
                estado BOOLEAN NOT NULL,
                PRIMARY KEY (id_detmod, id_modulo)
);


ALTER TABLE usuario ADD CONSTRAINT roll_usuario_fk
FOREIGN KEY (id_roll)
REFERENCES roll (id_roll)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE sub_modulo ADD CONSTRAINT modulo_sub_modulo_fk
FOREIGN KEY (id_modulo)
REFERENCES modulo (id_modulo)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE detalle_modulo ADD CONSTRAINT modulo_detalle_modulo_fk
FOREIGN KEY (id_modulo)
REFERENCES modulo (id_modulo)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE detalle_modulo ADD CONSTRAINT perfiles_detalle_modulo_fk
FOREIGN KEY (codigo_perfil)
REFERENCES perfil (codigo_perfil)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE usuario ADD CONSTRAINT perfil_usuario_fk
FOREIGN KEY (codigo_perfil)
REFERENCES perfil (codigo_perfil)
ON DELETE NO ACTION
ON UPDATE NO ACTION;

ALTER TABLE Bitacora ADD CONSTRAINT usuario_bitacora_fk
FOREIGN KEY (id_usuario)
REFERENCES usuario (id_usuario)
ON DELETE NO ACTION
ON UPDATE NO ACTION;
