<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="backups.aspx.cs" Inherits="SCFWS.backups" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <title>EBRI Center</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="EBRI Center, tu seguridad en nuestras manos" />
    <meta name="author" content="ebricenter.com" />
	<meta name="ROBOTS" content="NOINDEX, NOFOLLOW" /> <!-- Remove this Robots Meta Tag, to allow indexing of site -->
    <link href="scripts/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="scripts/bootstrap/css/bootstrap-responsive.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="scripts/fontawesome/css/font-awesome.min.css" />
    <!--[if IE 7]>
        <link rel="stylesheet" href="scripts/fontawesome/css/font-awesome-ie7.min.css">
    <![endif]-->
    <link href="scripts/icons/general/stylesheets/general_foundicons.css" media="screen" rel="stylesheet" type="text/css" />  
    <link href="scripts/icons/social/stylesheets/social_foundicons.css" media="screen" rel="stylesheet" type="text/css" />
    <link href="scripts/wookmark/css/style.css" rel="stylesheet" type="text/css" />	<link href="scripts/yoxview/yoxview.css" rel="stylesheet" type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Syncopate" rel="stylesheet" type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Abel" rel="stylesheet" type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Source+Sans+Pro" rel="stylesheet" type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Open+Sans" rel="stylesheet" type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Pontano+Sans" rel="stylesheet" type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Oxygen" rel="stylesheet" type="text/css" />
    <link href="styles/custom.css" rel="stylesheet" type="text/css" />
</head>

<body id="pageBody">
    <form id="form1" runat="server">
