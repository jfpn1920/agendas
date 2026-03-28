activo = input("¿El contacto está activo? (si/no): ")
nombre = input("Ingrese el nombre: ")
if activo == "si" and nombre != "":
    print("Contacto activo y válido")
else:
    print("Contacto no válido o inactivo")