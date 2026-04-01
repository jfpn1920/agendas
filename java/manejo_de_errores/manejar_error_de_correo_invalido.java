package manejo_de_errores;
import java.util.Scanner;
public class manejar_error_de_correo_invalido {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        try {
            System.out.print("Ingrese el correo del contacto: ");
            String correo = scanner.nextLine();
            if (!correo.contains("@") || !correo.contains(".")) {
                System.out.println("Error: El correo ingresado no es válido.");
            } else {
                System.out.println("Correo guardado correctamente: " + correo);
            }
        } catch (Exception e) {
            System.out.println("Ocurrió un error al ingresar el correo.");
        }
        scanner.close();
    }
}