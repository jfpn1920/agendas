contactos = []
while True:
    print("\n--- Registrar nuevo contacto ---")
    nombre = input("Ingrese el nombre (o escriba 'salir' para terminar): ")
    if nombre.lower() == "salir":
        print("Finalizando registro...")
        break
    telefono = input("Ingrese el teléfono: ")
    contactos.append((nombre, telefono))
    print("Contacto registrado:", nombre, "-", telefono)
print("\nTodos los contactos registrados:")
for nombre, telefono in contactos:
    print("Nombre:", nombre, "- Teléfono:", telefono)