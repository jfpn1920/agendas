package manejo_de_errores;
import java.util.Scanner;
public class validar_datos_incompletos_con_excepciones {
    @SuppressWarnings("resource")
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        try {
            System.out.print("Ingrese el nombre del contacto: ");
            String nombre = scanner.nextLine();
            System.out.print("Ingrese el teléfono del contacto: ");
            String telefono = scanner.nextLine();
            System.out.print("Ingrese el correo del contacto: ");
            String correo = scanner.nextLine();
            if (nombre.trim().isEmpty() || telefono.trim().isEmpty() || correo.trim().isEmpty()) {
                throw new IllegalArgumentException("Error: Hay datos incompletos.");
            }
            System.out.println("\nContacto guardado correctamente.");
            System.out.println("Nombre: " + nombre);
            System.out.println("Teléfono: " + telefono);
            System.out.println("Correo: " + correo);
        } catch (IllegalArgumentException e) {
            System.out.println(e.getMessage());
        }
        scanner.close();
    }
}