-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 08-03-2015 a las 04:29:31
-- Versión del servidor: 5.5.24-log
-- Versión de PHP: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `scfdb`
--
CREATE DATABASE `scfdb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `scfdb`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_bitacora`
--

CREATE TABLE IF NOT EXISTS `tabm_bitacora` (
  `cod_bit` int(7) NOT NULL AUTO_INCREMENT,
  `fecha_bit` datetime NOT NULL,
  `usuario_bit` varchar(25) DEFAULT NULL,
  `maquina_bit` varchar(100) NOT NULL,
  `ip_bit` varchar(25) NOT NULL,
  `empresa_bit` varchar(50) DEFAULT NULL,
  `accion_bit` varchar(100) NOT NULL,
  PRIMARY KEY (`cod_bit`),
  KEY `tabm_usuario_tabm_bitacora_fk` (`usuario_bit`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_conciliacion`
--

CREATE TABLE IF NOT EXISTS `tabm_conciliacion` (
  `cod_conci` decimal(7,0) NOT NULL,
  `fechconci_conci` date NOT NULL,
  `cod_estcta` decimal(7,0) NOT NULL,
  `cod_mov` decimal(7,0) NOT NULL,
  `conciliado_conci` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_conci`),
  KEY `tabm_movimiento_tabm_conciliacion_fk` (`cod_mov`),
  KEY `tabm_estadocuenta_tabm_conciliacion_fk` (`cod_estcta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_ctabco`
--

CREATE TABLE IF NOT EXISTS `tabm_ctabco` (
  `cod_ctabco` decimal(7,0) NOT NULL,
  `cod_empsa` decimal(7,0) NOT NULL,
  `cod_mda` decimal(7,0) NOT NULL,
  `numcta_ctabco` varchar(25) NOT NULL,
  `nombre_ctabco` varchar(50) NOT NULL,
  `banco_ctabco` varchar(50) NOT NULL,
  `saldo_ctabco` float NOT NULL,
  `estado_ctabco` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_ctabco`),
  KEY `tabm_moneda_tabm_ctabco_fk` (`cod_mda`),
  KEY `tabm_empresa_tabm_ctabco_fk` (`cod_empsa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_cuenta`
--

CREATE TABLE IF NOT EXISTS `tabm_cuenta` (
  `cod_cta` decimal(7,0) NOT NULL,
  `cod_tcta` decimal(7,0) NOT NULL,
  `cuenta_cta` varchar(25) NOT NULL,
  `descrip_cta` varchar(100) NOT NULL,
  `estado_cta` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_cta`),
  KEY `tabm_tcuenta_tabm_cuenta_fk` (`cod_tcta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_empresa`
--

CREATE TABLE IF NOT EXISTS `tabm_empresa` (
  `cod_empsa` decimal(7,0) NOT NULL,
  `nomcomercial_empsa` varchar(50) NOT NULL,
  `rznsocial_empsa` varchar(50) NOT NULL,
  `dire_empsa` varchar(50) NOT NULL,
  `nit_empsa` varchar(25) NOT NULL,
  `estado_empsa` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_empsa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_empresa`
--

INSERT INTO `tabm_empresa` (`cod_empsa`, `nomcomercial_empsa`, `rznsocial_empsa`, `dire_empsa`, `nit_empsa`, `estado_empsa`) VALUES
('1', 'Hotel San Carlos', 'Hotel San Carlos', 'Av. La Reforma 7-89, Zona 10', '4372342-6', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_estadocuenta`
--

CREATE TABLE IF NOT EXISTS `tabm_estadocuenta` (
  `cod_estcta` decimal(7,0) NOT NULL,
  `cod_ctabco` decimal(7,0) NOT NULL,
  `mes_estcta` varchar(25) NOT NULL,
  `anio_estcta` varchar(25) NOT NULL,
  `ubic_estcta` varchar(300) NOT NULL,
  `estado_estcta` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_estcta`),
  KEY `tabm_ctabco_tabm_estadocuenta_fk` (`cod_ctabco`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_lmayor`
--

CREATE TABLE IF NOT EXISTS `tabm_lmayor` (
  `cod_lmyr` decimal(7,0) NOT NULL,
  `cod_mda` decimal(7,0) NOT NULL,
  `cod_empsa` decimal(7,0) NOT NULL,
  `cod_cta` decimal(7,0) NOT NULL,
  `cargo_lmyr` float NOT NULL,
  `abono_lmyr` float NOT NULL,
  `deudor_lmyr` float NOT NULL,
  `acreedor_lmyr` float NOT NULL,
  PRIMARY KEY (`cod_lmyr`),
  KEY `tabm_cuenta_tabm_lmayor_fk` (`cod_cta`),
  KEY `tabm_moneda_tabm_lmayor_fk` (`cod_mda`),
  KEY `tabm_empresa_tabm_lmayor_fk` (`cod_empsa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_moneda`
--

CREATE TABLE IF NOT EXISTS `tabm_moneda` (
  `cod_mda` decimal(7,0) NOT NULL,
  `moneda_mda` varchar(25) NOT NULL,
  `abrev_mda` varchar(25) NOT NULL,
  `tipocambio_mda` float NOT NULL,
  `estado_mda` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_mda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_moneda`
--

INSERT INTO `tabm_moneda` (`cod_mda`, `moneda_mda`, `abrev_mda`, `tipocambio_mda`, `estado_mda`) VALUES
('1', 'Quetzal', 'GTQ', 1, 1),
('2', 'Dolar', 'USD', 7.63612, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_movimiento`
--

CREATE TABLE IF NOT EXISTS `tabm_movimiento` (
  `cod_mov` decimal(7,0) NOT NULL,
  `cod_tmov` decimal(7,0) NOT NULL,
  `cod_ctabco` decimal(7,0) NOT NULL,
  `fechmov_mov` date NOT NULL,
  `correlativo_mov` decimal(15,0) NOT NULL,
  `descrip_mov` varchar(100) NOT NULL,
  `debito_mov` float NOT NULL,
  `credito_mov` float NOT NULL,
  `saldo_mov` float NOT NULL,
  `estado_mov` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_mov`),
  KEY `tabm_tmovimiento_tabm_movimiento_fk` (`cod_tmov`),
  KEY `tabm_ctabco_tabm_movimiento_fk` (`cod_ctabco`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_perfil`
--

CREATE TABLE IF NOT EXISTS `tabm_perfil` (
  `cod_pfl` decimal(7,0) NOT NULL,
  `perfil_pfl` varchar(25) NOT NULL,
  `descrip_pfl` varchar(100) NOT NULL,
  `estado_pfl` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_pfl`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_perfil`
--

INSERT INTO `tabm_perfil` (`cod_pfl`, `perfil_pfl`, `descrip_pfl`, `estado_pfl`) VALUES
('1', 'Administrador', 'Administrador del sistema', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_poliza`
--

CREATE TABLE IF NOT EXISTS `tabm_poliza` (
  `cod_plz` decimal(7,0) NOT NULL,
  `cod_empsa` decimal(7,0) NOT NULL,
  `cod_mda` decimal(7,0) NOT NULL,
  `num_plz` decimal(7,0) NOT NULL,
  `fechemi_plz` date NOT NULL,
  `descrip_plz` varchar(100) NOT NULL,
  `debito_plz` float NOT NULL,
  `credito_plz` float NOT NULL,
  `estado_plz` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_plz`),
  KEY `tabm_moneda_tabm_poliza_fk` (`cod_mda`),
  KEY `tabm_empresa_tabm_poliza_fk` (`cod_empsa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_tabla`
--

CREATE TABLE IF NOT EXISTS `tabm_tabla` (
  `cod_tbl` decimal(7,0) NOT NULL,
  `tabla_tbl` varchar(25) NOT NULL,
  `estado_tbl` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_tbl`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_tabla`
--

INSERT INTO `tabm_tabla` (`cod_tbl`, `tabla_tbl`, `estado_tbl`) VALUES
('1', 'tabm_conciliacion', 1),
('2', 'tabm_ctabco', 1),
('3', 'tabm_cuenta', 1),
('4', 'tabm_empresa', 1),
('5', 'tabm_estadocuenta', 1),
('6', 'tabm_lmayor', 1),
('7', 'tabm_moneda', 1),
('8', 'tabm_movimiento', 1),
('9', 'tabm_perfil', 1),
('10', 'tabm_poliza', 1),
('11', 'tabm_tcuenta', 1),
('12', 'tabm_tmovimiento', 1),
('13', 'tabm_usuario', 1),
('14', 'tabt_dperfil', 1),
('15', 'tabt_dpoliza', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_tcuenta`
--

CREATE TABLE IF NOT EXISTS `tabm_tcuenta` (
  `cod_tcta` decimal(7,0) NOT NULL,
  `nombre_tcta` varchar(25) NOT NULL,
  `descrip_tcta` varchar(100) NOT NULL,
  `estado_tcta` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_tcta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_tcuenta`
--

INSERT INTO `tabm_tcuenta` (`cod_tcta`, `nombre_tcta`, `descrip_tcta`, `estado_tcta`) VALUES
('1', 'Activo corriente', 'Cuentas de activo corriente', 1),
('2', 'Activo no corriente', 'Cuentas de activo no corriente', 1),
('3', 'Pasivo corriente', 'Cuentas de pasivo corriente', 1),
('4', 'Pasivo no corriente', 'Cuentas de pasivo no corriente', 1),
('5', 'Patrimonio neto', 'Cuentas de patrimonio neto', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_tmovimiento`
--

CREATE TABLE IF NOT EXISTS `tabm_tmovimiento` (
  `cod_tmov` decimal(7,0) NOT NULL,
  `nombre_tmov` varchar(25) NOT NULL,
  `descrip_tmov` varchar(100) NOT NULL,
  `estado_tmov` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_tmov`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_tmovimiento`
--

INSERT INTO `tabm_tmovimiento` (`cod_tmov`, `nombre_tmov`, `descrip_tmov`, `estado_tmov`) VALUES
('1', 'Deposito', 'Depositos bancarios', 1),
('2', 'Retiro', 'Retiros bancarios', 1),
('3', 'Cheque', 'Cheques emitidos', 1),
('4', 'Nota de debito', 'Notas de debito emitidas', 1),
('5', 'Nota de credito', 'Notas de credito emitidas', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_usuario`
--

CREATE TABLE IF NOT EXISTS `tabm_usuario` (
  `cod_usr` decimal(7,0) NOT NULL,
  `cod_pfl` decimal(7,0) NOT NULL,
  `usuario_usr` varchar(25) NOT NULL,
  `password_usr` varchar(25) NOT NULL,
  `estado_usr` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_usr`),
  KEY `tabm_perfil_tabm_usuario_fk` (`cod_pfl`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabm_usuario`
--

INSERT INTO `tabm_usuario` (`cod_usr`, `cod_pfl`, `usuario_usr`, `password_usr`, `estado_usr`) VALUES
('1', '1', 'admin', 'admin', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_dperfil`
--

CREATE TABLE IF NOT EXISTS `tabt_dperfil` (
  `cod_pfl` decimal(7,0) NOT NULL,
  `cod_tbl` decimal(7,0) NOT NULL,
  `insert_dpfl` tinyint(1) NOT NULL,
  `update_dpfl` tinyint(1) NOT NULL,
  `delete_dpfl` tinyint(1) NOT NULL,
  `print_dpfl` tinyint(1) NOT NULL,
  `select_dpfl` tinyint(1) NOT NULL,
  `estado_dpfl` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_pfl`,`cod_tbl`),
  KEY `tabm_tabla_tabt_dperfil_fk` (`cod_tbl`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tabt_dperfil`
--

INSERT INTO `tabt_dperfil` (`cod_pfl`, `cod_tbl`, `insert_dpfl`, `update_dpfl`, `delete_dpfl`, `print_dpfl`, `select_dpfl`, `estado_dpfl`) VALUES
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
('1', '15', 1, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_dpoliza`
--

CREATE TABLE IF NOT EXISTS `tabt_dpoliza` (
  `cod_plz` decimal(7,0) NOT NULL,
  `cod_cta` decimal(7,0) NOT NULL,
  `debito_dplz` float NOT NULL,
  `credito_dplz` float NOT NULL,
  `estado_dplz` tinyint(1) NOT NULL,
  PRIMARY KEY (`cod_plz`,`cod_cta`),
  KEY `tabm_cuenta_tabt_dpoliza_fk` (`cod_cta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tabm_conciliacion`
--
ALTER TABLE `tabm_conciliacion`
  ADD CONSTRAINT `tabm_estadocuenta_tabm_conciliacion_fk` FOREIGN KEY (`cod_estcta`) REFERENCES `tabm_estadocuenta` (`cod_estcta`),
  ADD CONSTRAINT `tabm_movimiento_tabm_conciliacion_fk` FOREIGN KEY (`cod_mov`) REFERENCES `tabm_movimiento` (`cod_mov`);

--
-- Filtros para la tabla `tabm_ctabco`
--
ALTER TABLE `tabm_ctabco`
  ADD CONSTRAINT `tabm_empresa_tabm_ctabco_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_empresa` (`cod_empsa`),
  ADD CONSTRAINT `tabm_moneda_tabm_ctabco_fk` FOREIGN KEY (`cod_mda`) REFERENCES `tabm_moneda` (`cod_mda`);

--
-- Filtros para la tabla `tabm_cuenta`
--
ALTER TABLE `tabm_cuenta`
  ADD CONSTRAINT `tabm_tcuenta_tabm_cuenta_fk` FOREIGN KEY (`cod_tcta`) REFERENCES `tabm_tcuenta` (`cod_tcta`);

--
-- Filtros para la tabla `tabm_estadocuenta`
--
ALTER TABLE `tabm_estadocuenta`
  ADD CONSTRAINT `tabm_ctabco_tabm_estadocuenta_fk` FOREIGN KEY (`cod_ctabco`) REFERENCES `tabm_ctabco` (`cod_ctabco`);

--
-- Filtros para la tabla `tabm_lmayor`
--
ALTER TABLE `tabm_lmayor`
  ADD CONSTRAINT `tabm_empresa_tabm_lmayor_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_empresa` (`cod_empsa`),
  ADD CONSTRAINT `tabm_cuenta_tabm_lmayor_fk` FOREIGN KEY (`cod_cta`) REFERENCES `tabm_cuenta` (`cod_cta`),
  ADD CONSTRAINT `tabm_moneda_tabm_lmayor_fk` FOREIGN KEY (`cod_mda`) REFERENCES `tabm_moneda` (`cod_mda`);

--
-- Filtros para la tabla `tabm_movimiento`
--
ALTER TABLE `tabm_movimiento`
  ADD CONSTRAINT `tabm_ctabco_tabm_movimiento_fk` FOREIGN KEY (`cod_ctabco`) REFERENCES `tabm_ctabco` (`cod_ctabco`),
  ADD CONSTRAINT `tabm_tmovimiento_tabm_movimiento_fk` FOREIGN KEY (`cod_tmov`) REFERENCES `tabm_tmovimiento` (`cod_tmov`);

--
-- Filtros para la tabla `tabm_poliza`
--
ALTER TABLE `tabm_poliza`
  ADD CONSTRAINT `tabm_empresa_tabm_poliza_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_empresa` (`cod_empsa`),
  ADD CONSTRAINT `tabm_moneda_tabm_poliza_fk` FOREIGN KEY (`cod_mda`) REFERENCES `tabm_moneda` (`cod_mda`);

--
-- Filtros para la tabla `tabm_usuario`
--
ALTER TABLE `tabm_usuario`
  ADD CONSTRAINT `tabm_perfil_tabm_usuario_fk` FOREIGN KEY (`cod_pfl`) REFERENCES `tabm_perfil` (`cod_pfl`);

--
-- Filtros para la tabla `tabt_dperfil`
--
ALTER TABLE `tabt_dperfil`
  ADD CONSTRAINT `tabm_perfil_tabt_dperfil_fk` FOREIGN KEY (`cod_pfl`) REFERENCES `tabm_perfil` (`cod_pfl`),
  ADD CONSTRAINT `tabm_tabla_tabt_dperfil_fk` FOREIGN KEY (`cod_tbl`) REFERENCES `tabm_tabla` (`cod_tbl`);

--
-- Filtros para la tabla `tabt_dpoliza`
--
ALTER TABLE `tabt_dpoliza`
  ADD CONSTRAINT `tabm_poliza_tabt_dpoliza_fk` FOREIGN KEY (`cod_plz`) REFERENCES `tabm_poliza` (`cod_plz`),
  ADD CONSTRAINT `tabm_cuenta_tabt_dpoliza_fk` FOREIGN KEY (`cod_cta`) REFERENCES `tabm_cuenta` (`cod_cta`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
