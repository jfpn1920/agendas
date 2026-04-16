nombre = input("Ingrese el nombre: ")
telefono = input("Ingrese el teléfono: ")
correo = input("Ingrese el correo: ")
if nombre != "" and telefono.isdigit() and "@" in correo and "." in correo:
    print("Datos completos y correctos")
else:
    print("Datos inválidos")