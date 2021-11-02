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
- Re-activar que el player mire en la dirección del movimiento: En el script Player, commentar la linea 45 y descomentar la linea 34.
- Agregar la lógica necesaria para que, al no oprimir Input de movimiento, el Player no regrese a la rotación por defecto. En cambio, debe quedar con la ultima rotación que se aplico mientras aun se estaba movimiendo.

**Parte 2: Character Controller**