package organizacion_del_codigo.dividir_proyecto_en_archivos;
import java.util.Scanner;
public class principal {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        agenda miAgenda = new agenda();
        System.out.print("Ingrese el nombre del contacto: ");
        String nombre = scanner.nextLine();
        System.out.print("Ingrese el teléfono: ");
        String telefono = scanner.nextLine();
        contacto nuevo = new contacto(nombre, telefono);
        miAgenda.agregarContacto(nuevo);
        System.out.println("\nLista de contactos:");
        miAgenda.mostrarAgenda();
        scanner.close();
    }
}