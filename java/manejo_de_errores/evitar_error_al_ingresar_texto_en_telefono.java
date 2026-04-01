package manejo_de_errores;
import java.util.Scanner;
public class evitar_error_al_ingresar_texto_en_telefono {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        try {
            System.out.print("Ingrese el número de teléfono: ");
            int telefono = scanner.nextInt();
            System.out.println("Teléfono guardado correctamente: " + telefono);
        } catch (Exception e) {
            System.out.println("Error: El teléfono debe contener solo números.");
        }
        scanner.close();
    }
}