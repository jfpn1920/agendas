class Contacto:
    def __init__(self, nombre, telefono, email):
        self.nombre = nombre
        self.telefono = telefono
        self.email = email
    def __str__(self):
        return f"{self.nombre} | {self.telefono} | {self.email}"
class Agenda:
    def __init__(self):
        self.contactos = []
    def agregar(self, nombre, telefono, email):
        if self.buscar(nombre):
            print("El contacto ya existe.")
            return
        if not telefono.isdigit():
            print("Teléfono inválido.")
            return
        contacto = Contacto(nombre, telefono, email)
        self.contactos.append(contacto)
        print("Contacto agregado.")
    def listar(self):
        if not self.contactos:
            print("Agenda vacía.")
            return
        for c in self.contactos:
            print(c)
    def buscar(self, nombre):
        for c in self.contactos:
            if c.nombre.lower() == nombre.lower():
                return c
        return None
    def eliminar(self, nombre):
        contacto = self.buscar(nombre)
        if contacto:
            self.contactos.remove(contacto)
            print("Eliminado.")
        else:
            print("No encontrado.")
    def editar(self, nombre):
        contacto = self.buscar(nombre)
        if contacto:
            nuevo_tel = input("Nuevo teléfono: ")
            nuevo_email = input("Nuevo email: ")
            if nuevo_tel.isdigit():
                contacto.telefono = nuevo_tel
            else:
                print("Teléfono inválido.")
            contacto.email = nuevo_email
            print("Contacto actualizado.")
        else:
            print("No encontrado.")