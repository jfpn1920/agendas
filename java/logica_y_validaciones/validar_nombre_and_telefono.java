package logica_y_validaciones;
public class validar_nombre_and_telefono {
    public static void main(String[] args) {
        String nombre = "Ana Gómez";
        String telefono = "3001234567";
        if (!nombre.isEmpty() && telefono.length() == 10) {
            System.out.println("Nombre y teléfono son válidos.");
        } else {
            System.out.println("Error: nombre o teléfono inválido.");
        }
    }
}