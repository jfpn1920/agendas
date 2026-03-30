from utils.helpers import formatear_nombre, generar_id
def crear_contacto(nombre, telefono):
    return {
        "id": generar_id(),
        "nombre": formatear_nombre(nombre),
        "telefono": telefono
    }
def agregar_contacto(lista, contacto):
    lista.append(contacto)
def obtener_contactos(lista):
    return lista
def buscar_contacto(lista, nombre):
    nombre = nombre.lower()
    for c in lista:
        if c["nombre"].lower() == nombre:
            return c
    return None
def eliminar_contacto(lista, nombre):
    contacto = buscar_contacto(lista, nombre)
    if contacto:
        lista.remove(contacto)
        return True
    return False