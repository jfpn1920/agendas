package metodos;
import java.util.ArrayList;
import java.util.Scanner;
public class funcion_para_registrar_contacto {
    public static void main(String[] args) {
        ArrayList<String> contactos = new ArrayList<>();
        Scanner scanner = new Scanner(System.in);
        registrarContacto(contactos, scanner);
        System.out.println("\n=== CONTACTOS ===");
        for (String c : contactos) {
            System.out.println(c);
        }
        scanner.close();
    }
    public static void registrarContacto(ArrayList<String> contactos, Scanner scanner) {
        
        System.out.print("Ingrese nombre: ");
        String nombre = scanner.nextLine();
        System.out.print("Ingrese teléfono: ");
        String telefono = scanner.nextLine();
        contactos.add(nombre + " - " + telefono);
        System.out.println("Contacto registrado correctamente.");
    }
}