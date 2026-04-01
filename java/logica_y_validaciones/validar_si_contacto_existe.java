package logica_y_validaciones;
public class validar_si_contacto_existe {
    public static void main(String[] args) {
        String contactoGuardado = "Juan Pérez";
        String contactoBuscado = "Juan Pérez";
        if (contactoGuardado.equals(contactoBuscado)) {
            System.out.println("El contacto existe.");
        } else {
            System.out.println("El contacto no existe.");
        }
    }
}