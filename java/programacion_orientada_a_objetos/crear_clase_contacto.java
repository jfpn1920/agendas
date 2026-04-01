package programacion_orientada_a_objetos;
public class crear_clase_contacto {
    String nombre;
    String telefono;
    String correo;
    public crear_clase_contacto(String nombre, String telefono, String correo) {
        this.nombre = nombre;
        this.telefono = telefono;
        this.correo = correo;
    }
    public void mostrarContacto() {
        System.out.println("Nombre: " + nombre);
        System.out.println("Teléfono: " + telefono);
        System.out.println("Correo: " + correo);
    }
    public static void main(String[] args) {
        crear_clase_contacto contacto1 = new crear_clase_contacto(
                "Genis",
                "3001234567",
                "genis@email.com"
        );
        contacto1.mostrarContacto();
    }
}