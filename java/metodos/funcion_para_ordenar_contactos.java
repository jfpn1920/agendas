package metodos;
public class funcion_para_ordenar_contactos {
    public static void ordenarContactos(String[] contactos) {
        for (int i = 0; i < contactos.length - 1; i++) {
            for (int j = 0; j < contactos.length - 1 - i; j++) {
                if (contactos[j] != null && contactos[j + 1] != null &&
                    contactos[j].compareToIgnoreCase(contactos[j + 1]) > 0) {
                    String temp = contactos[j];
                    contactos[j] = contactos[j + 1];
                    contactos[j + 1] = temp;
                }
            }
        }
    }
    public static void mostrarAgenda(String[] contactos) {
        for (int i = 0; i < contactos.length; i++) {
            if (contactos[i] != null) {
                System.out.println((i + 1) + ". " + contactos[i]);
            }
        }
    }
    public static void main(String[] args) {
        String[] contactos = {"Juan", "Maria", "Carlos", "Ana", "Camila"};
        System.out.println("=== ANTES DE ORDENAR ===");
        mostrarAgenda(contactos);
        ordenarContactos(contactos);
        System.out.println("\n=== DESPUÉS DE ORDENAR ===");
        mostrarAgenda(contactos);
    }
}