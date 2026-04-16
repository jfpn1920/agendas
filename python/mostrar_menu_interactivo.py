while True:
    print("\n--- Menú de Agenda ---")
    print("1. Registrar contacto")
    print("2. Mostrar contactos")
    print("3. Buscar contacto")
    print("4. Eliminar contacto")
    print("5. Salir")
    opcion = input("Seleccione una opción: ")
    if opcion == "1":
        print("Opción: Registrar contacto")
    elif opcion == "2":
        print("Opción: Mostrar contactos")
    elif opcion == "3":
        print("Opción: Buscar contacto")
    elif opcion == "4":
        print("Opción: Eliminar contacto")
    elif opcion == "5":
        print("Saliendo del menú...")
        break
    else:
        print("Opción no válida, intente de nuevo")