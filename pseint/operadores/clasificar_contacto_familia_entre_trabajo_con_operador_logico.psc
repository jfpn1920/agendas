Algoritmo clasificar_contacto_familia_entre_trabajo_con_operador_logico
    Definir categoria Como Cadena
    Escribir "Ingrese la categoria (familia o trabajo):"
    Leer categoria
    Si categoria = "familia" Entonces
        Escribir "El contacto pertenece a FAMILIA"
    SiNo
        Si categoria = "trabajo" Entonces
            Escribir "El contacto pertenece a TRABAJO"
        SiNo
            Escribir "Categoria no valida"
        FinSi
    FinSi
FinAlgoritmo