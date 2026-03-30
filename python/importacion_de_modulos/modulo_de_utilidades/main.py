import contactos
agenda = []
while True:
    print("\n--- AGENDA ---")
    print("1. Agregar contacto")
    print("2. Mostrar contactos")
    print("3. Eliminar contacto")
    print("4. Salir")
    opcion = input("Opción: ")
    if opcion == "1":
        nombre = input("Nombre: ")
        telefono = input("Teléfono: ")
        print(contactos.agregar_contacto(agenda, nombre, telefono))
    elif opcion == "2":
        for c in contactos.mostrar_contactos(agenda):
            print(c)
    elif opcion == "3":
        nombre = input("Nombre a eliminar: ")
        print(contactos.eliminar_contacto(agenda, nombre))
    elif opcion == "4":
        break
    else:
        print("Opción inválida")