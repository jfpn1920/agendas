package manejo_de_errores;
import java.util.ArrayList;
import java.util.Scanner;
public class evitar_indices_fuera_de_rango {
    public static void main(String[] args) {
        ArrayList<String> contactos = new ArrayList<>();
        Scanner scanner = new Scanner(System.in);
        contactos.add("Genis");
        contactos.add("Maria");
        contactos.add("Carlos");
        try {
            System.out.println("Lista de contactos:");
            for (int i = 0; i < contactos.size(); i++) {
                System.out.println(i + " - " + contactos.get(i));
            }
            System.out.print("Ingrese el índice del contacto que desea ver: ");
            int indice = scanner.nextInt();
            System.out.println("Contacto seleccionado: " + contactos.get(indice));
        } catch (IndexOutOfBoundsException e) {
            System.out.println("Error: El índice ingresado está fuera del rango de la lista.");
        } catch (Exception e) {
            System.out.println("Ocurrió un error inesperado.");
        }
        scanner.close();
    }
}