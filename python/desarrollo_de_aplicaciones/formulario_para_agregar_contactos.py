import flet as ft
def main(page: ft.Page):
    page.title = "Agenda de Contactos"
    page.horizontal_alignment = "center"
    page.scroll = "auto"
    nombre = ft.TextField(label="Nombre", expand=True)
    telefono = ft.TextField(label="Teléfono", expand=True)
    correo = ft.TextField(label="Correo", expand=True)
    lista_contactos = ft.Column()
    contactos = []
    def agregar_contacto(e):
        if nombre.value and telefono.value and correo.value:
            contacto = f"{nombre.value} - {telefono.value} - {correo.value}"
            contactos.append(contacto)
            lista_contactos.controls.append(ft.Text(contacto))
            nombre.value = ""
            telefono.value = ""
            correo.value = ""
            page.update()
    boton_agregar = ft.ElevatedButton(
        "Agregar contacto",
        width=200,
        on_click=agregar_contacto
    )
    contenido = ft.Container(
        width=500,
        padding=20,
        content=ft.Column(
            [
                ft.Text("Formulario de Contactos", size=25, weight="bold"),
                nombre,
                telefono,
                correo,
                boton_agregar,
                ft.Divider(),
                ft.Text("Lista de contactos:", size=20),
                lista_contactos
            ],
            spacing=15
        )
    )
    page.add(contenido)
ft.run(main)