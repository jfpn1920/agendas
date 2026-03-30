import random
def generar_id():
    return random.randint(1000, 9999)
def agregar_contacto(lista, nombre, telefono):
    contacto_id = generar_id()
    contacto = {
        "id": contacto_id,
        "nombre": nombre,
        "telefono": telefono
    }
    lista.append(contacto)
    return f"Contacto agregado con ID: {contacto_id}"
def mostrar_contactos(lista):
    if not lista:
        return ["No hay contactos"]
    return [
        f"ID: {c['id']} | {c['nombre']} - {c['telefono']}"
        for c in lista
    ]
def buscar_por_id(lista, contacto_id):
    for c in lista:
        if c["id"] == contacto_id:
            return f"{c['nombre']} - {c['telefono']}"
    return "Contacto no encontrado"