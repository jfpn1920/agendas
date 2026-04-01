package programacion_orientada_a_objetos;
import java.util.ArrayList;
public class sistema_con_multiples_contactos {
    ArrayList<String> contactos = new ArrayList<>();
    public void agregarContacto(String nombre) {
        contactos.add(nombre);
        System.out.println("Contacto agregado: " + nombre);
    }
    public void mostrarContactos() {
        System.out.println("Lista de contactos:");
        if (contactos.isEmpty()) {
            System.out.println("No hay contactos en la agenda.");
        } else {
            for (String contacto : contactos) {
                System.out.println(contacto);
            }
        }
    }
    public static void main(String[] args) {
        sistema_con_multiples_contactos agenda = new sistema_con_multiples_contactos();
        agenda.agregarContacto("Genis");
        agenda.agregarContacto("Maria");
        agenda.agregarContacto("Carlos");
        agenda.agregarContacto("Laura");
        agenda.agregarContacto("Pedro");
        System.out.println("----------------------");
        agenda.mostrarContactos();
    }
}