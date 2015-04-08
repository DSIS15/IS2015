-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 08-04-2015 a las 22:35:44
-- Versión del servidor: 5.6.21
-- Versión de PHP: 5.5.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `hospitaldb`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_modulo`
--

CREATE TABLE IF NOT EXISTS `detalle_modulo` (
`id_detmod` int(11) NOT NULL,
  `id_modulo` int(11) NOT NULL,
  `codigo_perfil` int(11) NOT NULL,
  `fecha_creacion` date NOT NULL,
  `fecha_modificacion` date NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_modulo`
--

INSERT INTO `detalle_modulo` (`id_detmod`, `id_modulo`, `codigo_perfil`, `fecha_creacion`, `fecha_modificacion`, `estado`) VALUES
(1, 1, 1, '2015-04-07', '2015-04-07', 1),
(2, 2, 1, '2015-04-07', '2015-04-07', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulo`
--

CREATE TABLE IF NOT EXISTS `modulo` (
`id_modulo` int(11) NOT NULL,
  `nombre_modulo` varchar(25) NOT NULL,
  `nombre_dll` varchar(15) NOT NULL,
  `fecha_creacion` date NOT NULL,
  `fecha_modificacion` date NOT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `modulo`
--

INSERT INTO `modulo` (`id_modulo`, `nombre_modulo`, `nombre_dll`, `fecha_creacion`, `fecha_modificacion`, `estado`) VALUES
(1, 'Inicio', '', '2015-04-07', '2015-04-07', 1),
(2, 'Seguridad', 'dll_seguridad', '2015-04-07', '2015-04-07', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

CREATE TABLE IF NOT EXISTS `perfil` (
`codigo_perfil` int(11) NOT NULL,
  `nombre_perfil` varchar(15) NOT NULL,
  `fecha_creacion` date NOT NULL,
  `fecha_modificacion` date NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `perfil`
--

INSERT INTO `perfil` (`codigo_perfil`, `nombre_perfil`, `fecha_creacion`, `fecha_modificacion`, `estado`) VALUES
(1, 'admin', '2015-04-07', '2015-04-07', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `roll`
--

CREATE TABLE IF NOT EXISTS `roll` (
`id_roll` int(11) NOT NULL,
  `nombre_roll` varchar(15) NOT NULL,
  `descripcion` varchar(20) NOT NULL,
  `fecha_creacion` date NOT NULL,
  `fecha_modificacion` date NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `roll`
--

INSERT INTO `roll` (`id_roll`, `nombre_roll`, `descripcion`, `fecha_creacion`, `fecha_modificacion`, `estado`) VALUES
(1, 'admin', 'admin', '2015-04-07', '2015-04-07', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sub_modulo`
--

CREATE TABLE IF NOT EXISTS `sub_modulo` (
`id_submodulo` int(11) NOT NULL,
  `id_modulo` int(11) NOT NULL,
  `nombre_submodulo` varchar(25) NOT NULL,
  `nombre_form` varchar(25) NOT NULL,
  `fecha_creacion` date NOT NULL,
  `fecha_modificacion` date NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `sub_modulo`
--

INSERT INTO `sub_modulo` (`id_submodulo`, `id_modulo`, `nombre_submodulo`, `nombre_form`, `fecha_creacion`, `fecha_modificacion`, `estado`) VALUES
(1, 1, 'Ordenar modo cascada', '', '2015-04-07', '2015-04-07', 1),
(2, 1, 'Ordenar modo Horizontal', '', '2015-04-07', '2015-04-07', 1),
(3, 1, 'Ordenar modo Vertical', '', '2015-04-07', '2015-04-07', 1),
(4, 1, 'Salir', '', '2015-04-07', '2015-04-07', 1),
(5, 2, 'Administración Perfil', 'wfPerfiles', '2015-04-07', '2015-04-07', 1),
(6, 2, 'Administración Usuarios', 'wfUsuario', '2015-04-07', '2015-04-07', 1),
(7, 2, 'Modulo', 'wfModulo', '2015-04-07', '2015-04-07', 1),
(8, 2, 'Administración de Recurso', 'wfDetMod', '2015-04-07', '2015-04-07', 1),
(9, 2, 'Sub Modulo', 'wfSubMod', '2015-04-08', '2015-04-08', 1),
(10, 2, 'Roll', 'wfRoll', '0000-00-00', '0000-00-00', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
`id_usuario` int(11) NOT NULL,
  `codigo_perfil` int(11) NOT NULL,
  `id_roll` int(11) NOT NULL,
  `alias_usuario` varchar(15) NOT NULL,
  `contrasena_usuario` varchar(10) NOT NULL,
  `nombre_usuario` varchar(15) NOT NULL,
  `primer_apellido` varchar(10) NOT NULL,
  `segundo_apellido` varchar(10) NOT NULL,
  `direccion` varchar(25) NOT NULL,
  `fecha_de_creacion` date NOT NULL,
  `fecha_de_modificacion` date NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `codigo_perfil`, `id_roll`, `alias_usuario`, `contrasena_usuario`, `nombre_usuario`, `primer_apellido`, `segundo_apellido`, `direccion`, `fecha_de_creacion`, `fecha_de_modificacion`, `estado`) VALUES
(1, 1, 1, 'admin', 'admin', 'admin', 'admin', 'admin', 'admin', '2015-04-07', '2015-04-07', 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `detalle_modulo`
--
ALTER TABLE `detalle_modulo`
 ADD PRIMARY KEY (`id_detmod`,`id_modulo`), ADD KEY `modulo_detalle_modulo_fk` (`id_modulo`), ADD KEY `perfiles_detalle_modulo_fk` (`codigo_perfil`);

--
-- Indices de la tabla `modulo`
--
ALTER TABLE `modulo`
 ADD PRIMARY KEY (`id_modulo`);

--
-- Indices de la tabla `perfil`
--
ALTER TABLE `perfil`
 ADD PRIMARY KEY (`codigo_perfil`);

--
-- Indices de la tabla `roll`
--
ALTER TABLE `roll`
 ADD PRIMARY KEY (`id_roll`);

--
-- Indices de la tabla `sub_modulo`
--
ALTER TABLE `sub_modulo`
 ADD PRIMARY KEY (`id_submodulo`), ADD KEY `modulo_sub_modulo_fk` (`id_modulo`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
 ADD PRIMARY KEY (`id_usuario`), ADD KEY `roll_usuario_fk` (`id_roll`), ADD KEY `perfil_usuario_fk` (`codigo_perfil`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `detalle_modulo`
--
ALTER TABLE `detalle_modulo`
MODIFY `id_detmod` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `modulo`
--
ALTER TABLE `modulo`
MODIFY `id_modulo` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `perfil`
--
ALTER TABLE `perfil`
MODIFY `codigo_perfil` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `roll`
--
ALTER TABLE `roll`
MODIFY `id_roll` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `sub_modulo`
--
ALTER TABLE `sub_modulo`
MODIFY `id_submodulo` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `detalle_modulo`
--
ALTER TABLE `detalle_modulo`
ADD CONSTRAINT `modulo_detalle_modulo_fk` FOREIGN KEY (`id_modulo`) REFERENCES `modulo` (`id_modulo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `perfiles_detalle_modulo_fk` FOREIGN KEY (`codigo_perfil`) REFERENCES `perfil` (`codigo_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `sub_modulo`
--
ALTER TABLE `sub_modulo`
ADD CONSTRAINT `modulo_sub_modulo_fk` FOREIGN KEY (`id_modulo`) REFERENCES `modulo` (`id_modulo`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
ADD CONSTRAINT `perfil_usuario_fk` FOREIGN KEY (`codigo_perfil`) REFERENCES `perfil` (`codigo_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `roll_usuario_fk` FOREIGN KEY (`id_roll`) REFERENCES `roll` (`id_roll`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
