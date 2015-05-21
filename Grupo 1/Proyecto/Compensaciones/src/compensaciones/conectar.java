/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package compensaciones;

import com.mysql.jdbc.Connection;
import java.sql.DriverManager;
import javax.swing.JOptionPane;

/**
 *
 * @author Francisco
 */
public class conectar {
    Connection con=null;
    public Connection conexion(){
        try{
          Class.forName("com.mysql.jdbc.Driver");
          con=(Connection) DriverManager.getConnection("jdbc:mysql://localhost/rrhh_test","root","");
          System.out.println("conexion establecida");
          JOptionPane.showMessageDialog(null, "conexion establecida");
        }catch (Exception e){
            System.out.println("error de conexion");
            JOptionPane.showMessageDialog(null, "error de conexion "+e);
        }
            
        return con;
    
    }
}
