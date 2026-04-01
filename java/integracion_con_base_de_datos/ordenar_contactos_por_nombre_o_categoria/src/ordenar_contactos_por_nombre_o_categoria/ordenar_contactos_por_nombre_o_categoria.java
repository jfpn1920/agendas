package ordenar_contactos_por_nombre_o_categoria;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Scanner;
public class ordenar_contactos_por_nombre_o_categoria {
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
            System.out.println("2. Mostrar contactos ordenados por nombre");
            System.out.println("3. Mostrar contactos ordenados por categoría");
            System.out.println("4. Salir");
            System.out.print("Seleccione una opción: ");
            opcion = sc.nextInt();
            sc.nextLine();
            switch (opcion) {
                case 1:
                    agregarContacto(conn);
                    break;
                case 2:
                    ordenarPorNombre(conn);
                    break;
                case 3:
                    ordenarPorCategoria(conn);
                    break;
                case 4:
                    System.out.println("👋 Saliendo del programa...");
                    break;
                default:
                    System.out.println("❌ Opción inválida");
            }
        } while (opcion != 4);
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
            System.out.print("Dirección: ");
            String direccion = sc.nextLine();
            System.out.print("Categoría: ");
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
            System.out.println("❌ Error al agregar contacto: " + e.getMessage());
        }
    }
    public static void ordenarPorNombre(Connection conn) {
        try {
            String sql = "SELECT * FROM contactos ORDER BY nombre ASC";
            PreparedStatement ps = conn.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            System.out.println("\n=== CONTACTOS ORDENADOS POR NOMBRE ===");
            while (rs.next()) {
                System.out.println("ID: " + rs.getInt("id"));
                System.out.println("Nombre: " + rs.getString("nombre"));
                System.out.println("Teléfono: " + rs.getString("telefono"));
                System.out.println("Correo: " + rs.getString("correo"));
                System.out.println("Dirección: " + rs.getString("direccion"));
                System.out.println("Categoría: " + rs.getString("categoria"));
                System.out.println("---------------------------");
            }
        } catch (Exception e) {
            System.out.println("❌ Error al mostrar contactos: " + e.getMessage());
        }
    }
    public static void ordenarPorCategoria(Connection conn) {
        try {
            String sql = "SELECT * FROM contactos ORDER BY categoria ASC";
            PreparedStatement ps = conn.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            System.out.println("\n=== CONTACTOS ORDENADOS POR CATEGORÍA ===");
            while (rs.next()) {
                System.out.println("ID: " + rs.getInt("id"));
                System.out.println("Nombre: " + rs.getString("nombre"));
                System.out.println("Teléfono: " + rs.getString("telefono"));
                System.out.println("Correo: " + rs.getString("correo"));
                System.out.println("Dirección: " + rs.getString("direccion"));
                System.out.println("Categoría: " + rs.getString("categoria"));
                System.out.println("---------------------------");
            }
        } catch (Exception e) {
            System.out.println("❌ Error al mostrar contactos: " + e.getMessage());
        }
    }
}