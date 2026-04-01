package estructuras_de_datos;
import java.util.ArrayList;
public class contador_de_contactos {
    public static void main(String[] args) {
        ArrayList<String> contactos = new ArrayList<>();
        contactos.add("Ana Gómez - 3001112233");
        contactos.add("Luis Pérez - 3012223344");
        contactos.add("Sofía Martínez - 3023334455");
        int total = contactos.size();
        System.out.println("Cantidad total de contactos: " + total);
    }
}