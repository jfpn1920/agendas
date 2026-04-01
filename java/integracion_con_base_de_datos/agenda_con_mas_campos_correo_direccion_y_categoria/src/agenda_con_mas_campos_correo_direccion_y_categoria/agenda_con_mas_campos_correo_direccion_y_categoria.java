package agenda_con_mas_campos_correo_direccion_y_categoria;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.Scanner;
public class agenda_con_mas_campos_correo_direccion_y_categoria {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Connection conn = conexion.conectar();
        if (conn == null) {
            System.out.println("❌ No se pudo conectar a la base de datos");
            sc.close();
            return;
        }
        try {
            System.out.println("=== AGENDA CON MÁS CAMPOS ===");
            System.out.print("Nombre: ");
            String nombre = sc.nextLine();
            System.out.print("Teléfono: ");
            String telefono = sc.nextLine();
            System.out.print("Correo: ");
            String correo = sc.nextLine();
            System.out.print("Dirección: ");
            String direccion = sc.nextLine();
            System.out.print("Categoría (familia, trabajo, amigos): ");
            String categoria = sc.nextLine();
            String sql = "INSERT INTO contactos (nombre, telefono, correo, direccion, categoria) VALUES (?, ?, ?, ?, ?)";
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setString(1, nombre);
            ps.setString(2, telefono);
            ps.setString(3, correo);
            ps.setString(4, direccion);
            ps.setString(5, categoria);
            int filas = ps.executeUpdate();
            if (filas > 0) {
                System.out.println("✅ Contacto agregado correctamente");
            }
        } catch (Exception e) {
            System.out.println("❌ Error al insertar: " + e.getMessage());
        }
        sc.close();
    }
}