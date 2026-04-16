agenda = {
    "Juan": {"telefono": "3001234567", "correo": "juan@gmail.com", "categoria": "Familia"},
    "Maria": {"telefono": "3019876543", "correo": "maria@gmail.com", "categoria": "Trabajo"},
    "Pedro": {"telefono": "3025554444", "correo": "pedro@gmail.com", "categoria": "Amigos"},
    "Ana": {"telefono": "3008887777", "correo": "ana@gmail.com", "categoria": "Familia"}
}
print("Contactos clasificados por categoría:\n")
for nombre, datos in agenda.items():
    print("Nombre:", nombre)
    print("Teléfono:", datos["telefono"])
    print("Correo:", datos["correo"])
    print("Categoría:", datos["categoria"])
    print("----------------------")