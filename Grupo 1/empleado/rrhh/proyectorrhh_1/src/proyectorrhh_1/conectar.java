/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package proyectorrhh_1;
import java.sql.*;
import javax.swing.JOptionPane;

/**
 *
 * @author JCR
 */
public class conectar {
    Connection con=null;
    public Connection conexion(){
        try{
          Class.forName("com.mysql.jdbc.Driver");
          con=DriverManager.getConnection("jdbc:mysql://localhost/mydb","root","");
          System.out.println("conexion establecida");
          //JOptionPane.showMessageDialog(null, "conexion establecida");
        }catch (Exception e){
            System.out.println("error de conexion");
            JOptionPane.showMessageDialog(null, "error de conexion "+e);
        }
            
        return con;
    }
}
