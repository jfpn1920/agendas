from conexion import conectar
import re
def validar_nombre(nombre):
    return len(nombre.strip()) > 0
def validar_telefono(telefono):
    return telefono.isdigit() and len(telefono) >= 7
def validar_email(email):
    patron = r'^[\w\.-]+@[\w\.-]+\.\w+$'
    return re.match(patron, email)
def guardar_contacto(nombre, telefono, email):
    if not validar_nombre(nombre):
        print("❌ Nombre inválido")
        return    
    if not validar_telefono(telefono):
        print("❌ Teléfono inválido (solo números, mínimo 7 dígitos)")
        return
    if not validar_email(email):
        print("❌ Email inválido")
        return
    conexion = conectar()
    if conexion:
        cursor = conexion.cursor()
        try:
            sql = "INSERT INTO contactos (nombre, telefono, email) VALUES (%s, %s, %s)"
            cursor.execute(sql, (nombre, telefono, email))
            conexion.commit()
            
            print("✅ Contacto guardado correctamente")
        except Exception as e:
            print("⚠️ Error al guardar (posible email duplicado):", e)
        finally:
            cursor.close()
            conexion.close()
def main():
    print("=== Validar Datos Antes de Insertar ===")
    while True:
        nombre = input("Nombre: ")
        telefono = input("Teléfono: ")
        email = input("Email: ")
        guardar_contacto(nombre, telefono, email)
        continuar = input("¿Deseas agregar otro contacto? (s/n): ").lower()
        if continuar != "s":
            print("👋 Fin del programa")
            break
if __name__ == "__main__":
    main()