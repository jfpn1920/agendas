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
    def agregar_contacto(self, nombre, telefono, email):
        for contacto in self.contactos:
            if contacto.nombre.lower() == nombre.lower():
                print("El contacto ya existe.")
                return
        nuevo = Contacto(nombre, telefono, email)
        self.contactos.append(nuevo)
        print("Contacto agregado correctamente.")
    def mostrar_agenda(self):
        if not self.contactos:
            print("La agenda está vacía.")
        else:
            print("\nLista de contactos:")
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
while True:
    print("\n--- AGENDA ---")
    print("1. Agregar contacto")
    print("2. Mostrar agenda")
    print("3. Buscar contacto")
    print("4. Eliminar contacto")
    print("5. Salir")
    opcion = input("Seleccione una opción: ")
    if opcion == "1":
        nombre = input("Nombre: ")
        telefono = input("Teléfono: ")
        email = input("Email: ")
        agenda.agregar_contacto(nombre, telefono, email)
    elif opcion == "2":
        agenda.mostrar_agenda()
    elif opcion == "3":
        nombre = input("Nombre a buscar: ")
        agenda.buscar_contacto(nombre)
    elif opcion == "4":
        nombre = input("Nombre a eliminar: ")
        agenda.eliminar_contacto(nombre)
    elif opcion == "5":
        print("Saliendo del sistema...")
        break
    else:
        print("Opción inválida.")