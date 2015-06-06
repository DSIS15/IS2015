DROP DATABASE IF EXISTS `scfdb`;
CREATE DATABASE IF NOT EXISTS `scfdb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `scfdb`;

CREATE TABLE tabm_prov_cte (
                cod_prov_cte NUMERIC(7) NOT NULL,
                nombre_prov_cte VARCHAR(50) NOT NULL,
                nit_prov_cte VARCHAR(25) NOT NULL,
                descrip NUMERIC(1) NOT NULL,
                dire VARCHAR(50) NOT NULL,
                tel_prov_cte NUMERIC(8) NOT NULL,
                estado_prov_cte NUMERIC(1) NOT NULL,
                CONSTRAINT pk_prov_cte PRIMARY KEY (cod_prov_cte)
);


CREATE TABLE tabm_tmovimiento (
                cod_tmov NUMERIC(7) NOT NULL,
                nombre_tmov VARCHAR(25) NOT NULL,
                descrip_tmov VARCHAR(100) NOT NULL,
                estado_tmov NUMERIC(1) NOT NULL,
                CONSTRAINT pk_tmov PRIMARY KEY (cod_tmov)
);


CREATE TABLE tabm_poliza (
                cod_plz NUMERIC(7) NOT NULL,
                num_plz NUMERIC(7) NOT NULL,
                fechemi_plz TIMESTAMP NOT NULL,
                descrip_plz VARCHAR(100) NOT NULL,
                estado_plz NUMERIC(1) NOT NULL,
                CONSTRAINT pk_plz PRIMARY KEY (cod_plz)
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
                cod_bit INTEGER AUTO_INCREMENT,
                fecha_bit TIMESTAMP NOT NULL,
                usuario_bit VARCHAR(25) NOT NULL,
                maquina_bit VARCHAR(100) NOT NULL,
                ip_bit VARCHAR(25) NOT NULL,
                empresa_bit VARCHAR(50) NOT NULL,
                accion_bit VARCHAR(100) NOT NULL,
                CONSTRAINT pk_bit PRIMARY KEY (cod_bit)
);


CREATE TABLE tabm_empresa (
                cod_empsa NUMERIC(7) NOT NULL,
                nomcomercial_empsa VARCHAR(50) NOT NULL,
                rznsocial_empsa VARCHAR(50) NOT NULL,
                dire_empsa VARCHAR(50) NOT NULL,
                nit_empsa VARCHAR(25) NOT NULL,
                estado_empsa NUMERIC(1) NOT NULL,
                CONSTRAINT pk_empsa PRIMARY KEY (cod_empsa)
) ;


CREATE TABLE tabm_cuenta (
                cod_cta NUMERIC(7) NOT NULL,
                cod_empsa NUMERIC(7) NOT NULL,
                cod_mda NUMERIC(7) NOT NULL,
                nomenc_cta VARCHAR(15) NOT NULL,
                predec_cta VARCHAR(15) NOT NULL,
                nivel_cta NUMERIC(2) NOT NULL,
                cuenta_cta VARCHAR(50) NOT NULL,
                santerior_cta FLOAT NOT NULL,
                cargo_cta FLOAT NOT NULL,
                abono_cta FLOAT NOT NULL,
                sactual_cta FLOAT NOT NULL,
                cargosacum_cta FLOAT NOT NULL,
                abonosacum_cta FLOAT NOT NULL,
                debe_cta NUMERIC(1) NOT NULL,
                haber_cta NUMERIC(1) NOT NULL,
                perdida_cta NUMERIC(1) NOT NULL,
                ganancia_cta NUMERIC(1) NOT NULL,
                activo_cta NUMERIC(1) NOT NULL,
                pasivo_cta NUMERIC(1) NOT NULL,
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


CREATE TABLE tabt_dpoliza (
                cod_plz NUMERIC(7) NOT NULL,
                cod_cta NUMERIC(7) NOT NULL,
                corr_dplz NUMERIC(7) NOT NULL,
                cargo_dplz FLOAT NOT NULL,
                abono_dplz FLOAT NOT NULL,
                estado_dplz NUMERIC(1) NOT NULL,
                CONSTRAINT pk_dplz PRIMARY KEY (cod_plz, cod_cta, corr_dplz)
);


CREATE TABLE tabm_factura (
                cod_fact NUMERIC(7) NOT NULL,
                cod_plz NUMERIC(7) NOT NULL,
                cod_cta NUMERIC(7) NOT NULL,
                corr_dplz NUMERIC(7) NOT NULL,
                cod_prov_cte NUMERIC(7) NOT NULL,
                tipo_mov NUMERIC(1) NOT NULL,
                tipo_docto VARCHAR(25) NOT NULL,
                num_docto VARCHAR(15) NOT NULL,
                fecha_fact DATE NOT NULL,
                precio_neto FLOAT NOT NULL,
		imp_fact FLOAT NOT NULL,
		total_fact FLOAT NOT NULL,	
                CONSTRAINT pk_fact PRIMARY KEY (cod_fact)
);


CREATE TABLE tabm_amortdep (
                cod_amortdep NUMERIC(7) NOT NULL,
                cod_cta NUMERIC(7) NOT NULL,
                periodos_amortdep NUMERIC(2) NOT NULL,
                valorp_amortdep FLOAT NOT NULL,
                interes_amortdep FLOAT NOT NULL,
                estado_amortdep NUMERIC(1) NOT NULL,
                CONSTRAINT tabm_amortdep_pk PRIMARY KEY (cod_amortdep)
);


CREATE TABLE tabt_damortdep (
                cod_damortdep NUMERIC(7) NOT NULL,
                cod_amortdep NUMERIC(7) NOT NULL,
                periodo_damortdep NUMERIC(2) NOT NULL,
                pago_damortdep FLOAT NOT NULL,
                interes_damortdep FLOAT NOT NULL,
                amort_damortdep FLOAT NOT NULL,
                sfinal_damortdep FLOAT NOT NULL,
                estado_damortdep NUMERIC(1) NOT NULL,
                CONSTRAINT pk_tabt_damortdep PRIMARY KEY (cod_damortdep)
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
                CONSTRAINT pk_conci PRIMARY KEY (cod_estcta, cod_mov)
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


ALTER TABLE tabm_factura ADD CONSTRAINT tabm_prov_cte_tabt_factura_fk
FOREIGN KEY (cod_prov_cte)
REFERENCES tabm_prov_cte (cod_prov_cte)
;

ALTER TABLE tabm_movimiento ADD CONSTRAINT tabm_tmovimiento_tabm_movimiento_fk
FOREIGN KEY (cod_tmov)
REFERENCES tabm_tmovimiento (cod_tmov)
;

ALTER TABLE tabt_dpoliza ADD CONSTRAINT tabm_poliza_tabt_dpoliza_fk
FOREIGN KEY (cod_plz)
REFERENCES tabm_poliza (cod_plz)
;

ALTER TABLE tabm_ctabco ADD CONSTRAINT tabm_moneda_tabm_ctabco_fk
FOREIGN KEY (cod_mda)
REFERENCES tabm_moneda (cod_mda)
;

ALTER TABLE tabm_movimiento ADD CONSTRAINT tabm_moneda_tabm_movimiento_fk
FOREIGN KEY (cod_mda)
REFERENCES tabm_moneda (cod_mda)
;

ALTER TABLE tabm_cuenta ADD CONSTRAINT tabm_moneda_tabm_cuenta_fk
FOREIGN KEY (cod_mda)
REFERENCES tabm_moneda (cod_mda)
;

ALTER TABLE tabm_ctabco ADD CONSTRAINT tabm_empresa_tabm_ctabco_fk
FOREIGN KEY (cod_empsa)
REFERENCES tabm_empresa (cod_empsa)
;

ALTER TABLE tabm_movimiento ADD CONSTRAINT tabm_empresa_tabm_movimiento_fk
FOREIGN KEY (cod_empsa)
REFERENCES tabm_empresa (cod_empsa)
;

ALTER TABLE tabm_cuenta ADD CONSTRAINT tabm_empresa_tabm_cuenta_fk
FOREIGN KEY (cod_empsa)
REFERENCES tabm_empresa (cod_empsa)
;

ALTER TABLE tabm_amortdep ADD CONSTRAINT tabm_cuenta_tabm_amortdep_fk
FOREIGN KEY (cod_cta)
REFERENCES tabm_cuenta (cod_cta)
;

ALTER TABLE tabt_damortdep ADD CONSTRAINT tabm_amortdep_tabt_damortdep_fk
FOREIGN KEY (cod_amortdep)
REFERENCES tabm_amortdep (cod_amortdep)
;

ALTER TABLE tabt_dpoliza ADD CONSTRAINT tabm_cuenta_tabt_dpoliza_fk
FOREIGN KEY (cod_cta)
REFERENCES tabm_cuenta (cod_cta)
;

ALTER TABLE tabm_activos ADD CONSTRAINT tabm_cuenta_tabm_activos_fk
FOREIGN KEY (cod_cta)
REFERENCES tabm_cuenta (cod_cta)
;

ALTER TABLE tabm_factura ADD CONSTRAINT tabt_dpoliza_tabt_factura_fk
FOREIGN KEY (cod_plz, cod_cta, corr_dplz)
REFERENCES tabt_dpoliza (cod_plz, cod_cta, corr_dplz)
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

ALTER TABLE tabm_conciliacion ADD CONSTRAINT tabm_estadocuenta_tabm_conciliacion_fk
FOREIGN KEY (cod_estcta)
REFERENCES tabm_estadocuenta (cod_estcta)
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
('4', 'tabm_prov_cte', 'Clientes/Proveedores', 1),
('5', 'tabm_conciliacion', 'Conciliaciones bancarias', 1),
('6', 'tabm_ctabco', 'Cuentas bancarias', 1),
('7', 'tabm_cuenta', 'Cuentas contables', 1),
('8', 'tabm_empresa', 'Empresas', 1),
('9', 'tabm_estadocuenta', 'Estados de cuenta', 1),
('10', 'tabm_factura', 'Facturas', 1),
('11', 'tabm_moneda', 'Monedas', 1),
('12', 'tabm_movimiento', 'Movimientos', 1),
('13', 'tabm_perfil', 'Perfiles', 1),
('14', 'tabm_poliza', 'Polizas', 1),
('15', 'tabm_tmovimiento', 'Tipos de movimientos', 1),
('16', 'tabm_usuario', 'Usuarios', 1);

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
('1', '16', 1, 1, 1, 1, 1, 1);

INSERT INTO `tabm_ctabco` VALUES
('1', '1', '1', '12345', 'Hotel San Carlos', 'GyT Continental', 150000, '1');

INSERT INTO `tabm_cuenta` VALUES
('1', '1', '1', '1', '0', '1','Activo', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '1', '0', '1'),
('2', '1', '1', '1.1', '1', '2', 'Activo Corriente', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '1', '0', '1'),
('3', '1', '1', '1.2', '1', '2', 'Activo No Corriente', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '1', '0', '1'),
('4', '1', '1', '2', '0', '1', 'Pasivo', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '0', '1', '1'),
('5', '1', '1', '2.1', '2', '2', 'Pasivo Corriente', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '0', '1', '1'),
('6', '1', '1', '2.2', '2', '2', 'Pasivo No Corriente', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '0', '1', '1'),
('7', '1', '1', '3', '0', '1', 'Patrimonio Neto', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '0', '1', '1'),
('8', '1', '1', '1.1.1', '1.1', '3', 'Caja', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '1', '0', '1'),
('9', '1', '1', '1.1.2', '1.1', '3', 'Bancos', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '1', '0', '1'),
('10', '1', '1', '1.1.3', '1.1', '3', 'Clientes', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '1', '0', '1'),
('11', '1', '1', '1.2.1', '1.2', '3', 'Inmuebles', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '1', '0', '1'),
('12', '1', '1', '1.2.2', '1.2', '3', 'Mobiliario y Equipo', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '1', '0', '1'),
('13', '1', '1', '1.2.3', '1.2', '3', 'Maquinaria', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '1', '0', '1'),
('14', '1', '1', '2.1.1', '2.1', '3', 'Proveedores Comerciales', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '0', '1', '1'),
('15', '1', '1', '2.1.2', '2.1', '3', 'Acreedores no Comerciales', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '0', '1', '1'),
('16', '1', '1', '2.1.3', '2.1', '3', 'IVA por Pagar', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '0', '1', '1'),
('17', '1', '1', '2.2.1', '2.2', '3', 'Acreedores a Largo Plazo', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '0', '1', '1'),
('18', '1', '1', '2.2.2', '2.2', '3', 'Hipotecas a Largo Plazo', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '0', '1', '1'),
('19', '1', '1', '2.2.3', '2.2', '3', 'Emisión de Bonos', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '0', '1', '1'),
('20', '1', '1', '3.1', '3', '2', 'Capital', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '0', '1', '1'),
('21', '1', '1', '3.2', '3', '2', 'Capital Autorizado', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '0', '1', '1'),
('22', '1', '1', '3.3', '3', '2', 'Reserva Legal', 0, 0, 0, 0, 0, 0, '0', '0', '0', '0', '0', '1', '1'),
('23', '1', '1', '4', '0', '1', 'Debe', 0, 0, 0, 0, 0, 0, '1', '0', '0', '0', '0', '0', '1'),
('24', '1', '1', '5', '0', '1', 'Haber', 0, 0, 0, 0, 0, 0, '0', '1', '0', '0', '0', '0', '1'),
('25', '1', '1', '6', '0', '1', 'Perdida', 0, 0, 0, 0, 0, 0, '0', '0', '1', '0', '0', '0', '1'),
('26', '1', '1', '7', '0', '1', 'Ganancia', 0, 0, 0, 0, 0, 0, '0', '0', '0', '1', '0', '0', '1');

INSERT INTO `tabm_movimiento` VALUES
('1', '1', '1', '1', '1', '2015-04-08', '12345', 'a', 100, 0, '1'),
('2', '1', '1', '1', '1', '2015-04-08', '67890', 'b', 50, 0, '1');

INSERT INTO `tabm_estadocuenta` VALUES
('1', '1', '1', '2015', '\\\\127.0.0.1\\scf\\RUP.pdf', 'RUP.pdf', 8000, '1'),
('2', '1', '2', '2015', '\\\\127.0.0.1\\scf\\ManualTecnicoSCF.pdf', 'ManualTecnicoSCF.pdf', 10000, '1'),
('3', '1', '3', '2015', '\\\\127.0.0.1\\scf\\Ingenieria de Requerimientos.pdf', 'Ingenieria de Requerimientos.pdf', 12000, '1');

CREATE VIEW CompraVenta AS SELECT cod_fact, tipo_docto,num_docto,fecha_fact,IF(tipo_mov=0,'Compra','Venta') AS CompraVenta,precio_neto,imp_fact,IF(tipo_mov=0,'Crédito Fiscal','Débito Fiscal') AS CreditoDebito, total_fact FROM tabm_factura;

ALTER TABLE `tabm_bitacora` AUTO_INCREMENT=1;