package ciclos;
public class eliminar_contacto_en_bucle {
    public static void main(String[] args) {
        String contactoAEliminar = "Contacto 2";
        boolean eliminado = false;
        for (int i = 1; i <= 3; i++) {
            String nombre = "Contacto " + i;
            if (nombre.equals(contactoAEliminar)) {
                System.out.println("Contacto eliminado: " + nombre);
                eliminado = true;
                break;
            } else {
                System.out.println("Revisando: " + nombre);
            }
        }
        if (!eliminado) {
            System.out.println("Contacto no encontrado.");
        }
    }
}