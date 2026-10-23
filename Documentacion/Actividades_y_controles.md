# Actividades de Unity — clases 02 a 06

Revisión del 19 de octubre de 2026. Materiales: los cinco documentos de Obsidian de la carpeta `2026-unity-ut-clases` y el texto adjunto de Clase 06. El proyecto ya utilizaba Unity 6000.6.4f1; no se cambió de versión para esta actividad. El documento usa 6000.6.3f1.

## Dónde está cada actividad

|Clase|Actividad / archivo dentro de Assets|Situación|
|---|---|---|
|02|Carpetas Scripts, Prefabs, Sprites, Scenes y Settings|Ya estaban creadas. Esta actividad no exige una escena adicional.|
|03|Scenes/Clase03/Actividad02_PrimeraEscena.unity|Antes `Scene.unity`. Conserva Player, Enemy y Platform con Transform y componentes físicos.|
|04|Scenes/Clase04/Player_Reactivo.unity|Se completó una escena independiente: movimiento por Transform, WASD y flechas; dos scripts en Player que se comunican.|
|05, ejercicio 1|Scenes/Clase05/Escena01_Transform.unity|Se creó: Jugador en X=-5, velocidad 5, movimiento horizontal directo.|
|05, ejercicio 2|Scenes/Clase05/Escena02_AddForce.unity|Se creó: Pelota con gravedad e impulso; Suelo estático.|
|05, ejercicio 3|Scenes/Clase05/Escena03_LinearVelocity.unity|Se creó: Pelota con velocidad horizontal inicial 4 y Plataforma.|
|Salón, Nave|Scenes/Nave.unity|Actividad presencial: cambia de color únicamente el Propulsor. Se conserva independiente del reto escrito de Clase05.|
|05, reto|Scenes/Clase05/Reto_Final_Equilibrio.unity|Reto del documento: Nave, Pelota y Suelo; movimiento físico y CambioColor en el mismo objeto Nave; espacio impulsa la pelota y cambia la nave a rojo.|
|06, ejercicio 1|Settings/PlayerControls.inputactions|Mapa Player, Move (Value/Vector2), Jump y ChangeColor (Button). Este ejercicio es una configuración, no una cuarta escena.|
|06, ejercicio 2|Scenes/Clase06/Escena01_InputMovement.unity|Movimiento con Transform y PlayerInput.|
|06, ejercicio 3|Scenes/Clase06/Escena02_InputPhysics.unity|Fuerza con Rigidbody2D sin gravedad, impulso y cambio blanco/rojo.|
|06, reto|Scenes/Clase06/Reto_Input_Equilibrio.unity|Nave con fuerzas, Pelota con impulso y velocidad inicial conservada de Clase05, cambio de color y detección de caída.|

**La Clase 06 contiene tres ejercicios más un reto final.** Hay tres escenas porque el ejercicio 1 solamente configura el archivo de entradas.

`Scenes/SampleScene.unity` contiene una práctica de objetos y cuerpos físicos (Cube y tres cuadrados). `Scenes/Plinko.unity` contiene un tablero de Plinko, obstáculos, pelota y textos. Se conservaron como trabajos adicionales: los documentos proporcionados no los exigen como entregas separadas. `Settings/Scenes/URP2DSceneTemplate.unity` es la plantilla del proyecto, no una actividad del alumno.

## Controles

Haz clic en la ventana **Game** después de presionar Play para que Unity reciba el teclado.

|Escena|Controles|
|---|---|
|Clase04 Player reactivo|WASD y flechas. Arriba: verde; abajo: amarillo; izquierda: rojo; derecha: azul.|
|Clase05 Transform|A/D o flechas izquierda/derecha.|
|Clase05 AddForce|Espacio: impulso de la pelota.|
|Clase05 LinearVelocity|Movimiento automático al iniciar.|
|Nave del salón|WASD/flechas: fuerzas en la nave y color según dirección únicamente en su hijo Propulsor; espacio: impulso de la pelota. La nave conserva su color.|
|Clase05 reto del documento|WASD/flechas: fuerzas en la nave; espacio: impulso de la pelota y color rojo en toda la nave.|
|Clase06 InputMovement|WASD y flechas; movimiento directo a velocidad 5.|
|Clase06 InputPhysics|WASD/flechas: fuerza 8; espacio: impulso 4; C: alternar blanco y rojo.|
|Clase06 reto|WASD/flechas: nave; espacio: pelota; C y V: alternar color de la nave.|

