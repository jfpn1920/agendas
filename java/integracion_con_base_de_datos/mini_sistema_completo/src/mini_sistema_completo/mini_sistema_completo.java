package mini_sistema_completo;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Scanner;
public class mini_sistema_completo {
    static Scanner sc = new Scanner(System.in);
    public static void main(String[] args) {
        Connection conn = conexion.conectar();
        if (conn == null) {
            System.out.println("❌ No se pudo conectar a la base de datos");
            return;
        }
        int opcion;
        do {
            System.out.println("\n=== MINI SISTEMA DE AGENDA ===");
            System.out.println("1. Agregar contacto");
            System.out.println("2. Mostrar contactos");
            System.out.println("3. Buscar contacto por nombre");
            System.out.println("4. Actualizar contacto");
            System.out.println("5. Eliminar contacto");
            System.out.println("6. Salir");
            System.out.print("Seleccione una opción: ");
            opcion = sc.nextInt();
            sc.nextLine();
            switch (opcion) {
                case 1:
                    agregarContacto(conn);
                    break;
                case 2:
                    mostrarContactos(conn);
                    break;
                case 3:
                    buscarContacto(conn);
                    break;
                case 4:
                    actualizarContacto(conn);
                    break;
                case 5:
                    eliminarContacto(conn);
                    break;
                case 6:
                    System.out.println("👋 Saliendo del sistema...");
                    break;
                default:
                    System.out.println("❌ Opción inválida");
            }
        } while (opcion != 6);
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
            ps.executeUpdate();
            System.out.println("✅ Contacto agregado correctamente");
        } catch (Exception e) {
            System.out.println("❌ Error al agregar contacto: " + e.getMessage());
        }
    }
    public static void mostrarContactos(Connection conn) {
        try {
            String sql = "SELECT * FROM contactos";
            PreparedStatement ps = conn.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            System.out.println("\n=== LISTA DE CONTACTOS ===");
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
    public static void buscarContacto(Connection conn) {
        try {
            System.out.print("Ingrese el nombre a buscar: ");
            String nombre = sc.nextLine();
            String sql = "SELECT * FROM contactos WHERE nombre LIKE ?";
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setString(1, "%" + nombre + "%");
            ResultSet rs = ps.executeQuery();
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
            System.out.println("❌ Error en la búsqueda: " + e.getMessage());
        }
    }
    public static void actualizarContacto(Connection conn) {
        try {
            System.out.print("Ingrese el ID del contacto: ");
            int id = sc.nextInt();
            sc.nextLine();
            System.out.print("Nuevo nombre: ");
            String nombre = sc.nextLine();
            System.out.print("Nuevo teléfono: ");
            String telefono = sc.nextLine();
            System.out.print("Nuevo correo: ");
            String correo = sc.nextLine();
            System.out.print("Nueva dirección: ");
            String direccion = sc.nextLine();
            System.out.print("Nueva categoría: ");
            String categoria = sc.nextLine();
            String sql = "UPDATE contactos SET nombre=?, telefono=?, correo=?, direccion=?, categoria=? WHERE id=?";
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setString(1, nombre);
            ps.setString(2, telefono);
            ps.setString(3, correo);
            ps.setString(4, direccion);
            ps.setString(5, categoria);
            ps.setInt(6, id);
            ps.executeUpdate();
            System.out.println("✅ Contacto actualizado");
        } catch (Exception e) {
            System.out.println("❌ Error al actualizar: " + e.getMessage());
        }
    }
    public static void eliminarContacto(Connection conn) {
        try {
            System.out.print("Ingrese el ID del contacto a eliminar: ");
            int id = sc.nextInt();
            String sql = "DELETE FROM contactos WHERE id=?";
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setInt(1, id);
            ps.executeUpdate();
            System.out.println("✅ Contacto eliminado");
        } catch (Exception e) {
            System.out.println("❌ Error al eliminar: " + e.getMessage());
        }
    }
}