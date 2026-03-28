contactos = ["Ana", "Luis", "Carlos"]
buscar = input("Ingrese el nombre del contacto a buscar: ")
encontrado = False
for contacto in contactos:
    if contacto == buscar:
        encontrado = True
        break
if encontrado:
    print("Contacto encontrado")
else:
    print("Contacto no encontrado")