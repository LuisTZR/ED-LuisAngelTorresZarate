Ejercicio 2 — Red de computadoras

a) ¿Cuántos vértices y aristas tiene?

Vértices (n): Router, Servidor, Switch1, Switch2, PC1, PC2, PC3, PC4, Impresora1, Impresora2 → 10 vértices

Aristas (m):

Router-Servidor

Router-Switch1

Router-Switch2

Switch1-PC1, Switch1-PC2, Switch1-Impresora1

Switch2-PC3, Switch2-PC4, Switch2-Impresora2
Total 9 aristas.

b) ¿Es conexo? ¿Qué significa esto para la red?

Sí, el grafo es conexo: hay un camino entre cualquier par de dispositivos. Desde cualquier equipo se puede comunicarse (a través del Router y switches) con cualquier otro equipo de la red.

c) ¿Es un árbol? Justifica

Un árbol no dirigido debe ser conexo y tener exactamente n-1 aristas. Aquí n=10, n-1=9 y m=9. Además no hay ciclos (no existen enlaces redundantes entre switches/servidor), por tanto sí es un árbol.

d) Si se desconecta el Router, ¿cuántas componentes conexas quedan?

Al quitar el Router se eliminan las aristas Router-Servidor, Router-Switch1 y Router-Switch2. Quedan:
Componente 1: Servidor (aislado).
Componente 2: Switch1 + PC1 + PC2 + Impresora1.
Componente 3: Switch2 + PC3 + PC4 + Impresora2.

Total: 3 componentes conexas.

e) ¿Cuál es el dispositivo más crítico de la red?

El Router. Si falla, divide la red en 3 componentes y muchos dispositivos quedan aislados entre sí.
