import contactos
agenda = []
while True:
    print("\n--- AGENDA ---")
    print("1. Agregar contacto")
    print("2. Mostrar contactos")
    print("3. Salir")
    opcion = input("Opción: ")
    if opcion == "1":
        nombre = input("Nombre: ")
        telefono = input("Teléfono: ")
        mensaje = contactos.agregar_contacto(agenda, nombre, telefono)
        print(mensaje)
    elif opcion == "2":
        lista = contactos.mostrar_contactos(agenda)
        for c in lista:
            print(c)
    elif opcion == "3":
        break
    else:
        print("Opción inválida")