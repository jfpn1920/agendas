import flet as ft
import re
def main(page: ft.Page):
    page.title = "Agenda de Contactos"
    page.horizontal_alignment = "center"
    page.scroll = "auto"
    nombre = ft.TextField(label="Nombre", expand=True)
    telefono = ft.TextField(label="Teléfono", expand=True)
    correo = ft.TextField(label="Correo", expand=True)
    buscador = ft.TextField(
        label="Buscar contacto",
        prefix_icon=ft.Icons.SEARCH,
        expand=True
    )
    lista_contactos = ft.Column()
    contactos = []
    indice_editar = None
    def mostrar_mensaje(texto):
        page.snack_bar = ft.SnackBar(ft.Text(texto))
        page.snack_bar.open = True
        page.update()
    def correo_valido(email):
        patron = r"^[\w\.-]+@[\w\.-]+\.\w+$"
        return re.match(patron, email)
    def mostrar_contactos(lista):
        lista_contactos.controls.clear()
        for i, contacto in enumerate(lista):
            fila = ft.Container(
                padding=10,
                border=ft.border.all(1, "#cccccc"),
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
                            alignment="end",
                            col={"xs":12,"sm":4,"md":3}
                        )
                    ]
                )
            )
            lista_contactos.controls.append(fila)
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
        if not nombre.value or not telefono.value or not correo.value:
            mostrar_mensaje("Todos los campos son obligatorios")
            return
        if not telefono.value.isdigit():
            mostrar_mensaje("El teléfono solo debe contener números")
            return
        if not correo_valido(correo.value):
            mostrar_mensaje("Correo no válido")
            return
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
        expand=True,
        on_click=agregar_contacto
    )
    contenido = ft.Container(
        width=900,
        padding=20,
        content=ft.Column(
            [
                ft.Text("Agenda de Contactos", size=25, weight="bold"),
                ft.ResponsiveRow([
                    ft.Column([nombre], col={"xs":12,"sm":12,"md":12})
                ]),
                ft.ResponsiveRow([
                    ft.Column([telefono], col={"xs":12,"sm":6,"md":6}),
                    ft.Column([correo], col={"xs":12,"sm":6,"md":6})
                ]),
                boton_agregar,
                ft.Divider(),
                ft.Text("Buscar contacto", size=20),
                buscador,
                ft.Divider(),
                ft.Text("Lista de contactos", size=20),
                lista_contactos
            ],
            spacing=20
        )
    )
    page.add(contenido)
ft.run(main)