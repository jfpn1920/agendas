package metodos;
import java.util.Scanner;
public class funcion_para_buscar_contacto {
    public static boolean buscarContacto(String[] contactos, String nombreBuscado) {
        for (int i = 0; i < contactos.length; i++) {
            if (contactos[i].equalsIgnoreCase(nombreBuscado)) {
                return true;
            }
        }
        return false;
    }
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] contactos = {"Juan", "Maria", "Carlos", "Ana"};
        System.out.print("Ingrese el nombre a buscar: ");
        String nombre = scanner.nextLine();
        boolean encontrado = buscarContacto(contactos, nombre);
        if (encontrado) {
            System.out.println("Contacto encontrado en la agenda.");
        } else {
            System.out.println("Contacto no existe.");
        }
        scanner.close();
    }
}