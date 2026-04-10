Funcion total <- contar_contactos(nombres, n)
	Definir i Como Entero
	Definir total Como Entero
	total <- 0
	Para i <- 1 Hasta n Hacer
		total <- total + 1
	FinPara
FinFuncion
Algoritmo funcion_para_contar_contactos	
	Definir nombres Como Cadena
	Definir n, resultado Como Entero
	Dimension nombres[100]
	n <- 4
	nombres[1] <- "Ana"
	nombres[2] <- "Luis"
	nombres[3] <- "Carlos"
	nombres[4] <- "Maria"
	resultado <- contar_contactos(nombres, n)
	Escribir "Total de contactos: ", resultado
FinAlgoritmo