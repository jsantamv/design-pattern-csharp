# Inyección de dependencia

La inyección de dependencia es un patrón de diseño de software que se utiliza para eliminar la dependencia de una clase de sus dependencias. 
En lugar de crear o instanciar directamente sus dependencias, la clase recibe las dependencias a través de una interfaz o un constructor.

Esto tiene varias ventajas:

1. Mejora la testabilidad: Las dependencias pueden ser sustituidas por mock objects durante las pruebas, lo que permite probar la clase de forma aislada.
1. Mejora la mantenibilidad: Si una dependencia cambia, solo es necesario actualizar la forma en que se proporciona a la clase que la utiliza, en lugar de modificar la clase directamente.
1. Mejora la flexibilidad: Las dependencias pueden ser intercambiadas fácilmente, lo que permite cambiar la funcionalidad de una clase sin modificarla directamente.

En resumen, la inyección de dependencia es una técnica que se utiliza para desacoplar clases y mejorar la testabilidad, la mantenibilidad y la flexibilidad del código.