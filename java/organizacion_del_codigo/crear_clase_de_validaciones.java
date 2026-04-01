package organizacion_del_codigo;
public class crear_clase_de_validaciones {
    public static boolean validarNombre(String nombre) {
        return nombre != null && !nombre.trim().isEmpty();
    }
    public static boolean validarTelefono(String telefono) {
        if (telefono == null || telefono.trim().isEmpty()) {
            return false;
        }
        return telefono.matches("\\d+");
    }
    public static boolean validarCorreo(String correo) {
        if (correo == null || correo.trim().isEmpty()) {
            return false;
        }
        return correo.contains("@") && correo.contains(".");
    }
}