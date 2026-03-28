correo = input("Ingrese el correo: ")
if "@" in correo and "." in correo:
    print("Correo válido")
else:
    print("Correo inválido")