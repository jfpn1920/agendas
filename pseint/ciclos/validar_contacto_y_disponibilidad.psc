Algoritmo validar_contacto_y_disponibilidad
	Definir nombres Como Cadena
	Definir telefonos Como Cadena
	Definir disponible Como Cadena
	Definir i, n Como Entero
	Definir buscar Como Cadena
	Definir encontrado Como Logico
	encontrado <- Falso
	Escribir "¿Cuántos contactos tienes?"
	Leer n
	Dimension nombres[n]
	Dimension telefonos[n]
	Dimension disponible[n]
	Para i <- 0 Hasta n-1 Hacer
		Escribir "Nombre del contacto ", i+1
		Leer nombres[i]
		Escribir "Teléfono"
		Leer telefonos[i]
		Escribir "¿Está disponible? (SI/NO)"
		Leer disponible[i]
	FinPara
	Escribir "Ingrese el nombre del contacto a buscar:"
	Leer buscar
	Para i <- 0 Hasta n-1 Hacer
		Si nombres[i] = buscar Y disponible[i] = "SI" Entonces
			Escribir "Contacto encontrado y disponible:"
			Escribir "Nombre: ", nombres[i]
			Escribir "Teléfono: ", telefonos[i]
			encontrado <- Verdadero
		FinSi
	FinPara
	Si encontrado = Falso Entonces
		Escribir "El contacto no existe o no está disponible"
	FinSi
FinAlgoritmo