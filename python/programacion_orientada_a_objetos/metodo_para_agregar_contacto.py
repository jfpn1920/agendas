class Contacto:
    def __init__(self, nombre, telefono, email):
        self.nombre = nombre
        self.telefono = telefono
        self.email = email
class Agenda:
    def __init__(self):
        self.contactos = []
    def agregar_contacto(self, nombre, telefono, email):
        nuevo_contacto = Contacto(nombre, telefono, email)
        self.contactos.append(nuevo_contacto)
        print("Contacto agregado correctamente.")