contactos = [] 
nombre1 = "Ana"
telefono1 = "3001111111"
contactos.append((nombre1, telefono1))
nombre2 = "Luis"
telefono2 = "3012222222"
contactos.append((nombre2, telefono2))
nombre3 = "Carlos"
telefono3 = "3023333333"
contactos.append((nombre3, telefono3))
print("Contactos guardados:")
for nombre, telefono in contactos:
    print("Nombre:", nombre, "- Teléfono:", telefono)