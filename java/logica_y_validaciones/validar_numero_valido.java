package logica_y_validaciones;
public class validar_numero_valido {
    public static void main(String[] args) {
        String telefono = "3001234567";
        if (telefono.length() == 10) {
            System.out.println("Número válido.");
        } else {
            System.out.println("Número inválido.");
        }
    }
}