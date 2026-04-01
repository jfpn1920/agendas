package fundamentos;
public class mostrar_informacion_completa {
    public static void main(String[] args) {
        String nombre1 = "Ana Gómez";
        String telefono1 = "3001112233";
        String correo1 = "ana@gmail.com";
        String direccion1 = "Calle 10 #20-30";
        String nombre2 = "Luis Pérez";
        String telefono2 = "3012223344";
        String correo2 = "luis@gmail.com";
        String direccion2 = "Carrera 15 #25-40";
        System.out.println("=== INFORMACIÓN COMPLETA DE CONTACTOS ===");
        System.out.println("\nContacto 1:");
        System.out.println("Nombre: " + nombre1);
        System.out.println("Teléfono: " + telefono1);
        System.out.println("Correo: " + correo1);
        System.out.println("Dirección: " + direccion1);
        System.out.println("\nContacto 2:");
        System.out.println("Nombre: " + nombre2);
        System.out.println("Teléfono: " + telefono2);
        System.out.println("Correo: " + correo2);
        System.out.println("Dirección: " + direccion2);
    }
}