El proyecto conserva **Active Input Handling = Both**, tal como permite la Clase06, para mantener operativas las prácticas con `Input.GetKey` y `Input.GetAxisRaw`. Los scripts de Clase06 leen acciones mediante `InputValue`, con `PlayerInput`, mapa `Player` y `Send Messages`.

En la práctica de personalización se cambió el binding de color de C a V y se comprobó el mismo método `OnChangeColor` sin editarlo. El archivo final conserva V y también C como alternativa para mantener el control solicitado por el ejercicio base.

## Nave del salón y reto escrito de Clase05

La escena `Assets/Scenes/Nave.unity` corresponde a la actividad presencial, donde solo cambia el Propulsor. La escena `Assets/Scenes/Clase05/Reto_Final_Equilibrio.unity` es independiente y cumple el comportamiento del reto escrito: `NaveEquilibrio` y `CambioColor` están en la misma Nave. Esta nueva escena no contiene Propulsor. Se creó reutilizando la configuración física y los scripts existentes; no se volvió a ejecutar en Play durante su creación porque la conexión con el editor no estaba disponible. Las mediciones históricas de este documento corresponden a las pruebas anteriores y no se presentan como nuevas pruebas de esta escena.

### Configuración de la nave del salón

Se corrigieron tres referencias a scripts ausentes en el propulsor. La nave utiliza `NaveEquilibrio`, que aplica fuerzas en `FixedUpdate`. Solamente su hijo `Propulsor` utiliza `ColorPropulsor`, que cambia su propio SpriteRenderer según la dirección; la nave conserva su color. El hijo acompaña automáticamente al padre al moverse. La pelota utiliza `ControlPelota`, con velocidad horizontal inicial, impulso y `OnCollisionEnter2D`. El suelo tiene BoxCollider2D y no tiene cuerpo dinámico.

La nave tenía masa 15 y la pelota masa 0.1. Se dejaron ambas en 1 y la amortiguación lineal de la nave en 2: así, el impulso 4 no produce una velocidad de 40 en la pelota, y la nave responde mejor. Estos ajustes utilizan únicamente las propiedades físicas explicadas en Clase05. No se añadieron puntuación, reinicios, menús, límites, enemigos ni otras mecánicas.

Los scripts de las prácticas de Clase05 y Clase06 siguen los ejemplos de los documentos. Las adaptaciones son la colisión obligatoria de `ControlPelota`, la comunicación entre scripts del reto de Clase04 y conservar la velocidad inicial de la pelota al migrarla a `PelotaInput`.

## Evidencias y alcance de las pruebas

Los resultados medidos están en [Verificacion_Unity.md](Verificacion_Unity.md). Incluyen tres configuraciones por reto y la comprobación de que el mensaje **La pelota cayó al suelo.** se produjo por una colisión real.

Las pruebas del nuevo sistema usan eventos de teclado en Play que pasan por Input Actions y PlayerInput. La simulación física se avanza en pasos de 0.02 segundos. Las mediciones son pruebas técnicas automatizadas; no se presentan como experiencias personales de la alumna.

Para el sistema Legacy se comprobaron componentes, inicialización, método de cambio de color y física. La pulsación física de WASD/flechas y espacio en las escenas antiguas requiere revisión manual en Game, porque el teclado virtual del New Input System no genera entradas Legacy. También quedan como trabajo personal las variaciones de velocidad 2/5/10, escala y posición, y las reflexiones redactadas con tus palabras.

