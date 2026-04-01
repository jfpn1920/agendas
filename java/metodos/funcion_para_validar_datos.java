package metodos;
import java.util.Scanner;
public class funcion_para_validar_datos {
    public static boolean validarNombre(String nombre) {
        if (nombre == null || nombre.trim().isEmpty()) {
            return false;
        }
        for (int i = 0; i < nombre.length(); i++) {
            if (!Character.isLetter(nombre.charAt(i)) && nombre.charAt(i) != ' ') {
                return false;
            }
        }
        return true;
    }
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Ingrese un nombre: ");
        String nombre = scanner.nextLine();
        if (validarNombre(nombre)) {
            System.out.println("Nombre válido.");
        } else {
            System.out.println("Nombre inválido. Intente nuevamente.");
        }
        scanner.close();
    }
}