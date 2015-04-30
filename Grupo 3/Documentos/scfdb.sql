CREATE DATABASE `scfdb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `scfdb`;

CREATE TABLE tabm_impuesto (
                cod_imp NUMERIC(7) NOT NULL,
                impuesto_imp VARCHAR(25) NOT NULL,
                valor_imp FLOAT NOT NULL,
                estado_imp NUMERIC(1) NOT NULL,
                CONSTRAINT pk_imp PRIMARY KEY (cod_imp)
);

CREATE TABLE tabm_tmovimiento (
                cod_tmov NUMERIC(7) NOT NULL,
                nombre_tmov VARCHAR(25) NOT NULL,
                descrip_tmov VARCHAR(100) NOT NULL,
                estado_tmov NUMERIC(1) NOT NULL,
                CONSTRAINT pk_tmov PRIMARY KEY (cod_tmov)
);

CREATE TABLE tabm_clasificacion (
                cod_clf NUMERIC(7) NOT NULL,
                nombre_clf VARCHAR(25) NOT NULL,
                nomenc_clf VARCHAR(15) NOT NULL,
                descrip_clf VARCHAR(100) NOT NULL,
                estado_clf NUMERIC(1) NOT NULL,
                CONSTRAINT pk_clf PRIMARY KEY (cod_clf)
);

CREATE TABLE tabm_cuenta (
                cod_cta NUMERIC(7) NOT NULL,
                cod_clf NUMERIC(7) NOT NULL,
                nombre_cta VARCHAR(50) NOT NULL,
                nomenc_cta VARCHAR(15) NOT NULL,
                estado_cta NUMERIC(1) NOT NULL,
                CONSTRAINT pk_cta PRIMARY KEY (cod_cta)
);

CREATE TABLE tabm_activos (
                cod_act NUMERIC(7) NOT NULL,
                cod_cta NUMERIC(7) NOT NULL,
                descrip_act VARCHAR(100) NOT NULL,
                color_act VARCHAR(25) NOT NULL,
                tamanio_act VARCHAR(25) NOT NULL,
                modelo_act VARCHAR(50) NOT NULL,
                estado_act NUMERIC(1) NOT NULL,
                CONSTRAINT pk_activos PRIMARY KEY (cod_act)
);

CREATE TABLE tabm_porcentaje (
                cod_pct NUMERIC(7) NOT NULL,
                cod_cta NUMERIC(7) NOT NULL,
                cod_act NUMERIC(7) NOT NULL,
                factor_pct FLOAT NOT NULL,
                estado_pct NUMERIC(1) NOT NULL,
                CONSTRAINT tabm_porcentaje_pk PRIMARY KEY (cod_pct)
);

CREATE TABLE tabm_amortdep (
                cod_amortdep NUMERIC(7) NOT NULL,
                cod_cta NUMERIC(7) NOT NULL,
                anio_amortdep NUMERIC(4) NOT NULL,
                metodo_amortdep VARCHAR(50) NOT NULL,
                interes_amortdep FLOAT NOT NULL,
                vidautil_amortdep NUMERIC(2) NOT NULL,
                produccion_amortdep FLOAT NOT NULL,
                desecho_amortdep FLOAT NOT NULL,
                estado_amortdep NUMERIC(1) NOT NULL,
                CONSTRAINT tabm_amortdep_pk PRIMARY KEY (cod_amortdep)
);

CREATE TABLE tabm_moneda (
                cod_mda NUMERIC(7) NOT NULL,
                moneda_mda VARCHAR(25) NOT NULL,
                abrev_mda VARCHAR(25) NOT NULL,
                tipocambio_mda FLOAT NOT NULL,
                estado_mda NUMERIC(1) NOT NULL,
                CONSTRAINT pk_mda PRIMARY KEY (cod_mda)
);

CREATE TABLE tabm_bitacora (
                cod_bit INTEGER NOT NULL AUTO_INCREMENT,
                fecha_bit TIMESTAMP NOT NULL,
                usuario_bit VARCHAR(25) NOT NULL,
                maquina_bit VARCHAR(100) NOT NULL,
                ip_bit VARCHAR(25) NOT NULL,
                empresa_bit VARCHAR(50) NOT NULL,
                accion_bit VARCHAR(100) NOT NULL,
                CONSTRAINT pk_bit PRIMARY KEY (cod_bit)
) AUTO_INCREMENT=1;

CREATE TABLE tabm_empresa (
                cod_empsa NUMERIC(7) NOT NULL,
                nomcomercial_empsa VARCHAR(50) NOT NULL,
                rznsocial_empsa VARCHAR(50) NOT NULL,
                dire_empsa VARCHAR(50) NOT NULL,
                nit_empsa VARCHAR(25) NOT NULL,
                estado_empsa NUMERIC(1) NOT NULL,
                CONSTRAINT pk_empsa PRIMARY KEY (cod_empsa)
);

CREATE TABLE tabm_dcuenta (
                cod_dcta NUMERIC(7) NOT NULL,
                cod_empsa NUMERIC(7) NOT NULL,
                cod_mda NUMERIC(7) NOT NULL,
                cod_cta NUMERIC(7) NOT NULL,
                mes_dcta NUMERIC(2) NOT NULL,
                anio_dcta NUMERIC(4) NOT NULL,
                debe_dcta FLOAT NOT NULL,
                haber_dcta FLOAT NOT NULL,
                perdida_dcta FLOAT NOT NULL,
                ganancia_dcta FLOAT NOT NULL,
                activo_dcta FLOAT NOT NULL,
                pasivo_dcta FLOAT NOT NULL,
                estado_dcta NUMERIC(1) NOT NULL,
                CONSTRAINT pk_dsta PRIMARY KEY (cod_dcta)
);

CREATE TABLE tabm_ctabco (
                cod_ctabco NUMERIC(7) NOT NULL,
                cod_empsa NUMERIC(7) NOT NULL,
                cod_mda NUMERIC(7) NOT NULL,
                numcta_ctabco VARCHAR(25) NOT NULL,
                nombre_ctabco VARCHAR(50) NOT NULL,
                banco_ctabco VARCHAR(50) NOT NULL,
                saldo_ctabco FLOAT NOT NULL,
                estado_ctabco NUMERIC(1) NOT NULL,
                CONSTRAINT pk_ctabco PRIMARY KEY (cod_ctabco)
);

CREATE TABLE tabm_movimiento (
                cod_mov NUMERIC(7) NOT NULL,
                cod_empsa NUMERIC(7) NOT NULL,
                cod_mda NUMERIC(7) NOT NULL,
                cod_tmov NUMERIC(7) NOT NULL,
                cod_ctabco NUMERIC(7) NOT NULL,
                fechmov_mov TIMESTAMP NOT NULL,
                correlativo_mov NUMERIC(15) NOT NULL,
                descrip_mov VARCHAR(100) NOT NULL,
                debito_mov FLOAT NOT NULL,
                credito_mov FLOAT NOT NULL,
                estado_mov NUMERIC(1) NOT NULL,
                CONSTRAINT pk_mov PRIMARY KEY (cod_mov)
);

CREATE TABLE tabt_impmov (
                cod_imp NUMERIC(7) NOT NULL,
                cod_mov NUMERIC(7) NOT NULL,
                total_impmov FLOAT NOT NULL,
                CONSTRAINT pk_impmov PRIMARY KEY (cod_imp, cod_mov)
);

CREATE TABLE tabm_estadocuenta (
                cod_estcta NUMERIC(7) NOT NULL,
                cod_ctabco NUMERIC(7) NOT NULL,
                mes_estcta NUMERIC(2) NOT NULL,
                anio_estcta NUMERIC(4) NOT NULL,
                ubic_estcta VARCHAR(300) NOT NULL,
				nombre_estcta VARCHAR(50) NOT NULL,
                saldo_estcta FLOAT NOT NULL,
                estado_estcta NUMERIC(1) NOT NULL,
                CONSTRAINT pk_estcta PRIMARY KEY (cod_estcta)
);

CREATE TABLE tabm_conciliacion (
                cod_estcta NUMERIC(7) NOT NULL,
                cod_mov NUMERIC(7) NOT NULL,
                fechconci_conci TIMESTAMP NOT NULL,
                conciliado_conci NUMERIC(1) NOT NULL,
                estado_conci NUMERIC(1) NOT NULL,
                CONSTRAINT pk_conci PRIMARY KEY (cod_estcta,cod_mov)
);

CREATE TABLE tabm_poliza (
                cod_plz NUMERIC(7) NOT NULL,
                cod_empsa NUMERIC(7) NOT NULL,
                cod_mda NUMERIC(7) NOT NULL,
                num_plz NUMERIC(7) NOT NULL,
                fechemi_plz TIMESTAMP NOT NULL,
                descrip_plz VARCHAR(100) NOT NULL,
                estado_plz NUMERIC(1) NOT NULL,
                CONSTRAINT pk_plz PRIMARY KEY (cod_plz)
);

CREATE TABLE tabt_dpoliza (
                cod_plz NUMERIC(7) NOT NULL,
                cod_cta NUMERIC(7) NOT NULL,
                corr_dplz NUMERIC(7) NOT NULL,
                cargo_dplz FLOAT NOT NULL,
                abono_dplz FLOAT NOT NULL,
                estado_dplz NUMERIC(1) NOT NULL,
                CONSTRAINT pk_dplz PRIMARY KEY (cod_plz, cod_cta, corr_dplz)
);

CREATE TABLE tabm_perfil (
                cod_pfl NUMERIC(7) NOT NULL,
                perfil_pfl VARCHAR(25) NOT NULL,
                descrip_pfl VARCHAR(100) NOT NULL,
                estado_pfl NUMERIC(1) NOT NULL,
                CONSTRAINT pk_pfl PRIMARY KEY (cod_pfl)
);

CREATE TABLE tabm_tabla (
                cod_tbl NUMERIC(7) NOT NULL,
                tabla_tbl VARCHAR(50) NOT NULL,
                alias_tbl VARCHAR(50) NOT NULL,
                estado_tbl NUMERIC(1) NOT NULL,
                CONSTRAINT pk_tbl PRIMARY KEY (cod_tbl)
);

CREATE TABLE tabt_dperfil (
                cod_pfl NUMERIC(7) NOT NULL,
                cod_tbl NUMERIC(7) NOT NULL,
                insert_dpfl NUMERIC(1) NOT NULL,
                update_dpfl NUMERIC(1) NOT NULL,
                delete_dpfl NUMERIC(1) NOT NULL,
                print_dpfl NUMERIC(1) NOT NULL,
                select_dpfl NUMERIC(1) NOT NULL,
                estado_dpfl NUMERIC(1) NOT NULL,
                CONSTRAINT pk_dpfl PRIMARY KEY (cod_pfl, cod_tbl)
);

CREATE TABLE tabm_usuario (
                cod_usr NUMERIC(7) NOT NULL,
                cod_pfl NUMERIC(7) NOT NULL,
                usuario_usr VARCHAR(25) NOT NULL,
                password_usr VARCHAR(100) NOT NULL,
                estado_usr NUMERIC(1) NOT NULL,
                CONSTRAINT pk_usr PRIMARY KEY (cod_usr)
);

CREATE TABLE tabt_permisoespecial (
                cod_usr NUMERIC(7) NOT NULL,
                cod_tbl NUMERIC(7) NOT NULL,
                insert_permspl NUMERIC(1) NOT NULL,
                update_permspl NUMERIC(1) NOT NULL,
                delete_permspl NUMERIC(1) NOT NULL,
                print_permspl NUMERIC(1) NOT NULL,
                select_permspl NUMERIC(1) NOT NULL,
                estado_permspl NUMERIC(1) NOT NULL,
                CONSTRAINT pk_permspl PRIMARY KEY (cod_usr, cod_tbl)
);

ALTER TABLE tabt_impmov ADD CONSTRAINT tabm_impuesto_tabt_dmovimiento_fk
FOREIGN KEY (cod_imp)
REFERENCES tabm_impuesto (cod_imp)
;

ALTER TABLE tabm_movimiento ADD CONSTRAINT tabm_tmovimiento_tabm_movimiento_fk
FOREIGN KEY (cod_tmov)
REFERENCES tabm_tmovimiento (cod_tmov)
;

ALTER TABLE tabm_amortdep ADD CONSTRAINT tabm_cuenta_tabm_amortdep_fk
FOREIGN KEY (cod_cta)
REFERENCES tabm_cuenta (cod_cta)
;

ALTER TABLE tabt_dpoliza ADD CONSTRAINT tabm_cuenta_tabt_dpoliza_fk
FOREIGN KEY (cod_cta)
REFERENCES tabm_cuenta (cod_cta)
;

ALTER TABLE tabm_porcentaje ADD CONSTRAINT tabm_cuenta_tabm_porcentaje_fk
FOREIGN KEY (cod_cta)
REFERENCES tabm_cuenta (cod_cta)
;

ALTER TABLE tabm_activos ADD CONSTRAINT tabm_cuenta_tabm_activos_fk
FOREIGN KEY (cod_cta)
REFERENCES tabm_cuenta (cod_cta)
;

ALTER TABLE tabm_dcuenta ADD CONSTRAINT tabm_cuenta_tabm_dcuenta_fk
FOREIGN KEY (cod_cta)
REFERENCES tabm_cuenta (cod_cta)
;

ALTER TABLE tabm_porcentaje ADD CONSTRAINT tabm_activos_tabm_porcentaje_fk
FOREIGN KEY (cod_act)
REFERENCES tabm_activos (cod_act)
;

ALTER TABLE tabm_poliza ADD CONSTRAINT tabm_moneda_tabm_poliza_fk
FOREIGN KEY (cod_mda)
REFERENCES tabm_moneda (cod_mda)
;

ALTER TABLE tabm_ctabco ADD CONSTRAINT tabm_moneda_tabm_ctabco_fk
FOREIGN KEY (cod_mda)
REFERENCES tabm_moneda (cod_mda)
;

ALTER TABLE tabm_dcuenta ADD CONSTRAINT tabm_moneda_tabm_dcuenta_fk
FOREIGN KEY (cod_mda)
REFERENCES tabm_moneda (cod_mda)
;

ALTER TABLE tabm_movimiento ADD CONSTRAINT tabm_moneda_tabm_movimiento_fk
FOREIGN KEY (cod_mda)
REFERENCES tabm_moneda (cod_mda)
;

ALTER TABLE tabm_poliza ADD CONSTRAINT tabm_empresa_tabm_poliza_fk
FOREIGN KEY (cod_empsa)
REFERENCES tabm_empresa (cod_empsa)
;

ALTER TABLE tabm_ctabco ADD CONSTRAINT tabm_empresa_tabm_ctabco_fk
FOREIGN KEY (cod_empsa)
REFERENCES tabm_empresa (cod_empsa)
;

ALTER TABLE tabm_dcuenta ADD CONSTRAINT tabm_empresa_tabm_dcuenta_fk
FOREIGN KEY (cod_empsa)
REFERENCES tabm_empresa (cod_empsa)
;

ALTER TABLE tabm_movimiento ADD CONSTRAINT tabm_empresa_tabm_movimiento_fk
FOREIGN KEY (cod_empsa)
REFERENCES tabm_empresa (cod_empsa)
;

ALTER TABLE tabm_estadocuenta ADD CONSTRAINT tabm_ctabco_tabm_estadocuenta_fk
FOREIGN KEY (cod_ctabco)
REFERENCES tabm_ctabco (cod_ctabco)
;

ALTER TABLE tabm_movimiento ADD CONSTRAINT tabm_ctabco_tabm_movimiento_fk
FOREIGN KEY (cod_ctabco)
REFERENCES tabm_ctabco (cod_ctabco)
;

ALTER TABLE tabm_conciliacion ADD CONSTRAINT tabm_movimiento_tabm_conciliacion_fk
FOREIGN KEY (cod_mov)
REFERENCES tabm_movimiento (cod_mov)
;

ALTER TABLE tabt_impmov ADD CONSTRAINT tabm_movimiento_tabt_dmovimiento_fk
FOREIGN KEY (cod_mov)
REFERENCES tabm_movimiento (cod_mov)
;

ALTER TABLE tabm_conciliacion ADD CONSTRAINT tabm_estadocuenta_tabm_conciliacion_fk
FOREIGN KEY (cod_estcta)
REFERENCES tabm_estadocuenta (cod_estcta)
;

ALTER TABLE tabt_dpoliza ADD CONSTRAINT tabm_poliza_tabt_dpoliza_fk
FOREIGN KEY (cod_plz)
REFERENCES tabm_poliza (cod_plz)
;

ALTER TABLE tabt_dperfil ADD CONSTRAINT tabm_perfil_tabt_dperfil_fk
FOREIGN KEY (cod_pfl)
REFERENCES tabm_perfil (cod_pfl)
;

ALTER TABLE tabm_usuario ADD CONSTRAINT tabm_perfil_tabm_usuario_fk
FOREIGN KEY (cod_pfl)
REFERENCES tabm_perfil (cod_pfl)
;

ALTER TABLE tabt_dperfil ADD CONSTRAINT tabm_tabla_tabt_dperfil_fk
FOREIGN KEY (cod_tbl)
REFERENCES tabm_tabla (cod_tbl)
;

ALTER TABLE tabt_permisoespecial ADD CONSTRAINT tabm_tabla_tabt_permisoespecial_fk
FOREIGN KEY (cod_tbl)
REFERENCES tabm_tabla (cod_tbl)
;

ALTER TABLE tabt_permisoespecial ADD CONSTRAINT tabm_usuario_tabt_permisoespecial_fk
FOREIGN KEY (cod_usr)
REFERENCES tabm_usuario (cod_usr)
;

INSERT INTO `tabm_empresa` VALUES
('1', 'Hotel San Carlos', 'Hotel San Carlos', 'Av. La Reforma 7-89, Zona 10', '4372342-6', 1);

INSERT INTO `tabm_moneda` VALUES
('1', 'Quetzal', 'GTQ', 1, 1),
('2', 'Dolar', 'USD', 7.63612, 1);

INSERT INTO `tabm_perfil` VALUES
('1', 'Administrador', 'Administrador del sistema', 1);

INSERT INTO `tabm_tabla` VALUES
('1', 'tabm_activos', 'Activos', 1),
('2', 'tabm_amortdep', 'Amortizaciones/Depreciaciones', 1),
('3', 'tabm_clasificacion', 'Clasificacion de cuentas', 1),
('4', 'tabm_conciliacion', 'Conciliaciones bancarias', 1),
('5', 'tabm_ctabco', 'Cuentas bancarias', 1),
('6', 'tabm_cuenta', 'Cuentas contables', 1),
('7', 'tabm_dcuenta', 'Detalle de Cuentas contables', 1),
('8', 'tabm_empresa', 'Empresas', 1),
('9', 'tabm_estadocuenta', 'Estados de cuenta', 1),
('10', 'tabm_impuesto', 'Impuestos', 1),
('11', 'tabm_moneda', 'Monedas', 1),
('12', 'tabm_movimiento', 'Movimientos', 1),
('13', 'tabm_perfil', 'Perfiles', 1),
('14', 'tabm_poliza', 'Polizas', 1),
('15', 'tabm_porcentaje', 'Porcentajes', 1),
('16', 'tabm_tmovimiento', 'Tipos de movimientos', 1),
('17', 'tabm_usuario', 'Usuarios', 1);

INSERT INTO `tabm_tmovimiento` VALUES
('1', 'Deposito', 'Depositos bancarios', 1),
('2', 'Retiro', 'Retiros bancarios', 1),
('3', 'Cheque', 'Cheques emitidos', 1),
('4', 'Nota de debito', 'Notas de debito emitidas', 1),
('5', 'Nota de credito', 'Notas de credito emitidas', 1);

INSERT INTO `tabm_usuario` VALUES
('1', '1', 'admin', '+9gn21LwZ7M=', 1);

INSERT INTO `tabt_dperfil` VALUES
('1', '1', 1, 1, 1, 1, 1, 1),
('1', '2', 1, 1, 1, 1, 1, 1),
('1', '3', 1, 1, 1, 1, 1, 1),
('1', '4', 1, 1, 1, 1, 1, 1),
('1', '5', 1, 1, 1, 1, 1, 1),
('1', '6', 1, 1, 1, 1, 1, 1),
('1', '7', 1, 1, 1, 1, 1, 1),
('1', '8', 1, 1, 1, 1, 1, 1),
('1', '9', 1, 1, 1, 1, 1, 1),
('1', '10', 1, 1, 1, 1, 1, 1),
('1', '11', 1, 1, 1, 1, 1, 1),
('1', '12', 1, 1, 1, 1, 1, 1),
('1', '13', 1, 1, 1, 1, 1, 1),
('1', '14', 1, 1, 1, 1, 1, 1),
('1', '15', 1, 1, 1, 1, 1, 1),
('1', '16', 1, 1, 1, 1, 1, 1),
('1', '17', 1, 1, 1, 1, 1, 1);

INSERT INTO `tabm_ctabco` VALUES
('1', '1', '1', '12345', 'Hotel San Carlos', 'GyT Continental', 150000, '1');

INSERT INTO `tabm_movimiento` VALUES
('1', '1', '1', '1', '1', '2015-04-08', '12345', 'a', 100, 0, '1'),
('2', '1', '1', '1', '1', '2015-04-08', '67890', 'b', 50, 0, '1');

INSERT INTO `tabm_estadocuenta` VALUES
('1', '1', '1', '2015', '\\\\127.0.0.1\\scf\\RUP.pdf', 'RUP.pdf', 8000, '1'),
('2', '1', '2', '2015', '\\\\127.0.0.1\\scf\\ManualTecnicoSCF.pdf', 'ManualTecnicoSCF.pdf', 10000, '1'),
('3', '1', '3', '2015', '\\\\127.0.0.1\\scf\\Ingenieria de Requerimientos.pdf', 'Ingenieria de Requerimientos.pdf', 12000, '1');