package SQL_CONEXION;

/**
 *
 * @author Jesús Oviedo
 */
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import javax.swing.JOptionPane;

public class ConexionDB {

    private Connection GetConnection() {
        Connection conexion = null;

        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            String url;
            url = "jdbc:sqlserver://localhost:1433;databaseName=Proyecto_GPI_GOLF;user=ap;password=gpigolf;";
            conexion = DriverManager.getConnection(url);
        } catch (ClassNotFoundException ex) {
            JOptionPane.showMessageDialog(null, ex, "Error1 en la Conexión con la BD " + ex.getMessage(), JOptionPane.ERROR_MESSAGE);
            conexion = null;
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, ex, "Error2 en la Conexión con la BD " + ex.getMessage(), JOptionPane.ERROR_MESSAGE);
            conexion = null;
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(null, ex, "Error3 en la Conexión con la BD " + ex.getMessage(), JOptionPane.ERROR_MESSAGE);
            conexion = null;
        } finally {
            return conexion;
        }
    }

    public void RealizarConexion() {
    Connection conexionE = GetConnection();
        if (conexionE != null) {
            JOptionPane.showMessageDialog(null, "Conexión Realizada Correctamente");
        }
    }
}
