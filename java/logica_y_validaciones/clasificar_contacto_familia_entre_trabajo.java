package logica_y_validaciones;
public class clasificar_contacto_familia_entre_trabajo {
    public static void main(String[] args) {
        String nombre = "Carlos Ramírez";
        String tipo = "familia";
        if (tipo.equalsIgnoreCase("familia")) {
            System.out.println(nombre + " pertenece a la categoría: Familia.");
        } else if (tipo.equalsIgnoreCase("trabajo")) {
            System.out.println(nombre + " pertenece a la categoría: Trabajo.");
        } else {
            System.out.println("Categoría no válida.");
        }
    }
}