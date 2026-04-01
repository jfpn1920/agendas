package ciclos;
import java.util.Scanner;
public class repetir_registro_hasta_salir {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String continuar = "si";
        while (continuar.equalsIgnoreCase("si")) {
            System.out.print("Ingrese nombre: ");
            String nombre = scanner.nextLine();
            System.out.print("Ingrese teléfono: ");
            String telefono = scanner.nextLine();
            System.out.println("Contacto registrado:");
            System.out.println("Nombre: " + nombre);
            System.out.println("Teléfono: " + telefono);
            System.out.print("¿Desea registrar otro contacto? (si/no): ");
            continuar = scanner.nextLine();
        }
        System.out.println("Saliendo del sistema...");
        scanner.close();
    }
}