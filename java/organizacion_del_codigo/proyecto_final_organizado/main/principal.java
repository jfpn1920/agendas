package organizacion_del_codigo.proyecto_final_organizado.main;
import java.util.Scanner;
import organizacion_del_codigo.proyecto_final_organizado.model.contacto;
import organizacion_del_codigo.proyecto_final_organizado.service.agendaservice;
import organizacion_del_codigo.proyecto_final_organizado.util.utilidades;
public class principal {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        agendaservice agenda = new agendaservice();
        int opcion;
        do {
            utilidades.mostrarMenu();
            System.out.print("Seleccione una opción: ");
            opcion = scanner.nextInt();
            scanner.nextLine();
            switch (opcion) {
                case 1:
                    System.out.print("Nombre: ");
                    String nombre = scanner.nextLine();
                    System.out.print("Teléfono: ");
                    String telefono = scanner.nextLine();
                    contacto nuevo = new contacto(nombre, telefono);
                    agenda.agregarContacto(nuevo);
                    break;
                case 2:
                    agenda.mostrarContactos();
                    break;
                case 3:
                    System.out.print("Ingrese el nombre a buscar: ");
                    nombre = scanner.nextLine();
                    agenda.buscarContacto(nombre);
                    break;
                case 4:
                    System.out.print("Ingrese el nombre a eliminar: ");
                    nombre = scanner.nextLine();
                    agenda.eliminarContacto(nombre);
                    break;
                case 5:
                    System.out.println("Saliendo del sistema...");
                    break;
                default:
                    System.out.println("Opción inválida.");
            }
        } while (opcion != 5);
        scanner.close();
    }
}