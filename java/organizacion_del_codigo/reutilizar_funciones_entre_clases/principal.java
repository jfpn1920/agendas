package organizacion_del_codigo.reutilizar_funciones_entre_clases;
import java.util.Scanner;
public class principal {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        agenda miAgenda = new agenda();
        System.out.print("Ingrese el nombre del contacto: ");
        String nombre = scanner.nextLine();
        miAgenda.agregarContacto(nombre);
        miAgenda.mostrarContactos();
        scanner.close();
    }
}