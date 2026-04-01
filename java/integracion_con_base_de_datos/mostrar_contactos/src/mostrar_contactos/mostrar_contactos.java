package mostrar_contactos;
import java.sql.Connection;
import java.sql.Statement;
import java.sql.ResultSet;
import java.sql.PreparedStatement;
import java.util.Scanner;
public class mostrar_contactos {
    @SuppressWarnings("resource")
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Connection conn = conexion.conectar();
        if (conn == null) {
            System.out.println("❌ No se pudo conectar");
            return;
        }
        System.out.println("=== AGREGAR CONTACTO ===");
        System.out.print("Nombre: ");
        String nombre = sc.nextLine();
        System.out.print("Teléfono: ");
        String telefono = sc.nextLine();
        System.out.print("Correo: ");
        String correo = sc.nextLine();
        String insertSQL = "INSERT INTO contactos (nombre, telefono, correo) VALUES (?, ?, ?)";
        try {
            PreparedStatement ps = conn.prepareStatement(insertSQL);
            ps.setString(1, nombre);
            ps.setString(2, telefono);
            ps.setString(3, correo);
            ps.executeUpdate();
            System.out.println("✅ Contacto guardado");
        } catch (Exception e) {
            System.out.println("❌ Error al insertar: " + e.getMessage());
        }
        String sql = "SELECT * FROM contactos";
        try {
            Statement stmt = conn.createStatement();
            ResultSet rs = stmt.executeQuery(sql);
            System.out.println("\n=== LISTA DE CONTACTOS ===");
            while (rs.next()) {
                int id = rs.getInt("id");
                String nom = rs.getString("nombre");
                String tel = rs.getString("telefono");
                String cor = rs.getString("correo");
                System.out.println("------------------------");
                System.out.println("ID: " + id);
                System.out.println("Nombre: " + nom);
                System.out.println("Teléfono: " + tel);
                System.out.println("Correo: " + cor);
            }
        } catch (Exception e) {
            System.out.println("❌ Error al mostrar: " + e.getMessage());
        }
        sc.close();
    }
}