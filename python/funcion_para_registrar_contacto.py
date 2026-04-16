agenda = {}
def registrar_contacto():
    nombre = input("Ingresa el nombre: ")
    telefono = input("Ingresa el teléfono: ")
    correo = input("Ingresa el correo: ")
    agenda[nombre] = {
        "telefono": telefono,
        "correo": correo
    }
    print("Contacto registrado correctamente.")
registrar_contacto()
print("\nAgenda de contactos:")
print(agenda)