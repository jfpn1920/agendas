package estructuras_de_datos;
import java.util.ArrayList;
public class guardar_contactos_en_lista {
    public static void main(String[] args) {
        ArrayList<String> contactos = new ArrayList<>();
        contactos.add("Ana Gómez");
        contactos.add("Luis Pérez");
        contactos.add("Sofía Martínez");
        System.out.println("=== CONTACTOS GUARDADOS ===");
        for (String contacto : contactos) {
            System.out.println(contacto);
        }
    }
}