Las herramientas `Assets/Editor/PrepararActividades.cs` y `VerificarActividades.cs` son utilidades de organización y comprobación del editor; no se ejecutan como mecánicas del juego ni forman parte de lo que debes explicar como código de las clases. El paquete Pipeline permite esta comprobación local. El código del juego permanece en `Assets/Scripts`.

## Interpretación de las tres configuraciones

En Clase05, con masa 1 en ambos cuerpos y damping 2 en la nave, la fuerza 4 produjo X=0.375 y VX=1.250 a los 0.5 s. Al subir a fuerza 8, X=0.750 y VX=2.500: la respuesta horizontal fue aproximadamente el doble. Con fuerza 8 y gravedad 2, la pelota terminó en Y=-1.324, más abajo que con gravedad 1 (Y=-0.677). La gravedad mayor dificulta recuperarla.

En Clase06, la fuerza 4 produjo X=0.444 y VX=1.581; la fuerza 8 produjo X=0.768 y VX=2.512. La diferencia no es exactamente doble porque también intervienen los contactos entre nave y pelota. Al aumentar la gravedad de la pelota a 2, su posición final bajó de Y=-0.953 a Y=-1.625: cae antes. La configuración guardada mantiene fuerza 8, gravedad 1, masas 1 y damping 2; permite respuesta con amortiguación. Para experimentar con un control más suave se puede bajar la fuerza a 4, que produjo menor desplazamiento en la prueba.

Como comparación de masas, antes de corregir el reto original (nave 15, pelota 0.1), la misma prueba de fuerza 4 produjo X=0.025 y VX=0.083 en la nave: su mayor masa reducía mucho la respuesta. Además, impulso 4 sobre masa 0.1 equivale a un cambio de velocidad vertical 40, frente a 4 con masa 1. Esto explica el ajuste realizado.

También se verificó el binding **V del archivo final guardado**, sin emparejar dispositivos mediante el verificador: un evento D + espacio + V en el dispositivo Keyboard existente dio Move=(1,0) en ambos PlayerInput, velocidad vertical 4 en Pelota y color rojo en Nave. Para esta prueba técnica se habilitó temporalmente la entrada y ejecución en segundo plano; después se restauraron las opciones y se liberaron las teclas. En el uso normal basta enfocar Game.

## Conceptos para repasar

- Una acción expresa lo que hace el jugador; un binding indica qué control la activa. Move puede tener varios bindings de teclado sin cambiar el script.
- Vector2 contiene las direcciones horizontal y vertical. OnMove recibe su valor y guarda también cero cuando se sueltan las teclas.
- PlayerInput relaciona Move con OnMove mediante Send Messages. Si se cambia el nombre de la acción, debe coincidir su método receptor.
- Transform cambia la posición directamente. AddForce cambia la velocidad mediante la física y puede dejar inercia. FixedUpdate acompaña el ciclo físico; Impulse aplica el cambio de una sola vez.
- El cambio de color usa SpriteRenderer; no necesita modificar Rigidbody2D. Separarlo del movimiento permite cambiar una responsabilidad sin reescribir la otra.
- El nuevo sistema separa teclas y comportamiento; el clásico consulta directamente teclas/ejes. Un gamepad se agregaría como bindings de las mismas acciones, tal como describe el documento; no se añadió en esta práctica.
- Para distintos estados de juego, los mapas permiten agrupar y activar acciones apropiadas. Aquí solamente se utiliza Player, que es lo solicitado.
- Hierarchy muestra objetos de la escena; Project muestra archivos. Scene permite editar; Game muestra la cámara; Inspector muestra propiedades y componentes.

## Archivos y entrega

El respaldo previo a la organización está en `Respaldos/Antes_Actividades_2026-10-19`, fuera de Assets para que Unity no importe escenas ni scripts duplicados. Mantiene las escenas originales con sus nombres y sus metadatos.

Las escenas de las actividades se agregaron a la lista de escenas del proyecto. Los cambios están guardados localmente. No se hizo commit ni push: el proyecto ya tenía cambios de la alumna antes de esta revisión y las indicaciones de GitHub dentro de los documentos se trataron como requisitos de entrega, no como autorización para publicar el repositorio.
