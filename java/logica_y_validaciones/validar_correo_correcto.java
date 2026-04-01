package logica_y_validaciones;
public class validar_correo_correcto {
    public static void main(String[] args) {
        String correo = "usuario@gmail.com";
        if (correo.contains("@") && correo.contains(".")) {
            System.out.println("Correo válido.");
        } else {
            System.out.println("Correo inválido.");
        }
    }
}