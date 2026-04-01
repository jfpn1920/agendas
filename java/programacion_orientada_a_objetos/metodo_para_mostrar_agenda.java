package programacion_orientada_a_objetos;
import java.util.ArrayList;
public class metodo_para_mostrar_agenda {
    ArrayList<String> contactos = new ArrayList<>();
    public void agregarContacto(String nombre) {
        contactos.add(nombre);
    }
    public void mostrarAgenda() {
        System.out.println("Contactos en la agenda:");
        if (contactos.isEmpty()) {
            System.out.println("La agenda está vacía.");
        } else {
            for (String contacto : contactos) {
                System.out.println(contacto);
            }
        }
    }
    public static void main(String[] args) {
        metodo_para_mostrar_agenda agenda = new metodo_para_mostrar_agenda();
        agenda.agregarContacto("Genis");
        agenda.agregarContacto("Maria");
        agenda.agregarContacto("Carlos");
        agenda.mostrarAgenda();
    }
}