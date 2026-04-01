package programacion_orientada_a_objetos;
import java.util.ArrayList;
class Contacto {
    String nombre;
    String telefono;
    String correo;
    public Contacto(String nombre, String telefono, String correo) {
        this.nombre = nombre;
        this.telefono = telefono;
        this.correo = correo;
    }
    public void mostrarContacto() {
        System.out.println("Nombre: " + nombre);
        System.out.println("Teléfono: " + telefono);
        System.out.println("Correo: " + correo);
        System.out.println("-------------------");
    }
}
public class agenda_con_objetos {
    ArrayList<Contacto> contactos = new ArrayList<>();
    public void agregarContacto(Contacto contacto) {
        contactos.add(contacto);
    }
    public void mostrarAgenda() {
        System.out.println("Agenda de contactos:");
        if (contactos.isEmpty()) {
            System.out.println("La agenda está vacía.");
        } else {
            for (Contacto c : contactos) {
                c.mostrarContacto();
            }
        }
    }
    public static void main(String[] args) {
        agenda_con_objetos agenda = new agenda_con_objetos();
        Contacto c1 = new Contacto("Genis", "3001234567", "genis@email.com");
        Contacto c2 = new Contacto("Maria", "3019876543", "maria@email.com");
        Contacto c3 = new Contacto("Carlos", "3024567890", "carlos@email.com");
        agenda.agregarContacto(c1);
        agenda.agregarContacto(c2);
        agenda.agregarContacto(c3);
        agenda.mostrarAgenda();
    }
}