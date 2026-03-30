import contactos
agenda = []
contactos.agregar_contacto(agenda, "Juan", "12345")
contactos.agregar_contacto(agenda, "Ana", "67890")
contactos.mostrar_contactos(agenda)
contactos.buscar_contacto(agenda, "Ana")