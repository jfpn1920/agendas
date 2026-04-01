package ordenar_contactos_por_nombre_o_categoria;
import java.sql.Connection;
import java.sql.DriverManager;
public class conexion {
    private static final String URL = "jdbc:mysql://localhost:3306/ordenar_los_contactos_por_nombre_o_categoria";
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