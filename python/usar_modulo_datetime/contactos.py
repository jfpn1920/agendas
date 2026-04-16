from datetime import datetime
def agregar_contacto(lista, nombre, telefono):
    fecha_creacion = datetime.now().strftime("%Y-%m-%d %H:%M:%S")
    contacto = {
        "nombre": nombre,
        "telefono": telefono,
        "fecha": fecha_creacion
    }
    lista.append(contacto)
    return "Contacto agregado correctamente"
def mostrar_contactos(lista):
    if not lista:
        return ["No hay contactos"]
    resultado = []
    for c in lista:
        resultado.append(
            f"{c['nombre']} - {c['telefono']} (Agregado: {c['fecha']})"
        )
    return resultado