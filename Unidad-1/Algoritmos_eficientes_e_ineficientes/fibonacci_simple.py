# fibonacci_simple.py
# Versión simple, fácil de ejecutar en Windows o en Replit.
import time
import csv

def fib_recursivo(n):
    """O(2^n). Solo ejecutar para n pequeños (<=35)."""
    if n < 0:
        raise ValueError("n debe ser >= 0")
    if n <= 1:
        return n
    return fib_recursivo(n-1) + fib_recursivo(n-2)

def fib_iterativo(n):
    """O(n). Seguro incluso para n grandes."""
    if n < 0:
        raise ValueError("n debe ser >= 0")
    a, b = 0, 1
    for _ in range(n):
        a, b = b, a + b
    return a

def fib_memo(n, memo=None):
    """O(n) usando memoización (bonus)."""
    if memo is None:
        memo = {}
    if n in memo:
        return memo[n]
    if n <= 1:
        memo[n] = n
        return n
    memo[n] = fib_memo(n-1, memo) + fib_memo(n-2, memo)
    return memo[n]

def main():
    valores_n = [5, 10, 20, 30, 35]   # los n que pide la práctica
    resultados = []

    for n in valores_n:
        # Versión recursiva: solo para n <= 35 (evita que se quede colgado)
        if n <= 35:
            t0 = time.perf_counter()
            rec_val = fib_recursivo(n)
            t1 = time.perf_counter()
            rec_time = t1 - t0
        else:
            rec_val = None
            rec_time = "skipped"

        # Versión iterativa
        t0 = time.perf_counter()
        it_val = fib_iterativo(n)
        t1 = time.perf_counter()
        it_time = t1 - t0

        # Verificación
        coinciden = (rec_val == it_val) if rec_val is not None else "Rec skipped"

        resultados.append({
            "n": n,
            "fibonacci": it_val,
            "recursivo_s": rec_time,
            "iterativo_s": it_time,
            "coinciden": coinciden
        })

    # Mostrar en pantalla (tabla simple)
    print("n\tFibonacci\tRecursivo(s)\tIterativo(s)\tCoinciden")
    for r in resultados:
        print(f"{r['n']}\t{r['fibonacci']}\t{r['recursivo_s']}\t{r['iterativo_s']:.6f}\t{r['coinciden']}")

    # Guardar CSV para que lo puedas abrir en Excel si quieres
    with open("resultados_fib.csv", "w", newline="", encoding="utf-8") as f:
        writer = csv.writer(f)
        writer.writerow(["n", "fibonacci", "recursivo_s", "iterativo_s", "coinciden"])
        for r in resultados:
            writer.writerow([r["n"], r["fibonacci"], r["recursivo_s"], f"{r['iterativo_s']:.6f}", r["coinciden"]])

    print("\nResultados guardados en 'resultados_fib.csv' (puedes abrirlo con Excel).")

if __name__ == "__main__":
    main()
