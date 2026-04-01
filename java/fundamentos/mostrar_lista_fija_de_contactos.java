package fundamentos;
public class mostrar_lista_fija_de_contactos {
    public static void main(String[] args) {
        String nombre1 = "Ana Gómez";
        String telefono1 = "3001112233";
        String nombre2 = "Luis Pérez";
        String telefono2 = "3012223344";
        String nombre3 = "Sofía Martínez";
        String telefono3 = "3023334455";
        System.out.println("=== LISTA DE CONTACTOS ===");
        System.out.println("Contacto 1:");
        System.out.println("Nombre: " + nombre1);
        System.out.println("Teléfono: " + telefono1);
        System.out.println();
        System.out.println("Contacto 2:");
        System.out.println("Nombre: " + nombre2);
        System.out.println("Teléfono: " + telefono2);
        System.out.println();
        System.out.println("Contacto 3:");
        System.out.println("Nombre: " + nombre3);
        System.out.println("Teléfono: " + telefono3);
    }
}