SubProceso agenda_reutilizable(nombres, telefonos, correos, categoria, n, opcion)
	Definir i Como Entero
	Definir buscar, filtro Como Cadena
	Segun opcion Hacer
		1:
			Escribir "===== MOSTRAR AGENDA ====="
			Para i <- 1 Hasta n Hacer
				Escribir nombres[i], " - ", telefonos[i], " - ", correos[i]
			FinPara
		2:
			Escribir "Ingrese el nombre a buscar:"
			Leer buscar
			Para i <- 1 Hasta n Hacer
				Si nombres[i] = buscar Entonces
					Escribir "Encontrado: ", nombres[i], " - ", telefonos[i], " - ", correos[i]
				FinSi
			FinPara
		3:
			Escribir "Ingrese categoria a filtrar:"
			Leer filtro
			Para i <- 1 Hasta n Hacer
				Si categoria[i] = filtro Entonces
					Escribir nombres[i], " - ", telefonos[i], " - ", correos[i]
				FinSi
			FinPara
		De Otro Modo:
			Escribir "Opcion invalida"
			
	FinSegun
FinSubProceso
Algoritmo funcion_reutilizable_de_agenda
	Definir nombres, telefonos, correos, categoria Como Cadena
	Definir n, opcion Como Entero
	Dimension nombres[100]
	Dimension telefonos[100]
	Dimension correos[100]
	Dimension categoria[100]
	n <- 4
	nombres[1] <- "Ana"
	nombres[2] <- "Luis"
	nombres[3] <- "Carlos"
	nombres[4] <- "Maria"
	telefonos[1] <- "111"
	telefonos[2] <- "222"
	telefonos[3] <- "333"
	telefonos[4] <- "444"
	correos[1] <- "a@mail.com"
	correos[2] <- "l@mail.com"
	correos[3] <- "c@mail.com"
	correos[4] <- "m@mail.com"
	categoria[1] <- "Familia"
	categoria[2] <- "Trabajo"
	categoria[3] <- "Amigos"
	categoria[4] <- "Familia"
	Escribir "===== MENU AGENDA ====="
	Escribir "1. Mostrar agenda"
	Escribir "2. Buscar contacto"
	Escribir "3. Filtrar por categoria"
	Escribir "Seleccione opcion:"
	Leer opcion
	agenda_reutilizable(nombres, telefonos, correos, categoria, n, opcion)
FinAlgoritmo