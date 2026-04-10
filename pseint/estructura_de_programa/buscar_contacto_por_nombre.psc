Algoritmo buscar_contacto_por_nombre
	Definir nombres Como Cadena
	Definir i, n Como Entero
	Definir buscar Como Cadena
	Definir encontrado Como Logico
	n <- 3
	Dimension nombres[n]
	Para i <- 0 Hasta n-1 Hacer
		Repetir
			Escribir "Ingrese nombre del contacto ", i+1, ":"
			Leer nombres[i]
		Hasta Que nombres[i] <> ""
	FinPara
	Escribir "------------------------------"
	Escribir "Ingrese el nombre a buscar:"
	Leer buscar
	encontrado <- Falso
	Para i <- 0 Hasta n-1 Hacer
		Si nombres[i] = buscar Entonces
			encontrado <- Verdadero
		FinSi
	FinPara
	Si encontrado Entonces
		Escribir "Contacto encontrado ?"
	SiNo
		Escribir "Contacto no existe ?"
	FinSi
FinAlgoritmo