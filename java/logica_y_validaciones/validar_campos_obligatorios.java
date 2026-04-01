package logica_y_validaciones;
public class validar_campos_obligatorios {
    public static void main(String[] args) {
        String nombre = "Ana Gómez";
        String telefono = "3001234567";
        String correo = "ana@gmail.com";
        if (!nombre.isEmpty() && !telefono.isEmpty() && !correo.isEmpty()) {
            System.out.println("Todos los campos son obligatorios y están completos.");
        } else {
            System.out.println("Error: hay campos obligatorios vacíos.");
        }
    }
}