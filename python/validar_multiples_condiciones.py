nombre = input("Ingrese el nombre: ")
telefono = input("Ingrese el teléfono: ")
correo = input("Ingrese el correo: ")
if nombre != "" and telefono.isdigit() and "@" in correo and "." in correo:
    print("Todos los datos son válidos")
else:
    print("Hay datos inválidos")