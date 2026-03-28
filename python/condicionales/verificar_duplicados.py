contactos = ["Ana", "Luis", "Carlos"]
nombre = input("Ingrese el nombre del contacto: ")
if nombre in contactos:
    print("El contacto ya existe")
else:
    print("El contacto no está duplicado")