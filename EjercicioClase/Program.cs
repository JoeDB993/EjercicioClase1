//Instanciar la clase o declarar un objeto

using EjercicioClase;

SuperHeroe superheroe = new SuperHeroe();
superheroe.nombre = "Juan";
superheroe.identidadsecreta = "Homelander";
superheroe.ciudad = "Washintong";
superheroe.puedevolar = true;
superheroe.SuperPoder.NombrePoder = "Súper fuerza.";
superheroe.SuperPoder.descripcion = "Es capaz de levantar objetos extremadamente pesados y destruir edificios con sus puños.";
superheroe.SuperPoder.nivel = "Indestructible.";
superheroe.Imprimir();


SuperHeroe superheroe2 = new SuperHeroe();
superheroe2.nombre = "Ana";
superheroe2.identidadsecreta = "Invisible Woman";
superheroe2.ciudad = "New York";
superheroe2.puedevolar = false;
superheroe2.SuperPoder.NombrePoder = "Invisibilidad.";
superheroe2.SuperPoder.descripcion = "Puede volverse invisible a voluntad.";
superheroe2.SuperPoder.nivel = "Avanzado.";
superheroe2.Imprimir();

SuperHeroe superheroe3 = new SuperHeroe();
superheroe3.nombre = "Carlos";
superheroe3.identidadsecreta = "Flash";
superheroe3.ciudad = "Central City";
superheroe3.puedevolar = false;
superheroe3.SuperPoder.NombrePoder = "Super velocidad.";
superheroe3.SuperPoder.descripcion = "Es capaz de moverse a velocidades increíbles, superando la velocidad del sonido.";
superheroe3.SuperPoder.nivel = "Máximo.";
superheroe3.Imprimir();
