agenda = {
    "Familia": ["Juan", "Ana"],
    "Trabajo": ["Maria", "Carlos", "Luis"],
    "Amigos": ["Pedro", "Sofia"]
}
print("Cantidad de contactos por grupo:\n")
for grupo, contactos in agenda.items():
    cantidad = len(contactos)
    print(grupo + ":", cantidad, "contactos")