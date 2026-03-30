from conexion import conectar
def guardar_contacto(nombre, telefono, email):
    conexion = conectar()
    if conexion:
        cursor = conexion.cursor()
        sql = "INSERT INTO contactos (nombre, telefono, email) VALUES (%s, %s, %s)"
        valores = (nombre, telefono, email)
        cursor.execute(sql, valores)
        conexion.commit()
        cursor.close()
        conexion.close()
        print("✅ Contacto guardado correctamente")
def main():
    print("=== Guardar Múltiples Contactos ===")
    while True:
        nombre = input("Nombre: ")
        telefono = input("Teléfono: ")
        email = input("Email: ")
        guardar_contacto(nombre, telefono, email)
        continuar = input("¿Deseas agregar otro contacto? (s/n): ").lower()
        if continuar != "s":
            print("📁 Fin del registro de contactos")
            break
if __name__ == "__main__":
    main()