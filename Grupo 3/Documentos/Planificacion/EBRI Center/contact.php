<html>
<head>
	<meta charset="utf-8">
    <title>EBRI Center</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="EBRI Center, tu seguridad en nuestras manos">
    <meta name="author" content="ebricenter.com">
	<META NAME="ROBOTS" CONTENT="NOINDEX, NOFOLLOW"> <!-- Remove this Robots Meta Tag, to allow indexing of site -->
    <link href="scripts/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="scripts/bootstrap/css/bootstrap-responsive.min.css" rel="stylesheet">
    <link rel="stylesheet" href="scripts/fontawesome/css/font-awesome.min.css">
    <!--[if IE 7]>
        <link rel="stylesheet" href="scripts/fontawesome/css/font-awesome-ie7.min.css">
    <![endif]-->
    <link href="scripts/icons/general/stylesheets/general_foundicons.css" media="screen" rel="stylesheet" type="text/css" />  
    <link href="scripts/icons/social/stylesheets/social_foundicons.css" media="screen" rel="stylesheet" type="text/css" />
    <link href="scripts/wookmark/css/style.css" rel="stylesheet" type="text/css" />	<link href="scripts/yoxview/yoxview.css" rel="stylesheet" type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Syncopate" rel="stylesheet" type="text/css">
    <link href="http://fonts.googleapis.com/css?family=Abel" rel="stylesheet" type="text/css">
    <link href="http://fonts.googleapis.com/css?family=Source+Sans+Pro" rel="stylesheet" type="text/css">
    <link href="http://fonts.googleapis.com/css?family=Open+Sans" rel="stylesheet" type="text/css">
    <link href="http://fonts.googleapis.com/css?family=Pontano+Sans" rel="stylesheet" type="text/css">
    <link href="http://fonts.googleapis.com/css?family=Oxygen" rel="stylesheet" type="text/css">
    <link href="styles/custom.css" rel="stylesheet" type="text/css" />
    
    <script src="email/validation.js" type="text/javascript"></script>
