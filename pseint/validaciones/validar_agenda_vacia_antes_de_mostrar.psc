Algoritmo validar_agenda_vacia_antes_de_mostrar
	Definir contactos Como Cadena
	Definir i, n, contador Como Entero
	n <- 5
	Dimension contactos[n]
	Para i <- 0 Hasta n-1 Hacer
		contactos[i] <- ""
	FinPara
	contador <- 0
	Para i <- 0 Hasta n-1 Hacer
		Si contactos[i] <> "" Entonces
			contador <- contador + 1
		FinSi
	FinPara
	Si contador = 0 Entonces
		Escribir "La agenda está vacía ?"
	SiNo
		Escribir "Contactos en la agenda:"
		Para i <- 0 Hasta n-1 Hacer
			Si contactos[i] <> "" Entonces
				Escribir "- ", contactos[i]
			FinSi
		FinPara
	FinSi
FinAlgoritmo