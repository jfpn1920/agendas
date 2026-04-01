package organizacion_del_codigo.organizar_paquetes_model_service_main.service;
import java.util.ArrayList;
import organizacion_del_codigo.organizar_paquetes_model_service_main.model.contacto;
public class agendaservice {
    private ArrayList<contacto> contactos = new ArrayList<>();
    public void agregarcontacto(contacto contacto) {
        contactos.add(contacto);
        System.out.println("Contacto agregado correctamente.");
    }
    public void mostrarcontactos() {
        if (contactos.isEmpty()) {
            System.out.println("La agenda está vacía.");
        } else {
            for (contacto c : contactos) {
                c.mostrarcontactos();
            }
        }
    }
}