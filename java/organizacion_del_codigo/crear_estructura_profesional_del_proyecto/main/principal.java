package organizacion_del_codigo.crear_estructura_profesional_del_proyecto.main;
import java.util.Scanner;
import organizacion_del_codigo.crear_estructura_profesional_del_proyecto.model.contacto;
import organizacion_del_codigo.crear_estructura_profesional_del_proyecto.service.agendaservice;
import organizacion_del_codigo.crear_estructura_profesional_del_proyecto.util.utilidades;
public class principal {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        agendaservice agenda = new agendaservice();
        utilidades.mostrarMensaje("AGENDA DE CONTACTOS");
        System.out.print("Ingrese el nombre del contacto: ");
        String nombre = scanner.nextLine();
        System.out.print("Ingrese el teléfono: ");
        String telefono = scanner.nextLine();
        contacto nuevo = new contacto(nombre, telefono);
        agenda.agregarContacto(nuevo);
        utilidades.mostrarSeparador();
        agenda.mostrarContactos();
        scanner.close();
    }
}