package ciclos;
import java.util.Scanner;
public class contar_contactos {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String continuar = "si";
        int contador = 0;
        while (continuar.equalsIgnoreCase("si")) {
            System.out.print("Ingrese nombre: ");
            String nombre = scanner.nextLine().trim();
            System.out.print("Ingrese teléfono: ");
            String telefono = scanner.nextLine().trim();
            if (nombre.isEmpty() || telefono.isEmpty()) {
                System.out.println("Error: nombre o teléfono vacío.");
            } else {
                contador++;
                System.out.println("Contacto registrado correctamente.");
            }
            System.out.print("¿Desea registrar otro contacto? (si/no): ");
            continuar = scanner.nextLine().trim();
        }
        System.out.println("Cantidad total de contactos registrados: " + contador);
        scanner.close();
    }
}