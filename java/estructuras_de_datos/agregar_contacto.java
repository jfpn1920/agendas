package estructuras_de_datos;
import java.util.ArrayList;
import java.util.Scanner;
public class agregar_contacto {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ArrayList<String> contactos = new ArrayList<>();
        System.out.print("Ingrese nombre: ");
        String nombre = scanner.nextLine();
        System.out.print("Ingrese teléfono: ");
        String telefono = scanner.nextLine();
        String contacto = nombre + " - " + telefono;
        contactos.add(contacto);
        System.out.println("\n=== CONTACTOS GUARDADOS ===");
        for (String c : contactos) {
            System.out.println(c);
        }
        scanner.close();
    }
}