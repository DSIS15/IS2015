/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package proyectohhrr;
import java.sql.*;
import javax.swing.JOptionPane;

/**
 *
 * @author JCR
 */


public class conectar {
    //Connection miconexion;
    //Statement stSentencias;
   // PreparedStatement psPrepararSentencias;
    
    
    
    Connection con=null;
    

    
    public Connection conexion(){
        try{
          Class.forName("com.mysql.jdbc.Driver");
          con=DriverManager.getConnection("jdbc:mysql://localhost/capacitaciones","root","");
          System.out.println("conexion establecida");
          //JOptionPane.showMessageDialog(null, "conexion establecida");
        }catch (Exception e){
            System.out.println("error de conexion");
            JOptionPane.showMessageDialog(null, "error de conexion "+e);
        }
       
            
        return con;
    }
    

    
    
    PreparedStatement prepareStatement(String sentenciaInsert) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    //para poder insertar a la bd
    /*public void ejecutar (String sql) throws Exception
 {
  try {
      stSentencias.execute(sql);
  }  catch (Exception e){
      throw e;
  } 
 }*/   
}

