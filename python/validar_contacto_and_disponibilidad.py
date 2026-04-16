contactos = ["Ana", "Luis", "Carlos"]
nombre = input("Ingrese el nombre del contacto: ")
disponible = input("¿Está disponible? (si/no): ")
if nombre in contactos and disponible == "si":
    print("Contacto disponible")
else:
    print("Contacto no disponible o no existe")