package actualizar_contacto;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.Scanner;
public class actualizar_contacto {
    static Scanner sc = new Scanner(System.in);
    public static void main(String[] args) {
        Connection conn = conexion.conectar();
        if (conn == null) {
            System.out.println("❌ No se pudo conectar a la base de datos");
            return;
        }
        int opcion;
        do {
            System.out.println("\n=== AGENDA DE CONTACTOS ===");
            System.out.println("1. Agregar contacto");
            System.out.println("2. Actualizar contacto");
            System.out.println("3. Salir");
            System.out.print("Seleccione una opción: ");
            opcion = sc.nextInt();
            sc.nextLine();
            switch (opcion) {
                case 1:
                    agregarContacto(conn);
                    break;
                case 2:
                    actualizarContacto(conn);
                    break;
                case 3:
                    System.out.println("👋 Saliendo del programa...");
                    break;
                default:
                    System.out.println("❌ Opción inválida");
            }
        } while (opcion != 3);
        sc.close();
    }
    public static void agregarContacto(Connection conn) {
        try {
            System.out.println("\n=== AGREGAR CONTACTO ===");
            System.out.print("Nombre: ");
            String nombre = sc.nextLine();
            System.out.print("Teléfono: ");
            String telefono = sc.nextLine();
            System.out.print("Correo: ");
            String correo = sc.nextLine();
            String sql = "INSERT INTO contactos (nombre, telefono, correo) VALUES (?, ?, ?)";
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setString(1, nombre);
            ps.setString(2, telefono);
            ps.setString(3, correo);
            int filas = ps.executeUpdate();
            if (filas > 0) {
                System.out.println("✅ Contacto agregado correctamente");
            }
        } catch (Exception e) {
            System.out.println("❌ Error al agregar: " + e.getMessage());
        }
    }
    public static void actualizarContacto(Connection conn) {
        try {
            System.out.println("\n=== ACTUALIZAR CONTACTO ===");
            System.out.print("Ingrese el ID del contacto: ");
            int id = sc.nextInt();
            sc.nextLine();
            System.out.print("Nuevo nombre: ");
            String nombre = sc.nextLine();
            System.out.print("Nuevo teléfono: ");
            String telefono = sc.nextLine();
            System.out.print("Nuevo correo: ");
            String correo = sc.nextLine();
            String sql = "UPDATE contactos SET nombre = ?, telefono = ?, correo = ? WHERE id = ?";
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setString(1, nombre);
            ps.setString(2, telefono);
            ps.setString(3, correo);
            ps.setInt(4, id);
            int filas = ps.executeUpdate();
            if (filas > 0) {
                System.out.println("✅ Contacto actualizado correctamente");
            } else {
                System.out.println("❌ No existe un contacto con ese ID");
            }
        } catch (Exception e) {
            System.out.println("❌ Error al actualizar: " + e.getMessage());
        }
    }
}