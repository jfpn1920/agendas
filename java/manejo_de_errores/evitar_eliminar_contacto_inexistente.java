package manejo_de_errores;
import java.util.ArrayList;
import java.util.Scanner;
public class evitar_eliminar_contacto_inexistente {
    public static void main(String[] args) {
        ArrayList<String> contactos = new ArrayList<>();
        Scanner scanner = new Scanner(System.in);
        contactos.add("Genis");
        contactos.add("Maria");
        contactos.add("Carlos");
        try {
            System.out.print("Ingrese el nombre del contacto a eliminar: ");
            String nombre = scanner.nextLine();
            if (contactos.contains(nombre)) {
                contactos.remove(nombre);
                System.out.println("Contacto eliminado correctamente.");
            } else {
                System.out.println("Error: El contacto no existe en la agenda.");
            }
        } catch (Exception e) {
            System.out.println("Ocurrió un error al intentar eliminar el contacto.");
        }
        System.out.println("\nContactos actuales:");
        for (String contacto : contactos) {
            System.out.println(contacto);
        }
        scanner.close();
    }
}