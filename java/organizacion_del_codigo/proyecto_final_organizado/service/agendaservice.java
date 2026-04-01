package organizacion_del_codigo.proyecto_final_organizado.service;
import java.util.ArrayList;
import organizacion_del_codigo.proyecto_final_organizado.model.contacto;
public class agendaservice {
    private ArrayList<contacto> contactos = new ArrayList<>();
    public void agregarContacto(contacto c) {
        contactos.add(c);
        System.out.println("Contacto agregado correctamente.");
    }
    public void mostrarContactos() {
        if (contactos.isEmpty()) {
            System.out.println("La agenda está vacía.");
            return;
        }
        for (contacto c : contactos) {
            c.mostrarContacto();
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
        boolean eliminado = contactos.removeIf(
            c -> c.getNombre().equalsIgnoreCase(nombre)
        );
        if (eliminado) {
            System.out.println("Contacto eliminado.");
        } else {
            System.out.println("El contacto no existe.");
        }
    }
}