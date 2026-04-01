package logica_y_validaciones;
public class validar_longitud_del_nombre {
    public static void main(String[] args) {
        String nombre = "Ana";
        if (nombre.length() >= 3) {
            System.out.println("Nombre válido.");
        } else {
            System.out.println("El nombre es demasiado corto.");
        }
    }
}