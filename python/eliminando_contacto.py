agenda = {
    "Juan": {"telefono": "3001234567", "correo": "juan@gmail.com"},
    "Maria": {"telefono": "3019876543", "correo": "maria@gmail.com"},
    "Pedro": {"telefono": "3025554444", "correo": "pedro@gmail.com"}
}
nombre = input("Ingresa el nombre del contacto que deseas eliminar: ")
if nombre in agenda:
    del agenda[nombre]
    print("Contacto eliminado correctamente.")
else:
    print("El contacto no existe en la agenda.")
print("\nAgenda actualizada:")
print(agenda)