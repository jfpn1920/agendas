package metodos;
import java.util.Scanner;
public class funcion_para_actualizar_contacto {
    public static boolean actualizarContacto(String[] contactos, String nombreAntiguo, String nombreNuevo) {
        for (int i = 0; i < contactos.length; i++) {
            if (contactos[i].equalsIgnoreCase(nombreAntiguo)) {
                contactos[i] = nombreNuevo;
                return true;
            }
        }
        return false;
    }
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] contactos = {"Juan", "Maria", "Carlos", "Ana"};
        System.out.print("Ingrese el nombre del contacto a actualizar: ");
        String viejo = scanner.nextLine();
        System.out.print("Ingrese el nuevo nombre: ");
        String nuevo = scanner.nextLine();
        boolean actualizado = actualizarContacto(contactos, viejo, nuevo);
        if (actualizado) {
            System.out.println("Contacto actualizado correctamente.");
        } else {
            System.out.println("Contacto no encontrado.");
        }
        System.out.println("\n=== AGENDA ACTUALIZADA ===");
        for (int i = 0; i < contactos.length; i++) {
            System.out.println((i + 1) + ". " + contactos[i]);
        }
        scanner.close();
    }
}