cantidad = int(input("¿Cuántos contactos desea registrar?: "))
contactos = []
for i in range(cantidad):
    print(f"\nContacto {i+1}:")
    nombre = input("Ingrese el nombre: ")
    telefono = input("Ingrese el teléfono: ")
    contactos.append((nombre, telefono))
print("Contactos registrados:")
for nombre, telefono in contactos:
    print("Nombre:", nombre, "- Teléfono:", telefono)