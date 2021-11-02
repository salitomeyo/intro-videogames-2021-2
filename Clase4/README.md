# Clase #4

## Contenido

- Showcase/Demo: Sistema solar.
  - Instantiate e impacto en frame rate.
  - Gizmos y ajustes en código.
  - Impacto y problemas en performance.
- Movemiento tercera persona
  - Estructura Player.
  - Un poco de arquitectura: composición de sistemas.
  - Rotación y Quaternion.
  - Introducción a Raycast.

## Taller

### Fecha de entrega
> Lunes 8 de Noviembre - 11:59 pm (media noche del lunes).

### Descripción
**Parte 1: Rotación cuando no hay input**
- Re-activar que el player mire en la dirección del movimiento: En el script Player, descomentar la [linea 34](https://github.com/UNAL-IntroVideojuegos-2021-2/intro-videogames-2021-2/blob/main/Unity/intro-videojuegos-app-2021-2/Assets/Scr/Player/Player.cs#L34) y commentar la [linea 45](https://github.com/UNAL-IntroVideojuegos-2021-2/intro-videogames-2021-2/blob/main/Unity/intro-videojuegos-app-2021-2/Assets/Scr/Player/Player.cs#L45).
- Agregar la lógica necesaria para que, al no oprimir Input de movimiento, el Player no regrese a la rotación por defecto. En cambio, debe quedar con la ultima rotación que se aplico mientras aun se estaba movimiendo.

**Parte 2: Character Controller**
- Duplique la escena `Shooter`. Nombre la nueva escena `CharacterControllerMovement`.
  - Use `Ctrl + D` para duplicar la escena. Esto para asegurar que cualquier referencia externa sea copiada también.
- Cree un nuevo script llamado `PlayerCharMovementController` en la carpeta correspiondiente.
- En la escena `CharacterControllerMovement`, en el objeto `Player`:
  - Remueva el componente `Rigidbody`. En su lugar añada el componente `CharacterController`.
  - Remuena el componente `PlayerMovementController`. En su lugar añada el componente `PlayerCharMovementController`.
- Cree el codigo necesario para que el script `PlayerCharMovementController` ejecute el movimiento del jugador usando `CharacterController` en vez de `Rigidbody`.
  - En el script `Player` **SOLO** debe cambiar el tipo de la variable `_movementController` ([linea 12](https://github.com/UNAL-IntroVideojuegos-2021-2/intro-videogames-2021-2/blob/main/Unity/intro-videojuegos-app-2021-2/Assets/Scr/Player/Player.cs#L12)). Esto implica, que el script `PlayerCharMovementController` debe tener los métodos `Move` y `RotateTo`.
- Note las diferencias entre trabajar con `Rigidbody` y `CharacterController`. Por ejemplo: que pasa con las pequeñas plataformas amarillas que hay en la escena? Como interactuan? Que pasa cuando el Player sale de las plataformas?

### Entrega
- Crear una branch a partir del branch `session/session-4`.
  - El nombre de la nueva branch debe tener el siguiente formato: `student/[usuario-unal]/session-2`
```
 Ejemplo: Si su correo es pedrito@unal.edu.co, la rama para hacer la entrega de la clase 2 debe ser `student/pedrito/session-2`.
```
- Hacer los commits necesarios para efectuar la solución al taller.
- Hacer un Pull Request de su branch (`student/[usuario-unal]/session-2`)
  - La branch target del PR debe ser `session/session-4`.
  - El nombre del PR debe seguir el formato `Solución Taller 2 by [usuario-unal]`. 
```
 Ejemplo: Si su correo es pedrito@unal.edu.co, el título del PR debe ser: `Solución Taller 2 by pedrito`.
```
  - La descripción del PR puede ser usada para dejar notas, aclaraciones, preguntas, etc. También se puede dejar vacio.

### Nota
No dude en buscar recursos (YouTube, tutoriales, foros, etc.) y revisar la documentación oficial de Unity para la ejecución del taller.
No dude en escribirnos con cualquier duda, sugerencia, comentario que tenga!