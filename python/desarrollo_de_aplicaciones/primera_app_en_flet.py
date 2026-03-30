import flet as ft
def main(page: ft.Page):
    page.title = "Mi primera app en Flet"
    page.bgcolor = "red"
    page.horizontal_alignment = "center"
    page.vertical_alignment = "center"
    page.add(
        ft.Text(
            "Hola, esta es mi primera app en Flet",
            color="white",
            size=30,
            text_align="center"
        )
    )
ft.run(main)