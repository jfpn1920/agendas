package estructuras_de_datos;
import java.util.ArrayList;
import java.util.Scanner;
public class modificar_contacto {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ArrayList<String> contactos = new ArrayList<>();
        contactos.add("Ana Gómez - 3001112233");
        contactos.add("Luis Pérez - 3012223344");
        contactos.add("Sofía Martínez - 3023334455");
        System.out.println("=== LISTA DE CONTACTOS ===");
        for (String c : contactos) {
            System.out.println(c);
        }
        System.out.print("\nIngrese el nombre del contacto a modificar: ");
        String nombreBuscar = scanner.nextLine();
        boolean encontrado = false;
        for (int i = 0; i < contactos.size(); i++) {
            if (contactos.get(i).contains(nombreBuscar)) {
                System.out.print("Nuevo nombre: ");
                String nuevoNombre = scanner.nextLine();
                System.out.print("Nuevo teléfono: ");
                String nuevoTelefono = scanner.nextLine();
                contactos.set(i, nuevoNombre + " - " + nuevoTelefono);
                encontrado = true;
                System.out.println("Contacto modificado correctamente.");
                break;
            }
        }
        if (!encontrado) {
            System.out.println("Contacto no encontrado.");
        }
        System.out.println("\n=== LISTA ACTUALIZADA ===");
        for (String c : contactos) {
            System.out.println(c);
        }
        scanner.close();
    }
}