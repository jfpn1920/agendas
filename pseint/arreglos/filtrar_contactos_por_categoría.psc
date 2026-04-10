Algoritmo filtrar_contactos_por_categoría
	Definir nombres Como Cadena
	Definir telefonos Como Cadena
	Definir categoria Como Cadena
	Definir i, n Como Entero
	Definir filtro Como Cadena
	Definir encontrado Como Logico
	Dimension nombres[100]
	Dimension telefonos[100]
	Dimension categoria[100]
	n <- 5
	nombres[0] <- "Ana"
	nombres[1] <- "Luis"
	nombres[2] <- "Carlos"
	nombres[3] <- "Maria"
	nombres[4] <- "Pedro"
	telefonos[0] <- "111"
	telefonos[1] <- "222"
	telefonos[2] <- "333"
	telefonos[3] <- "444"
	telefonos[4] <- "555"
	categoria[0] <- "Familia"
	categoria[1] <- "Trabajo"
	categoria[2] <- "Amigos"
	categoria[3] <- "Familia"
	categoria[4] <- "Trabajo"
	encontrado <- Falso
	Escribir "Ingrese la categoría a filtrar (Familia, Trabajo, Amigos):"
	Leer filtro
	Escribir "Contactos en la categoría ", filtro, ":"
	Para i <- 0 Hasta n-1 Hacer
		Si categoria[i] = filtro Entonces
			Escribir "Nombre: ", nombres[i]
			Escribir "Teléfono: ", telefonos[i]
			Escribir "Categoría: ", categoria[i]
			Escribir "--------------------"
			encontrado <- Verdadero
		FinSi
	FinPara
	Si encontrado = Falso Entonces
		Escribir "No se encontraron contactos en esa categoría"
	FinSi
FinAlgoritmo