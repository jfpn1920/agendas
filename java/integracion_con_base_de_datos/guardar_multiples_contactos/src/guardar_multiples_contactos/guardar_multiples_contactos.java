package guardar_multiples_contactos;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.Scanner;
public class guardar_multiples_contactos {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Connection conn = conexion.conectar();
        if (conn == null) {
            System.out.println("❌ No se pudo conectar");
            sc.close();
            return;
        }
        String opcion;
        do {
            System.out.println("\n=== NUEVO CONTACTO ===");
            System.out.print("Nombre: ");
            String nombre = sc.nextLine();
            System.out.print("Teléfono: ");
            String telefono = sc.nextLine();
            System.out.print("Correo: ");
            String correo = sc.nextLine();
            String sql = "INSERT INTO contactos (nombre, telefono, correo) VALUES (?, ?, ?)";
            try {
                PreparedStatement ps = conn.prepareStatement(sql);
                ps.setString(1, nombre);
                ps.setString(2, telefono);
                ps.setString(3, correo);
                ps.executeUpdate();
                System.out.println("✅ Contacto guardado");
            } catch (Exception e) {
                System.out.println("❌ Error: " + e.getMessage());
            }
            System.out.print("\n¿Desea agregar otro contacto? (s/n): ");
            opcion = sc.nextLine();
        } while (opcion.equalsIgnoreCase("s"));
        System.out.println("👋 Fin del programa");
        sc.close();
    }
}