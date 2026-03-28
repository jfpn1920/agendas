agenda = {
    "Pedro": {"telefono": "3025554444", "correo": "pedro@gmail.com"},
    "Juan": {"telefono": "3001234567", "correo": "juan@gmail.com"},
    "Maria": {"telefono": "3019876543", "correo": "maria@gmail.com"}
}
def ordenar_contactos():
    print("Agenda ordenada por nombre:\n")
    for nombre in sorted(agenda):
        print("Nombre:", nombre)
        print("Teléfono:", agenda[nombre]["telefono"])
        print("Correo:", agenda[nombre]["correo"])
        print("----------------------")
ordenar_contactos()