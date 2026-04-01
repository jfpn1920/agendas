package manejo_de_errores;
import java.util.Scanner;
public class validar_entrada_de_numeros_con_try_catch {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int telefono;
        try {
            System.out.print("Ingrese el número de teléfono del contacto: ");
            telefono = scanner.nextInt();
            System.out.println("Número guardado correctamente: " + telefono);
        } catch (Exception e) {
            System.out.println("Error: Debes ingresar solo números.");
        }
        scanner.close();
    }
}