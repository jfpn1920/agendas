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
        print("✅ Contacto guardado")
def mostrar_contactos():
    conexion = conectar()
    if conexion:
        cursor = conexion.cursor()
        cursor.execute("SELECT * FROM contactos")
        resultados = cursor.fetchall()
        if resultados:
            print("\n📋 Contactos:\n")
            for contacto in resultados:
                print(f"ID: {contacto[0]} | Nombre: {contacto[1]} | Tel: {contacto[2]}")
        else:
            print("⚠️ No hay contactos")
        cursor.close()
        conexion.close()
def eliminar_contacto(id_contacto):
    conexion = conectar()
    if conexion:
        cursor = conexion.cursor()
        sql = "DELETE FROM contactos WHERE id = %s"
        cursor.execute(sql, (id_contacto,))
        conexion.commit()
        if cursor.rowcount > 0:
            print("🗑️ Contacto eliminado correctamente")
        else:
            print("⚠️ No se encontró el contacto")
        cursor.close()
        conexion.close()
def main():
    print("=== Eliminar Contacto ===")
    while True:
        print("\n1. Agregar contacto")
        print("2. Mostrar contactos")
        print("3. Eliminar contacto")
        print("4. Salir")
        opcion = input("Elige una opción: ")
        if opcion == "1":
            nombre = input("Nombre: ")
            telefono = input("Teléfono: ")
            email = input("Email: ")
            guardar_contacto(nombre, telefono, email)
        elif opcion == "2":
            mostrar_contactos()
        elif opcion == "3":
            mostrar_contactos()
            try:
                id_contacto = int(input("Ingrese el ID a eliminar: "))
                eliminar_contacto(id_contacto)
            except ValueError:
                print("❌ Debes ingresar un número válido")
        elif opcion == "4":
            print("👋 Saliendo")
            break
        else:
            print("❌ Opción inválida")
if __name__ == "__main__":
    main()