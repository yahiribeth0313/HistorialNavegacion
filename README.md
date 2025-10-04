# 🌐 Simulador de Historial de Navegación en C#

Este proyecto implementa un **simulador de navegación** con un menú interactivo en consola,  
utilizando **Stack (Pilas)** y **Queue (Colas)** para manejar el historial y páginas en espera.

---

## 🚀 Funcionalidades
- Visitar nuevas páginas (se guardan en el historial).
- Retroceder a la página anterior.
- Agregar páginas en espera.
- Visitar la siguiente página en espera.
- Mostrar historial completo.
- Mostrar páginas en espera.

---

## 🖥 Ejemplo de uso
--- Menú Navegador ---

Visitar nueva página

Ir hacia atrás (Historial)

Agregar página en espera

Visitar siguiente página en espera

Mostrar historial

Mostrar páginas en espera

Salir
Opción: 1
Ingrese la URL de la página: Google.com
Visitando: Google.com

---

## 📂 Estructura del proyecto
HistorialNavegacion/
│── Program.cs # Código principal
│── README.md # Documentación

yaml
Copy code

---

## ⚙️ Ejecución
1. Clona el repositorio:
    ```bash
   git clone https://github.com/yahiribeth0313/HistorialNavegacion.git
Abre el proyecto en Visual Studio o Visual Studio Code.

Ejecuta Program.cs.

📚 Conceptos aplicados
Stack<T> → Control del historial de navegación (última página visitada primero).

Queue<T> → Manejo de páginas en espera (orden FIFO).

Switch/Case → Menú interactivo en consola.

👨‍💻 Autor
Proyecto realizado por Yahiribeth Gonzalez Diaz.
