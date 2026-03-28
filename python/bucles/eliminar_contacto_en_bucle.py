contactos = ["Ana", "Luis", "Carlos"]
eliminar = input("Ingrese el nombre del contacto a eliminar: ")
for i in range(len(contactos)):
    if contactos[i] == eliminar:
        contactos.pop(i)
        print("Contacto eliminado")
        break
else:
    print("Contacto no encontrado")
print("Lista actual de contactos:", contactos)