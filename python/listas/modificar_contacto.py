agenda = ["Juan", "Maria", "Pedro"]
print("Contactos en la agenda:", agenda)
contacto_modificar = input("Ingresa el nombre del contacto que deseas modificar: ")
if contacto_modificar in agenda:
    nuevo_nombre = input("Ingresa el nuevo nombre del contacto: ")
    posicion = agenda.index(contacto_modificar)
    agenda[posicion] = nuevo_nombre
    
    print("Contacto modificado correctamente.")
else:
    print("El contacto no existe en la agenda.")
print("Agenda actualizada:", agenda)