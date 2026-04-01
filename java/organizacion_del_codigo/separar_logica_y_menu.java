package organizacion_del_codigo;
import java.util.ArrayList;
import java.util.Scanner;
public class separar_logica_y_menu {
    static ArrayList<String> contactos = new ArrayList<>();
    static Scanner scanner = new Scanner(System.in);
    public static void main(String[] args) {
        int opcion;
        do {
            mostrarMenu();
            opcion = scanner.nextInt();
            scanner.nextLine();
            switch (opcion) {
                case 1:
                    agregarContacto();
                    break;
                case 2:
                    mostrarContactos();
                    break;
                case 3:
                    System.out.println("Saliendo del sistema...");
                    break;
                default:
                    System.out.println("Opción inválida.");
            }
        } while (opcion != 3);
        scanner.close();
    }
    public static void mostrarMenu() {
        System.out.println("\n--- AGENDA ---");
        System.out.println("1. Agregar contacto");
        System.out.println("2. Mostrar contactos");
        System.out.println("3. Salir");
        System.out.print("Seleccione una opción: ");
    }
    public static void agregarContacto() {
        System.out.print("Ingrese el nombre del contacto: ");
        String nombre = scanner.nextLine();
        contactos.add(nombre);
        System.out.println("Contacto agregado correctamente.");
    }
    public static void mostrarContactos() {
        if (contactos.isEmpty()) {
            System.out.println("La agenda está vacía.");
        } else {
            System.out.println("Lista de contactos:");
            for (String contacto : contactos) {
                System.out.println("- " + contacto);
            }
        }
    }
}