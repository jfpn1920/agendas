package organizacion_del_codigo;
public class crear_clase_de_utilidades {
    public static void mostrarMenu() {
        System.out.println("\n--- AGENDA DE CONTACTOS ---");
        System.out.println("1. Agregar contacto");
        System.out.println("2. Buscar contacto");
        System.out.println("3. Mostrar agenda");
        System.out.println("4. Salir");
        System.out.print("Seleccione una opción: ");
    }
    public static void mostrarSeparador() {
        System.out.println("----------------------------");
    }
    public static void mostrarMensaje(String mensaje) {
        System.out.println(mensaje);
    }
}