from conexion import conectar
def guardar_contacto(nombre, telefono, email):
    conexion = conectar()
    if conexion:
        cursor = conexion.cursor()
        sql = "INSERT INTO contactos (nombre, telefono, email) VALUES (%s, %s, %s)"
        valores = (nombre, telefono, email)
        cursor.execute(sql, valores)
        conexion.commit()
        print("✅ Contacto guardado correctamente")
        cursor.close()
        conexion.close()
if __name__ == "__main__":
    print("=== Guardar Contacto ===")
    nombre = input("Nombre: ")
    telefono = input("Teléfono: ")
    email = input("Email: ")
    guardar_contacto(nombre, telefono, email)