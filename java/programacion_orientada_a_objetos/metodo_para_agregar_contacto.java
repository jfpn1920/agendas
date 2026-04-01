package programacion_orientada_a_objetos;
import java.util.ArrayList;
public class metodo_para_agregar_contacto {
    ArrayList<String> contactos = new ArrayList<>();
    public void agregarContacto(String nombre) {
        contactos.add(nombre);
        System.out.println("Contacto agregado: " + nombre);
    }
    public void mostrarContactos() {
        System.out.println("Lista de contactos:");
        for (String contacto : contactos) {
            System.out.println(contacto);
        }
    }
    public static void main(String[] args) {
        metodo_para_agregar_contacto agenda = new metodo_para_agregar_contacto();
        agenda.agregarContacto("Genis");
        agenda.agregarContacto("Maria");
        agenda.agregarContacto("Carlos");
        agenda.mostrarContactos();
    }
}