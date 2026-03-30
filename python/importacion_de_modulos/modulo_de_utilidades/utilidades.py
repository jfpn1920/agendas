def formatear_nombre(nombre):
    return nombre.strip().title()
def contacto_existe(lista, nombre):
    for contacto in lista:
        if contacto["nombre"].lower() == nombre.lower():
            return True
    return False
def buscar_indice(lista, nombre):
    for i, contacto in enumerate(lista):
        if contacto["nombre"].lower() == nombre.lower():
            return i
    return -1