package estructuras_de_datos;
import java.util.ArrayList;
import java.util.Scanner;
public class filtrar_contactos_por_categoria {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ArrayList<String> contactos = new ArrayList<>();
        contactos.add("Ana Gómez - 3001112233 - familia");
        contactos.add("Luis Pérez - 3012223344 - trabajo");
        contactos.add("Sofía Martínez - 3023334455 - familia");
        contactos.add("Carlos Ramírez - 3034445566 - trabajo");
        System.out.print("Ingrese categoría a filtrar (familia/trabajo): ");
        String categoria = scanner.nextLine();
        boolean encontrado = false;
        System.out.println("\n=== CONTACTOS FILTRADOS ===");
        for (String contacto : contactos) {
            if (contacto.toLowerCase().contains(categoria.toLowerCase())) {
                System.out.println(contacto);
                encontrado = true;
            }
        }
        if (!encontrado) {
            System.out.println("No hay contactos en esa categoría.");
        }
        scanner.close();
    }
}