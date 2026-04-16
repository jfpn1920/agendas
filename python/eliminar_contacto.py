agenda = ["Juan", "Maria", "Pedro"]
print("Contactos en la agenda:", agenda)
contacto_eliminar = input("Ingresa el nombre del contacto que deseas eliminar: ")
if contacto_eliminar in agenda:
    agenda.remove(contacto_eliminar)
    print("Contacto eliminado correctamente.")
else:
    print("El contacto no existe en la agenda.")
print("Agenda actualizada:", agenda)