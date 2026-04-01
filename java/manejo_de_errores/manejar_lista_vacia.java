package manejo_de_errores;
import java.util.ArrayList;
public class manejar_lista_vacia {
    public static void main(String[] args) {
        ArrayList<String> contactos = new ArrayList<>();
        try {
            if (contactos.isEmpty()) {
                System.out.println("La agenda está vacía. No hay contactos para mostrar.");
            } else {
                System.out.println("Lista de contactos:");
                for (String contacto : contactos) {
                    System.out.println(contacto);
                }
            }
        } catch (Exception e) {
            System.out.println("Ocurrió un error al mostrar los contactos.");
        }
    }
}