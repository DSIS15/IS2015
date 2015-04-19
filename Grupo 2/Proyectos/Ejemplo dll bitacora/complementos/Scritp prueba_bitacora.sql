-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 19-04-2015 a las 21:39:00
-- Versión del servidor: 5.6.21
-- Versión de PHP: 5.5.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `prueba_bitacora`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

CREATE TABLE IF NOT EXISTS `bitacora` (
`id_bitacora` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `descripcion` varchar(30) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bitacora`
--

INSERT INTO `bitacora` (`id_bitacora`, `id_usuario`, `descripcion`, `fecha`) VALUES
(1, 1, 'Inserción', '2015-04-18'),
(2, 1, 'Consulta', '2015-04-18'),
(3, 1, 'Elimino 2 registros', '2015-04-18'),
(4, 1, 'Actualizo 1 registro', '2015-04-18');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario_prueba`
--

CREATE TABLE IF NOT EXISTS `usuario_prueba` (
`id_usuario` int(11) NOT NULL,
  `nombre` varchar(15) NOT NULL,
  `apellido` varchar(15) NOT NULL,
  `fecha_ingreso` date NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario_prueba`
--

INSERT INTO `usuario_prueba` (`id_usuario`, `nombre`, `apellido`, `fecha_ingreso`) VALUES
(1, 'Arial', 'Analysts', '2015-04-18'),
(2, 'Usuario2', 'Usuario2', '2015-04-19'),
(3, 'Usuario3', 'Usuario3', '2015-04-19');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `viewbitacora`
--
CREATE TABLE IF NOT EXISTS `viewbitacora` (
`id_bitacora` int(11)
,`nombre` varchar(15)
,`descripcion` varchar(30)
,`fecha` date
);
-- --------------------------------------------------------

--
-- Estructura para la vista `viewbitacora`
--
DROP TABLE IF EXISTS `viewbitacora`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewbitacora` AS select `bitacora`.`id_bitacora` AS `id_bitacora`,`usuario_prueba`.`nombre` AS `nombre`,`bitacora`.`descripcion` AS `descripcion`,`bitacora`.`fecha` AS `fecha` from (`bitacora` join `usuario_prueba` on((`usuario_prueba`.`id_usuario` = `bitacora`.`id_usuario`)));

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `bitacora`
--
ALTER TABLE `bitacora`
 ADD PRIMARY KEY (`id_bitacora`), ADD KEY `usuario_bitacora_fk` (`id_usuario`);

--
-- Indices de la tabla `usuario_prueba`
--
ALTER TABLE `usuario_prueba`
 ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `bitacora`
--
ALTER TABLE `bitacora`
MODIFY `id_bitacora` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `usuario_prueba`
--
ALTER TABLE `usuario_prueba`
MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `bitacora`
--
ALTER TABLE `bitacora`
ADD CONSTRAINT `usuario_bitacora_fk` FOREIGN KEY (`id_usuario`) REFERENCES `usuario_prueba` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
