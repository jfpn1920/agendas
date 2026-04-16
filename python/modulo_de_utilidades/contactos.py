import utilidades
def agregar_contacto(lista, nombre, telefono):
    nombre = utilidades.formatear_nombre(nombre)
    if utilidades.contacto_existe(lista, nombre):
        return "El contacto ya existe"
    contacto = {"nombre": nombre, "telefono": telefono}
    lista.append(contacto)
    return "Contacto agregado correctamente"
def mostrar_contactos(lista):
    if not lista:
        return ["No hay contactos"]
    return [f"{c['nombre']} - {c['telefono']}" for c in lista]
def eliminar_contacto(lista, nombre):
    indice = utilidades.buscar_indice(lista, nombre)
    if indice == -1:
        return "Contacto no encontrado"
    lista.pop(indice)
    return "Contacto eliminado"