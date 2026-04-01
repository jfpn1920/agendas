package programacion_orientada_a_objetos;
import java.util.ArrayList;
class Contacto {
    private String nombre;
    private String telefono;
    private String correo;
    public Contacto(String nombre, String telefono, String correo) {
        this.nombre = nombre;
        this.telefono = telefono;
        this.correo = correo;
    }
    public String getNombre() {
        return nombre;
    }
    public void mostrarContacto() {
        System.out.println("Nombre: " + nombre);
        System.out.println("Teléfono: " + telefono);
        System.out.println("Correo: " + correo);
        System.out.println("-----------------------");
    }
}
public class agenda_mejorada_con_poo {
    private ArrayList<Contacto> contactos = new ArrayList<>();
    public void agregarContacto(Contacto contacto) {
        contactos.add(contacto);
        System.out.println("Contacto agregado.");
    }
    public void buscarContacto(String nombre) {
        for (Contacto c : contactos) {
            if (c.getNombre().equalsIgnoreCase(nombre)) {
                System.out.println("Contacto encontrado:");
                c.mostrarContacto();
                return;
            }
        }
        System.out.println("Contacto no encontrado.");
    }
    public void eliminarContacto(String nombre) {
        for (Contacto c : contactos) {
            if (c.getNombre().equalsIgnoreCase(nombre)) {
                contactos.remove(c);
                System.out.println("Contacto eliminado.");
                return;
            }
        }
        System.out.println("Contacto no encontrado.");
    }
    public void mostrarAgenda() {
        if (contactos.isEmpty()) {
            System.out.println("La agenda está vacía.");
        } else {
            System.out.println("Lista de contactos:");
            for (Contacto c : contactos) {
                c.mostrarContacto();
            }
        }
    }
    public static void main(String[] args) {
        agenda_mejorada_con_poo agenda = new agenda_mejorada_con_poo();
        Contacto c1 = new Contacto("Genis", "3001234567", "genis@email.com");
        Contacto c2 = new Contacto("Maria", "3019876543", "maria@email.com");
        Contacto c3 = new Contacto("Carlos", "3024567890", "carlos@email.com");
        agenda.agregarContacto(c1);
        agenda.agregarContacto(c2);
        agenda.agregarContacto(c3);
        System.out.println("------ AGENDA ------");
        agenda.mostrarAgenda();
        System.out.println("------ BUSCAR ------");
        agenda.buscarContacto("Maria");
        System.out.println("------ ELIMINAR ------");
        agenda.eliminarContacto("Carlos");
        System.out.println("------ AGENDA ACTUALIZADA ------");
        agenda.mostrarAgenda();
    }
}