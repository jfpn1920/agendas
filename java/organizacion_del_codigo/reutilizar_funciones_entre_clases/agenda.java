package organizacion_del_codigo.reutilizar_funciones_entre_clases;
import java.util.ArrayList;
public class agenda {
    ArrayList<String> contactos = new ArrayList<>();
    public void agregarContacto(String nombre) {
        contactos.add(nombre);
        utilidades.mostrarSeparador();
        utilidades.mostrarMensaje("Contacto agregado correctamente.");
        utilidades.mostrarSeparador();
    }
    public void mostrarContactos() {
        utilidades.mostrarSeparador();
        if (contactos.isEmpty()) {
            utilidades.mostrarMensaje("La agenda está vacía.");
        } else {
            utilidades.mostrarMensaje("Lista de contactos:");
            for (String contacto : contactos) {
                System.out.println("- " + contacto);
            }
        }
        utilidades.mostrarSeparador();
    }
}