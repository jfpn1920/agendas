package ciclos;
public class mostrar_agenda_en_bucle {
    public static void main(String[] args) {
        int cantidadContactos = 3;
        System.out.println("=== AGENDA DE CONTACTOS ===");
        for (int i = 1; i <= cantidadContactos; i++) {
            System.out.println("\nContacto #" + i);
            System.out.println("Nombre: Contacto " + i);
            System.out.println("Teléfono: 300000000" + i);
        }
    }
}