package logica_y_validaciones;
public class validar_correo_or_telefono {
    public static void main(String[] args) {
        String correo = "usuario@gmail.com";
        String telefono = "";
        boolean correoValido = correo.contains("@") && correo.contains(".");
        boolean telefonoValido = telefono.length() == 10 && telefono.matches("\\d+");
        if (correoValido || telefonoValido) {
            System.out.println("Contacto válido.");
        } else {
            System.out.println("Debe ingresar un correo o un teléfono válido.");
        }
    }
}