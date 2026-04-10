Algoritmo usar_funciones_reutilizables
	Definir nombre1, nombre2 Como Cadena
	MostrarTitulo
	PedirNombre(nombre1)
	MostrarSaludo(nombre1)
	LineaSeparadora
	PedirNombre(nombre2)
	MostrarSaludo(nombre2)
	Pausa
FinAlgoritmo
SubProceso PedirNombre(nombre Por Referencia)
	Repetir
		Escribir "Ingrese un nombre:"
		Leer nombre
	Hasta Que nombre <> ""
FinSubProceso
SubProceso MostrarSaludo(nombre)
	Escribir "Hola ", nombre, " ??"
FinSubProceso
SubProceso MostrarTitulo
	Escribir "=============================="
	Escribir "   FUNCIONES REUTILIZABLES"
	Escribir "=============================="
FinSubProceso
SubProceso LineaSeparadora
	Escribir "------------------------------"
FinSubProceso
SubProceso Pausa
	Definir tecla Como Cadena
	Escribir "Presione ENTER para continuar..."
	Leer tecla
FinSubProceso