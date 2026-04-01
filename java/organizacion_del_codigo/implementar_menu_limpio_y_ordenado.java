package organizacion_del_codigo;
import java.util.ArrayList;
import java.util.Scanner;
public class implementar_menu_limpio_y_ordenado {
    static ArrayList<String> contactos = new ArrayList<>();
    static Scanner scanner = new Scanner(System.in);
    public static void main(String[] args) {
        int opcion;
        do {
            mostrarMenu();
            opcion = leerOpcion();
            switch (opcion) {
                case 1:
                    agregarContacto();
                    break;
                case 2:
                    mostrarContactos();
                    break;
                case 3:
                    eliminarContacto();
                    break;
                case 4:
                    System.out.println("Saliendo del sistema...");
                    break;
                default:
                    System.out.println("Opción inválida.");
            }
        } while (opcion != 4);
        scanner.close();
    }
    public static void mostrarMenu() {
        System.out.println("\n================================");
        System.out.println("        AGENDA DE CONTACTOS     ");
        System.out.println("================================");
        System.out.println("1. Agregar contacto");
        System.out.println("2. Mostrar contactos");
        System.out.println("3. Eliminar contacto");
        System.out.println("4. Salir");
        System.out.println("================================");
        System.out.print("Seleccione una opción: ");
    }
    public static int leerOpcion() {
        return scanner.nextInt();
    }
    public static void agregarContacto() {
        scanner.nextLine();
        System.out.print("Ingrese el nombre del contacto: ");
        String nombre = scanner.nextLine();
        contactos.add(nombre);
        System.out.println("Contacto agregado correctamente.");
    }
    public static void mostrarContactos() {
        if (contactos.isEmpty()) {
            System.out.println("La agenda está vacía.");
        } else {
            System.out.println("\nLista de contactos:");
            for (String contacto : contactos) {
                System.out.println("- " + contacto);
            }
        }
    }
    public static void eliminarContacto() {
        scanner.nextLine();
        System.out.print("Ingrese el nombre del contacto a eliminar: ");
        String nombre = scanner.nextLine();
        if (contactos.remove(nombre)) {
            System.out.println("Contacto eliminado correctamente.");
        } else {
            System.out.println("Contacto no encontrado.");
        }
    }
}