package metodos;
import java.util.ArrayList;
import java.util.Scanner;
public class funcion_para_eliminar_contacto {
    public static void main(String[] args) {
        ArrayList<String> contactos = new ArrayList<>();
        Scanner scanner = new Scanner(System.in);
        contactos.add("Ana Gómez - 3001112233");
        contactos.add("Luis Pérez - 3012223344");
        contactos.add("Sofía Martínez - 3023334455");
        System.out.println("=== CONTACTOS ===");
        for (String c : contactos) {
            System.out.println(c);
        }
        eliminarContacto(contactos, scanner);
        System.out.println("\n=== LISTA ACTUALIZADA ===");
        for (String c : contactos) {
            System.out.println(c);
        }
        scanner.close();
    }
    public static void eliminarContacto(ArrayList<String> contactos, Scanner scanner) {
        System.out.print("\nIngrese el nombre del contacto a eliminar: ");
        String nombreEliminar = scanner.nextLine();
        boolean eliminado = false;
        for (int i = 0; i < contactos.size(); i++) {
            if (contactos.get(i).toLowerCase().contains(nombreEliminar.toLowerCase())) {
                contactos.remove(i);
                eliminado = true;
                System.out.println("Contacto eliminado correctamente.");
                break;
            }
        }
        if (!eliminado) {
            System.out.println("Contacto no encontrado.");
        }
    }
}