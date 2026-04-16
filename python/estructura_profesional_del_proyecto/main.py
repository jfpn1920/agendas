from contactos import (
    crear_contacto,
    agregar_contacto,
    obtener_contactos,
    buscar_contacto,
    eliminar_contacto
)
agenda = []
def menu():
    print("\n--- AGENDA ---")
    print("1. Agregar contacto")
    print("2. Mostrar contactos")
    print("3. Buscar contacto")
    print("4. Eliminar contacto")
    print("5. Salir")
while True:
    menu()
    opcion = input("Opción: ")
    if opcion == "1":
        nombre = input("Nombre: ")
        telefono = input("Teléfono: ")
        contacto = crear_contacto(nombre, telefono)
        agregar_contacto(agenda, contacto)
        print("Contacto agregado")
    elif opcion == "2":
        lista = obtener_contactos(agenda)
        if not lista:
            print("No hay contactos")
        else:
            for c in lista:
                print(f"{c['id']} - {c['nombre']} - {c['telefono']}")
    elif opcion == "3":
        nombre = input("Nombre a buscar: ")
        c = buscar_contacto(agenda, nombre)
        if c:
            print(f"{c['nombre']} - {c['telefono']}")
        else:
            print("No encontrado")
    elif opcion == "4":
        nombre = input("Nombre a eliminar: ")
        if eliminar_contacto(agenda, nombre):
            print("Eliminado")
        else:
            print("No encontrado")
    elif opcion == "5":
        print("Saliendo...")
        break
    else:
        print("Opción inválida")