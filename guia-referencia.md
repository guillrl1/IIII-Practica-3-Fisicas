## Guía de Referencia Rápida de Unity

Durante esta práctica se han utilizado los siguientes componentes y clases fundamentales de la API de Unity:

### [`Vector3`](https://docs.unity3d.com/ScriptReference/Vector3.html)
Es una estructura matemática que representa puntos y direcciones en un espacio 3D mediante tres coordenadas (X, Y, Z).
- **[`new Vector3(x, y, z)`](https://docs.unity3d.com/ScriptReference/Vector3-ctor.html)**: Constructor para crear un vector desde cero.
- **[`.magnitude`](https://docs.unity3d.com/ScriptReference/Vector3-magnitude.html)**: Propiedad que devuelve la longitud total del vector (la distancia desde el origen 0,0,0 hasta su punto final).
- **[`.normalized`](https://docs.unity3d.com/ScriptReference/Vector3-normalized.html)**: Propiedad que devuelve el mismo vector manteniendo su dirección, pero reduciendo su magnitud (longitud) exactamente a 1. Vital para mantener velocidades constantes.
- **[`Vector3.Distance(A, B)`](https://docs.unity3d.com/ScriptReference/Vector3.Distance.html)**: Método estático que calcula la distancia real entre dos posiciones.
- **[`Vector3.Angle(A, B)`](https://docs.unity3d.com/ScriptReference/Vector3.Angle.html)**: Método que calcula el ángulo más corto entre dos vectores.
- **[`Vector3.MoveTowards(actual, objetivo, pasoMaximo)`](https://docs.unity3d.com/ScriptReference/Vector3.MoveTowards.html)**: Calcula un punto intermedio para acercarse gradualmente a un objetivo sin sobrepasarlo. Ideal para mover objetos cuando no se usan físicas.
- **[`Vector3.forward`, `.up`, `.right`, etc.](https://docs.unity3d.com/ScriptReference/Vector3-forward.html)**: Atajos rápidos del sistema (ej. `Vector3.forward` equivale a `new Vector3(0, 0, 1)`).

### [`Transform`](https://docs.unity3d.com/ScriptReference/Transform.html)
El componente más importante de Unity. Todos los GameObjects tienen uno. Controla la Posición, Rotación y Escala del objeto en el mundo. Se accede a él en los scripts escribiendo `transform` (en minúscula).
- **[`.position`](https://docs.unity3d.com/ScriptReference/Transform-position.html)**: Almacena y permite modificar la posición global del objeto (es un Vector3).
- **[`.forward`](https://docs.unity3d.com/ScriptReference/Transform-forward.html)**: Devuelve un Vector3 normalizado que apunta hacia donde está mirando el eje Z positivo (el frente) del objeto en ese instante.
- **[`.Translate(vector, espacio)`](https://docs.unity3d.com/ScriptReference/Transform.Translate.html)**: Método que desplaza el objeto gradualmente. Puede ejecutarse usando el espacio local (`Space.Self`) o el espacio mundial (`Space.World`).
- **[`.Rotate(x, y, z)`](https://docs.unity3d.com/ScriptReference/Transform.Rotate.html)**: Método que hace rotar al objeto sobre sus propios ejes.
- **[`.LookAt(objetivo)`](https://docs.unity3d.com/ScriptReference/Transform.LookAt.html)**: Método que rota instantáneamente el objeto para que su eje frontal apunte directamente hacia la posición (Transform) de otro objeto.

### [`Input`](https://docs.unity3d.com/ScriptReference/Input.html)
La clase encargada de gestionar las entradas del jugador (teclado, ratón, mandos).
- **[`.GetAxis("NombreEje")`](https://docs.unity3d.com/ScriptReference/Input.GetAxis.html)**: Lee un eje configurado en el Input Manager. Devuelve un valor decimal suave entre -1 y 1. Ideal para joysticks o movimiento fluido.
- **[`.GetAxisRaw("NombreEje")`](https://docs.unity3d.com/ScriptReference/Input.GetAxisRaw.html)**: Ignora el suavizado y devuelve valores enteros al instante (-1, 0, 1). Fundamental para lograr un "control total" o respuesta inmediata (estilo arcade).
- **[`.GetButtonDown("NombreBoton")`](https://docs.unity3d.com/ScriptReference/Input.GetButtonDown.html)**: Devuelve `true` únicamente en el frame exacto en el que el jugador presiona el botón. No se repite si se mantiene pulsado.
- **[`.GetKey(KeyCode.Tecla)`](https://docs.unity3d.com/ScriptReference/Input.GetKey.html)**: Detecta directamente hardware físico. Devuelve `true` de forma continua mientras la tecla especificada se mantenga presionada.
- **[`.GetKeyDown(KeyCode.Tecla)`](https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html)**: Detecta el frame exacto en el que se pulsa una tecla de teclado físico (ej. usado con `KeyCode.X` para aplicar impulsos precisos).

### Tiempos y Ciclos de Ejecución
- **[`Time.deltaTime`](https://docs.unity3d.com/ScriptReference/Time-deltaTime.html)**: Tiempo en segundos que tardó el último fotograma (frame). Se multiplica en el `Update()` para independizar la velocidad del juego de los FPS de la tarjeta gráfica.
- **[`Time.fixedDeltaTime`](https://docs.unity3d.com/ScriptReference/Time-fixedDeltaTime.html)**: El intervalo de tiempo de cálculo para las físicas (por defecto 0.02s). Se usa cuando multiplicamos valores matemáticos dentro de `FixedUpdate`.
- **[`FixedUpdate()`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.FixedUpdate.html)**: Método del ciclo de vida de Unity. A diferencia del `Update` (que corre a ritmo libre según los gráficos), este corre a un ritmo temporal inalterable y constante. **Toda modificación a los componentes de físicas debe realizarse siempre aquí.**

### Físicas y Colisiones
- **[`Rigidbody`](https://docs.unity3d.com/ScriptReference/Rigidbody.html)**: El componente que convierte a un objeto en un ente físico afectado por las leyes naturales (gravedad, masa).
  - **[`.velocity`](https://docs.unity3d.com/ScriptReference/Rigidbody-velocity.html)**: Permite leer o sobreescribir de forma drástica y directa la velocidad lineal (Vector3) del objeto.
  - **[`.AddForce(vector, ForceMode)`](https://docs.unity3d.com/ScriptReference/Rigidbody.AddForce.html)**: Aplica empuje físico de manera realista. `ForceMode.Impulse` aplica toda la fuerza en un instante (explosiones, saltos).
  - **[`.MovePosition(posicion)`](https://docs.unity3d.com/ScriptReference/Rigidbody.MovePosition.html)**: Mueve el objeto respetando las colisiones con el entorno de manera mucho más estable y natural que alterando el `transform.position`.
  - **[`.isKinematic`](https://docs.unity3d.com/ScriptReference/Rigidbody-isKinematic.html)**: Propiedad booleana; si es verdadera, el objeto ignora la gravedad y otros golpes, pero puede mover u obstruir a los demás objetos físicos.
- **Eventos de Impacto**:
  - **[`OnCollisionEnter(Collision)`](https://docs.unity3d.com/ScriptReference/Collider.OnCollisionEnter.html)**: Se dispara al inicio de un choque sólido. Recibe la clase `Collision`, que contiene datos sobre el choque y permite acceder al objeto impactado con `.gameObject`.
  - **[`OnTriggerEnter(Collider)`](https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html) / [`OnTriggerExit`](https://docs.unity3d.com/ScriptReference/Collider.OnTriggerExit.html)**: Se disparan al entrar y salir de un Collider configurado como "zona fantasma" (`Is Trigger`). Recibe directamente el `Collider` que ha atravesado la zona.
- **Identificación Rápida**:
  - **[`.CompareTag("Etiqueta")`](https://docs.unity3d.com/ScriptReference/Component.CompareTag.html)**: Es la forma más optimizada y recomendada para verificar si el objeto con el que hemos chocado es un enemigo, el suelo o un recolectable (ej. `other.CompareTag("Enemigo")`). Evita depender del nombre exacto del objeto.

### Renderizado y Apariencia
- **[`Renderer`](https://docs.unity3d.com/ScriptReference/Renderer.html)**: Componente encargado de dibujar la malla 3D en pantalla. 
- **[`.material.color`](https://docs.unity3d.com/ScriptReference/Material-color.html)**: Permite modificar el color del material principal del objeto en tiempo de ejecución.
- **[`Color`](https://docs.unity3d.com/ScriptReference/Color.html)**: Estructura que maneja valores RGBA (rojo, verde, azul, alfa).
- **[`Random.value`](https://docs.unity3d.com/ScriptReference/Random-value.html)**: Devuelve un valor fraccionario al azar entre 0.0 y 1.0. Muy útil para introducir variabilidad o generar colores RGB aleatorios al instante (`new Color(Random.value, Random.value, Random.value)`).
