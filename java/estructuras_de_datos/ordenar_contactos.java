package estructuras_de_datos;
import java.util.ArrayList;
import java.util.Collections;
public class ordenar_contactos {
    public static void main(String[] args) {
        ArrayList<String> contactos = new ArrayList<>();
        contactos.add("Luis Pérez");
        contactos.add("Ana Gómez");
        contactos.add("Sofía Martínez");
        contactos.add("Carlos Ramírez");
        System.out.println("=== ANTES DE ORDENAR ===");
        for (String c : contactos) {
            System.out.println(c);
        }
        Collections.sort(contactos);
        System.out.println("\n=== DESPUÉS DE ORDENAR ===");
        for (String c : contactos) {
            System.out.println(c);
        }
    }
}