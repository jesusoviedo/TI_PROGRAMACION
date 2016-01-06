package SQL_CONEXION;

/**
 *
 * @author Jesús Oviedo
 *
 */
public class Acceso {

    public static void main(String[] args) {
       ConexionDB SqlServer = new ConexionDB ();
       SqlServer.RealizarConexion();
    }
}
