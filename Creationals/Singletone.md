# **El patrón Singleton**

Matemáticamente hablando un Singleton es un conjunto que posee un único elemento. En programación se utiliza para garantizar que únicamente exista una instancia de un objeto al mismo tiempo.

Si pensamos en una serie de procesos como la gestión de la cola de impresión, una clase de utilidades con métodos compartidos entre varias clases o el proceso que se encarga de distribuir los mensajes recibidos por un servicio https nos damos cuenta de que en memoria no se necesita más de una copia de cada clase a la vez pues, aunque haya varios documentos pendientes de impresión, únicamente necesitaremos un gestor de los mismos que les vaya dando salida dependiendo de cómo entren.

La diferencia existente entre un Singleton y una clase estática se debe a que, mientras cualquier clase estática se debe de cargar en memoria en el momento en el que se inicializa el programa, el Singleton permite una "lazy instantiation" o **instanciación momentánea** que se producirá únicamente cuando el programa lo necesite, no sobrecargando la memoria ram más de lo necesario.

Existen otras razones por las que la solución Singleton se ha convertido en la solución por excelencia. Una de ellas es que **permite la herencia**, por lo que es posible generar una serie de subclases que cubran necesidades específicas. También es posible variar el **número de instancias permitido**.

Es también el método con el que se implementan, a menudo, otros patrones como **la factoría abstracta, el constructor o Builder y el prototipo o Prototype**.