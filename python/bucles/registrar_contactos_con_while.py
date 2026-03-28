contactos = []
i = 0
cantidad = int(input("¿Cuántos contactos desea registrar?: "))
while i < cantidad:
    print(f"\nContacto {i+1}:")
    nombre = input("Ingrese el nombre: ")
    telefono = input("Ingrese el teléfono: ")
    contactos.append((nombre, telefono))
    i += 1
print("Contactos registrados:")
for nombre, telefono in contactos:
    print("Nombre:", nombre, "- Teléfono:", telefono)