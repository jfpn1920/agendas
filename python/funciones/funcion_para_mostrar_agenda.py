agenda = {
    "Juan": {"telefono": "3001234567", "correo": "juan@gmail.com"},
    "Maria": {"telefono": "3019876543", "correo": "maria@gmail.com"},
    "Pedro": {"telefono": "3025554444", "correo": "pedro@gmail.com"}
}
def mostrar_agenda():
    print("Agenda de contactos:\n")
    for nombre, datos in agenda.items():
        print("Nombre:", nombre)
        print("Teléfono:", datos["telefono"])
        print("Correo:", datos["correo"])
        print("----------------------")
mostrar_agenda()