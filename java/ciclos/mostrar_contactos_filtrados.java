package ciclos;
import java.util.ArrayList;
public class mostrar_contactos_filtrados {
    public static void main(String[] args) {
        ArrayList<String> contactos = new ArrayList<>();
        contactos.add("Ana Gómez");
        contactos.add("Luis Pérez");
        contactos.add("Andrés Martínez");
        contactos.add("Sofía López");
        System.out.println("=== CONTACTOS FILTRADOS (empiezan con A) ===");
        for (String contacto : contactos) {
            if (contacto.startsWith("A")) {
                System.out.println(contacto);
            }
        }
    }
}