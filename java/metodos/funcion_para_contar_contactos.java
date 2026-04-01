package metodos;
public class funcion_para_contar_contactos {
    public static int contarContactos(String[] contactos) {
        int contador = 0;
        for (int i = 0; i < contactos.length; i++) {
            if (contactos[i] != null && !contactos[i].trim().isEmpty()) {
                contador++;
            }
        }
        return contador;
    }
    public static void main(String[] args) {
        String[] contactos = {"Juan", "Maria", "", null, "Carlos", "Ana"};
        int total = contarContactos(contactos);
        System.out.println("Total de contactos registrados: " + total);
    }
}