Ejercicio 3 — Materias y prerrequisitos (ejemplo)
a) Descripción del problema

Se modelarom las materias de un ciclo de la carrera y los prerrequisitos. Se quiere visualizar qué materias se requieren antes de cursar otras y responder preguntas como "¿qué materias debo aprobar para tomar Bases de Datos?".

b) Qué representa cada vértice

Cada vértice es una materia:

Matemáticas
Programación I
Programación II
Estructuras de Datos
Algoritmos
Bases de Datos
Sistemas Operativos

c) Qué representa cada arista

Una arista dirigida A -> B significa: A es prerrequisito de B (debe cursarse A antes de B).

Lista de aristas (prerrequisitos)

Matemáticas -> Programación I
Programación I -> Programación II
Programación II -> Estructuras de Datos
Estructuras de Datos -> Algoritmos
Algoritmos -> Bases de Datos
Programación II -> Sistemas Operativos
Matemáticas -> Estructuras de Datos
Estructuras de Datos -> Bases de Datos

d) Análisis: grados, conexidad, ciclos

Grados (out/in):

Materia	out (salientes)	in (entrantes)
Matemáticas	2 (→ Prog I, → Estructuras)	0
Programación I	1 (→ Prog II)	1 (← Matemáticas)
Programación II	2 (→ Estructuras, → Sist. Op)	1 (← Prog I)
Estructuras de Datos	2 (→ Algoritmos, → BD)	2 (← Prog II, ← Matemáticas)
Algoritmos	1 (→ Bases de Datos)	1 (← Estructuras)
Bases de Datos	0	2 (← Algoritmos, ← Estructuras)
Sistemas Operativos	0	1 (← Programación II)

Conexidad:

Como grafo dirigido no es fuertemente conexo. Si consideramos el grafo sin dirección, sí es conexo: todas las materias están conectadas a través de la relación prereq.

Ciclos:

No hay ciclos en este modelo, que es lo esperado para prerrequisitos.

e) Pregunta interesante respondida

Pregunta: ¿Cuál es la cadena mínima de prerrequisitos para llegar a "Bases de Datos"?

Rutas posibles (dirigidas) a Bases de Datos:
Matemáticas → Estructuras → Bases de Datos (2 aristas)
Matemáticas → Programación I → Programación II → Estructuras → Bases de Datos (4 aristas)
La cadena mínima (menos aristas) es: Matemáticas → Estructuras de Datos → Bases de Datos (2 pasos).
