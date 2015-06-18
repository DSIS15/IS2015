-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 05-06-2015 a las 06:46:16
-- Versión del servidor: 5.6.20
-- Versión de PHP: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `produccion2015`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_bitacora`
--

CREATE TABLE IF NOT EXISTS `tabm_bitacora` (
  `cod_bita` int(11) NOT NULL,
  `cod_usu` int(4) NOT NULL,
  `nom_maquina` varchar(50) NOT NULL,
  `fecha_bita` varchar(15) NOT NULL,
  `hora_bita` varchar(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_bitacora`
--

INSERT INTO `tabm_bitacora` (`cod_bita`, `cod_usu`, `nom_maquina`, `fecha_bita`, `hora_bita`) VALUES
(0, 2, 'CESARFLORES-PC', '03/06/2015', '15:44'),
(0, 0, 'RODRIGO_MIRANDA', '04/06/2015', '04:48 p.m.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_bodega`
--

CREATE TABLE IF NOT EXISTS `tabm_bodega` (
  `cod_bod` int(4) NOT NULL,
  `cod_termi` int(4) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_cliente`
--

CREATE TABLE IF NOT EXISTS `tabm_cliente` (
  `cod_cte` int(4) NOT NULL,
  `dpi_cte` varchar(20) NOT NULL,
  `nit_cte` varchar(10) NOT NULL,
  `nom1_cte` varchar(25) NOT NULL,
  `nom2_cte` varchar(25) NOT NULL,
  `apell1_cte` varchar(25) NOT NULL,
  `apell2_cte` varchar(25) NOT NULL,
  `tel_cte` varchar(15) NOT NULL,
  `dire_cte` varchar(50) NOT NULL,
  `estado_cte` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_cliente`
--

INSERT INTO `tabm_cliente` (`cod_cte`, `dpi_cte`, `nit_cte`, `nom1_cte`, `nom2_cte`, `apell1_cte`, `apell2_cte`, `tel_cte`, `dire_cte`, `estado_cte`) VALUES
(1, '2203976940101', '2458891', 'Cesar ', 'Estuardo', 'Flores', 'Escobar', '2458754', 'Condominio Villa Atlantis Casa D-11 Zona 17 C.A', 1),
(2, '2564651215456', '216516', 'Carlos ', 'Humberto', 'Ruiz', '', '6546238', 'Ciudad de Guatemala', 1),
(3, '2245255', '2254A', 'Roberto', 'Alexander', 'Grave ', 'Vicente', '24587584', 'Ciudad de Guatemala', 1),
(4, '2547893150101', '102540', 'Jose ', 'Alejandro ', 'Ambrosio ', 'Reyes', '50254785487', '2da Av. 3-58 zona 1 Villa Nueva', 1),
(5, '2556546540101', '', 'Felix', 'Alejandro ', 'Guzman ', 'Sosa', '87548748', 'Ciudad de Guatemala', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_codbarras`
--

CREATE TABLE IF NOT EXISTS `tabm_codbarras` (
  `cod_cobar` int(4) NOT NULL,
  `cod_pro` int(4) NOT NULL,
  `cod_termi` int(15) NOT NULL,
  `cod_lote` int(5) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_codbarras`
--

INSERT INTO `tabm_codbarras` (`cod_cobar`, `cod_pro`, `cod_termi`, `cod_lote`) VALUES
(1, 1, 2147483647, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_empleado`
--

CREATE TABLE IF NOT EXISTS `tabm_empleado` (
  `cod_emp` int(4) NOT NULL,
  `cod_empsa` int(4) NOT NULL,
  `dpi_emp` int(20) NOT NULL,
  `nit_emp` varchar(10) NOT NULL,
  `nom1_emp` varchar(25) NOT NULL,
  `nom2_emp` varchar(25) NOT NULL,
  `apell1_emp` varchar(25) NOT NULL,
  `apell2_emp` varchar(25) NOT NULL,
  `dire_emp` varchar(50) NOT NULL,
  `afiigss_emp` int(20) NOT NULL,
  `estado_emp` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_empleado`
--

INSERT INTO `tabm_empleado` (`cod_emp`, `cod_empsa`, `dpi_emp`, `nit_emp`, `nom1_emp`, `nom2_emp`, `apell1_emp`, `apell2_emp`, `dire_emp`, `afiigss_emp`, `estado_emp`) VALUES
(1, 1, 2147483647, '845986', 'Cesar', 'Estuardo', 'Flores ', 'Escobar', 'Condominio Villa Atlantis  Casa D-11 Zona 17 Carre', 25478525, 1),
(2, 1, 2147483647, '548739K', 'Juan ', 'Alberto', 'Solares', '', 'Av. Hincapie colonia la trinidad 5-40 ', 2147483647, 1),
(3, 1, 23646575, '234567-6', 'Rodrigo', 'Antonio', 'Miranda', 'Juárez', '3 av 2-54 Z.3 Ciudad', 123243, 1);

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
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_empresa`
--

INSERT INTO `tabm_empresa` (`cod_empsa`, `nomcomercial_empsa`, `dire_empsa`, `nit_empsa`, `cod_mda`, `estado_empsa`) VALUES
(1, 'Industrias Guatemaltecas', '6ta Av. 3-44 Zona 1', '27235487', 1, 1),
(2, 'Coban', 'Ciudad de Guatemala', '254798554', 2, 1),
(3, 'Industrias Textiles', 'Ciudad', '234365-6', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_fact`
--

CREATE TABLE IF NOT EXISTS `tabm_fact` (
  `cod_fact` int(4) NOT NULL,
  `cod_cte` int(4) NOT NULL,
  `cod_vta` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_formula`
--

CREATE TABLE IF NOT EXISTS `tabm_formula` (
  `cod_formu` int(4) NOT NULL,
  `descrip_formu` varchar(30) NOT NULL,
  `unidad_formu` varchar(20) NOT NULL,
  `costouni_formu` float NOT NULL,
  `estado_formu` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_formula`
--

INSERT INTO `tabm_formula` (`cod_formu`, `descrip_formu`, `unidad_formu`, `costouni_formu`, `estado_formu`) VALUES
(1, 'Pantalon', 'oz', 125, 1),
(2, 'zapatos', 'm', 5, 1),
(3, 'tennis', 'm', 7, 1),
(4, 'Zapato Cool', 'kg', 40, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_inventario`
--

CREATE TABLE IF NOT EXISTS `tabm_inventario` (
  `cod_inv` int(4) NOT NULL,
  `cod_mp` int(4) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_lotemp`
--

CREATE TABLE IF NOT EXISTS `tabm_lotemp` (
  `cod_lote` int(4) NOT NULL,
  `cod_ped` int(4) NOT NULL,
  `estado_lote` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_materiaprima`
--

CREATE TABLE IF NOT EXISTS `tabm_materiaprima` (
  `cod_mp` int(4) NOT NULL,
  `nom_mp` varchar(30) NOT NULL,
  `unimedida_mp` varchar(10) NOT NULL,
  `canitdad_mp` int(11) NOT NULL,
  `precio_mp` float NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_materiaprima`
--

INSERT INTO `tabm_materiaprima` (`cod_mp`, `nom_mp`, `unimedida_mp`, `canitdad_mp`, `precio_mp`) VALUES
(1, 'Cintas', 'Pares', 50, 3),
(2, 'Botones', 'Unidad', 10, 2),
(3, 'Hilo de Poliester', 'Bobinas', 100, 1000);

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
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_moneda`
--

INSERT INTO `tabm_moneda` (`cod_mda`, `moneda_mda`, `abrev_mda`, `tipcambio_mda`, `estado_mda`) VALUES
(1, 'Quetzal', 'Q', 7.1235, 1),
(2, 'Dolar', '$', 7.1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_movimiento`
--

CREATE TABLE IF NOT EXISTS `tabm_movimiento` (
  `cod_usu` int(4) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_pedido`
--

CREATE TABLE IF NOT EXISTS `tabm_pedido` (
  `cod_ped` int(4) NOT NULL,
  `fecha_ped` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_pedido`
--

INSERT INTO `tabm_pedido` (`cod_ped`, `fecha_ped`) VALUES
(1, '2015-05-26'),
(2, '2015-05-28'),
(3, '2015-06-04'),
(4, '2015-06-04'),
(5, '2015-06-04'),
(6, '2015-06-04');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_perfil`
--

CREATE TABLE IF NOT EXISTS `tabm_perfil` (
  `cod_perf` int(5) NOT NULL,
  `nombre_perf` varchar(50) NOT NULL,
  `insertar` varchar(20) NOT NULL,
  `eliminar` varchar(20) NOT NULL,
  `modificar` varchar(20) NOT NULL,
  `reporte` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_perfil`
--

INSERT INTO `tabm_perfil` (`cod_perf`, `nombre_perf`, `insertar`, `eliminar`, `modificar`, `reporte`) VALUES
(1, 'Administrador', '1', '1', '1', '1'),
(2, 'MP1', '1', '0', '1', '0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_prodterminado`
--

CREATE TABLE IF NOT EXISTS `tabm_prodterminado` (
  `cod_termi` int(4) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_produccion`
--

CREATE TABLE IF NOT EXISTS `tabm_produccion` (
  `cod_pro` int(4) NOT NULL,
  `cod_formu` int(4) NOT NULL,
  `cantidad_prod` int(10) NOT NULL,
  `estado_prod` tinyint(1) NOT NULL,
  `costo_dir` float NOT NULL,
  `costo_ind` float NOT NULL,
  `costo_prod` float NOT NULL,
  `costo_total` float NOT NULL,
  `precio_vta` float NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_produccion`
--

INSERT INTO `tabm_produccion` (`cod_pro`, `cod_formu`, `cantidad_prod`, `estado_prod`, `costo_dir`, `costo_ind`, `costo_prod`, `costo_total`, `precio_vta`) VALUES
(1, 1, 50, 1, 15, 10, 20, 175, 200);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_proveedor`
--

CREATE TABLE IF NOT EXISTS `tabm_proveedor` (
  `cod_prov` int(4) NOT NULL,
  `nit_prov` varchar(10) NOT NULL,
  `nom_prov` varchar(30) NOT NULL,
  `dire_prov` varchar(50) NOT NULL,
  `tel_prov` varchar(15) NOT NULL,
  `estado_prov` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_proveedor`
--

INSERT INTO `tabm_proveedor` (`cod_prov`, `nit_prov`, `nom_prov`, `dire_prov`, `tel_prov`, `estado_prov`) VALUES
(1, '2546325', 'JuanZacariasSosa', '323542', '3-24 Zona 1 Av ', 0),
(2, '3458754', 'Cemaco', '24658745', 'Ciudad de Guate', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_usuario`
--

CREATE TABLE IF NOT EXISTS `tabm_usuario` (
  `cod_usu` int(4) NOT NULL,
  `cod_emp` int(4) NOT NULL,
  `cod_perf` int(5) NOT NULL,
  `user_usu` varchar(20) NOT NULL,
  `pass_usu` varchar(20) NOT NULL,
  `estado_usu` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabm_usuario`
--

INSERT INTO `tabm_usuario` (`cod_usu`, `cod_emp`, `cod_perf`, `user_usu`, `pass_usu`, `estado_usu`) VALUES
(1, 1, 2, 'cesar', '123', 1),
(2, 1, 2, 'rodrigo', '1234', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabm_ventas`
--

CREATE TABLE IF NOT EXISTS `tabm_ventas` (
  `cod_vta` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_detalleformu`
--

CREATE TABLE IF NOT EXISTS `tabt_detalleformu` (
  `cod_formu` int(4) NOT NULL,
  `cod_mp` int(4) NOT NULL,
  `precio` varchar(30) NOT NULL,
  `cantidad_formu` int(15) NOT NULL,
  `estado_formu` varchar(15) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabt_detalleformu`
--

INSERT INTO `tabt_detalleformu` (`cod_formu`, `cod_mp`, `precio`, `cantidad_formu`, `estado_formu`) VALUES
(4, 1, '36', 12, 'Activo'),
(4, 2, '4', 2, 'Activo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_detallemp`
--

CREATE TABLE IF NOT EXISTS `tabt_detallemp` (
  `cod_mp` int(4) NOT NULL,
  `cod_lote` int(4) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_detallepedido`
--

CREATE TABLE IF NOT EXISTS `tabt_detallepedido` (
  `cod_ped` int(4) NOT NULL,
  `cod_mp` int(4) NOT NULL,
  `cod_prov` int(4) NOT NULL,
  `cantidad_dped` float NOT NULL,
  `unidad_dped` varchar(15) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tabt_detallepedido`
--

INSERT INTO `tabt_detallepedido` (`cod_ped`, `cod_mp`, `cod_prov`, `cantidad_dped`, `unidad_dped`) VALUES
(1, 1, 1, 25, 'mt'),
(1, 2, 1, 30, 'ft'),
(3, 2, 1, 12, 'lb'),
(4, 1, 1, 12, 'mt'),
(5, 2, 1, 22, 'lb'),
(6, 3, 1, 50, 'Bobinas'),
(6, 2, 1, 100, 'Unidad'),
(6, 1, 1, 50, 'Pares');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tabt_detalleproducto`
--

CREATE TABLE IF NOT EXISTS `tabt_detalleproducto` (
  `cod_pro` int(4) NOT NULL,
  `cod_emp` int(4) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tabm_bitacora`
--
ALTER TABLE `tabm_bitacora`
 ADD PRIMARY KEY (`cod_bita`,`cod_usu`), ADD KEY `tabm_usuario_tabm_bitacora_fk` (`cod_usu`);

--
-- Indices de la tabla `tabm_bodega`
--
ALTER TABLE `tabm_bodega`
 ADD PRIMARY KEY (`cod_bod`), ADD KEY `tabm_prodterminado_tabm_bodega_fk` (`cod_termi`);

--
-- Indices de la tabla `tabm_cliente`
--
ALTER TABLE `tabm_cliente`
 ADD PRIMARY KEY (`cod_cte`);

--
-- Indices de la tabla `tabm_codbarras`
--
ALTER TABLE `tabm_codbarras`
 ADD PRIMARY KEY (`cod_cobar`), ADD KEY `tabm_produccion_tabm_codbarras_fk` (`cod_pro`);

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
-- Indices de la tabla `tabm_fact`
--
ALTER TABLE `tabm_fact`
 ADD PRIMARY KEY (`cod_fact`), ADD KEY `tabm_ventas_tabm_fact_fk` (`cod_vta`), ADD KEY `tabm_cliente_tabm_fact_fk` (`cod_cte`);

--
-- Indices de la tabla `tabm_formula`
--
ALTER TABLE `tabm_formula`
 ADD PRIMARY KEY (`cod_formu`);

--
-- Indices de la tabla `tabm_inventario`
--
ALTER TABLE `tabm_inventario`
 ADD PRIMARY KEY (`cod_inv`), ADD KEY `tabm_materiaprima_tabm_inventario_fk` (`cod_mp`);

--
-- Indices de la tabla `tabm_lotemp`
--
ALTER TABLE `tabm_lotemp`
 ADD PRIMARY KEY (`cod_lote`), ADD KEY `tabm_pedido_tabm_lotemp_fk` (`cod_ped`);

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
 ADD PRIMARY KEY (`cod_usu`);

--
-- Indices de la tabla `tabm_pedido`
--
ALTER TABLE `tabm_pedido`
 ADD PRIMARY KEY (`cod_ped`);

--
-- Indices de la tabla `tabm_perfil`
--
ALTER TABLE `tabm_perfil`
 ADD PRIMARY KEY (`cod_perf`);

--
-- Indices de la tabla `tabm_prodterminado`
--
ALTER TABLE `tabm_prodterminado`
 ADD PRIMARY KEY (`cod_termi`);

--
-- Indices de la tabla `tabm_produccion`
--
ALTER TABLE `tabm_produccion`
 ADD PRIMARY KEY (`cod_pro`), ADD KEY `tabm_formula_tabm_produccion_fk` (`cod_formu`);

--
-- Indices de la tabla `tabm_proveedor`
--
ALTER TABLE `tabm_proveedor`
 ADD PRIMARY KEY (`cod_prov`);

--
-- Indices de la tabla `tabm_usuario`
--
ALTER TABLE `tabm_usuario`
 ADD PRIMARY KEY (`cod_usu`), ADD KEY `tabm_empleado_tabm_usuario_fk` (`cod_emp`), ADD KEY `tabm_perfil_tabm_usuario_fk` (`cod_perf`);

--
-- Indices de la tabla `tabm_ventas`
--
ALTER TABLE `tabm_ventas`
 ADD PRIMARY KEY (`cod_vta`);

--
-- Indices de la tabla `tabt_detalleformu`
--
ALTER TABLE `tabt_detalleformu`
 ADD KEY `tabm_formula_tabt_detalleformu_fk` (`cod_formu`), ADD KEY `tabm_materiaprima_tabt_detalleformu_fk` (`cod_mp`);

--
-- Indices de la tabla `tabt_detallemp`
--
ALTER TABLE `tabt_detallemp`
 ADD KEY `tabm_lotemp_tabt_detallemp_fk` (`cod_lote`), ADD KEY `tabm_materiaprima_tabt_detallemp_fk` (`cod_mp`);

--
-- Indices de la tabla `tabt_detallepedido`
--
ALTER TABLE `tabt_detallepedido`
 ADD KEY `tabm_pedido_tabt_detallepedido_fk` (`cod_ped`), ADD KEY `tabm_proveedor_tabt_detallepedido_fk` (`cod_prov`), ADD KEY `tabm_materiaprima_tabt_detallepedido_fk` (`cod_mp`);

--
-- Indices de la tabla `tabt_detalleproducto`
--
ALTER TABLE `tabt_detalleproducto`
 ADD KEY `tabm_produccion_tabt_detalleproducto_fk` (`cod_pro`), ADD KEY `tabm_empleado_tabt_detalleproducto_fk` (`cod_emp`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
