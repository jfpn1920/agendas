def agregar_contacto(lista, nombre, telefono):
    contacto = {"nombre": nombre, "telefono": telefono}
    lista.append(contacto)
def mostrar_contactos(lista):
    for contacto in lista:
        print(f"Nombre: {contacto['nombre']}, Teléfono: {contacto['telefono']}")
def buscar_contacto(lista, nombre):
    for contacto in lista:
        if contacto["nombre"] == nombre:
            print(f"Teléfono: {contacto['telefono']}")
            return
    print("Contacto no encontrado")