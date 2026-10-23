# Verificación automática en Unity 6000.6.4f1

Pruebas ejecutadas en Play con teclado virtual y simulación física de pasos de 0.02 s.


## Assets/Scenes/SampleScene.unity

- OK: No hay componentes con script ausente.
- OK: Existe cámara principal.

## Assets/Scenes/Plinko.unity

- OK: No hay componentes con script ausente.
- OK: Existe cámara principal.

## Assets/Scenes/Clase03/Actividad02_PrimeraEscena.unity

- OK: No hay componentes con script ausente.
- OK: Existe cámara principal.
- OK: Player, Enemy y Platform presentes.

## Assets/Scenes/Clase04/Player_Reactivo.unity

- OK: No hay componentes con script ausente.
- OK: Existe cámara principal.
- OK: Movimiento y CambioColor en el mismo objeto.
- OK: El método de comunicación cambia el color.
- El teclado Legacy requiere comprobación manual de WASD/flechas; no se inyecta con Input System.

## Assets/Scenes/Clase05/Escena01_Transform.unity

- OK: No hay componentes con script ausente.
- OK: Existe cámara principal.
- OK: Transform sin Rigidbody2D; velocidad 5, inicio X=-5.

## Assets/Scenes/Clase05/Escena02_AddForce.unity

- OK: No hay componentes con script ausente.
- OK: Existe cámara principal.
- OK: El impulso físico de 5 produce velocidad hacia arriba.

## Assets/Scenes/Clase05/Escena03_LinearVelocity.unity

- OK: No hay componentes con script ausente.
- OK: Existe cámara principal.
- OK: Start asignó linearVelocity.x=4.

## Assets/Scenes/Clase05/Reto_Final_Equilibrio.unity

- OK: No hay componentes con script ausente.
- OK: Existe cámara principal.

|Prueba (0.5 s)|Fuerza|Gravedad pelota|Damping nave|X nave final|VX nave final|Y pelota final|
|---|---|---|---|---|---|---|
|1|4|1|2|0.375|1.250|-0.677|
|2|8|1|2|0.750|2.500|-0.677|
|3|8|2|2|0.750|2.500|-1.324|
- OK: OnCollisionEnter2D emitió: La pelota cayó al suelo.
- En Clase05 la tabla aplica directamente la fuerza equivalente a flecha derecha; en Clase06 la fuerza llega mediante el binding D y OnMove. Los valores son mediciones de la simulación, no observaciones atribuidas a la alumna.

## Assets/Scenes/Clase06/Escena01_InputMovement.unity

- OK: No hay componentes con script ausente.
- OK: Existe cámara principal.
- OK: PlayerInput de Jugador: Player / Send Messages.
- OK: D llega a OnMove y desplaza Transform a la derecha.
- OK: Flecha izquierda desplaza Transform a la izquierda.
- OK: Soltar las teclas detiene Transform.
- OK: Movimiento diagonal WASD.

## Assets/Scenes/Clase06/Escena02_InputPhysics.unity

- OK: No hay componentes con script ausente.
- OK: Existe cámara principal.
- OK: PlayerInput de JugadorFisico: Player / Send Messages.
- OK: Move aplica fuerza horizontal.
- OK: Espacio activa un impulso de 4.
- OK: Mantener espacio no repite el impulso.
- OK: C cambia a rojo.
- OK: Segunda pulsación C cambia a blanco.

## Assets/Scenes/Clase06/Reto_Input_Equilibrio.unity

- OK: No hay componentes con script ausente.
- OK: Existe cámara principal.
- OK: PlayerInput de Nave: Player / Send Messages.
- OK: PlayerInput de Pelota: Player / Send Messages.
- OK: Espacio impulsa la pelota con PlayerInput separado.
- OK: C cambia el color de la nave.
- OK: Binding C cambiado a V: el mismo OnChangeColor funciona.

|Prueba (0.5 s)|Fuerza|Gravedad pelota|Damping nave|X nave final|VX nave final|Y pelota final|
|---|---|---|---|---|---|---|
|1|4|1|2|0.444|1.581|-1.008|
|2|8|1|2|0.768|2.512|-0.953|
|3|8|2|2|0.768|2.355|-1.625|
- OK: OnCollisionEnter2D emitió: La pelota cayó al suelo.
- En Clase05 la tabla aplica directamente la fuerza equivalente a flecha derecha; en Clase06 la fuerza llega mediante el binding D y OnMove. Los valores son mediciones de la simulación, no observaciones atribuidas a la alumna.