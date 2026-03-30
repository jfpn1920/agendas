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
            contacto = {
                "nombre": nombre.value,
                "telefono": telefono.value,
                "correo": correo.value
            }
            contactos.append(contacto)
            lista_contactos.controls.append(
                ft.Text(f"{contacto['nombre']} - {contacto['telefono']} - {contacto['correo']}")
            )
            nombre.value = ""
            telefono.value = ""
            correo.value = ""
            lista_contactos.update()
            page.update()
    boton_agregar = ft.ElevatedButton(
        "Agregar contacto",
        expand=True,
        on_click=agregar_contacto
    )
    contenido = ft.Container(
        width=700,
        padding=20,
        content=ft.Column(
            [
                ft.Text("Formulario de Contactos", size=25, weight="bold"),
                ft.ResponsiveRow([
                    ft.Column([nombre], col={"xs": 12, "sm": 12, "md": 12})
                ]),
                ft.ResponsiveRow([
                    ft.Column([telefono], col={"xs": 12, "sm": 6, "md": 6}),
                    ft.Column([correo], col={"xs": 12, "sm": 6, "md": 6})
                ]),
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