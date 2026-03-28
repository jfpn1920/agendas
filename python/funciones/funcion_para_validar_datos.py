def validar_datos(telefono, correo):
    if telefono.isdigit():
        telefono_valido = True
    else:
        telefono_valido = False
    if "@" in correo:
        correo_valido = True
    else:
        correo_valido = False
    if telefono_valido and correo_valido:
        return True
    else:
        return False
telefono = input("Ingresa el teléfono: ")
correo = input("Ingresa el correo: ")
if validar_datos(telefono, correo):
    print("Los datos son válidos.")
else:
    print("Los datos no son válidos.")