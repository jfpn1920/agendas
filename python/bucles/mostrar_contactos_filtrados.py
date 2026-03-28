contactos = [("Ana", "familia"), ("Luis", "trabajo"), ("Carlos", "familia")]
filtro = input("Ingrese la categoría a filtrar (familia/trabajo): ")
print(f"Contactos filtrados por {filtro}:")
for nombre, categoria in contactos:
    if categoria == filtro:
        print("Nombre:", nombre, "- Categoría:", categoria)