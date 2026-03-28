agenda = ["Juan", "Maria", "Pedro"]
contacto_buscar = input("Ingresa el nombre del contacto que deseas buscar: ")
if contacto_buscar in agenda:
    print("El contacto", contacto_buscar, "sí está en la agenda.")
else:
    print("El contacto no se encuentra en la agenda.")