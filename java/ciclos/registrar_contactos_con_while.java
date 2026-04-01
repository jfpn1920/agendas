package ciclos;
public class registrar_contactos_con_while {
    public static void main(String[] args) {
        int cantidadContactos = 3;
        int i = 1;
        while (i <= cantidadContactos) {
            System.out.println("Registrando contacto #" + i);
            i++;
        }
        System.out.println("Todos los contactos han sido registrados.");
    }
}