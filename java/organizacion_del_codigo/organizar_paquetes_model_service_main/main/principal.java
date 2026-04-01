package organizacion_del_codigo.organizar_paquetes_model_service_main.main;
import java.util.Scanner;
import organizacion_del_codigo.organizar_paquetes_model_service_main.model.contacto;
import organizacion_del_codigo.organizar_paquetes_model_service_main.service.agendaservice;
public class principal {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        agendaservice agenda = new agendaservice();
        System.out.print("Ingrese el nombre del contacto: ");
        String nombre = scanner.nextLine();
        System.out.print("Ingrese el teléfono: ");
        String telefono = scanner.nextLine();
        contacto nuevo = new contacto(nombre, telefono);
        agenda.agregarcontacto(nuevo);
        System.out.println("\nLista de contactos:");
        agenda.mostrarcontactos();
        scanner.close();
    }
}