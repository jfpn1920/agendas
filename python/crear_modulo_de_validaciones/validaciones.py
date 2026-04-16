def validar_nombre(nombre):
    if not nombre.strip():
        return False, "El nombre no puede estar vacío"
    if not nombre.isalpha():
        return False, "El nombre solo debe contener letras"
    return True, "Nombre válido"
def validar_telefono(telefono):
    if not telefono.isdigit():
        return False, "El teléfono solo debe contener números"
    if len(telefono) < 7:
        return False, "El teléfono es muy corto"
    return True, "Teléfono válido"