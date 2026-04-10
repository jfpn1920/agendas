SubProceso ordenar_contactos(nombres, telefonos, correos, n)
	Definir i, j Como Entero
	Definir aux Como Cadena
	Para i <- 1 Hasta n-1 Hacer
		Para j <- 1 Hasta n-1 Hacer
			Si nombres[j] > nombres[j+1] Entonces
				aux <- nombres[j]
				nombres[j] <- nombres[j+1]
				nombres[j+1] <- aux
				aux <- telefonos[j]
				telefonos[j] <- telefonos[j+1]
				telefonos[j+1] <- aux
				aux <- correos[j]
				correos[j] <- correos[j+1]
				correos[j+1] <- aux
			FinSi
		FinPara
	FinPara
FinSubProceso
Algoritmo funcion_para_ordenar_contactos	
	Definir nombres, telefonos, correos Como Cadena
	Definir i, n Como Entero
	Dimension nombres[100]
	Dimension telefonos[100]
	Dimension correos[100]
	n <- 5
	nombres[1] <- "Carlos"
	nombres[2] <- "Ana"
	nombres[3] <- "Luis"
	nombres[4] <- "Pedro"
	nombres[5] <- "Maria"
	telefonos[1] <- "333"
	telefonos[2] <- "111"
	telefonos[3] <- "222"
	telefonos[4] <- "555"
	telefonos[5] <- "444"
	correos[1] <- "c@mail.com"
	correos[2] <- "a@mail.com"
	correos[3] <- "l@mail.com"
	correos[4] <- "p@mail.com"
	correos[5] <- "m@mail.com"
	ordenar_contactos(nombres, telefonos, correos, n)
	Escribir "===== CONTACTOS ORDENADOS ====="
	Para i <- 1 Hasta n Hacer
		Escribir nombres[i], " - ", telefonos[i], " - ", correos[i]
	FinPara
FinAlgoritmo