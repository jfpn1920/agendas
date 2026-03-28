class Contacto:
    def __init__(self, nombre, telefono, email):
        self.nombre = nombre
        self.telefono = telefono
        self.email = email
    def __str__(self):
        return f"Nombre: {self.nombre}, Teléfono: {self.telefono}, Email: {self.email}"
class Agenda:
    def __init__(self):
        self.__contactos = []
    def agregar(self, contacto):
        if not isinstance(contacto, Contacto):
            print("Error: objeto inválido.")
            return
        if self.buscar(contacto.nombre):
            print("El contacto ya existe.")
            return
        self.__contactos.append(contacto)
        print("Contacto agregado.")
    def mostrar(self):
        if not self.__contactos:
            print("Agenda vacía.")
            return
        for contacto in self.__contactos:
            print(contacto)
    def buscar(self, nombre):
        for contacto in self.__contactos:
            if contacto.nombre.lower() == nombre.lower():
                return contacto
        return None
    def eliminar(self, nombre):
        contacto = self.buscar(nombre)
        if contacto:
            self.__contactos.remove(contacto)
            print("Contacto eliminado.")
        else:
            print("No encontrado.")
    def editar(self, nombre):
        contacto = self.buscar(nombre)
        if contacto:
            print("Editar contacto:")
            contacto.telefono = input("Nuevo teléfono: ")
            contacto.email = input("Nuevo email: ")
            print("Contacto actualizado.")
        else:
            print("Contacto no encontrado.")