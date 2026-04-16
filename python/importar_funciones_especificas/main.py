from contactos import agregar_contacto, mostrar_contactos, buscar_contacto
agenda = []
while True:
    print("\n--- AGENDA ---")
    print("1. Agregar contacto")
    print("2. Mostrar contactos")
    print("3. Buscar contacto")
    print("4. Salir")
    opcion = input("Elige una opción: ")
    if opcion == "1":
        nombre = input("Nombre: ")
        telefono = input("Teléfono: ")
        agregar_contacto(agenda, nombre, telefono)
    elif opcion == "2":
        mostrar_contactos(agenda)
    elif opcion == "3":
        nombre = input("Nombre a buscar: ")
        buscar_contacto(agenda, nombre)
    elif opcion == "4":
        print("Saliendo...")
        break
    else:
        print("Opción inválida")