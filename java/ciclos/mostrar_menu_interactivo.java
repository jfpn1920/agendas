package ciclos;
import java.util.Scanner;
public class mostrar_menu_interactivo {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int opcion = 0;
        while (opcion != 4) {
            System.out.println("\n=== MENÚ AGENDA ===");
            System.out.println("1. Ver contactos");
            System.out.println("2. Agregar contacto");
            System.out.println("3. Eliminar contacto");
            System.out.println("4. Salir");
            System.out.print("Seleccione una opción: ");
            opcion = scanner.nextInt();
            switch (opcion) {
                case 1:
                    System.out.println("Mostrando contactos...");
                    break;
                case 2:
                    System.out.println("Agregando contacto...");
                    break;
                case 3:
                    System.out.println("Eliminando contacto...");
                    break;
                case 4:
                    System.out.println("Saliendo del sistema...");
                    break;
                default:
                    System.out.println("Opción inválida.");
            }
        }
        scanner.close();
    }
}