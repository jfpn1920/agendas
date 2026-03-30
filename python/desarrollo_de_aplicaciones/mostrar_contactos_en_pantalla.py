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
    def mostrar_contactos():
        lista_contactos.controls.clear()
        for c in contactos:
            lista_contactos.controls.append(ft.Text(c))
        page.update()
    def agregar_contacto(e):
        if nombre.value and telefono.value and correo.value:
            contacto = f"{nombre.value} - {telefono.value} - {correo.value}"
            contactos.append(contacto)
            mostrar_contactos()
            nombre.value = ""
            telefono.value = ""
            correo.value = ""
            page.update()
    boton_agregar = ft.ElevatedButton(
        "Agregar contacto",
        expand=True,
        on_click=agregar_contacto
    )
    formulario = ft.Container(
        width=600,
        padding=20,
        content=ft.Column(
            [
                ft.Text("Formulario de Contactos", size=25, weight="bold"),
                ft.ResponsiveRow([
                    ft.Column([nombre], col={"xs":12, "sm":12, "md":12})
                ]),
                ft.ResponsiveRow([
                    ft.Column([telefono], col={"xs":12, "sm":6, "md":6}),
                    ft.Column([correo], col={"xs":12, "sm":6, "md":6})
                ]),
                boton_agregar,
                ft.Divider(),
                ft.Text("Lista de contactos:", size=20),
                lista_contactos
            ],
            spacing=15
        )
    )
    page.add(formulario)
ft.run(main)