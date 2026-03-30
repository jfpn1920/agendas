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
    indice_editar = None
    def mostrar_contactos():
        lista_contactos.controls.clear()
        for i, contacto in enumerate(contactos):
            fila = ft.Container(
                padding=10,
                border=ft.border.all(1, "#dddddd"),
                border_radius=10,
                content=ft.ResponsiveRow(
                    [
                        ft.Column(
                            [
                                ft.Text(
                                    f"{contacto['nombre']} - {contacto['telefono']} - {contacto['correo']}"
                                )
                            ],
                            col={"xs":12,"sm":8,"md":9}
                        ),
                        ft.Row(
                            [
                                ft.IconButton(
                                    icon=ft.Icons.EDIT,
                                    icon_color="blue",
                                    on_click=lambda e, index=i: editar_contacto(index)
                                ),
                                ft.IconButton(
                                    icon=ft.Icons.DELETE,
                                    icon_color="red",
                                    on_click=lambda e, index=i: eliminar_contacto(index)
                                )
                            ],
                            col={"xs":12,"sm":4,"md":3},
                            alignment="end"
                        )
                    ]
                )
            )
            lista_contactos.controls.append(fila)
        page.update()
    def agregar_contacto(e):
        nonlocal indice_editar
        if nombre.value and telefono.value and correo.value:
            if indice_editar is None:
                contacto = {
                    "nombre": nombre.value,
                    "telefono": telefono.value,
                    "correo": correo.value
                }
                contactos.append(contacto)
            else:
                contactos[indice_editar]["nombre"] = nombre.value
                contactos[indice_editar]["telefono"] = telefono.value
                contactos[indice_editar]["correo"] = correo.value
                indice_editar = None
                boton_agregar.text = "Agregar contacto"
            nombre.value = ""
            telefono.value = ""
            correo.value = ""
            mostrar_contactos()
    def eliminar_contacto(index):
        contactos.pop(index)
        mostrar_contactos()
    def editar_contacto(index):
        nonlocal indice_editar
        contacto = contactos[index]
        nombre.value = contacto["nombre"]
        telefono.value = contacto["telefono"]
        correo.value = contacto["correo"]
        indice_editar = index
        boton_agregar.text = "Guardar cambios"
        page.update()
    boton_agregar = ft.ElevatedButton(
        "Agregar contacto",
        expand=True,
        on_click=agregar_contacto
    )
    contenido = ft.Container(
        width=900,
        padding=20,
        content=ft.Column(
            [
                ft.Text("Formulario de Contactos", size=25, weight="bold"),
                ft.ResponsiveRow([
                    ft.Column([nombre], col={"xs":12,"sm":12,"md":12})
                ]),
                ft.ResponsiveRow([
                    ft.Column([telefono], col={"xs":12,"sm":6,"md":6}),
                    ft.Column([correo], col={"xs":12,"sm":6,"md":6})
                ]),
                boton_agregar,
                ft.Divider(),
                ft.Text("Lista de contactos:", size=20),
                lista_contactos
            ],
            spacing=20
        )
    )
    page.add(contenido)
ft.run(main)