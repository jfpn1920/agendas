package estructuras_de_datos;
import java.util.ArrayList;
public class mostrar_agenda_completa {
    public static void main(String[] args) {
        ArrayList<String> contactos = new ArrayList<>();
        contactos.add("Ana Gómez - 3001112233 - familia");
        contactos.add("Luis Pérez - 3012223344 - trabajo");
        contactos.add("Sofía Martínez - 3023334455 - familia");
        contactos.add("Carlos Ramírez - 3034445566 - trabajo");
        System.out.println("=== AGENDA COMPLETA ===");
        if (contactos.isEmpty()) {
            System.out.println("La agenda está vacía.");
        } else {
            for (String contacto : contactos) {
                System.out.println(contacto);
            }
        }
    }
}