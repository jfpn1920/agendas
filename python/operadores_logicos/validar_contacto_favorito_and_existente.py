contactos = ["Ana", "Luis", "Carlos"]
favorito = input("Ingrese el contacto favorito: ")
if favorito != "" and favorito in contactos:
    print("Contacto favorito válido y existente")
else:
    print("El contacto no es válido o no existe")