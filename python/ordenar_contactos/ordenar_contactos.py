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
def mostrar_contactos_ordenados(tipo_orden):
    conexion = conectar()
    if conexion:
        cursor = conexion.cursor()
        if tipo_orden == "1":
            sql = "SELECT * FROM contactos ORDER BY nombre ASC"
        elif tipo_orden == "2":
            sql = "SELECT * FROM contactos ORDER BY nombre DESC"
        else:
            print("❌ Opción inválida")
            return
        cursor.execute(sql)
        resultados = cursor.fetchall()
        if resultados:
            print("\n📋 Contactos ordenados:\n")
            for c in resultados:
                print(f"ID: {c[0]} | Nombre: {c[1]} | Tel: {c[2]} | Email: {c[3]}")
        else:
            print("⚠️ No hay contactos")
        cursor.close()
        conexion.close()
def main():
    print("=== Ordenar Contactos ===")
    while True:
        print("\n1. Agregar contacto")
        print("2. Mostrar A-Z")
        print("3. Mostrar Z-A")
        print("4. Salir")
        opcion = input("Elige una opción: ")
        if opcion == "1":
            nombre = input("Nombre: ")
            telefono = input("Teléfono: ")
            email = input("Email: ")
            guardar_contacto(nombre, telefono, email)
        elif opcion == "2":
            mostrar_contactos_ordenados("1")
        elif opcion == "3":
            mostrar_contactos_ordenados("2")
        elif opcion == "4":
            print("👋 Saliendo")
            break
        else:
            print("❌ Opción inválida")
if __name__ == "__main__":
    main()