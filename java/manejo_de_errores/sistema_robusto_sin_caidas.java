package manejo_de_errores;
import java.util.ArrayList;
import java.util.InputMismatchException;
import java.util.Scanner;
public class sistema_robusto_sin_caidas {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ArrayList<String> contactos = new ArrayList<>();
        boolean ejecutar = true;
        while (ejecutar) {
            try {
                System.out.println("\n--- AGENDA DE CONTACTOS ---");
                System.out.println("1. Agregar contacto");
                System.out.println("2. Mostrar contactos");
                System.out.println("3. Salir");
                System.out.print("Seleccione una opción: ");
                int opcion = scanner.nextInt();
                scanner.nextLine(); 
                switch (opcion) {
                    case 1:
                        System.out.print("Ingrese el nombre del contacto: ");
                        String nombre = scanner.nextLine();
                        if (nombre.trim().isEmpty()) {
                            throw new IllegalArgumentException("El nombre no puede estar vacío.");
                        }
                        contactos.add(nombre);
                        System.out.println("Contacto agregado correctamente.");
                        break;
                    case 2:
                        if (contactos.isEmpty()) {
                            System.out.println("La agenda está vacía.");
                        } else {
                            System.out.println("Lista de contactos:");
                            for (String contacto : contactos) {
                                System.out.println("- " + contacto);
                            }
                        }
                        break;
                    case 3:
                        ejecutar = false;
                        System.out.println("Saliendo del sistema...");
                        break;
                    default:
                        System.out.println("Opción inválida.");
                }
            } catch (InputMismatchException e) {
                System.out.println("Error: Debe ingresar un número.");
                scanner.nextLine();
            } catch (IllegalArgumentException e) {
                System.out.println("Error: " + e.getMessage());
            } catch (Exception e) {
                System.out.println("Ocurrió un error inesperado.");
            }
        }
        scanner.close();
    }
}