import validaciones
def agregar_contacto(lista, nombre, telefono):
    valido_nombre, msg_nombre = validaciones.validar_nombre(nombre)
    if not valido_nombre:
        return msg_nombre
    valido_tel, msg_tel = validaciones.validar_telefono(telefono)
    if not valido_tel:
        return msg_tel
    contacto = {"nombre": nombre, "telefono": telefono}
    lista.append(contacto)
    return "Contacto agregado correctamente"
def mostrar_contactos(lista):
    if not lista:
        return ["No hay contactos"]
    return [f"{c['nombre']} - {c['telefono']}" for c in lista]