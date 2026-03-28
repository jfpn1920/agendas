agenda = {}
nombre = input("Ingresa el nombre del contacto: ")
telefono = input("Ingresa el teléfono: ")
correo = input("Ingresa el correo electrónico: ")
agenda[nombre] = {
    "telefono": telefono,
    "correo": correo
}
print("Agenda de contactos:")
print(agenda)