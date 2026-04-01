package estructuras_de_datos;
import java.util.ArrayList;
public class limpiar_agenda {
    public static void main(String[] args) {
        ArrayList<String> contactos = new ArrayList<>();
        contactos.add("Ana Gómez - 3001112233");
        contactos.add("Luis Pérez - 3012223344");
        contactos.add("Sofía Martínez - 3023334455");
        System.out.println("=== ANTES DE LIMPIAR ===");
        for (String c : contactos) {
            System.out.println(c);
        }
        contactos.clear();
        System.out.println("\n=== DESPUÉS DE LIMPIAR ===");
        if (contactos.isEmpty()) {
            System.out.println("La agenda está vacía.");
        } else {
            for (String c : contactos) {
                System.out.println(c);
            }
        }
    }
}