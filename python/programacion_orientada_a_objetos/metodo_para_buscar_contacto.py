class Agenda:
    def __init__(self):
        self.contactos = []
    def buscar_contacto(self, nombre):
        for contacto in self.contactos:
            if contacto.nombre.lower() == nombre.lower():
                print("Contacto encontrado:")
                print(f"Nombre: {contacto.nombre}")
                print(f"Teléfono: {contacto.telefono}")
                print(f"Email: {contacto.email}")
                return
        print("Contacto no encontrado.")