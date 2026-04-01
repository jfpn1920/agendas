package logica_y_validaciones;
public class validar_agenda_vacia {
    public static void main(String[] args) {
        int cantidadContactos = 0;
        if (cantidadContactos == 0) {
            System.out.println("La agenda está vacía.");
        } else {
            System.out.println("Hay contactos en la agenda.");
        }
    }
}