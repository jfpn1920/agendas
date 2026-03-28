nombre = input("Ingrese el nombre: ")
telefono = input("Ingrese el teléfono: ")
correo = input("Ingrese el correo: ")
if (nombre != "" and telefono.isdigit()) or ("@" in correo and "." in correo):
    print("Criterios válidos")
else:
    print("No cumple los criterios")