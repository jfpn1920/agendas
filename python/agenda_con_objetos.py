class Contacto:
    def __init__(self, nombre, telefono, email):
        self.nombre = nombre
        self.telefono = telefono
        self.email = email
    def mostrar(self):
        return f"Nombre: {self.nombre}, Teléfono: {self.telefono}, Email: {self.email}"
class Agenda:
    def __init__(self):
        self.contactos = []
    def agregar_contacto(self, contacto):
        if isinstance(contacto, Contacto):
            self.contactos.append(contacto)
            print("Contacto agregado correctamente.")
        else:
            print("Error: Debe ser un objeto de tipo Contacto.")
    def mostrar_agenda(self):
        if not self.contactos:
            print("La agenda está vacía.")
        else:
            for contacto in self.contactos:
                print(contacto.mostrar())
    def buscar_contacto(self, nombre):
        for contacto in self.contactos:
            if contacto.nombre.lower() == nombre.lower():
                return contacto
        return None
    def eliminar_contacto(self, nombre):
        contacto = self.buscar_contacto(nombre)
        if contacto:
            self.contactos.remove(contacto)
            print("Contacto eliminado.")
        else:
            print("Contacto no encontrado.")