</head>
<body id="pageBody">
<div id="divBoxed" class="container">
    <div class="transparent-bg" style="position: absolute;top: 0;left: 0;width: 100%;height: 100%;z-index: -1;zoom: 1;"></div>
    	<div class="divPanel notop nobottom">
            <div class="row-fluid">
                <div class="span12">
                    <div id="divLogo" class="pull-left">
                        <a href="index.php"><img src="images/EBRI Center LOGO.png" id="Logo" alt="EBRI Center"></a>
                    </div>
                    <div id="divMenuRight" class="pull-right">
                    <div class="navbar">
                        <button type="button" class="btn btn-navbar-highlight btn-large btn-primary" data-toggle="collapse" data-target=".nav-collapse">
                            NAVEGACION <span class="icon-chevron-down icon-white"></span>
                        </button>
                        <div class="nav-collapse collapse">
                            <ul class="nav nav-pills ddmenu">
                            <li><a href="index.php">Inicio</a></li>
							<li class="dropdown">
                            <a href="" class="dropdown-toggle">Nosotros<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                            <li><a href="about.php">Quienes Somos</a></li>
                            <li><a href="visionmission.php">Visión y Misión</a></li>
                            <li><a href="valuesgoals.php">Valores y Objetivos</a></li>
							<li><a href="infrastructure.php">Instalaciones</a></li>
						    </ul>
                            </li>
						    <li class="dropdown">
                            <a href="" class="dropdown-toggle">Servicios<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                            <li class="dropdown">
                            <a href="#" class="dropdown-toggle">Seguridad Técnica</a>
                            <ul class="dropdown-menu sub-menu">
                            <li><a href="encryption.php">Encriptación de Datos</a></li>
                            <li><a href="recovery.php">Recuperación de Datos</a></li>
                            <li><a href="backups.php">Copias de Seguridad</a></li>
                            </ul>
                            </li>
                            <li><a href="consulting.php">Consultoría de Software</a></li>
                            </ul>
                            </li>
                            <li class="dropdown">
                            <a href="" class="dropdown-toggle">Software<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                            <li><a href="createdsw.php">Software a Medida</a></li>
                            <li><a href="standardsw.php">Software Estándar</a></li>
                            </ul>
                            </li>
						<li class="active"><a href="contact.php">Contáctenos</a></li>						    
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
                	<div class="span8" id="divMain">
                		<br /> <br />
                    	<h1>Contáctenos</h1>
                   		<iframe width="100%" height="350" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3861.2059327076945!2d-90.51368112982244!3d14.587338332627692!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x9f7bd4a0d2a52c7e!2sedificio+europlaza%2C+zona+14!5e0!3m2!1sen!2s!4v1395790404733"></iframe>
						<br><br><br>
						<!--Start Contact form -->		                                                
						<form name="enq" method="post" action="email/" onsubmit="return validation();">
  							<fieldset>
								<input type="text" name="name" id="name" value=""  class="input-block-level" placeholder="Nombre" tabindex=1/>
    							<input type="text" name="email" id="email" value="" class="input-block-level" placeholder="Email" tabindex=2/>
    							<textarea rows="11" name="message" id="message" class="input-block-level" placeholder="Mensaje" style="resize:none;" tabindex=3></textarea>
    							<div class="actions">
									<input type="submit" value="Enviar mensaje" name="submit" id="submitButton" class="btn btn-primary pull-right" title="Click aqui para enviar su mensaje!" tabindex=4/>
								</div>
							</fieldset>
						</form>  				 
						<!--End Contact form -->
						<?php 
							if (@$_GET['msg'] <> '') {
								echo "<div class=\"alert alert-success\">";                       
                    			echo "<h4>". @$_GET['msg']. "</h4>";
                				echo "</div>";
							}
						?>	 
                	</div>
					<!--Edit Sidebar Content here-->	
                	<div class="span4 sidebar">
                    	<div class="sidebox">
                        	<h2 class="sidebox-title">Información</h2>
                    		<p>
                        		<address><strong>EBRI Center</strong><br />
                        		5 AV 5-55 Z-14 Edificio Europlaza T II<br />
                        		Nivel 11 Oficina 1105<br />
                        		Guatemala, Guatemala<br />
                        		PBX: (502) 2456-7890</address> 
                        		<address><strong>Email</strong><br />
                        		<a href="mailto:#">infoebricenter@gmail.com</a></address>  
                    		</p>
                    	</div>                    
                	</div>
					<!--/End Sidebar Content-->
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
	<script type="text/javascript">$(window).load(function () {var options = {autoResize: true,container: $('#gridArea'),offset: 10};var handler = $('#tiles li');handler.wookmark(options);$('#tiles li').each(function () { var imgm = 0; if($(this).find('img').length>0)imgm=parseInt($(this).find('img').not('p img').css('margin-bottom')); var newHeight = $(this).find('img').height() + imgm + $(this).find('div').height() + $(this).find('h4').height() + $(this).find('p').not('blockquote p').height() + $(this).find('iframe').height() + $(this).find('blockquote').height() + 5;if($(this).find('iframe').height()) newHeight = newHeight+15;$(this).css('height', newHeight + 'px');});handler.wookmark(options);handler.wookmark(options);});</script>
	<script src="scripts/yoxview/yox.js" type="text/javascript"></script>
	<script src="scripts/yoxview/jquery.yoxview-2.21.js" type="text/javascript"></script>
	<script type="text/javascript">$(document).ready(function () {$('.yoxview').yoxview({autoHideInfo:false,renderInfoPin:false,backgroundColor:'#ffffff',backgroundOpacity:0.8,infoBackColor:'#000000',infoBackOpacity:1});$('.yoxview a img').hover(function(){$(this).animate({opacity:0.7},300)},function(){$(this).animate({opacity:1},300)});});</script>
	<script type="text/javascript">$('.ttip').tooltip();</script>
</body>
</html>