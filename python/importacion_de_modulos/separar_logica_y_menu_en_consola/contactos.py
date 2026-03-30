def agregar_contacto(lista, nombre, telefono):
    contacto = {"nombre": nombre, "telefono": telefono}
    lista.append(contacto)
    return "Contacto agregado correctamente"
def mostrar_contactos(lista):
    if not lista:
        return ["No hay contactos"]
    resultado = []
    for i, contacto in enumerate(lista, 1):
        resultado.append(f"{i}. {contacto['nombre']} - {contacto['telefono']}")
    return resultado
def buscar_contacto(lista, nombre):
    for contacto in lista:
        if contacto["nombre"].lower() == nombre.lower():
            return f"{contacto['nombre']} - {contacto['telefono']}"
    return "Contacto no encontrado"
def eliminar_contacto(lista, nombre):
    for contacto in lista:
        if contacto["nombre"].lower() == nombre.lower():
            lista.remove(contacto)
            return "Contacto eliminado"
    return "Contacto no encontrado"