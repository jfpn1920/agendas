agenda = {
    "Juan": {"telefono": "3001234567", "correo": "juan@gmail.com"},
    "Maria": {"telefono": "3019876543", "correo": "maria@gmail.com"}
}
nombre = input("Ingresa el nombre del contacto que deseas actualizar: ")
if nombre in agenda:
    nuevo_telefono = input("Ingresa el nuevo teléfono: ")
    nuevo_correo = input("Ingresa el nuevo correo: ")
    agenda[nombre]["telefono"] = nuevo_telefono
    agenda[nombre]["correo"] = nuevo_correo
    print("Contacto actualizado correctamente.")
else:
    print("El contacto no existe en la agenda.")
print("\nAgenda actualizada:")
print(agenda)