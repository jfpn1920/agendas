contactos = ["Ana", "Luis", "Carlos"]
duplicado = input("¿El contacto está duplicado? (si/no): ")
nombre = input("Ingrese el nombre del contacto: ")
if duplicado == "si" or nombre in contactos:
    print("El contacto es duplicado o ya existe")
else:
    print("El contacto es nuevo")