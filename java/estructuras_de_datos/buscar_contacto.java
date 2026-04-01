package estructuras_de_datos;
import java.util.ArrayList;
import java.util.Scanner;
public class buscar_contacto {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ArrayList<String> contactos = new ArrayList<>();
        contactos.add("Ana Gómez - 3001112233");
        contactos.add("Luis Pérez - 3012223344");
        contactos.add("Sofía Martínez - 3023334455");
        System.out.print("Ingrese el nombre del contacto a buscar: ");
        String nombreBuscar = scanner.nextLine();
        boolean encontrado = false;
        for (String contacto : contactos) {
            if (contacto.toLowerCase().contains(nombreBuscar.toLowerCase())) {
                System.out.println("Contacto encontrado: " + contacto);
                encontrado = true;
            }
        }
        if (!encontrado) {
            System.out.println("Contacto no encontrado.");
        }
        scanner.close();
    }
}