Algoritmo validar_campos_obligatorios
	Definir nombre, telefono, correo Como Cadena
	Definir datosValidos Como Logico
	Repetir
		Escribir "Ingrese nombre:"
		Leer nombre
		Escribir "Ingrese teléfono:"
		Leer telefono
		Escribir "Ingrese correo:"
		Leer correo
		datosValidos <- Verdadero
		Si nombre = "" Entonces
			Escribir "Error: El nombre es obligatorio"
			datosValidos <- Falso
		FinSi
		Si telefono = "" Entonces
			Escribir "Error: El teléfono es obligatorio"
			datosValidos <- Falso
		FinSi
		Si correo = "" Entonces
			Escribir "Error: El correo es obligatorio"
			datosValidos <- Falso
		FinSi
		Si datosValidos = Falso Entonces
			Escribir "Debe completar todos los campos"
		FinSi
	Hasta Que datosValidos = Verdadero
	Escribir "Todos los campos fueron ingresados correctamente ?"
FinAlgoritmo