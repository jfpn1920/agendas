Algoritmo validar_categoria_por_grupo
    Definir categoria Como Cadena
    Escribir "Ingrese la categoria (familia, amigos o trabajo):"
    Leer categoria
    Si categoria = "familia" O categoria = "amigos" O categoria = "trabajo" Entonces
        Escribir "Categoria valida"
    SiNo
        Escribir "Categoria no valida"
    FinSi
FinAlgoritmo