<div id="divBoxed" class="container">
    <div class="transparent-bg" style="position: absolute;top: 0;left: 0;width: 100%;height: 100%;z-index: -1;zoom: 1;"></div>
    	<div class="divPanel notop nobottom">
            <div class="row-fluid">
                <div class="span12">
                    <div id="divLogo" class="pull-left">
                        <a href="index.aspx"><img src="images/EBRI Center LOGO.png" id="Logo" alt="EBRI Center" /></a>
                    </div>
                    <div id="divMenuRight" class="pull-right">
                    <div class="navbar">
                        <button type="button" class="btn btn-navbar-highlight btn-large btn-primary" data-toggle="collapse" data-target=".nav-collapse">
                            NAVEGACION <span class="icon-chevron-down icon-white"></span>
                        </button>
                        <div class="nav-collapse collapse">
                            <ul class="nav nav-pills ddmenu">
                            <li><a href="index.aspx">Inicio</a></li>
							<li class="dropdown">
                            <a class="dropdown-toggle">Nosotros<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                            <li><a href="about.aspx">Quienes Somos</a></li>
                            <li><a href="visionmission.aspx">Visión y Misión</a></li>
                            <li><a href="valuesgoals.aspx">Valores y Objetivos</a></li>
							<li><a href="infrastructure.aspx">Instalaciones</a></li>
						    </ul>
                            </li>
						    <li class="active dropdown">
                            <a class="dropdown-toggle">Servicios<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                            <li class="active dropdown">
                            <a href="#" class="dropdown-toggle">Seguridad Técnica</a>
                            <ul class="dropdown-menu sub-menu">
                            <li><a href="encryption.aspx">Encriptación de Datos</a></li>
                            <li><a href="recovery.aspx">Recuperación de Datos</a></li>
                            <li class="active"><a href="backups.aspx">Copias de Seguridad</a></li>
                            </ul>
                            </li>
                            <li><a href="consulting.aspx">Consultoría de Software</a></li>
                            </ul>
                            </li>
                            <li class="dropdown">
                            <a class="dropdown-toggle">Software<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                            <li><a href="createdsw.aspx">Software a Medida</a></li>
                            <li><a href="standardsw.aspx">Software Estándar</a></li>
                            </ul>
                            </li>
                            <li><a href="consults.aspx">Consultas</a></li>
						    <li><a href="contact.aspx">Contáctenos</a></li>						    
                            </ul>
                        </div>
                    </div>
                    </div>
                </div>
            </div>
    	</div>
    
		<div class="contentArea">
        	<div class="divPanel notop page-content">
	            <div class="row-fluid">
					<!--Edit Main Content Area here-->
            		<div class="span8" id="divMain">
                  		<br /><br />
                  		<h1>Copias de Seguridad</h1>
						<p style="text-align:left;">La copia de seguridad de los datos críticos de la organización garantiza que la empresa siempre esté en funcionamiento, independientemente de lo que ocurra. Razón por la cual EBRI Center ofrece un nuevo servicio garantizando la correcta realización de copias de seguridad y, por tanto, mejora la protección ante pérdidas de datos. Permitiendo acceder a sus copias de seguridad a través de internet, sin tener que trasladar medios extraíbles que se puedan extraviar, dañar o ser robados.</p>
						<br />
						<p style="text-align:left;">EBRI Center dispone de un servicio técnico proactivo para el cliente, que se encarga de dar soporte y controlar que sus copias de seguridad se realicen correctamente. Estos servicios son:</p>
						<ul>
							<li><p style="text-align:left;">Notificación de incidencias.</p></li>
							<li><p style="text-align:left;">Informe diario de copias de seguridad realizadas.</p></li>
							<li><p style="text-align:left;">Soporte telefónico y atención personalizada (Atención al cliente).</p></li>
							<li><p style="text-align:left;">Control del espacio de almacenamiento consumido.</p></li>
						</ul>
            		</div>
					<!--End Main Content Area here-->
					<!--Edit Sidebar Content here-->
              		<div class="span4 sidebar">
                		<div class="sidebox">
                			<img src="images/backups.jpg" class="img-polaroid" alt="Copias de Seguridad" />
                		</div>                    
            		</div>
					<!--End Sidebar Content here-->
            	</div>
			</div>
    	</div>
		<div id="divFooter" class="footerArea">
    		<p class="copyright">
            	<center>Copyright © 2015 EBRI Center. All Rights Reserved.</center>
        	</p>
    	</div>
    </div>
	<script src="scripts/jquery.min.js" type="text/javascript"></script> 
	<script src="scripts/bootstrap/js/bootstrap.min.js" type="text/javascript"></script>
	<script src="scripts/default.js" type="text/javascript"></script>

	<script src="scripts/wookmark/js/jquery.wookmark.js" type="text/javascript"></script>
	<script type="text/javascript">$(window).load(function () { var options = { autoResize: true, container: $('#gridArea'), offset: 10 }; var handler = $('#tiles li'); handler.wookmark(options); $('#tiles li').each(function () { var imgm = 0; if ($(this).find('img').length > 0) imgm = parseInt($(this).find('img').not('p img').css('margin-bottom')); var newHeight = $(this).find('img').height() + imgm + $(this).find('div').height() + $(this).find('h4').height() + $(this).find('p').not('blockquote p').height() + $(this).find('iframe').height() + $(this).find('blockquote').height() + 5; if ($(this).find('iframe').height()) newHeight = newHeight + 15; $(this).css('height', newHeight + 'px'); }); handler.wookmark(options); handler.wookmark(options); });</script>
	<script src="scripts/yoxview/yox.js" type="text/javascript"></script>
	<script src="scripts/yoxview/jquery.yoxview-2.21.js" type="text/javascript"></script>
	<script type="text/javascript">$(document).ready(function () { $('.yoxview').yoxview({ autoHideInfo: false, renderInfoPin: false, backgroundColor: '#ffffff', backgroundOpacity: 0.8, infoBackColor: '#000000', infoBackOpacity: 1 }); $('.yoxview a img').hover(function () { $(this).animate({ opacity: 0.7 }, 300) }, function () { $(this).animate({ opacity: 1 }, 300) }); });</script>
</form>
</body>
</html>

 
    
    