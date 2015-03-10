-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 09-03-2015 a las 06:22:30
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
  `ID_detmod` int(11) NOT NULL,
  `ID_modulo` int(11) NOT NULL,
  `Codigo_perfil` varchar(5) NOT NULL,
  `Estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_modulo`
--

INSERT INTO `detalle_modulo` (`ID_detmod`, `ID_modulo`, `Codigo_perfil`, `Estado`) VALUES
(1, 1, 'pr001', 1),
(2, 2, 'pr001', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_roll`
--

CREATE TABLE IF NOT EXISTS `detalle_roll` (
  `ID_detroll` int(11) NOT NULL,
  `ID_roll` int(11) NOT NULL,
  `ID_usuario` int(11) NOT NULL,
  `Estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulo`
--

CREATE TABLE IF NOT EXISTS `modulo` (
  `ID_modulo` int(11) NOT NULL,
  `Nombre_modulo` varchar(25) NOT NULL,
  `Nombre_DLL` varchar(15) NOT NULL,
  `Estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `modulo`
--

INSERT INTO `modulo` (`ID_modulo`, `Nombre_modulo`, `Nombre_DLL`, `Estado`) VALUES
(1, 'Inicio', 'dll_seguridad', 1),
(2, 'Administrar', 'dll_seguridad', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

CREATE TABLE IF NOT EXISTS `perfil` (
  `Codigo_perfil` varchar(5) NOT NULL,
  `nombre_perfil` varchar(15) NOT NULL,
  `Estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `perfil`
--

INSERT INTO `perfil` (`Codigo_perfil`, `nombre_perfil`, `Estado`) VALUES
('pr001', 'Super Usuario', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `roll`
--

CREATE TABLE IF NOT EXISTS `roll` (
  `ID_roll` int(11) NOT NULL,
  `Nombre_roll` varchar(10) NOT NULL,
  `Estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `roll`
--

INSERT INTO `roll` (`ID_roll`, `Nombre_roll`, `Estado`) VALUES
(1, 'Insertar', 1),
(2, 'Modificar', 1),
(3, 'Consultar', 1),
(4, 'Eliminar', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sub_modulo`
--

CREATE TABLE IF NOT EXISTS `sub_modulo` (
  `ID_submodulo` int(11) NOT NULL,
  `ID_modulo` int(11) NOT NULL,
  `Nombre_submodulo` varchar(25) NOT NULL,
  `Nobre_form` varchar(25) NOT NULL,
  `Estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `sub_modulo`
--

INSERT INTO `sub_modulo` (`ID_submodulo`, `ID_modulo`, `Nombre_submodulo`, `Nobre_form`, `Estado`) VALUES
(1, 2, 'Usuario', 'wfUsuario', 1),
(2, 2, 'Perfiles', 'wfPerfiles', 1),
(3, 1, 'Ayuda', 'wfAyuda', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `ID_usuario` int(11) NOT NULL,
  `Codigo_perfil` varchar(5) NOT NULL,
  `Nombre_usuario` varchar(15) NOT NULL,
  `Pasword_usuario` varchar(10) NOT NULL,
  `Estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`ID_usuario`, `Codigo_perfil`, `Nombre_usuario`, `Pasword_usuario`, `Estado`) VALUES
(1, 'pr001', 'Jaime', 'Jaime2014', 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `detalle_modulo`
--
ALTER TABLE `detalle_modulo`
 ADD PRIMARY KEY (`ID_detmod`), ADD KEY `modulo_detalle_modulo_fk` (`ID_modulo`), ADD KEY `perfiles_detalle_modulo_fk` (`Codigo_perfil`);

--
-- Indices de la tabla `detalle_roll`
--
ALTER TABLE `detalle_roll`
 ADD PRIMARY KEY (`ID_detroll`), ADD KEY `roll_detalle_roll_fk` (`ID_roll`), ADD KEY `usuario_detalle_roll_fk` (`ID_usuario`);

--
-- Indices de la tabla `modulo`
--
ALTER TABLE `modulo`
 ADD PRIMARY KEY (`ID_modulo`);

--
-- Indices de la tabla `perfil`
--
ALTER TABLE `perfil`
 ADD PRIMARY KEY (`Codigo_perfil`);

--
-- Indices de la tabla `roll`
--
ALTER TABLE `roll`
 ADD PRIMARY KEY (`ID_roll`);

--
-- Indices de la tabla `sub_modulo`
--
ALTER TABLE `sub_modulo`
 ADD PRIMARY KEY (`ID_submodulo`), ADD KEY `modulo_sub_modulo_fk` (`ID_modulo`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
 ADD PRIMARY KEY (`ID_usuario`), ADD KEY `perfiles_usuario_fk` (`Codigo_perfil`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `detalle_modulo`
--
ALTER TABLE `detalle_modulo`
ADD CONSTRAINT `modulo_detalle_modulo_fk` FOREIGN KEY (`ID_modulo`) REFERENCES `modulo` (`ID_modulo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `perfiles_detalle_modulo_fk` FOREIGN KEY (`Codigo_perfil`) REFERENCES `perfil` (`Codigo_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `detalle_roll`
--
ALTER TABLE `detalle_roll`
ADD CONSTRAINT `roll_detalle_roll_fk` FOREIGN KEY (`ID_roll`) REFERENCES `roll` (`ID_roll`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `usuario_detalle_roll_fk` FOREIGN KEY (`ID_usuario`) REFERENCES `usuario` (`ID_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `sub_modulo`
--
ALTER TABLE `sub_modulo`
ADD CONSTRAINT `modulo_sub_modulo_fk` FOREIGN KEY (`ID_modulo`) REFERENCES `modulo` (`ID_modulo`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
ADD CONSTRAINT `perfiles_usuario_fk` FOREIGN KEY (`Codigo_perfil`) REFERENCES `perfil` (`Codigo_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
