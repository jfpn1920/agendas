agenda = {
    "Juan": {"telefono": "3001234567", "correo": "juan@gmail.com"},
    "Maria": {"telefono": "3019876543", "correo": "maria@gmail.com"},
    "Pedro": {"telefono": "3025554444", "correo": "pedro@gmail.com"}
}
def contar_contactos():
    cantidad = len(agenda)
    print("La cantidad de contactos en la agenda es:", cantidad)
contar_contactos()