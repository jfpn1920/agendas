agenda = {
    "Juan": {"telefono": "3001234567", "correo": "juan@gmail.com"},
    "Maria": {"telefono": "3019876543", "correo": "maria@gmail.com"}
}
def buscar_contacto():
    nombre = input("Ingresa el nombre del contacto que deseas buscar: ")
    if nombre in agenda:
        print("Contacto encontrado:")
        print("Teléfono:", agenda[nombre]["telefono"])
        print("Correo:", agenda[nombre]["correo"])
    else:
        print("El contacto no existe en la agenda.")
buscar_contacto()