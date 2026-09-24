# Laboratorio #3: Arquitectura de Clases, Validaciones Avanzadas e Interfaces en C# (.NET) - Herramientas de la Programación Aplicada III
> **Institución:** Universidad Tecnológica de Panamá (UTP) - FISC[cite: 3]  
> **Carrera / Grupo:** Ingeniería en Sistemas Computacionales (III Año) - Grupo 1IL133[cite: 3]  
> **Instructor(a):** Ing. Irina Fong[cite: 3]  
> **Fecha Límite de Entrega:** 31 de agosto de 2026[cite: 3]  
> **Autor:** Alejandro Garcia / 8-10322-677  

## Descripción General
Repositorio oficial que contiene el desarrollo de las actividades del Laboratorio #3, enfocadas en la arquitectura de clases, validaciones defensivas e interfaces en C# (.NET)[cite: 3]. El proyecto aborda la construcción de interfaces gráficas en Windows Forms integrando controles `DataGridView`, `ErrorProvider`, componentes de validación por expresiones regulares (`Regex`), métodos estáticos y clases orientadas a objetos, así como la simulación de lógica de juegos de azar en consola[cite: 3].

---

## Contenido del Laboratorio y Estructura de Casos

### Caso #1: Gestión de Colaboradores en Windows Forms (EjemploGrid)
* **Objetivo:** Diseñar una interfaz gráfica de escritorio interactiva con enlace de datos (Data Binding) hacia colecciones en memoria (`ArrayList`), validaciones robustas de entrada y apoyo de clases utilitarias estáticas[cite: 3].
* **Estructura y Clases de Implementación:**
  * **Entidad `Persona`:** Clase de modelo que define las propiedades automáticas de la entidad (`Id`, `Nombres`, `Apellidos`, `Correo`, `FechaNacimiento` y `Salario`)[cite: 3].
  * **Clase Estática `Utilidades`:** Centraliza métodos helper reutilizables, incluyendo `EstaEnBlanco()` (usando `string.IsNullOrWhiteSpace`) y `EsCorreoValido()` para validación de formato mediante Expresiones Regulares (`Regex`) con el patrón `@"^[^@\s]+@[^@\s]+\.[^@\s]+$"`[cite: 3].
  * **Formulario `Form1`:** 
    * Inicializa la lista de colaboradores en el evento `Form1_Load` y enlaza el origen de datos con `dgvDatos.DataSource`[cite: 3].
    * Aplica validaciones visuales con `ErrorProvider` para asegurar campos obligatorios, selección de fechas mediante `DateTimePicker` y parseo seguro de montos con `decimal.TryParse`[cite: 3].
    * Actualiza dinámicamente la tabla `DataGridView` tras el registro de nuevas personas[cite: 3].
* **Capturas de Ejecución:**

---

### Caso #2: Juego de CRAPS en Consola (CasoJuegoCraps)
* **Objetivo:** Implementar la arquitectura y reglas del juego de Craps aplicando encapsulamiento, generación de números aleatorios (`Random`) y control de estados mediante enumeraciones (`enum`)[cite: 3].
* **Estructura y Clases de Implementación:**
  * **Clase `Craps`:** 
    * Define las enumeraciones privadas `NombreDados` (mapeo de tiros clave como 2, 3, 7, 11, 12) y `Estado` (`CONTINUA`, `GANA`, `PIERDE`)[cite: 3].
    * Método `Jugar()`: Ejecuta el lanzamiento inicial evaluando la victoria o derrota inmediata, o establece el "punto" para continuar iterando lanzamientos mediante un bucle `while` hasta ganar o perder al sacar un 7[cite: 3].
    * Método `LanzarDados()`: Utiliza la clase `Random` para simular el tiro de dos dados independientes y retorna la suma de los valores[cite: 3].
  * **Clase `Program`:** Punto de entrada de la aplicación de consola que instancia la clase `Craps` e inicia la ejecución con `juego.Jugar()`[cite: 3].
* **Capturas de Ejecución:**

---

## Tecnologías y Normas de Desarrollo
* **Lenguaje:** C# (.NET)[cite: 3]
* **Entorno de Desarrollo:** Visual Studio / VS Code[cite: 3]
* **Tipo de Aplicaciones:** Windows Forms (Escritorio) y Aplicación de Consola[cite: 3]
* **Estándares de Estilo:** 
  * PascalCase para nombres de clases, propiedades y métodos (`Persona`, `Utilidades`, `EsCorreoValido`, `LanzarDados`)[cite: 3].
  * camelCase para variables locales, parámetros de métodos e identificadores de controles (`listaPersonas`, `txtNombres`, `dtpFechaNacimiento`)[cite: 3].

## Instrucciones de Ejecución
1. Clona este repositorio en tu equipo local:
   ```bash
   git clone [https://github.com/tu-usuario/Laboratorio-No.3-HPA-III.git](https://github.com/tu-usuario/Laboratorio-No.3-HPA-III.git)
