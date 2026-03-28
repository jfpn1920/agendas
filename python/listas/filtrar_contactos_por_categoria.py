agenda = [
    ["Juan", "Familia"],
    ["Maria", "Trabajo"],
    ["Pedro", "Amigos"],
    ["Ana", "Familia"]
]
categoria_buscar = input("Ingresa la categoría que deseas filtrar: ")
print("Contactos en la categoría:", categoria_buscar)
for contacto in agenda:
    if contacto[1].lower() == categoria_buscar.lower():
        print(contacto[0])