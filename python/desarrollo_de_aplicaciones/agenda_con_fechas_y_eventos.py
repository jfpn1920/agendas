import flet as ft
def main(page: ft.Page):
    page.title = "Agenda de Eventos"
    page.horizontal_alignment = "center"
    page.scroll = "auto"
    eventos = []
    lista_eventos = ft.Column()
    evento = ft.TextField(label="Nombre del evento", expand=True)
    descripcion = ft.TextField(label="Descripción", multiline=True, expand=True)
    fecha_texto = ft.Text("No hay fecha seleccionada")
    def seleccionar_fecha(e):
        fecha_texto.value = str(e.control.value.date())
        page.update()
    date_picker = ft.DatePicker(on_change=seleccionar_fecha)
    page.overlay.append(date_picker)
    def abrir_calendario(e):
        date_picker.open = True
        page.update()
    boton_fecha = ft.ElevatedButton(
        "Seleccionar fecha",
        icon=ft.Icons.CALENDAR_MONTH,
        on_click=abrir_calendario
    )
    def mostrar_eventos():
        lista_eventos.controls.clear()
        for ev in eventos:
            tarjeta = ft.Card(
                elevation=3,
                content=ft.Container(
                    padding=15,
                    content=ft.Column(
                        [
                            ft.Text(ev["evento"], weight="bold", size=18),
                            ft.Text(f"📅 {ev['fecha']}"),
                            ft.Text(ev["descripcion"])
                        ]
                    )
                )
            )
            lista_eventos.controls.append(tarjeta)
        page.update()
    def agregar_evento(e):
        if evento.value and descripcion.value and fecha_texto.value != "No hay fecha seleccionada":
            nuevo_evento = {
                "evento": evento.value,
                "fecha": fecha_texto.value,
                "descripcion": descripcion.value
            }
            eventos.append(nuevo_evento)
            evento.value = ""
            descripcion.value = ""
            fecha_texto.value = "No hay fecha seleccionada"
            mostrar_eventos()
    boton_agregar = ft.ElevatedButton(
        "Agregar evento",
        icon=ft.Icons.ADD,
        expand=True,
        on_click=agregar_evento
    )
    contenido = ft.Container(
        width=900,
        padding=20,
        content=ft.Column(
            [
                ft.Text("Agenda de Eventos", size=30, weight="bold"),
                ft.ResponsiveRow([
                    ft.Column([evento], col={"xs":12,"sm":12,"md":12})
                ]),
                ft.ResponsiveRow([
                    ft.Column([descripcion], col={"xs":12,"sm":12,"md":12})
                ]),
                ft.ResponsiveRow([
                    ft.Column([boton_fecha], col={"xs":12,"sm":6}),
                    ft.Column([fecha_texto], col={"xs":12,"sm":6})
                ]),
                boton_agregar,
                ft.Divider(),
                ft.Text("Eventos guardados", size=20),
                lista_eventos
            ],
            spacing=20
        )
    )
    page.add(contenido)
ft.run(main)