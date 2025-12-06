Ejercicio 1 — Sistema de vuelos

a) ¿Es dirigido o no dirigido? ¿Es ponderado?

Es dirigido (cada vuelo es solo de ida: A → B).

Es ponderado (cada arista tiene un precio/valor).

b) Grados de entrada y salida (directed degree)

Lista de ciudades: México, Cancún, Monterrey, Houston, Miami.

Ciudad	Grado salida (out)	Grado entrada (in)
México	2 (→ Cancún, Monterrey)	1 (← Miami)
Cancún	1 (→ Miami)	1 (← México)
Monterrey	1 (→ Houston)	1 (← México)
Houston	1 (→ Miami)	1 (← Monterrey)
Miami	1 (→ México)	2 (← Cancún, Houston)
c) ¿Cuál ciudad tiene más vuelos salientes?

México tiene más vuelos salientes (2).

d) Ruta más barata de México a Miami

La ruta más barata es México → Cancún → Miami con costo $5000.

e) ¿Existe algún ciclo? Si sí, descríbelo

Sí hay ciclos porque existe un vuelo Miami → México, lo que permite volver al inicio:

Ejemplos de ciclos:

México → Cancún → Miami → México (ciclo 3 nodos).

México → Monterrey → Houston → Miami → México (ciclo 4 nodos).
