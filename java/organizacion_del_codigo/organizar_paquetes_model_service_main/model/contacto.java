package organizacion_del_codigo.organizar_paquetes_model_service_main.model;
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
    public void mostrarcontactos() {
        System.out.println("Nombre: " + nombre + " | Teléfono: " + telefono);
    }
}