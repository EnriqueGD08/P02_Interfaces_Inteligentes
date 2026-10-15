# Práctica 2: Física en Unity

Esta práctica contiene varios ejercicios independientes sobre el sistema de
física de Unity. Se experimenta con componentes `Rigidbody`, `Collider`,
colliders configurados como `Trigger`, materiales físicos, capas y fuerzas.

## Índice

1. [Configuración inicial y cuestiones previas](#configuración-inicial-y-cuestiones-previas)
2. [Situación 1: esfera no física](#situación-1-esfera-no-física)
3. [Situación 2: cubo y esfera físicos](#situación-2-cubo-y-esfera-físicos)
4. [Situación 3: esfera cinemática](#situación-3-esfera-cinemática)
5. [Situación 4: plano físico](#situación-4-plano-físico)
6. [Situación 5: esfera con diez veces más masa](#situación-5-esfera-con-diez-veces-más-masa)
7. [Situación 6: esfera con cien veces más masa](#situación-6-esfera-con-cien-veces-más-masa)
8. [Situación 7: esfera con fricción](#situación-7-esfera-con-fricción)
9. [Situación 8: esfera trigger no física](#situación-8-esfera-trigger-no-física)
10. [Situación 9: esfera física y trigger](#situación-9-esfera-física-y-trigger)
11. [Ejercicios programados](#ejercicios-programados)
1. [Ejercicio 1: movimiento físico](#ejercicio-1-movimiento-físico)
2. [Ejercicio 2: cambio de color al colisionar](#ejercicio-2-cambio-de-color-al-colisionar)
3. [Ejercicio 3: zonas de color y daño](#ejercicio-3-zonas-de-color-y-daño)
4. [Ejercicio 4: capas, enemigo y recolectable](#ejercicio-4-capas-enemigo-y-recolectable)
5. [Ejercicio 5: fricción y rebote](#ejercicio-5-fricción-y-rebote)
6. [Ejercicio 6: esfera que alcanza un obstáculo](#ejercicio-6-esfera-que-alcanza-un-obstáculo)

## Configuración inicial y cuestiones previas

La escena de prueba está formada por un plano, un cubo y una esfera. El plano
y la cámara mantienen sus posiciones por defecto. El cubo se coloca con
`y = 0.5` para que descanse sobre el plano. La esfera se coloca utilizando el
Transform indicado en el enunciado.

Un objeto con `Collider` puede participar en colisiones. Cuando además tiene un
`Rigidbody`, Unity lo trata como un objeto físico y puede calcular su
movimiento, gravedad, masa y respuesta a los contactos. Un `Rigidbody` con
`Is Kinematic` activado no es movido por las fuerzas y la gravedad del motor,
pero puede desplazarse mediante el script y afectar a otros cuerpos. Por su
parte, un `Collider` con `Is Trigger` activado detecta entradas y salidas, pero
no produce una respuesta física de contacto: los objetos pueden atravesarlo.

En las situaciones siguientes, el cubo y la esfera parten de la configuración
indicada en la escena. Se compara el resultado observado al ejecutar la escena
con la explicación de estos componentes.

[Volver al índice](#índice)

### Situación 1: esfera no física


El plano actúa como una superficie estática y la esfera como otro collider
estático. El cubo sí está sometido a la gravedad, por lo que cae hasta apoyarse
en el plano. Si entra en contacto con la esfera, el cubo puede reaccionar a la
colisión; la esfera no calcula un movimiento propio porque no tiene
`Rigidbody`.

[Volver al índice](#índice)

### Situación 2: cubo y esfera físicos


El plano permanece inmóvil y el cubo y la esfera responden a la gravedad y a
las colisiones. Al chocar entre sí, ambos cuerpos participan en la resolución
de la colisión, por lo que pueden cambiar su velocidad y separarse según sus
masas, velocidades y materiales físicos.

[Volver al índice](#índice)

### Situación 3: esfera cinemática


La esfera no cae por gravedad ni responde a fuerzas como un cuerpo dinámico.
Si se mueve mediante su Transform o mediante un script, puede interactuar con
el cubo cinemático. El cubo dinámico sí puede recibir una respuesta de la
colisión, mientras que la trayectoria de la esfera no se modifica por las
fuerzas del cubo.

[Volver al índice](#índice)

### Situación 4: plano físico


Los tres objetos están sometidos a la simulación física. El plano también
recibe gravedad y fuerzas, por lo que deja de comportarse como una superficie
fija: puede desplazarse al interactuar con el cubo y la esfera. El resultado es
una interacción entre tres cuerpos dinámicos, en lugar de una escena apoyada en
un suelo estático.

[Volver al índice](#índice)

### Situación 5: esfera con diez veces más masa


El plano cinemático permanece controlado por el usuario o por un script y no
cae por gravedad. La esfera tiene mucha más inercia que el cubo, por lo que en
un choque su velocidad cambia menos y el cubo recibe un efecto más apreciable.
La masa no hace que la esfera caiga más deprisa, pero sí modifica la respuesta
de las colisiones.

[Volver al índice](#índice)

### Situación 6: esfera con cien veces más masa


El efecto observado es más extremo que en la situación anterior. La esfera se
comporta prácticamente como un cuerpo muy difícil de acelerar o desviar,
mientras que el cubo cambia mucho más su movimiento al golpearla. El plano
continúa sin verse afectado por la gravedad al ser cinemático.

[Volver al índice](#índice)

### Situación 7: esfera con fricción


La fricción se opone al deslizamiento entre las superficies. Por ello, la
esfera pierde más movimiento tangencial y puede rodar o deslizarse de forma
distinta respecto a una esfera sin fricción. La magnitud final depende de los
coeficientes de fricción y de la combinación configurada en los materiales.

[Volver al índice](#índice)

### Situación 8: esfera trigger no física


Aunque la esfera tiene `Rigidbody` para poder moverla o detectar eventos, su
collider es un trigger y no genera una respuesta de contacto. El cubo puede
atravesar la esfera sin rebotar ni quedar bloqueado. La entrada y salida se
pueden detectar mediante `OnTriggerEnter` y `OnTriggerExit`, siempre que la
configuración de colliders y rigidbodies sea válida.

[Volver al índice](#índice)

### Situación 9: esfera física y trigger


La esfera sí es un cuerpo dinámico, por lo que puede recibir gravedad y fuerzas,
pero su collider continúa siendo un trigger. Por tanto, puede moverse como un
cuerpo físico y generar eventos de trigger, aunque el cubo no recibe una
respuesta de colisión sólida al atravesarla. La diferencia con la situación 8
es el movimiento físico de la esfera, no la ausencia de respuesta de contacto
del trigger.

[Volver al índice](#índice)

## Ejercicios programados

### Ejercicio 1: movimiento físico

Archivo: [MovFis1.cs](Ejercicio%201/MovFis1.cs)

El objeto obtiene su `Rigidbody` y lee los ejes `Horizontal` y `Vertical` en
`FixedUpdate`. Con esos valores construye un vector de movimiento y lo aplica
mediante `Translate`, con una velocidad multiplicada por 5. El script requiere
que el objeto tenga un componente `Rigidbody`.

![Resultado del ejercicio 1](Ejercicio%201/Grabaci%C3%B3n%202026-10-15%20182323.gif)

[Volver al índice](#índice)

### Ejercicio 2: cambio de color al colisionar

Archivo: [ColorCol2.cs](Ejercicio%202/ColorCol2.cs)

Cuando el objeto entra o sale de una colisión, muestra en la consola los nombres
de los objetos implicados. Si el otro objeto tiene la etiqueta `Cube` o
`Sphere`, cambia el color de su `Renderer` a un color aleatorio. El script usa
`OnCollisionEnter` y `OnCollisionExit`, por lo que necesita colisiones físicas,
no únicamente triggers.

![Resultado del ejercicio 2](Ejercicio%202/Grabaci%C3%B3n%202026-10-15%20184646.gif)

[Volver al índice](#índice)

### Ejercicio 3: zonas de color y daño

Archivos: [CuboGrand3.cs](Ejercicio%203/CuboGrand3.cs),
[CuboPeq3.cs](Ejercicio%203/CuboPeq3.cs) y
[MovFis1.cs](Ejercicio%203/MovFis1.cs)

El jugador se mueve con un `Rigidbody` y comienza con 30 puntos de daño. Al
entrar en el trigger del cubo grande, cambia su color y guarda el color
anterior para restaurarlo al salir. Al entrar en el cubo pequeño, el daño del
jugador aumenta en 10; al salir, disminuye en la misma cantidad. Ambos scripts
solo reaccionan a objetos con la etiqueta `Player`.

![Resultado del ejercicio 3](Ejercicio%203/Grabaci%C3%B3n%202026-10-15%20193826.gif)

[Volver al índice](#índice)

### Ejercicio 4: capas, enemigo y recolectable

Archivos: [Enemy4.cs](Ejercicio%204/Enemy4.cs),
[MovFis1.cs](Ejercicio%204/MovFis1.cs) y
[Recolectable4.cs](Ejercicio%204/Recolectable4.cs)

El jugador, los enemigos y los recolectables se asignan a capas específicas.
La configuración de `Physics.IgnoreLayerCollision` hace que enemigos y
recolectables solo interactúen con el jugador. El enemigo utiliza colisiones
normales y muestra un mensaje cuando choca con el jugador. El recolectable
convierte sus colliders en triggers y muestra un mensaje cuando el jugador
entra en su zona.

![Resultado del ejercicio 4](Ejercicio%204/Grabaci%C3%B3n%202026-10-15%20212122.gif)

[Volver al índice](#índice)

### Ejercicio 5: fricción y rebote

Archivos: [Objeto15.cs](Ejercicio%205/Objeto15.cs),
[Objeto25.cs](Ejercicio%205/Objeto25.cs) y
[Objeto35.cs](Ejercicio%205/Objeto35.cs)

Los tres objetos reciben un impulso al pulsar la tecla `X`, usando la fuerza y
la dirección configuradas en el inspector. Cada script asigna un material
físico diferente al collider:


La comparación permite observar cómo los coeficientes de fricción, la
combinación de materiales y la restitución modifican el desplazamiento y los
rebotes después del impulso.

![Resultado del ejercicio 5](Ejercicio%205/Grabaci%C3%B3n%202026-10-15%20213155.gif)

[Volver al índice](#índice)

### Ejercicio 6: esfera que alcanza un obstáculo

Archivos: [Cube6.cs](Ejercicio%206/Cube6.cs),
[Cylinder6.cs](Ejercicio%206/Cylinder6.cs) y
[Sphere6.cs](Ejercicio%206/Sphere6.cs)

El cilindro establece su color objetivo al iniciar la escena. La esfera avanza
hacia él mediante `Vector3.MoveTowards`. Cuando la esfera se encuentra a una
distancia igual o inferior a 1 unidad del cubo, recupera su posición anterior,
se detiene y cambia el color del cubo al color configurado. La detección se
realiza comprobando la distancia, no mediante un callback de colisión.

![Resultado del ejercicio 6](Ejercicio%206/Grabaci%C3%B3n%202026-10-15%20215236.gif)

[Volver al índice](#índice)
