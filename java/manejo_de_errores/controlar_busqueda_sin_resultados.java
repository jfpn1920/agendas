package manejo_de_errores;
import java.util.ArrayList;
import java.util.Scanner;
public class controlar_busqueda_sin_resultados {
    public static void main(String[] args) {
        ArrayList<String> contactos = new ArrayList<>();
        Scanner scanner = new Scanner(System.in);
        contactos.add("Genis");
        contactos.add("Maria");
        contactos.add("Carlos");
        try {
            System.out.print("Ingrese el nombre del contacto a buscar: ");
            String nombre = scanner.nextLine();
            boolean encontrado = false;
            for (String contacto : contactos) {
                if (contacto.equalsIgnoreCase(nombre)) {
                    System.out.println("Contacto encontrado: " + contacto);
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado) {
                System.out.println("No se encontraron resultados para: " + nombre);
            }
        } catch (Exception e) {
            System.out.println("Ocurrió un error durante la búsqueda.");
        }
        scanner.close();
    }
}