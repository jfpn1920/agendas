def registrar_contacto(agenda):
    nombre = input("Ingresa el nombre: ")
    telefono = input("Ingresa el teléfono: ")
    correo = input("Ingresa el correo: ")
    agenda[nombre] = {
        "telefono": telefono,
        "correo": correo
    }
    print("Contacto registrado correctamente.")
def mostrar_agenda(agenda):
    print("\nAgenda de contactos:\n")
    for nombre, datos in agenda.items():
        print("Nombre:", nombre)
        print("Teléfono:", datos["telefono"])
        print("Correo:", datos["correo"])
        print("----------------------")
agenda = {}
registrar_contacto(agenda)
mostrar_agenda(agenda)