cantidad = int(input("¿Cuántos contactos desea registrar?: "))
contactos = []
for i in range(cantidad):
    nombre = input("Ingrese el nombre: ")
    telefono = input("Ingrese el teléfono: ")
    contactos.append((nombre, telefono))
print("Lista de contactos:")
for nombre, telefono in contactos:
    print("Nombre:", nombre, "- Teléfono:", telefono)