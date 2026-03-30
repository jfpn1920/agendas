from contactos import agregar_contacto as add, mostrar_contactos as show, buscar_contacto as find
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
        add(agenda, nombre, telefono)
    elif opcion == "2":
        show(agenda)
    elif opcion == "3":
        nombre = input("Nombre a buscar: ")
        find(agenda, nombre)
    elif opcion == "4":
        print("Saliendo...")
        break
    else:
        print("Opción inválida")