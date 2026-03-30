from conexion import conectar
def guardar_contacto(nombre, telefono, email):
    conexion = conectar()
    if conexion:
        cursor = conexion.cursor()
        sql = "INSERT INTO contactos (nombre, telefono, email) VALUES (%s, %s, %s)"
        cursor.execute(sql, (nombre, telefono, email))
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
                print(f"ID: {contacto[0]} | Nombre: {contacto[1]} | Tel: {contacto[2]} | Email: {contacto[3]}")
        else:
            print("⚠️ No hay contactos")
        cursor.close()
        conexion.close()
def actualizar_contacto(id_contacto, nombre, telefono, email):
    conexion = conectar()
    if conexion:
        cursor = conexion.cursor()
        sql = """
        UPDATE contactos 
        SET nombre = %s, telefono = %s, email = %s 
        WHERE id = %s
        """
        cursor.execute(sql, (nombre, telefono, email, id_contacto))
        conexion.commit()
        if cursor.rowcount > 0:
            print("✏️ Contacto actualizado correctamente")
        else:
            print("⚠️ No se encontró el contacto")
        cursor.close()
        conexion.close()
def main():
    print("=== Actualizar Contacto ===")
    while True:
        print("\n1. Agregar contacto")
        print("2. Mostrar contactos")
        print("3. Actualizar contacto")
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
                id_contacto = int(input("Ingrese el ID a actualizar: "))
                print("Ingrese los nuevos datos:")
                nombre = input("Nuevo nombre: ")
                telefono = input("Nuevo teléfono: ")
                email = input("Nuevo email: ")
                actualizar_contacto(id_contacto, nombre, telefono, email)
            except ValueError:
                print("❌ ID inválido")
        elif opcion == "4":
            print("👋 Saliendo")
            break
        else:
            print("❌ Opción inválida")
if __name__ == "__main__":
    main()