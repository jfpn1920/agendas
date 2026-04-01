package metodos;
import java.util.Scanner;
public class funcion_reutilizable_de_agenda {
    public static boolean validarNombre(String nombre) {
        return nombre != null && !nombre.trim().isEmpty();
    }
    public static int buscarContacto(String[] contactos, String nombre) {
        for (int i = 0; i < contactos.length; i++) {
            if (contactos[i] != null && contactos[i].equalsIgnoreCase(nombre)) {
                return i;
            }
        }
        return -1;
    }
    public static boolean agregarContacto(String[] contactos, String nombre) {
        if (!validarNombre(nombre)) return false;
        for (int i = 0; i < contactos.length; i++) {
            if (contactos[i] == null || contactos[i].isEmpty()) {
                contactos[i] = nombre;
                return true;
            }
        }
        return false;
    }
    public static void mostrarAgenda(String[] contactos) {
        System.out.println("\n=== AGENDA ===");
        for (int i = 0; i < contactos.length; i++) {
            if (contactos[i] != null) {
                System.out.println((i + 1) + ". " + contactos[i]);
            }
        }
    }
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] contactos = new String[5];
        int opcion;
        do {
            System.out.println("\n=== MENÚ AGENDA ===");
            System.out.println("1. Agregar contacto");
            System.out.println("2. Buscar contacto");
            System.out.println("3. Mostrar agenda");
            System.out.println("4. Salir");
            System.out.print("Seleccione una opción: ");
            opcion = scanner.nextInt();
            scanner.nextLine(); 
            switch (opcion) {
                case 1:
                    System.out.print("Ingrese nombre: ");
                    String nombre = scanner.nextLine();
                    if (agregarContacto(contactos, nombre)) {
                        System.out.println("Contacto agregado.");
                    } else {
                        System.out.println("No se pudo agregar (agenda llena o dato inválido).");
                    }
                    break;
                case 2:
                    System.out.print("Ingrese nombre a buscar: ");
                    String buscar = scanner.nextLine();
                    int posicion = buscarContacto(contactos, buscar);
                    if (posicion != -1) {
                        System.out.println("Contacto encontrado en posición: " + (posicion + 1));
                    } else {
                        System.out.println("Contacto no encontrado.");
                    }
                    break;
                case 3:
                    mostrarAgenda(contactos);
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
}