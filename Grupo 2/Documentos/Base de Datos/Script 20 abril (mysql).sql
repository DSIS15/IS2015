-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 17-04-2015 a las 16:41:39
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
-- Estructura de tabla para la tabla `antecedentes_medicos`
--

CREATE TABLE IF NOT EXISTS `antecedentes_medicos` (
  `id_antecente_medico` decimal(10,0) NOT NULL,
  `id_pacientes` decimal(10,0) NOT NULL,
  `id_enfermedad` decimal(10,0) NOT NULL,
  `Descripcion` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora_hospital`
--

CREATE TABLE IF NOT EXISTS `bitacora_hospital` (
  `id_bitacora` decimal(10,0) NOT NULL,
  `id_usuario` decimal(10,0) NOT NULL,
  `hostname` varchar(20) NOT NULL,
  `fecha` varchar(10) NOT NULL,
  `hora` varchar(11) NOT NULL,
  `ip` varchar(17) NOT NULL,
  `descripcion` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bitacora_hospital`
--

INSERT INTO `bitacora_hospital` (`id_bitacora`, `id_usuario`, `hostname`, `fecha`, `hora`, `ip`, `descripcion`) VALUES
('1', '1', 'Orochi-pc', '15-04-2015', '3:30 p.m', '192.168.1.1', 'Realización de prueba'),
('2', '1', 'Orochi-pc', '15-04-2015', '3:31 p.m', '192.168.1.1', 'Realización de prueba 2');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cita_medi`
--

CREATE TABLE IF NOT EXISTS `cita_medi` (
  `id_cita_medi` decimal(10,0) NOT NULL,
  `id_usuario` decimal(10,0) NOT NULL,
  `id_pacientes` decimal(10,0) NOT NULL,
  `id_medico` decimal(10,0) NOT NULL,
  `fecha_cita` varchar(10) NOT NULL,
  `estado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_modulo`
--

CREATE TABLE IF NOT EXISTS `detalle_modulo` (
  `id_detmodulo` decimal(10,0) NOT NULL,
  `id_modulo` decimal(10,0) NOT NULL,
  `codigo_perfil` decimal(10,0) NOT NULL,
  `fecha_creacion` varchar(10) NOT NULL,
  `fecha_modificacion` varchar(10) NOT NULL,
  `estado` decimal(1,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_modulo`
--

INSERT INTO `detalle_modulo` (`id_detmodulo`, `id_modulo`, `codigo_perfil`, `fecha_creacion`, `fecha_modificacion`, `estado`) VALUES
('1', '1', '1', '15-04-2015', '15-04-2015', '1'),
('2', '2', '1', '15-04-2015', '15-04-2015', '1'),
('3', '3', '1', '2015/04/16', '2015/04/16', '1'),
('4', '4', '1', '2015/04/16', '2015/04/16', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `det_examen`
--

CREATE TABLE IF NOT EXISTS `det_examen` (
  `id_det_examen` decimal(10,0) NOT NULL,
  `id_pacientes` decimal(10,0) NOT NULL,
  `id_tipo_examen` decimal(10,0) NOT NULL,
  `id_medico` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `enfermedades_antecedentes`
--

CREATE TABLE IF NOT EXISTS `enfermedades_antecedentes` (
  `id_enfermedad` decimal(10,0) NOT NULL,
  `nombre_enfermedad` varchar(15) NOT NULL,
  `estado` decimal(1,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medico`
--

CREATE TABLE IF NOT EXISTS `medico` (
  `id_medico` decimal(10,0) NOT NULL,
  `nombre_medico` varchar(25) NOT NULL,
  `priimer_apellido_medico` varchar(15) NOT NULL,
  `medico_segundo_apellido` varchar(15) NOT NULL,
  `fecha_ingreso` varchar(11) NOT NULL,
  `estado` decimal(1,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulo`
--

CREATE TABLE IF NOT EXISTS `modulo` (
  `id_modulo` decimal(10,0) NOT NULL,
  `nombre_modulo` varchar(25) NOT NULL,
  `nombre_dll` varchar(25) NOT NULL,
  `fecha_creacion` varchar(10) NOT NULL,
  `fecha_modificacion` varchar(10) NOT NULL,
  `estado` decimal(1,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `modulo`
--

INSERT INTO `modulo` (`id_modulo`, `nombre_modulo`, `nombre_dll`, `fecha_creacion`, `fecha_modificacion`, `estado`) VALUES
('1', 'Inicio', '', '15-04-2015', '15-04-2015', '1'),
('2', 'Seguridad', 'dll_seguridad', '15-04-2015', '15-04-2015', '1'),
('3', 'Bitacora', 'dll_bitacora', '2015/04/16', '2015/04/16', '1'),
('4', 'Paciente', 'dll_paciente', '2015/04/16', '2015/04/16', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paciente`
--

CREATE TABLE IF NOT EXISTS `paciente` (
  `id_pacientes` decimal(10,0) NOT NULL,
  `nombre_paciente` varchar(25) NOT NULL,
  `primer_apellido` varchar(15) NOT NULL,
  `segundo_apellido` varchar(15) NOT NULL,
  `direccion_paciente` varchar(30) NOT NULL,
  `telefono_paciente` varchar(9) NOT NULL,
  `estatura_paciente` decimal(10,2) NOT NULL,
  `peso_paciente` decimal(10,2) NOT NULL,
  `sangre_paciente` varchar(5) NOT NULL,
  `identificacion_paciente` decimal(13,0) NOT NULL,
  `fecha_nacimiento_paciente` varchar(10) NOT NULL,
  `estado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `paciente`
--

INSERT INTO `paciente` (`id_pacientes`, `nombre_paciente`, `primer_apellido`, `segundo_apellido`, `direccion_paciente`, `telefono_paciente`, `estatura_paciente`, `peso_paciente`, `sangre_paciente`, `identificacion_paciente`, `fecha_nacimiento_paciente`, `estado`) VALUES
('1', 'jjjj', 'jjjj', 'jjjj', 'jjjjj', '4493599', '2.00', '98.00', 'A+', '9999999999', '13-11-1991', 1),
('2', 'aaaa', 'aaaa', 'aaaa', 'aaaa', '41493599', '1.72', '98.50', 'A+', '2093431251906', '13-11-1991', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

CREATE TABLE IF NOT EXISTS `perfil` (
  `codigo_perfil` decimal(10,0) NOT NULL,
  `nombre_perfil` varchar(15) NOT NULL,
  `fecha_creacion` varchar(15) NOT NULL,
  `fecha_modificacion` varchar(10) NOT NULL,
  `estado` decimal(1,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `perfil`
--

INSERT INTO `perfil` (`codigo_perfil`, `nombre_perfil`, `fecha_creacion`, `fecha_modificacion`, `estado`) VALUES
('1', 'admin', '15-04-2015', '15-04-2015', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sub_modulo`
--

CREATE TABLE IF NOT EXISTS `sub_modulo` (
  `id_submodulo` decimal(10,0) NOT NULL,
  `id_modulo` decimal(10,0) NOT NULL,
  `nombre_submodulo` varchar(30) NOT NULL,
  `nombre_form` varchar(30) NOT NULL,
  `fecha_creacion` varchar(10) NOT NULL,
  `fecha_modificacion` varchar(10) NOT NULL,
  `estado` decimal(1,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `sub_modulo`
--

INSERT INTO `sub_modulo` (`id_submodulo`, `id_modulo`, `nombre_submodulo`, `nombre_form`, `fecha_creacion`, `fecha_modificacion`, `estado`) VALUES
('1', '1', 'Ordenar modo cascada', '', '15-04-2015', '15-04-2015', '1'),
('2', '1', 'Ordenar modo Horizontal', '', '15-04-2015', '15-04-2015', '1'),
('3', '1', 'Ordenar modo Vertical', '', '15-04-2015', '15-04-2015', '1'),
('4', '1', 'Cerrar Sesion', '', '15-04-2015', '15-04-2015', '1'),
('5', '1', 'Salir', '', '15-04-2015', '15-04-2015', '1'),
('6', '2', 'Usuario', 'wfUsuario', '15-04-2015', '15-04-2015', '1'),
('7', '2', 'Modulo', 'wfModulo', '15-04-2015', '15-04-2015', '1'),
('8', '2', 'Sub Modulo', 'wfSubMod', '15-04-2015', '15-04-2015', '1'),
('9', '2', 'Perfil', 'wfPerfiles', '2015/04/15', '2015/04/15', '1'),
('10', '2', 'Administracion de Recursos', 'wfDetMod', '2015/04/15', '2015/04/15', '1'),
('11', '3', 'Bitacora', 'wfBitacora', '2015/04/16', '2015/04/16', '1'),
('12', '4', 'Administración Paciente', 'wfPaciente', '2015/04/16', '2015/04/16', '1'),
('13', '4', 'Antecedentes Medicos', 'wfAntecedentesM', '2015/04/16', '2015/04/16', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_examen`
--

CREATE TABLE IF NOT EXISTS `tipo_examen` (
  `id_tipo_examen` decimal(10,0) NOT NULL,
  `nombre_tipo_examen` varchar(20) NOT NULL,
  `descripcion_examen` varchar(25) NOT NULL,
  `fecha_creacion` varchar(10) NOT NULL,
  `fecha_modificacion` varchar(10) NOT NULL,
  `estado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `id_usuario` decimal(10,0) NOT NULL,
  `codigo_perfil` decimal(10,0) NOT NULL,
  `alias_usuario` varchar(15) NOT NULL,
  `contrasena_usuario` varchar(10) NOT NULL,
  `nombre_usuario` varchar(15) NOT NULL,
  `primer_apellido` varchar(10) NOT NULL,
  `segundo_apellido` varchar(10) NOT NULL,
  `direccion` varchar(25) NOT NULL,
  `fecha_de_creacion` varchar(10) NOT NULL,
  `fecha_de_modificacion` varchar(10) NOT NULL,
  `estado` decimal(1,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `codigo_perfil`, `alias_usuario`, `contrasena_usuario`, `nombre_usuario`, `primer_apellido`, `segundo_apellido`, `direccion`, `fecha_de_creacion`, `fecha_de_modificacion`, `estado`) VALUES
('1', '1', 'admin', 'admin', 'admin', 'admin', 'admin', 'admin', '15-04-2015', '15-04-2015', '1');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `viewbitacora_hospital`
--
CREATE TABLE IF NOT EXISTS `viewbitacora_hospital` (
`id_bitacora` decimal(10,0)
,`alias_usuario` varchar(15)
,`nombre_usuario` varchar(15)
,`primer_apellido` varchar(10)
,`hostname` varchar(20)
,`fecha` varchar(10)
,`hora` varchar(11)
,`ip` varchar(17)
,`descripcion` varchar(30)
);
-- --------------------------------------------------------

--
-- Estructura para la vista `viewbitacora_hospital`
--
DROP TABLE IF EXISTS `viewbitacora_hospital`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewbitacora_hospital` AS select `bitacora_hospital`.`id_bitacora` AS `id_bitacora`,`usuario`.`alias_usuario` AS `alias_usuario`,`usuario`.`nombre_usuario` AS `nombre_usuario`,`usuario`.`primer_apellido` AS `primer_apellido`,`bitacora_hospital`.`hostname` AS `hostname`,`bitacora_hospital`.`fecha` AS `fecha`,`bitacora_hospital`.`hora` AS `hora`,`bitacora_hospital`.`ip` AS `ip`,`bitacora_hospital`.`descripcion` AS `descripcion` from (`bitacora_hospital` join `usuario` on((`usuario`.`id_usuario` = `bitacora_hospital`.`id_usuario`)));

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `antecedentes_medicos`
--
ALTER TABLE `antecedentes_medicos`
 ADD PRIMARY KEY (`id_antecente_medico`), ADD KEY `enfermedades_antecedentes_antecedentes_medicos_fk` (`id_enfermedad`), ADD KEY `paciente_antecedentes_medicos_fk` (`id_pacientes`);

--
-- Indices de la tabla `bitacora_hospital`
--
ALTER TABLE `bitacora_hospital`
 ADD PRIMARY KEY (`id_bitacora`), ADD KEY `usuario_bitacora_hospital_fk` (`id_usuario`);

--
-- Indices de la tabla `cita_medi`
--
ALTER TABLE `cita_medi`
 ADD PRIMARY KEY (`id_cita_medi`), ADD KEY `medico_cita_medi_fk` (`id_medico`), ADD KEY `paciente_cita_medi_fk` (`id_pacientes`), ADD KEY `usuario_cita_medi_fk` (`id_usuario`);

--
-- Indices de la tabla `detalle_modulo`
--
ALTER TABLE `detalle_modulo`
 ADD PRIMARY KEY (`id_detmodulo`), ADD KEY `modulo_detalle_modulo_fk` (`id_modulo`), ADD KEY `perfil_detalle_modulo_fk` (`codigo_perfil`);

--
-- Indices de la tabla `det_examen`
--
ALTER TABLE `det_examen`
 ADD PRIMARY KEY (`id_det_examen`), ADD KEY `medico_det_examen_fk` (`id_medico`), ADD KEY `paciente_det_examen_fk` (`id_pacientes`), ADD KEY `tipo_examen_det_examen_fk` (`id_tipo_examen`);

--
-- Indices de la tabla `enfermedades_antecedentes`
--
ALTER TABLE `enfermedades_antecedentes`
 ADD PRIMARY KEY (`id_enfermedad`);

--
-- Indices de la tabla `medico`
--
ALTER TABLE `medico`
 ADD PRIMARY KEY (`id_medico`);

--
-- Indices de la tabla `modulo`
--
ALTER TABLE `modulo`
 ADD PRIMARY KEY (`id_modulo`);

--
-- Indices de la tabla `paciente`
--
ALTER TABLE `paciente`
 ADD PRIMARY KEY (`id_pacientes`);

--
-- Indices de la tabla `perfil`
--
ALTER TABLE `perfil`
 ADD PRIMARY KEY (`codigo_perfil`);

--
-- Indices de la tabla `sub_modulo`
--
ALTER TABLE `sub_modulo`
 ADD PRIMARY KEY (`id_submodulo`), ADD KEY `modulo_sub_modulo_fk` (`id_modulo`);

--
-- Indices de la tabla `tipo_examen`
--
ALTER TABLE `tipo_examen`
 ADD PRIMARY KEY (`id_tipo_examen`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
 ADD PRIMARY KEY (`id_usuario`), ADD KEY `perfil_usuario_fk` (`codigo_perfil`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `antecedentes_medicos`
--
ALTER TABLE `antecedentes_medicos`
ADD CONSTRAINT `enfermedades_antecedentes_antecedentes_medicos_fk` FOREIGN KEY (`id_enfermedad`) REFERENCES `enfermedades_antecedentes` (`id_enfermedad`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `paciente_antecedentes_medicos_fk` FOREIGN KEY (`id_pacientes`) REFERENCES `paciente` (`id_pacientes`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `bitacora_hospital`
--
ALTER TABLE `bitacora_hospital`
ADD CONSTRAINT `usuario_bitacora_hospital_fk` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `cita_medi`
--
ALTER TABLE `cita_medi`
ADD CONSTRAINT `medico_cita_medi_fk` FOREIGN KEY (`id_medico`) REFERENCES `medico` (`id_medico`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `paciente_cita_medi_fk` FOREIGN KEY (`id_pacientes`) REFERENCES `paciente` (`id_pacientes`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `usuario_cita_medi_fk` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `detalle_modulo`
--
ALTER TABLE `detalle_modulo`
ADD CONSTRAINT `modulo_detalle_modulo_fk` FOREIGN KEY (`id_modulo`) REFERENCES `modulo` (`id_modulo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `perfil_detalle_modulo_fk` FOREIGN KEY (`codigo_perfil`) REFERENCES `perfil` (`codigo_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `det_examen`
--
ALTER TABLE `det_examen`
ADD CONSTRAINT `medico_det_examen_fk` FOREIGN KEY (`id_medico`) REFERENCES `medico` (`id_medico`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `paciente_det_examen_fk` FOREIGN KEY (`id_pacientes`) REFERENCES `paciente` (`id_pacientes`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `tipo_examen_det_examen_fk` FOREIGN KEY (`id_tipo_examen`) REFERENCES `tipo_examen` (`id_tipo_examen`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `sub_modulo`
--
ALTER TABLE `sub_modulo`
ADD CONSTRAINT `modulo_sub_modulo_fk` FOREIGN KEY (`id_modulo`) REFERENCES `modulo` (`id_modulo`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
ADD CONSTRAINT `perfil_usuario_fk` FOREIGN KEY (`codigo_perfil`) REFERENCES `perfil` (`codigo_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
