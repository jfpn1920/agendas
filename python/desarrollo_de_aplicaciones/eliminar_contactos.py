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
        for i, contacto in enumerate(contactos):
            fila = ft.Row(
                [
                    ft.Text(
                        f"{contacto['nombre']} - {contacto['telefono']} - {contacto['correo']}",
                        expand=True
                    ),
                    ft.IconButton(
                        icon=ft.Icons.DELETE,
                        icon_color="red",
                        on_click=lambda e, index=i: eliminar_contacto(index)
                    )
                ]
            )
            lista_contactos.controls.append(fila)
        page.update()
    def agregar_contacto(e):
        if nombre.value and telefono.value and correo.value:
            contacto = {
                "nombre": nombre.value,
                "telefono": telefono.value,
                "correo": correo.value
            }
            contactos.append(contacto)
            nombre.value = ""
            telefono.value = ""
            correo.value = ""
            mostrar_contactos()
    def eliminar_contacto(index):
        contactos.pop(index)
        mostrar_contactos()
    boton_agregar = ft.ElevatedButton(
        "Agregar contacto",
        expand=True,
        on_click=agregar_contacto
    )
    contenido = ft.Container(
        width=800,
        padding=20,
        content=ft.Column(
            [
                ft.Text("Formulario de Contactos", size=25, weight="bold"),
                ft.ResponsiveRow([
                    ft.Column([nombre], col={"xs":12,"sm":12,"md":12,"lg":12})
                ]),
                ft.ResponsiveRow([
                    ft.Column([telefono], col={"xs":12,"sm":6,"md":6,"lg":6}),
                    ft.Column([correo], col={"xs":12,"sm":6,"md":6,"lg":6})
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