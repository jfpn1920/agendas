package metodos;
public class funcion_para_mostrar_agenda {
    public static void mostrarAgenda(String[] contactos) {
        System.out.println("=== AGENDA DE CONTACTOS ===");
        for (int i = 0; i < contactos.length; i++) {
            System.out.println((i + 1) + ". " + contactos[i]);
        }
    }
    public static void main(String[] args) {
        String[] contactos = {"Juan", "Maria", "Carlos", "Ana"};
        mostrarAgenda(contactos);
    }
}