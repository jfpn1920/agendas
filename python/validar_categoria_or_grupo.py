categoria = input("Ingrese la categoría (familia/trabajo): ")
grupo = input("Ingrese el grupo: ")
if categoria == "familia" or grupo != "":
    print("Categoría o grupo válido")
else:
    print("Debe ingresar categoría válida o grupo")