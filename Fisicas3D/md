## Ejercicio 1: Control de Personaje

**Objetivo:** Crear un personaje, controlar su desplazamiento con las teclas WASD o las flechas usando un `Rigidbody`, pero manteniendo el control total. **Resolución:**

- En el archivo `01_Movimiento.cs`, se implementó el movimiento mediante la captura de entrada (`Input.GetAxisRaw`) en el método `Update` para evitar el suavizado por defecto de Unity, logrando un control más directo.  
- El vector de movimiento se normalizó para evitar un aumento de velocidad al moverse en diagonal.  
- En `FixedUpdate`, se aplicó el movimiento usando `rb.MovePosition`, calculando la nueva posición basada en la posición actual, la dirección de movimiento, el tiempo entre frames físicos (`Time.fixedDeltaTime`), y una variable de velocidad configurable desde el inspector.  
- Se configuró el `Rigidbody` en el editor congelando las rotaciones para evitar que la cápsula volcase al moverse.

**Prueba de ejecución:** ![Prueba Ejercicio 1](ruta_gif_1.gif)

## Ejercicio 2: Detección de Colisiones

**Objetivo:** Mostrar por consola el nombre del objeto con el que se colisiona y cambiar su color. **Resolución:**

- El archivo `02_ColisionCambioColor.cs` utiliza el método `OnCollisionEnter` para detectar impactos físicos entre objetos con colliders y al menos un Rigidbody dinámico.  
- Al producirse la colisión, se imprime en consola un mensaje con los nombres de ambos objetos usando `gameObject.name` y `collision.gameObject.name`.  
- Se comprueba que el objeto colisionado no sea el plano base (`collision.gameObject.name != "Plane"`). Si no es el plano, se accede a su componente `Renderer` y se le asigna un nuevo color generado aleatoriamente usando `Random.value` para sus componentes RGB.

**Prueba de ejecución:** ![Prueba Ejercicio 2](ruta_gif_2.gif)

## Ejercicio 3: Interacción mediante Triggers

**Objetivo:** Crear zonas que modifiquen propiedades del personaje al entrar o salir (cambiar color y aumentar daño). **Resolución:**

- En el script `03_InteraccionZonas.cs`, se utilizaron los eventos `OnTriggerEnter` y `OnTriggerExit` para detectar cuándo el personaje (con Rigidbody) atraviesa zonas delimitadas por colliders configurados como `Is Trigger`.  
- Se emplearon etiquetas (`CompareTag`) para diferenciar las zonas.  
- Al entrar en la "ZonaColor", se guarda el color original y se asigna uno aleatorio. Al salir, se restaura el color original.  
- Al entrar en la "ZonaDmg", se incrementa una variable pública de daño y se notifica por consola.

**Prueba de ejecución:** ![Prueba Ejercicio 3](ruta_gif_3.gif)

## Ejercicio 4: Layer Collision Matrix

**Objetivo:** Configurar interacciones entre capas específicas (jugador, enemigos, recolectables) usando la configuración del proyecto. **Resolución:**

- Se crearon las capas (Layers) "Jugador", "Enemigo" y "Recolectable" en el editor de Unity y se asignaron a sus respectivos objetos.  
- En la matriz de colisión de físicas (`Project Settings > Physics`), se configuró para que los "Enemigos" solo colisionasen físicamente con el "Jugador" (y el entorno por defecto), desmarcando las demás intersecciones.  
- La capa "Recolectable" se aisló completamente en la matriz para no registrar colisiones físicas con ninguna otra capa, pero sus objetos se configuraron con colliders `Is Trigger` para que el código del jugador pudiese detectarlos.

**Prueba de ejecución:** ![Prueba Ejercicio 4](ruta_gif_4.gif)

## Ejercicio 5: Materiales Físicos y Fuerzas

**Objetivo:** Aplicar distintos Physic Materials a objetos y observar sus reacciones al aplicarles una fuerza simultánea. **Resolución:**

- Se crearon en el editor de Unity tres `Physic Materials`: Resbaladizo (sin fricción), Rugoso (alta fricción), y Rebote (alta restitución / bounciness). Se asignaron a tres esferas con `Rigidbody`.  
- El archivo `05_Lanzador.cs` aplica una fuerza simultánea a los objetos que lo tienen asignado al pulsar la tecla 'X'.  
- Se utilizó `rb.AddForce(Vector3.forward * fuerza, ForceMode.Impulse)` dentro del `FixedUpdate` (condicionado por un input capturado asíncronamente) para aplicar un empuje instantáneo hacia adelante. Se observa cómo el material físico altera drásticamente el resultado final del movimiento.

**Prueba de ejecución:** ![Prueba Ejercicio 5](ruta_gif_5.gif)

## Ejercicio 6: Movimiento y "Colisiones" sin Física

**Objetivo:** Mover una esfera hacia un cilindro y cambiar el color de un cubo intermedio sin utilizar ningún componente `Rigidbody` en la escena. **Resolución:**

- En el archivo `06_MovimientoSinFisica.cs`, el movimiento se realizó directamente modificando la posición del transform (`transform.position`) usando `Vector3.MoveTowards`, lo que mueve el objeto a una velocidad constante hacia un objetivo, independientemente del motor de físicas.  
- Dado que la ausencia de `Rigidbody` imposibilita el uso de `OnTriggerEnter` o `OnCollisionEnter`, la detección del "impacto" con el obstáculo se simuló matemáticamente en el método `Update`.  
- Se calculó la distancia entre la esfera y el obstáculo (`Vector3.Distance`). Cuando esta distancia es igual o inferior a un umbral (en este caso 1.0f, asumiendo objetos de tamaño 1), se considera que se han tocado y se cambia el material del cubo a rojo. Se utilizó una bandera booleana (`yaColisiono`) para evitar ejecutar el cambio de color continuamente.

**Prueba de ejecución:** ![Prueba Ejercicio 6](ruta_gif_6.gif)
