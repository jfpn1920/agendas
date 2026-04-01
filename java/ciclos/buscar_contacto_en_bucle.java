package ciclos;
public class buscar_contacto_en_bucle {
    public static void main(String[] args) {
        String contactoBuscado = "Contacto 2";
        boolean encontrado = false;
        for (int i = 1; i <= 3; i++) {
            String nombre = "Contacto " + i;
            if (nombre.equals(contactoBuscado)) {
                System.out.println("Contacto encontrado: " + nombre);
                encontrado = true;
                break;
            }
        }
        if (!encontrado) {
            System.out.println("Contacto no encontrado.");
        }
    }
}