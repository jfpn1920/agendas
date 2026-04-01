package organizacion_del_codigo.dividir_proyecto_en_archivos;
public class contacto {
    String nombre;
    String telefono;
    public contacto(String nombre, String telefono) {
        this.nombre = nombre;
        this.telefono = telefono;
    }
    public void mostrarContacto() {
        System.out.println("Nombre: " + nombre + " | Teléfono: " + telefono);
    }
}