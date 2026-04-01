package fundamentos;
public class mostrar_resumen_de_contactos {
    public static void main(String[] args) {
        int cantidadContactos = 3;
        String nombre1 = "Ana Gómez";
        String nombre2 = "Luis Pérez";
        String nombre3 = "Sofía Martínez";
        System.out.println("=== RESUMEN DE CONTACTOS ===");
        System.out.println("Cantidad total de contactos: " + cantidadContactos);
        System.out.println("Contactos registrados:");
        System.out.println("- " + nombre1);
        System.out.println("- " + nombre2);
        System.out.println("- " + nombre3);
    }
}