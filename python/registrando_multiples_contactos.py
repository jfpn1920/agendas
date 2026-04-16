agenda = {}
cantidad = int(input("¿Cuántos contactos deseas registrar?: "))
for i in range(cantidad):
    print("\nContacto", i + 1)
    nombre = input("Ingresa el nombre: ")
    telefono = input("Ingresa el teléfono: ")
    correo = input("Ingresa el correo: ")    
    agenda[nombre] = {
        "telefono": telefono,
        "correo": correo
    }
print("\nAgenda de contactos:")
print(agenda)