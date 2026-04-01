package programacion_orientada_a_objetos;
import java.util.ArrayList;
public class crear_clase_agenda {
    ArrayList<crear_clase_contacto> contactos;
    public crear_clase_agenda() {
        contactos = new ArrayList<>();
    }
    public void agregarContacto(crear_clase_contacto contacto) {
        contactos.add(contacto);
    }
    public void mostrarContactos() {
        for (crear_clase_contacto contacto : contactos) {
            contacto.mostrarContacto();
            System.out.println("------------------");
        }
    }
    public static void main(String[] args) {
        crear_clase_agenda agenda = new crear_clase_agenda();
        crear_clase_contacto c1 = new crear_clase_contacto("Genis", "3001234567", "genis@email.com");
        crear_clase_contacto c2 = new crear_clase_contacto("Maria", "3019876543", "maria@email.com");
        agenda.agregarContacto(c1);
        agenda.agregarContacto(c2);
        agenda.mostrarContactos();
    }
}