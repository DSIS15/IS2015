<?php
 if(isset($_POST['submit']))
 {
    $name = $_POST['name'];
	$email = $_POST['email'];
	$query = $_POST['message'];
	$email_from = $name.'<'.$email.'>';

 $to="infoebricenter@gmail.com";
 $subject="Comentario!";
 $headers  = 'MIME-Version: 1.0' . "\r\n";
 $headers .= 'Content-type: text/html; charset=iso-8859-1' . "\r\n";
 $headers .= "From: ".$email_from."\r\n";
 $message="	  
 	   
 		 Nombre:
		 $name 	   
         <br>
 		 Email:
		 $email 	   
         <br>
 		 Mensaje:
		 $query 	   
      
   ";
	if(mail($to,$subject,$message,$headers))
		header("Location:../contact.php?msg=Mensaje enviado! Gracias por contactarnos.");
	else
		header("Location:../contact.php?msg=Error al enviar el mensaje!");
 }
?>
