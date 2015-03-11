-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-03-2015 a las 23:06:03
-- Versión del servidor: 5.6.20
-- Versión de PHP: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `produccionprueba`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_bitacora`
--

CREATE TABLE IF NOT EXISTS `tabm_bitacora` (
  `cod_bita` int(11) NOT NULL,
  `cod_usu` int(4) NOT NULL,
  `cod_mov` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_bodega`
--

CREATE TABLE IF NOT EXISTS `tabm_bodega` (
  `cod_bod` int(4) NOT NULL,
  `nom_bod` varchar(50) NOT NULL,
  `dire_bod` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_codigobarras`
--

CREATE TABLE IF NOT EXISTS `tabm_codigobarras` (
  `cod_cbar` int(10) NOT NULL,
  `cod_prodterm` int(5) NOT NULL,
  `cod_pproc` int(5) NOT NULL,
  `cod_ordProd` int(4) NOT NULL,
  `cod_mp` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_conversion`
--

CREATE TABLE IF NOT EXISTS `tabm_conversion` (
  `cod_conv` int(5) NOT NULL,
  `tipo_conv` varchar(30) NOT NULL,
  `tipconversion_conv` float NOT NULL,
  `estado_conv` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_empleado`
--

CREATE TABLE IF NOT EXISTS `tabm_empleado` (
  `cod_emp` int(4) NOT NULL,
  `cod_empsa` int(4) NOT NULL,
  `dpi_emp` int(18) NOT NULL,
  `nit_emp` varchar(15) NOT NULL,
  `nom1_emp` varchar(25) NOT NULL,
  `nom2_emp` varchar(25) NOT NULL,
  `apell1_emp` varchar(50) NOT NULL,
  `apell2_emp` varchar(50) NOT NULL,
  `dire_emp` varchar(50) NOT NULL,
  `afiigss_emp` int(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_empresa`
--

CREATE TABLE IF NOT EXISTS `tabm_empresa` (
  `cod_empsa` int(4) NOT NULL,
  `nomcomercial_empsa` varchar(50) NOT NULL,
  `dire_empsa` varchar(50) NOT NULL,
  `nit_empsa` varchar(15) NOT NULL,
  `cod_mda` int(4) NOT NULL,
  `estado_empsa` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_formula`
--

CREATE TABLE IF NOT EXISTS `tabm_formula` (
  `cod_formu` int(4) NOT NULL,
  `cod_mp` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_inventario`
--

CREATE TABLE IF NOT EXISTS `tabm_inventario` (
  `cod_inv` int(4) NOT NULL,
  `cod_mp` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_materiaprima`
--

CREATE TABLE IF NOT EXISTS `tabm_materiaprima` (
  `cod_mp` int(4) NOT NULL,
  `nom_mp` varchar(30) NOT NULL,
  `descrip_mp` varchar(50) NOT NULL,
  `canitdad_mp` int(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_moneda`
--

CREATE TABLE IF NOT EXISTS `tabm_moneda` (
  `cod_mda` int(4) NOT NULL,
  `moneda_mda` varchar(25) NOT NULL,
  `abrev_mda` varchar(10) NOT NULL,
  `tipcambio_mda` float NOT NULL,
  `estado_mda` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_movimiento`
--

CREATE TABLE IF NOT EXISTS `tabm_movimiento` (
  `cod_mov` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_ordencompra`
--

CREATE TABLE IF NOT EXISTS `tabm_ordencompra` (
  `cod_ordComp` int(4) NOT NULL,
  `cod_empsa` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_ordenproduccion`
--

CREATE TABLE IF NOT EXISTS `tabm_ordenproduccion` (
  `cod_ordProd` int(4) NOT NULL,
  `cod_ordComp` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_perfil`
--

CREATE TABLE IF NOT EXISTS `tabm_perfil` (
  `cod_perf` int(5) NOT NULL,
  `perfil_perf` varchar(25) NOT NULL,
  `estado_perf` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_productoproceso`
--

CREATE TABLE IF NOT EXISTS `tabm_productoproceso` (
  `cod_pproc` int(5) NOT NULL,
  `cod_ordProd` int(4) NOT NULL,
  `cod_mp` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_productoterminado`
--

CREATE TABLE IF NOT EXISTS `tabm_productoterminado` (
  `cod_prodterm` int(5) NOT NULL,
  `cod_pproc` int(5) NOT NULL,
  `cod_ordProd` int(4) NOT NULL,
  `cod_mp` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_usuario`
--

CREATE TABLE IF NOT EXISTS `tabm_usuario` (
  `cod_usu` int(4) NOT NULL,
  `cod_emp` int(4) NOT NULL,
  `cod_empsa` int(4) NOT NULL,
  `cod_perf` int(5) NOT NULL,
  `user_usu` varchar(20) NOT NULL,
  `pass_usu` varchar(20) NOT NULL,
  `estado_usu` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_detallebodega`
--

CREATE TABLE IF NOT EXISTS `tabt_detallebodega` (
  `cod_bod` int(4) NOT NULL,
  `cod_prodterm` int(5) NOT NULL,
  `cod_pproc` int(5) NOT NULL,
  `cod_ordProd` int(4) NOT NULL,
  `cod_mp` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_detalleproduccion`
--

CREATE TABLE IF NOT EXISTS `tabt_detalleproduccion` (
  `cod_ordProd` int(4) NOT NULL,
  `cod_mp` int(4) NOT NULL,
  `cod_formu` int(4) NOT NULL,
  `cod_conv` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_dperfil`
--

CREATE TABLE IF NOT EXISTS `tabt_dperfil` (
  `insert_dperf` tinyint(1) NOT NULL,
  `update_tdperf` tinyint(1) NOT NULL,
  `select_dperf` tinyint(1) NOT NULL,
  `print_dperf` tinyint(1) NOT NULL,
  `estado_dperf` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tabm_bitacora`
--
ALTER TABLE `tabm_bitacora`
 ADD PRIMARY KEY (`cod_bita`,`cod_usu`,`cod_mov`), ADD KEY `tabm_movimiento_tabm_bitacora_fk` (`cod_mov`), ADD KEY `tabm_usuario_tabm_bitacora_fk` (`cod_usu`);

--
-- Indices de la tabla `tabm_bodega`
--
ALTER TABLE `tabm_bodega`
 ADD PRIMARY KEY (`cod_bod`);

--
-- Indices de la tabla `tabm_codigobarras`
--
ALTER TABLE `tabm_codigobarras`
 ADD PRIMARY KEY (`cod_cbar`,`cod_prodterm`,`cod_pproc`,`cod_ordProd`,`cod_mp`), ADD KEY `tabm_productoterminado_tabm_codigobarras_fk` (`cod_prodterm`,`cod_pproc`,`cod_ordProd`,`cod_mp`);

--
-- Indices de la tabla `tabm_conversion`
--
ALTER TABLE `tabm_conversion`
 ADD PRIMARY KEY (`cod_conv`);

--
-- Indices de la tabla `tabm_empleado`
--
ALTER TABLE `tabm_empleado`
 ADD PRIMARY KEY (`cod_emp`), ADD KEY `tabm_empresa_tabm_empleado_fk` (`cod_empsa`);

--
-- Indices de la tabla `tabm_empresa`
--
ALTER TABLE `tabm_empresa`
 ADD PRIMARY KEY (`cod_empsa`), ADD KEY `tabm_moneda_tabm_empresa_fk` (`cod_mda`);

--
-- Indices de la tabla `tabm_formula`
--
ALTER TABLE `tabm_formula`
 ADD PRIMARY KEY (`cod_formu`), ADD KEY `tabm_materiaprima_tabm_formula_fk` (`cod_mp`);

--
-- Indices de la tabla `tabm_inventario`
--
ALTER TABLE `tabm_inventario`
 ADD PRIMARY KEY (`cod_inv`), ADD KEY `tabm_materiaprima_tabm_inventario_fk` (`cod_mp`);

--
-- Indices de la tabla `tabm_materiaprima`
--
ALTER TABLE `tabm_materiaprima`
 ADD PRIMARY KEY (`cod_mp`);

--
-- Indices de la tabla `tabm_moneda`
--
ALTER TABLE `tabm_moneda`
 ADD PRIMARY KEY (`cod_mda`);

--
-- Indices de la tabla `tabm_movimiento`
--
ALTER TABLE `tabm_movimiento`
 ADD PRIMARY KEY (`cod_mov`);

--
-- Indices de la tabla `tabm_ordencompra`
--
ALTER TABLE `tabm_ordencompra`
 ADD PRIMARY KEY (`cod_ordComp`), ADD KEY `tabm_empresa_tabm_ordencompra_fk` (`cod_empsa`);

--
-- Indices de la tabla `tabm_ordenproduccion`
--
ALTER TABLE `tabm_ordenproduccion`
 ADD PRIMARY KEY (`cod_ordProd`), ADD KEY `tabm_ordencompra_tabm_ordenproduccion_fk` (`cod_ordComp`);

--
-- Indices de la tabla `tabm_perfil`
--
ALTER TABLE `tabm_perfil`
 ADD PRIMARY KEY (`cod_perf`);

--
-- Indices de la tabla `tabm_productoproceso`
--
ALTER TABLE `tabm_productoproceso`
 ADD PRIMARY KEY (`cod_pproc`,`cod_ordProd`,`cod_mp`), ADD KEY `tabt_detalleproduccion_tabm_productoproceso_fk` (`cod_ordProd`,`cod_mp`);

--
-- Indices de la tabla `tabm_productoterminado`
--
ALTER TABLE `tabm_productoterminado`
 ADD PRIMARY KEY (`cod_prodterm`,`cod_pproc`,`cod_ordProd`,`cod_mp`), ADD KEY `tabm_productoproceso_tabm_productoterminado_fk` (`cod_pproc`,`cod_ordProd`,`cod_mp`);

--
-- Indices de la tabla `tabm_usuario`
--
ALTER TABLE `tabm_usuario`
 ADD PRIMARY KEY (`cod_usu`), ADD KEY `tabm_empresa_tabm_usuario_fk` (`cod_empsa`), ADD KEY `tabm_empleado_tabm_usuario_fk` (`cod_emp`), ADD KEY `tabm_perfil_tabm_usuario_fk` (`cod_perf`);

--
-- Indices de la tabla `tabt_detallebodega`
--
ALTER TABLE `tabt_detallebodega`
 ADD PRIMARY KEY (`cod_bod`,`cod_prodterm`,`cod_pproc`,`cod_ordProd`,`cod_mp`), ADD KEY `tabm_productoterminado_tabt_detallebodega_fk` (`cod_prodterm`,`cod_pproc`,`cod_ordProd`,`cod_mp`);

--
-- Indices de la tabla `tabt_detalleproduccion`
--
ALTER TABLE `tabt_detalleproduccion`
 ADD PRIMARY KEY (`cod_ordProd`,`cod_mp`), ADD KEY `tabm_conversion_tabt_detalleproduccion_fk` (`cod_conv`), ADD KEY `tabm_materiaprima_tabt_detalleproduccion_fk` (`cod_mp`), ADD KEY `tabm_formula_tabt_detalleproduccion_fk` (`cod_formu`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tabm_bitacora`
--
ALTER TABLE `tabm_bitacora`
ADD CONSTRAINT `tabm_movimiento_tabm_bitacora_fk` FOREIGN KEY (`cod_mov`) REFERENCES `tabm_movimiento` (`cod_mov`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `tabm_usuario_tabm_bitacora_fk` FOREIGN KEY (`cod_usu`) REFERENCES `tabm_usuario` (`cod_usu`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabm_codigobarras`
--
ALTER TABLE `tabm_codigobarras`
ADD CONSTRAINT `tabm_productoterminado_tabm_codigobarras_fk` FOREIGN KEY (`cod_prodterm`, `cod_pproc`, `cod_ordProd`, `cod_mp`) REFERENCES `tabm_productoterminado` (`cod_prodterm`, `cod_pproc`, `cod_ordProd`, `cod_mp`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabm_empleado`
--
ALTER TABLE `tabm_empleado`
ADD CONSTRAINT `tabm_empresa_tabm_empleado_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_empresa` (`cod_empsa`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabm_empresa`
--
ALTER TABLE `tabm_empresa`
ADD CONSTRAINT `tabm_moneda_tabm_empresa_fk` FOREIGN KEY (`cod_mda`) REFERENCES `tabm_moneda` (`cod_mda`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabm_formula`
--
ALTER TABLE `tabm_formula`
ADD CONSTRAINT `tabm_materiaprima_tabm_formula_fk` FOREIGN KEY (`cod_mp`) REFERENCES `tabm_materiaprima` (`cod_mp`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabm_inventario`
--
ALTER TABLE `tabm_inventario`
ADD CONSTRAINT `tabm_materiaprima_tabm_inventario_fk` FOREIGN KEY (`cod_mp`) REFERENCES `tabm_materiaprima` (`cod_mp`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabm_ordencompra`
--
ALTER TABLE `tabm_ordencompra`
ADD CONSTRAINT `tabm_empresa_tabm_ordencompra_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_empresa` (`cod_empsa`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabm_ordenproduccion`
--
ALTER TABLE `tabm_ordenproduccion`
ADD CONSTRAINT `tabm_ordencompra_tabm_ordenproduccion_fk` FOREIGN KEY (`cod_ordComp`) REFERENCES `tabm_ordencompra` (`cod_ordComp`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabm_productoproceso`
--
ALTER TABLE `tabm_productoproceso`
ADD CONSTRAINT `tabt_detalleproduccion_tabm_productoproceso_fk` FOREIGN KEY (`cod_ordProd`, `cod_mp`) REFERENCES `tabt_detalleproduccion` (`cod_ordProd`, `cod_mp`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabm_productoterminado`
--
ALTER TABLE `tabm_productoterminado`
ADD CONSTRAINT `tabm_productoproceso_tabm_productoterminado_fk` FOREIGN KEY (`cod_pproc`, `cod_ordProd`, `cod_mp`) REFERENCES `tabm_productoproceso` (`cod_pproc`, `cod_ordProd`, `cod_mp`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabm_usuario`
--
ALTER TABLE `tabm_usuario`
ADD CONSTRAINT `tabm_empleado_tabm_usuario_fk` FOREIGN KEY (`cod_emp`) REFERENCES `tabm_empleado` (`cod_emp`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `tabm_empresa_tabm_usuario_fk` FOREIGN KEY (`cod_empsa`) REFERENCES `tabm_empresa` (`cod_empsa`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `tabm_perfil_tabm_usuario_fk` FOREIGN KEY (`cod_perf`) REFERENCES `tabm_perfil` (`cod_perf`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabt_detallebodega`
--
ALTER TABLE `tabt_detallebodega`
ADD CONSTRAINT `tabm_bodega_tabt_detallebodega_fk` FOREIGN KEY (`cod_bod`) REFERENCES `tabm_bodega` (`cod_bod`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `tabm_productoterminado_tabt_detallebodega_fk` FOREIGN KEY (`cod_prodterm`, `cod_pproc`, `cod_ordProd`, `cod_mp`) REFERENCES `tabm_productoterminado` (`cod_prodterm`, `cod_pproc`, `cod_ordProd`, `cod_mp`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tabt_detalleproduccion`
--
ALTER TABLE `tabt_detalleproduccion`
ADD CONSTRAINT `tabm_conversion_tabt_detalleproduccion_fk` FOREIGN KEY (`cod_conv`) REFERENCES `tabm_conversion` (`cod_conv`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `tabm_formula_tabt_detalleproduccion_fk` FOREIGN KEY (`cod_formu`) REFERENCES `tabm_formula` (`cod_formu`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `tabm_materiaprima_tabt_detalleproduccion_fk` FOREIGN KEY (`cod_mp`) REFERENCES `tabm_materiaprima` (`cod_mp`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `tabm_ordenproduccion_tabt_detalleproduccion_fk` FOREIGN KEY (`cod_ordProd`) REFERENCES `tabm_ordenproduccion` (`cod_ordProd`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
