package validar_datos_antes_de_insertar;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.Scanner;
public class validar_datos_antes_de_insertar {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Connection conn = conexion.conectar();
        if (conn == null) {
            System.out.println("❌ No se pudo conectar a la base de datos");
            sc.close();
            return;
        }
        try {
            System.out.println("=== AGREGAR CONTACTO (CON VALIDACIÓN) ===");
            System.out.print("Nombre: ");
            String nombre = sc.nextLine();
            if (nombre.isEmpty()) {
                System.out.println("❌ El nombre no puede estar vacío");
                sc.close();
                return;
            }
            System.out.print("Teléfono: ");
            String telefono = sc.nextLine();
            if (telefono.isEmpty()) {
                System.out.println("❌ El teléfono no puede estar vacío");
                sc.close();
                return;
            }
            System.out.print("Correo: ");
            String correo = sc.nextLine();
            if (!correo.contains("@")) {
                System.out.println("❌ El correo debe contener @");
                sc.close();
                return;
            }
            String sql = "INSERT INTO contactos (nombre, telefono, correo) VALUES (?, ?, ?)";
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setString(1, nombre);
            ps.setString(2, telefono);
            ps.setString(3, correo);
            int filas = ps.executeUpdate();
            if (filas > 0) {
                System.out.println("✅ Contacto insertado correctamente");
            }
        } catch (Exception e) {
            System.out.println("❌ Error al insertar: " + e.getMessage());
        }
        sc.close();
    }
}