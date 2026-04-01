package organizacion_del_codigo.crear_modulo_de_contactos;
import java.util.ArrayList;
public class contactoservice {
    private ArrayList<contacto> contactos = new ArrayList<>();
    public void agregarContacto(contacto contacto) {
        contactos.add(contacto);
        System.out.println("Contacto agregado correctamente.");
    }
    public void mostrarContactos() {
        if (contactos.isEmpty()) {
            System.out.println("No hay contactos en la agenda.");
        } else {
            System.out.println("Lista de contactos:");
            for (contacto c : contactos) {
                c.mostrarContacto();
            }
        }
    }
    public void buscarContacto(String nombre) {
        boolean encontrado = false;
        for (contacto c : contactos) {
            if (c.getNombre().equalsIgnoreCase(nombre)) {
                c.mostrarContacto();
                encontrado = true;
            }
        }
        if (!encontrado) {
            System.out.println("Contacto no encontrado.");
        }
    }
    public void eliminarContacto(String nombre) {
        contactos.removeIf(c -> c.getNombre().equalsIgnoreCase(nombre));
        System.out.println("Contacto eliminado si existía.");
    }
}