package organizacion_del_codigo.crear_estructura_profesional_del_proyecto.service;
import java.util.ArrayList;
import organizacion_del_codigo.crear_estructura_profesional_del_proyecto.model.contacto;
public class agendaservice {
    private ArrayList<contacto> contactos = new ArrayList<>();
    public void agregarContacto(contacto c) {
        contactos.add(c);
        System.out.println("Contacto agregado correctamente.");
    }
    public void mostrarContactos() {
        if (contactos.isEmpty()) {
            System.out.println("La agenda está vacía.");
        } else {
            for (contacto c : contactos) {
                c.mostrarContacto();
            }
        }
    }
}