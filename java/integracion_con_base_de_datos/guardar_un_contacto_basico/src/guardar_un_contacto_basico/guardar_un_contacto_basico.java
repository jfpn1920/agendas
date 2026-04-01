package guardar_un_contacto_basico;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.Scanner;
public class guardar_un_contacto_basico {
    @SuppressWarnings("resource")
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("=== GUARDAR CONTACTO ===");
        System.out.print("Nombre: ");
        String nombre = sc.nextLine();
        System.out.print("Teléfono: ");
        String telefono = sc.nextLine();
        System.out.print("Correo: ");
        String correo = sc.nextLine();
        Connection conn = conexion.conectar();
        if (conn == null) {
            System.out.println("❌ No se pudo conectar");
            return;
        }
        String sql = "INSERT INTO contactos (nombre, telefono, correo) VALUES (?, ?, ?)";
        try {
            PreparedStatement stmt = conn.prepareStatement(sql);
            stmt.setString(1, nombre);
            stmt.setString(2, telefono);
            stmt.setString(3, correo);
            stmt.executeUpdate();
            System.out.println("✅ Contacto guardado");
        } catch (Exception e) {
            System.out.println("❌ Error: " + e.getMessage());
        }
        sc.close();
    }
}