package ciclos;
import java.util.ArrayList;
public class recorrer_lista_de_contactos {
    public static void main(String[] args) {
        ArrayList<String> contactos = new ArrayList<>();
        contactos.add("Ana Gómez");
        contactos.add("Luis Pérez");
        contactos.add("Sofía Martínez");
        System.out.println("=== LISTA DE CONTACTOS ===");
        for (int i = 0; i < contactos.size(); i++) {
            System.out.println("Contacto " + (i + 1) + ": " + contactos.get(i));
        }
    }
}