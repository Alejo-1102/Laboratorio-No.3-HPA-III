# Laboratorio #3: Arquitectura de Clases, Validaciones Avanzadas e Interfaces en C# (.NET) - Herramientas de la Programación Aplicada III
> **Institución:** Universidad Tecnológica de Panamá (UTP) - FISC  
> **Carrera / Grupo:** Ingeniería en Sistemas Computacionales (III Año) - Grupo 1IL133  
> **Instructor(a):** Ing. Irina Fong  
> **Fecha Límite de Entrega:** 31 de agosto de 2026  
> **Autor:** Alejandro Garcia / 8-10322-677  

## Descripción General
Repositorio oficial que contiene el desarrollo de las actividades del Laboratorio #3, enfocadas en la arquitectura de clases, validaciones defensivas e interfaces en C# (.NET). El proyecto aborda la construcción de interfaces gráficas en Windows Forms integrando controles `DataGridView`, `ErrorProvider`, componentes de validación por expresiones regulares (`Regex`), métodos estáticos y clases orientadas a objetos, así como la simulación de lógica de juegos de azar en consola.

---

## Contenido del Laboratorio y Estructura de Casos

### Caso #1: Gestión de Colaboradores en Windows Forms (EjemploGrid)
* **Objetivo:** Diseñar una interfaz gráfica de escritorio interactiva con enlace de datos (Data Binding) hacia colecciones en memoria (`ArrayList`), validaciones robustas de entrada y apoyo de clases utilitarias estáticas.
* **Estructura y Clases de Implementación:**
  * **Entidad `Persona`:** Clase de modelo que define las propiedades automáticas de la entidad (`Id`, `Nombres`, `Apellidos`, `Correo`, `FechaNacimiento` y `Salario`).
  * **Clase Estática `Utilidades`:** Centraliza métodos helper reutilizables, incluyendo `EstaEnBlanco()` (usando `string.IsNullOrWhiteSpace`) y `EsCorreoValido()` para validación de formato mediante Expresiones Regulares (`Regex`) con el patrón `@"^[^@\s]+@[^@\s]+\.[^@\s]+$"`.
  * **Formulario `Form1`:** 
    * Inicializa la lista de colaboradores en el evento `Form1_Load` y enlaza el origen de datos con `dgvDatos.DataSource`.
    * Aplica validaciones visuales con `ErrorProvider` para asegurar campos obligatorios, selección de fechas mediante `DateTimePicker` y parseo seguro de montos con `decimal.TryParse`.
    * Actualiza dinámicamente la tabla `DataGridView` tras el registro de nuevas personas.
* **Capturas de Ejecución:**

---

### Caso #2: Juego de CRAPS en Consola (CasoJuegoCraps)
* **Objetivo:** Implementar la arquitectura y reglas del juego de Craps aplicando encapsulamiento, generación de números aleatorios (`Random`) y control de estados mediante enumeraciones (`enum`).
* **Estructura y Clases de Implementación:**
  * **Clase `Craps`:** 
    * Define las enumeraciones privadas `NombreDados` (mapeo de tiros clave como 2, 3, 7, 11, 12) y `Estado` (`CONTINUA`, `GANA`, `PIERDE`).
    * Método `Jugar()`: Ejecuta el lanzamiento inicial evaluando la victoria o derrota inmediata, o establece el "punto" para continuar iterando lanzamientos mediante un bucle `while` hasta ganar o perder al sacar un 7.
    * Método `LanzarDados()`: Utiliza la clase `Random` para simular el tiro de dos dados independientes y retorna la suma de los valores.
  * **Clase `Program`:** Punto de entrada de la aplicación de consola que instancia la clase `Craps` e inicia la ejecución con `juego.Jugar()`.
* **Capturas de Ejecución:**

---

## Tecnologías y Normas de Desarrollo
* **Lenguaje:** C# (.NET)
* **Entorno de Desarrollo:** Visual Studio / VS Code
* **Tipo de Aplicaciones:** Windows Forms (Escritorio) y Aplicación de Consola
* **Estándares de Estilo:** 
  * PascalCase para nombres de clases, propiedades y métodos (`Persona`, `Utilidades`, `EsCorreoValido`, `LanzarDados`).
  * camelCase para variables locales, parámetros de métodos e identificadores de controles (`listaPersonas`, `txtNombres`, `dtpFechaNacimiento`).

## Instrucciones de Ejecución
1. Clona este repositorio en tu equipo local:
   ```bash
   git clone [https://github.com/tu-usuario/Laboratorio-No.3-HPA-III.git](https://github.com/tu-usuario/Laboratorio-No.3-HPA-III.git)
