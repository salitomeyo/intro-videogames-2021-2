# Clase #2

## Contenido

- Manejo de la memoria.
  - Manejo de la memoria en game engines.
  - Stack, Heap y Garbage collector.
- GameLoop y GameObjects en game engines.
- GameLoop y GameObjects en Unity.
  - GameObject y Transform
  - Components
- Basic Movement en Unity

## Taller

### Fecha de entrega
> Miércoles 27 de Octubre, 11:59 pm (media noche).

### Descripción
- Clone el [repositorio](https://github.com/UNAL-IntroVideojuegos-2021-2/intro-videogames-2021-2).
- Cree una nueva rama a partir del branch `sessions/session-2` con el siguiente formato: `student/[usuario-unal]/session-2`
```
 Ejemplo: Si su correo es pedrito@unal.edu.co, la rama para hacer la entrega de la clase 2 debe ser `student/pedrito/session-2`.
```
- Ubique y abra el proyecto de Unity.
- Revise y juegue con el código `PlayerBasicMovement`.
- Responda las siguientes preguntas:
  - Cuál es la diferencia entre `Input.GetAxis` y `Input.GetAxisRaw`?
Respuesta: usando el comando "Debug.Log", se observo que la principal diferencia entre `Input.GetAxis` y `Input.GetAxisRaw` es que el primero da un valor continuo entre -1 y 1 sin omitir cifras decimales, mientras que `Input.GetAxisRaw` solo muestra -1, 0 o 1.
  - Cuál se deberia usar? (Pregunta capciosa...).
Respuesta: Depende del uso que se le desee dar, por ejemplo si se usa `Input.GetAxis` se podroa implementar por ejemplo a un joistick, mientras que el segundo, si o si siempre da -1 o 1, por lo tanto siempre es la misma magnitud de movimiento.
  - Qué hace `input.magnitude`? Por qué es util?
Respuesta: input magnitude nos da la magnitud del vector (horizontal,0,vertical), es decir, si por ejemplo nos movemos de derecha a izquierda o viceversa siempre obtendermos un valor positivo, y si nos movemos de forma diagonal, se obtiene raiz de 2 positivo, es util en el codigo ya que nos permite saber si hay movimiento o no, independientemente de la dirección.
  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?
Respuesta: Normalizar un vector significa dividir el vector por si magnitud, lo cual garantiza que la longitud de este sea de uno, esto es util en movimiento debido a que asegura que el personaje siempre se va a mover una unidad si se mueve de manera diagonal, lo cual facilita calculos.
- **Reto (Opcional):** Implementar una mécanica de dash en base al código dado.

### Como hacer la entrega:
- Edite el [README de la clase 2](https://github.com/UNAL-IntroVideojuegos-2021-2/intro-videogames-2021-2/blob/main/Clase2/README.md) para agreguar las respuestas a las preguntas. Por favor que sean respuestas cortas y concisas. Puede ser en Español o Ingles.
- Haga PR al branch `sessions/session-2`. 
- Para el nombre del PR usar el mensaje: `Solución Taller 2 by [usuario-unal]`. 
```
 Ejemplo: Si su correo es pedrito@unal.edu.co, el título del PR debe ser: `Solución Taller 2 by pedrito`.
```
- En la descripción del PR puede escribir lo que considere pertinente (aclaraciones, dudas, comentarios...).

## NOTA!!!!!!!!!
**Si no tiene permisos para: clonar el repositorio, crear una nueva branch, hacer Pull, hacer Push, hacer Pull Request, o cualquier otro inconveniente relacionado al repositorio, por favor contactenos para resolver el problema lo mas pronto posible!!!!**