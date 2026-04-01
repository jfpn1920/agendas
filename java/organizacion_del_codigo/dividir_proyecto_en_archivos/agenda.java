package organizacion_del_codigo.dividir_proyecto_en_archivos;
import java.util.ArrayList;
public class agenda {
    ArrayList<contacto> contactos = new ArrayList<>();
    public void agregarContacto(contacto c) {
        contactos.add(c);
        System.out.println("Contacto agregado correctamente.");
    }
    public void mostrarAgenda() {
        if (contactos.isEmpty()) {
            System.out.println("La agenda está vacía.");
        } else {
            for (contacto c : contactos) {
                c.mostrarContacto();
            }
        }
    }
}