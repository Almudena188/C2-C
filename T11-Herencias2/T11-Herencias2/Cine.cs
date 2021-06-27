using System;

namespace T11_Herencias2
{
	public class Cine
	{
        private Asiento[][] _asientos;
        private double _precio;
        private Pelicula _pelicula;

        /*Constructor*/
        public Cine(int filas, int columnas, double precio, Pelicula pelicula)
        {
            Asiento[][] asientos1 = new Asiento[filas][columnas];
            this._precio = precio;
            this._pelicula = pelicula;
            rellenaButacas();
        }

         private void rellenaButacas() {
 
            int fila = asientos.Length;
            for (int i = 0; i < asientos.Length; i++) {
                for (int j = 0; j < asientos[0].Length; j++) {
                    //Recuerda que los char se pueden sumar
                    asientos[i][j] = new Asiento((char) ('A' + j), fila);
                }
                fila--; //Decremento la fila para actualizar la fila
            }
 
         }
        public Boolean haySitio()
        {

            for (int i = 0; i < asientos.Length; i++)
            {
                for (int j = 0; j < asientos[0].Length; j++)
                {

                    if (!asientos[i][j].ocupado())
                    {
                        return true;
                    }

                }
            }

            return false;
        }
        public Boolean haySitioButaca(int fila, char letra)
        {
            Asiento a = new Asiento(letra, fila);
            return a.ocupado();
        }
        public Boolean sePuedeSentar(Espectador e)
        {
            return e.tieneDinero(_precio) && e.tieneEdad(pelicula.edadMinima);
        }
        public void sentar(int fila, char letra, Espectador e)
        {
            Asiento a = new Asiento(letra, fila);
            a.espectador = e;
        }

        public Asiento getAsiento(int fila, char letra)
        {
            return _asientos[_asientos.Length - fila - 1][letra - 'A'];
        }
        public int getFilas()
        {
            return asientos.Length;
        }
        public int getColumnas()
        {
            return asientos[0].Length;
        }

        public void mostrar()
        {

            Console.WriteLine("Información cine");
            Console.WriteLine("Pelicula reproducida: " + _pelicula);
            Console.WriteLine("Precio entrada: " + _precio);
            Console.WriteLine("");
            for (int i = 0; i < _asientos.Length; i++)
            {
                for (int j = 0; j < _asientos[0].Length; j++)
                {
                    Console.WriteLine(asientos[i][j]);
                }
                Console.WriteLine("");
            }
        }
        public Pelicula pelicula
        {
            get
            {
                return _pelicula;
            }
            set
            {

                _pelicula = value;

            }
        }
        public double precio
        {
            get
            {
                return _precio;
            }
            set
            {

                _precio = value;

            }
        }

        public Asiento[][] asientos
        {
            get
            {
                return _asientos;
            }
            set
            {
                
                    _asientos = value;
                
            }
        }
    }
}
