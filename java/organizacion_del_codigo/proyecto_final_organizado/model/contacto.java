package organizacion_del_codigo.proyecto_final_organizado.model;
public class contacto {
    private String nombre;
    private String telefono;
    public contacto(String nombre, String telefono) {
        this.nombre = nombre;
        this.telefono = telefono;
    }
    public String getNombre() {
        return nombre;
    }
    public String getTelefono() {
        return telefono;
    }
    public void mostrarContacto() {
        System.out.println("Nombre: " + nombre + " | Teléfono: " + telefono);
    }
}