package metodos;
import java.util.Scanner;
public class funcion_para_filtrar_contactos {
    public static void filtrarContactos(String[] contactos, String filtro) {
        System.out.println("=== CONTACTOS FILTRADOS ===");
        boolean encontrado = false;
        for (int i = 0; i < contactos.length; i++) {
            if (contactos[i] != null &&
                contactos[i].toLowerCase().startsWith(filtro.toLowerCase())) {
                System.out.println("- " + contactos[i]);
                encontrado = true;
            }
        }
        if (!encontrado) {
            System.out.println("No se encontraron coincidencias.");
        }
    }
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] contactos = {"Juan", "Maria", "Carlos", "Ana", "Camila"};
        System.out.print("Ingrese una letra o texto para filtrar: ");
        String filtro = scanner.nextLine();
        filtrarContactos(contactos, filtro);
        scanner.close();
    }
}