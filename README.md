# Ejercicio Prácticas Introducción a Físicas 3D 2026

Este repositorio contiene la resolución de los ejercicios prácticos en Unity centrados en la experimentación y configuración de componentes físicos (Rigidbody y Collider).

## Ejercicios realizados

A continuación se detallan los ejercicios resueltos basados en diferentes situaciones físicas con un Plano, un Cubo y una Esfera.
Configuración inicial: Plano, Cubo y Esfera. El plano, y la cámara se ubican en las posiciones por defecto. El cubo se ubica con y=0.5. La esfera con el Transform en la imagen
![Prueba](https://github.com/guillrl1/IIII-Practica-3-Fisicas/blob/main/gifs-parte1/01.png)

### Ejercicio 1: Configuración Física Básica
**Objetivo:** Configurar la escena para que solo el cubo sea afectado por la gravedad y la física, mientras que el plano y la esfera permanecen estáticos.
- **Resolución:** Asignación de componentes `Collider` a todos los objetos. Añadido el componente `Rigidbody` únicamente al Cubo.
- **Prueba de ejecución:** En la siguiente animación se observa cómo el cubo cae hasta chocar con el plano, mientras la esfera se mantiene flotando inmóvil.
![Prueba](https://github.com/guillrl1/IIII-Practica-3-Fisicas/blob/main/gifs-parte1/01_1.png)

### Ejercicio 2: Gravedad en Múltiples Objetos
**Objetivo:** Hacer que tanto el cubo como la esfera reaccionen a la física y colisionen entre sí.
- **Resolución:** Uso del componente `Rigidbody` tanto en el Cubo como en la Esfera. El plano se mantiene solo con `Collider`.
- **Prueba de ejecución:** En la siguiente animación se observa cómo la esfera cae sobre el cubo, y ambos son detenidos por el plano.
![Prueba Ejercicio 2](https://github.com/guillrl1/IIII-Practica-3-Fisicas/blob/main/gifs-parte1/02.gif)

### Ejercicio 3: Objetos Cinemáticos
**Objetivo:** Configurar la esfera para que participe en las físicas (deteniendo otros objetos) pero sin verse afectada por la gravedad o fuerzas.
- **Resolución:** Uso de la propiedad `Is Kinematic` activada en el `Rigidbody` de la Esfera. El cubo mantiene un `Rigidbody` estándar.
- **Prueba de ejecución:** En la siguiente animación se observa cómo el cubo cae con normalidad, mientras la esfera cinemática se queda suspendida en el aire inalterable.
![Prueba Ejercicio 3](https://github.com/guillrl1/IIII-Practica-3-Fisicas/blob/main/gifs-parte1/03.gif)

### Ejercicio 4: Suelo sin anclaje (Caída libre)
**Objetivo:** Comprobar el comportamiento del motor físico cuando el plano que sirve de suelo también actúa como un objeto físico afectado por la gravedad.
- **Resolución:** Asignación del componente `Rigidbody` estándar (sin Kinematic) a los tres objetos: Plano, Cubo y Esfera.
- **Prueba de ejecución:** En la siguiente animación se observa cómo todos los objetos caen al unísono hacia el vacío.
![Prueba Ejercicio 4](https://github.com/guillrl1/IIII-Practica-3-Fisicas/blob/main/gifs-parte1/04.gif)

### Ejercicio 5: Transferencia de Masa (Masa x10)
**Objetivo:** Observar la transferencia de energía en una colisión cuando un objeto tiene una masa considerablemente mayor que otro.
- **Resolución:** El Plano se configura como `Is Kinematic`. La Esfera recibe un `Rigidbody` con el valor de `Mass` en 10, chocando contra el Cubo (Masa = 1).
- **Prueba de ejecución:** En la siguiente animación se observa cómo la esfera empuja de forma brusca al cubo al tener 10 veces su masa.
![Prueba Ejercicio 5](https://github.com/guillrl1/IIII-Practica-3-Fisicas/blob/main/gifs-parte1/05.gif)

### Ejercicio 6: Impacto Extremo (Masa x100)
**Objetivo:** Llevar al extremo la diferencia de masas para ver la respuesta del motor de físicas ante fuerzas desproporcionadas.
- **Resolución:** Modificación del componente `Rigidbody` de la Esfera para que su valor `Mass` sea 100.
- **Prueba de ejecución:** En la siguiente animación se observa cómo el cubo sale despedido a gran velocidad tras recibir el impacto de una esfera con masa 100.
![Prueba Ejercicio 6](https://github.com/guillrl1/IIII-Practica-3-Fisicas/blob/main/gifs-parte1/06.gif)

### Ejercicio 7: Físicas con Fricción
**Objetivo:** Aplicar materiales físicos para añadir fricción a un objeto, manteniendo el plano como objeto físico en caída.
- **Resolución:** Creación de un `Physic Material` con valores de fricción altos, asignado al `Collider` de la Esfera. Todos los objetos tienen `Rigidbody`.
- **Prueba de ejecución:** En la siguiente animación se observa a los objetos caer al vacío de nuevo, sin llegar a apreciarse la fricción al no haber una base estable.
[Prueba Ejercicio 7](https://github.com/guillrl1/IIII-Practica-3-Fisicas/blob/main/gifs-parte1/07_1.png)
![Prueba Ejercicio 7](https://github.com/guillrl1/IIII-Practica-3-Fisicas/blob/main/gifs-parte1/07_2.gif)

### Ejercicio 8: Triggers Cinemáticos
**Objetivo:** Crear un objeto "fantasma" que detecte colisiones (vía código) sin generar respuesta física ni caer por gravedad.
- **Resolución:** Esfera con `Rigidbody` en `Is Kinematic` y su `Collider` con la casilla `Is Trigger` activada. Plano cinemático y cubo físico.
- **Prueba de ejecución:** En la siguiente animación se observa a la esfera flotando y actuando como zona de detección inmaterial, mientras el cubo cae y se detiene en el plano.
![Prueba Ejercicio 8](https://github.com/guillrl1/IIII-Practica-3-Fisicas/blob/main/gifs-parte1/08.gif)

### Ejercicio 9: Triggers Físicos
**Objetivo:** Crear un objeto afectado por la gravedad pero que carece de solidez al impactar con otros.
- **Resolución:** Esfera con `Rigidbody` estándar y su `Collider` con `Is Trigger` activado.
- **Prueba de ejecución:** En la siguiente animación se observa cómo la esfera cae infinitamente traspasando el cubo y el plano como si no existieran, debido a su propiedad Trigger.
![Prueba Ejercicio 9](https://github.com/guillrl1/IIII-Practica-3-Fisicas/blob/main/gifs-parte1/08.gif)
