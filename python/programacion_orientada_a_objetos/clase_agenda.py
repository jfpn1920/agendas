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
        self.contactos.append(contacto)
        print("Contacto agregado correctamente.")
    def mostrar_contactos(self):
        if not self.contactos:
            print("La agenda está vacía.")
        else:
            for contacto in self.contactos:
                print(contacto.mostrar())
    def buscar_contacto(self, nombre):
        for contacto in self.contactos:
            if contacto.nombre.lower() == nombre.lower():
                print("Contacto encontrado:")
                print(contacto.mostrar())
                return
        print("Contacto no encontrado.")
    def eliminar_contacto(self, nombre):
        for contacto in self.contactos:
            if contacto.nombre.lower() == nombre.lower():
                self.contactos.remove(contacto)
                print("Contacto eliminado.")
                return
        print("Contacto no encontrado.")
agenda = Agenda()
c1 = Contacto("Juan", "123456789", "juan@email.com")
c2 = Contacto("Ana", "987654321", "ana@email.com")
agenda.agregar_contacto(c1)
agenda.agregar_contacto(c2)
agenda.mostrar_contactos()
agenda.buscar_contacto("Juan")
agenda.eliminar_contacto("Ana")
agenda.mostrar_contactos()