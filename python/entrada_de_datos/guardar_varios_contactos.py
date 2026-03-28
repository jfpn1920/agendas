cantidad = int(input("¿Cuántos contactos desea guardar?: "))
contactos = []
for i in range(cantidad):
    nombre = input("Ingrese el nombre: ")
    telefono = input("Ingrese el teléfono: ")
    correo = input("Ingrese el correo: ")
    direccion = input("Ingrese la dirección: ")
    contactos.append((nombre, telefono, correo, direccion))
print("Contactos guardados:")
for contacto in contactos:
    print("Nombre:", contacto[0])
    print("Teléfono:", contacto[1])
    print("Correo:", contacto[2])
    print("Dirección:", contacto[3])
    print()