package buscar_contacto_por_nombre;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Scanner;
public class buscar_contacto_por_nombre {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Connection conn = conexion.conectar();
        if (conn == null) {
            System.out.println("❌ No se pudo conectar");
            sc.close();
            return;
        }
        int opcion;
        do {
            System.out.println("\n=== MENÚ ===");
            System.out.println("1. Crear contacto");
            System.out.println("2. Buscar contacto");
            System.out.println("3. Salir");
            System.out.print("Seleccione una opción: ");
            opcion = sc.nextInt();
            sc.nextLine(); 
            switch (opcion) {
                case 1:
                    System.out.println("\n=== CREAR CONTACTO ===");
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
                        System.out.println("❌ Error al guardar: " + e.getMessage());
                    }
                    break;
                case 2:
                    System.out.println("\n=== BUSCAR CONTACTO ===");
                    System.out.print("Ingrese el nombre a buscar: ");
                    String nombreBuscado = sc.nextLine();
                    String sql = "SELECT * FROM contactos WHERE nombre LIKE ?";
                    try {
                        PreparedStatement ps = conn.prepareStatement(sql);
                        ps.setString(1, "%" + nombreBuscado + "%");
                        ResultSet rs = ps.executeQuery();
                        boolean encontrado = false;
                        while (rs.next()) {
                            encontrado = true;
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
                        if (!encontrado) {
                            System.out.println("❌ No se encontraron contactos");
                        }
                    } catch (Exception e) {
                        System.out.println("❌ Error al buscar: " + e.getMessage());
                    }
                    break;
                case 3:
                    System.out.println("👋 Saliendo del sistema...");
                    break;
                default:
                    System.out.println("⚠️ Opción inválida");
            }
        } while (opcion != 3);
        sc.close();
    }
}