package validar_datos_antes_de_insertar;
import java.sql.Connection;
import java.sql.DriverManager;
public class conexion {
    private static final String URL = "jdbc:mysql://localhost:3306/validar_los_datos_antes_de_insertar";
    private static final String USER = "root";
    private static final String PASSWORD = "";
    public static Connection conectar() {
        Connection conn = null;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            conn = DriverManager.getConnection(URL, USER, PASSWORD);
            System.out.println("✅ Conexión exitosa a la base de datos");
        } catch (Exception e) {
            System.out.println("❌ Error de conexión: " + e.getMessage());
        }
        return conn;
    }
}