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
        System.out.println("----------------------");
    }
}
public class gestion_completa_con_poo {
    ArrayList<Contacto> contactos = new ArrayList<>();
    public void agregarContacto(Contacto contacto) {
        contactos.add(contacto);
        System.out.println("Contacto agregado correctamente.");
    }
    public void mostrarContactos() {
        if (contactos.isEmpty()) {
            System.out.println("La agenda está vacía.");
        } else {
            for (Contacto c : contactos) {
                c.mostrarContacto();
            }
        }
    }
    public void buscarContacto(String nombre) {
        for (Contacto c : contactos) {
            if (c.nombre.equalsIgnoreCase(nombre)) {
                System.out.println("Contacto encontrado:");
                c.mostrarContacto();
                return;
            }
        }
        System.out.println("Contacto no encontrado.");
    }
    public void eliminarContacto(String nombre) {
        for (Contacto c : contactos) {
            if (c.nombre.equalsIgnoreCase(nombre)) {
                contactos.remove(c);
                System.out.println("Contacto eliminado.");
                return;
            }
        }
        System.out.println("Contacto no encontrado.");
    }
    public static void main(String[] args) {
        gestion_completa_con_poo agenda = new gestion_completa_con_poo();
        Contacto c1 = new Contacto("Genis", "3001234567", "genis@email.com");
        Contacto c2 = new Contacto("Maria", "3019876543", "maria@email.com");
        Contacto c3 = new Contacto("Carlos", "3024567890", "carlos@email.com");
        agenda.agregarContacto(c1);
        agenda.agregarContacto(c2);
        agenda.agregarContacto(c3);
        System.out.println("------ LISTA DE CONTACTOS ------");
        agenda.mostrarContactos();
        System.out.println("------ BUSCAR CONTACTO ------");
        agenda.buscarContacto("Maria");
        System.out.println("------ ELIMINAR CONTACTO ------");
        agenda.eliminarContacto("Carlos");
        System.out.println("------ AGENDA ACTUALIZADA ------");
        agenda.mostrarContactos();
    }
}