package programacion_orientada_a_objetos;
import java.util.ArrayList;
public class metodo_para_eliminar_contacto {
    ArrayList<String> contactos = new ArrayList<>();
    public void agregarContacto(String nombre) {
        contactos.add(nombre);
    }
    public void eliminarContacto(String nombre) {
        if (contactos.remove(nombre)) {
            System.out.println("Contacto eliminado: " + nombre);
        } else {
            System.out.println("El contacto no existe.");
        }
    }
    public void mostrarContactos() {
        System.out.println("Lista de contactos:");
        for (String contacto : contactos) {
            System.out.println(contacto);
        }
    }
    public static void main(String[] args) {
        metodo_para_eliminar_contacto agenda = new metodo_para_eliminar_contacto();
        agenda.agregarContacto("Genis");
        agenda.agregarContacto("Maria");
        agenda.agregarContacto("Carlos");
        agenda.mostrarContactos();
        System.out.println("------ Eliminando contacto ------");
        agenda.eliminarContacto("Maria");
        agenda.mostrarContactos();
    }
}