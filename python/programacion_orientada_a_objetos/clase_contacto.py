class Contacto:
    def __init__(self, nombre, telefono, correo):
        self.nombre = nombre
        self.telefono = telefono
        self.correo = correo
contacto1 = Contacto("Juan", "3001234567", "juan@gmail.com")
print("Nombre:", contacto1.nombre)
print("Teléfono:", contacto1.telefono)
print("Correo:", contacto1.correo)