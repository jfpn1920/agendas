agenda = {
    "Juan": {"telefono": "3001234567", "correo": "juan@gmail.com"},
    "Maria": {"telefono": "3019876543", "correo": "maria@gmail.com"}
}
def eliminar_contacto():
    nombre = input("Ingresa el nombre del contacto que deseas eliminar: ")
    if nombre in agenda:
        del agenda[nombre]
        print("Contacto eliminado correctamente.")
    else:
        print("El contacto no existe.")
eliminar_contacto()
print("\nAgenda actualizada:")
print(agenda)