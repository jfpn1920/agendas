import contactos
agenda = []
while True:
    print("\n--- AGENDA ---")
    print("1. Agregar contacto")
    print("2. Mostrar contactos")
    print("3. Buscar contacto")
    print("4. Eliminar contacto")
    print("5. Salir")

    opcion = input("Elige una opción: ")

    if opcion == "1":
        nombre = input("Nombre: ")
        telefono = input("Teléfono: ")
        contactos.agregar_contacto(agenda, nombre, telefono)

    elif opcion == "2":
        contactos.mostrar_contactos(agenda)

    elif opcion == "3":
        nombre = input("Nombre a buscar: ")
        contactos.buscar_contacto(agenda, nombre)

    elif opcion == "4":
        nombre = input("Nombre a eliminar: ")
        contactos.eliminar_contacto(agenda, nombre)

    elif opcion == "5":
        print("Saliendo...")
        break

    else:
        print("Opción inválida")