package ciclos;
public class registrar_contactos_con_for {
    public static void main(String[] args) {
        int cantidadContactos = 3;
        for (int i = 1; i <= cantidadContactos; i++) {
            System.out.println("Registrando contacto #" + i);
        }
        System.out.println("Todos los contactos han sido registrados.");
    }
}