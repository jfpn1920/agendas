def agregar_contacto(lista, nombre, telefono):
    contacto = {"nombre": nombre, "telefono": telefono}
    lista.append(contacto)
    print("Contacto agregado correctamente")
def mostrar_contactos(lista):
    if not lista:
        print("No hay contactos")
        return
    for i, contacto in enumerate(lista, 1):
        print(f"{i}. {contacto['nombre']} - {contacto['telefono']}")
def buscar_contacto(lista, nombre):
    for contacto in lista:
        if contacto["nombre"].lower() == nombre.lower():
            print(f"Encontrado: {contacto['nombre']} - {contacto['telefono']}")
            return
    print("Contacto no encontrado")