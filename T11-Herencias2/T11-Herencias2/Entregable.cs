using System;

namespace T11_Herencias2
{
    public interface Entregable
    {
        public void entregar();

        public void devolver();

        public Boolean isEntregado();

        public int compareTo(Object a);
    }
}
