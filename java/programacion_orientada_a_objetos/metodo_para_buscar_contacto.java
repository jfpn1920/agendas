package programacion_orientada_a_objetos;
import java.util.ArrayList;
public class metodo_para_buscar_contacto {
    ArrayList<String> contactos = new ArrayList<>();
    public void agregarContacto(String nombre) {
        contactos.add(nombre);
    }
    public void buscarContacto(String nombre) {
        if (contactos.contains(nombre)) {
            System.out.println("Contacto encontrado: " + nombre);
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
        metodo_para_buscar_contacto agenda = new metodo_para_buscar_contacto();
        agenda.agregarContacto("Genis");
        agenda.agregarContacto("Maria");
        agenda.agregarContacto("Carlos");
        agenda.mostrarContactos();
        System.out.println("------ Buscando contacto ------");
        agenda.buscarContacto("Maria");
    }
}