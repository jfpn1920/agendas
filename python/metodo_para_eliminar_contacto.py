class Agenda:
    def __init__(self):
        self.contactos = []
    def eliminar_contacto(self, nombre):
        for contacto in self.contactos:
            if contacto.nombre.lower() == nombre.lower():
                self.contactos.remove(contacto)
                print("Contacto eliminado correctamente.")
                return
        print("Contacto no encontrado.")