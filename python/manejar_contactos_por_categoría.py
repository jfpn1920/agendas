agenda = {
    "Familia": ["Juan", "Ana"],
    "Trabajo": ["Maria", "Carlos"],
    "Amigos": ["Pedro", "Luis"]
}
print("Agenda organizada por categorías:\n")
for categoria, contactos in agenda.items():
    print("Categoría:", categoria)
    for contacto in contactos:
        print("-", contacto)
    print("----------------------")