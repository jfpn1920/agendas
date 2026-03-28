contactos = ["Ana", "Luis", "Carlos"]
nombre = input("Ingrese el nombre a buscar: ")
if nombre in contactos:
    print("El contacto existe")
else:
    print("El contacto no existe")