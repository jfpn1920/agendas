import flet as ft
def main(page: ft.Page):
    page.title = "Agenda de Contactos"
    page.horizontal_alignment = "center"
    page.scroll = "auto"
    page.theme_mode = "light"
    contactos = []
    lista_contactos = ft.Column()
    indice_editar = None
    nombre = ft.TextField(label="Nombre", prefix_icon=ft.Icons.PERSON, expand=True)
    telefono = ft.TextField(label="Teléfono", prefix_icon=ft.Icons.PHONE, expand=True)
    correo = ft.TextField(label="Correo", prefix_icon=ft.Icons.EMAIL, expand=True)
    buscador = ft.TextField(
        label="Buscar contacto",
        prefix_icon=ft.Icons.SEARCH,
        expand=True
    )
    def mostrar_contactos(lista):
        lista_contactos.controls.clear()
        for i, contacto in enumerate(lista):
            tarjeta = ft.Card(
                elevation=3,
                content=ft.Container(
                    padding=15,
                    content=ft.ResponsiveRow(
                        [
                            ft.Column(
                                [
                                    ft.Text(contacto["nombre"], weight="bold", size=16),
                                    ft.Text(contacto["telefono"]),
                                    ft.Text(contacto["correo"], color="blue")
                                ],
                                col={"xs":12,"sm":8,"md":9}
                            ),
                            ft.Row(
                                [
                                    ft.IconButton(
                                        icon=ft.Icons.EDIT,
                                        icon_color="blue",
                                        tooltip="Editar",
                                        on_click=lambda e, index=i: editar_contacto(index)
                                    ),
                                    ft.IconButton(
                                        icon=ft.Icons.DELETE,
                                        icon_color="red",
                                        tooltip="Eliminar",
                                        on_click=lambda e, index=i: eliminar_contacto(index)
                                    )
                                ],
                                alignment="end",
                                col={"xs":12,"sm":4,"md":3}
                            )
                        ]
                    )
                )
            )
            lista_contactos.controls.append(tarjeta)
        page.update()
    def buscar_contacto(e):
        texto = buscador.value.lower()
        filtrados = [
            c for c in contactos
            if texto in c["nombre"].lower()
            or texto in c["telefono"]
            or texto in c["correo"].lower()
        ]
        mostrar_contactos(filtrados)
    buscador.on_change = buscar_contacto
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
            mostrar_contactos(contactos)
    def eliminar_contacto(index):
        contactos.pop(index)
        mostrar_contactos(contactos)
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
        icon=ft.Icons.ADD,
        expand=True,
        on_click=agregar_contacto
    )
    contenido = ft.Container(
        width=900,
        padding=25,
        content=ft.Column(
            [
                ft.Text("Agenda de Contactos", size=30, weight="bold"),
                ft.ResponsiveRow([
                    ft.Column([nombre], col={"xs":12,"sm":12,"md":12})
                ]),
                ft.ResponsiveRow([
                    ft.Column([telefono], col={"xs":12,"sm":6,"md":6}),
                    ft.Column([correo], col={"xs":12,"sm":6,"md":6})
                ]),
                boton_agregar,
                ft.Divider(),
                buscador,
                ft.Divider(),
                lista_contactos
            ],
            spacing=20
        )
    )
    page.add(contenido)
ft.run(main)