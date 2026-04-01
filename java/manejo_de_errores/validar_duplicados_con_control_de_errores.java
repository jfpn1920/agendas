package manejo_de_errores;
import java.util.ArrayList;
import java.util.Scanner;
public class validar_duplicados_con_control_de_errores {
    public static void main(String[] args) {
        ArrayList<String> contactos = new ArrayList<>();
        Scanner scanner = new Scanner(System.in);
        contactos.add("Genis");
        contactos.add("Maria");
        contactos.add("Carlos");
        try {
            System.out.print("Ingrese el nombre del nuevo contacto: ");
            String nombre = scanner.nextLine();
            if (contactos.contains(nombre)) {
                System.out.println("Error: El contacto ya existe en la agenda.");
            } else {
                contactos.add(nombre);
                System.out.println("Contacto agregado correctamente.");
            }
        } catch (Exception e) {
            System.out.println("Ocurrió un error al agregar el contacto.");
        }
        System.out.println("\nLista de contactos:");
        for (String contacto : contactos) {
            System.out.println(contacto);
        }
        scanner.close();
    }
}