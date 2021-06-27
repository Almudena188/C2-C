using System;

public class Libro
{
    private int _ISBN;
    private String _titulo;
    private String _autor;
    private int _numPaginas;

    public Libro(int pISBN, String pTitulo, String pAutor, int pNumPaginas)
    {

        _ISBN = pISBN;
        _titulo = pTitulo;
        _autor = pAutor;
        _numPaginas = pNumPaginas;

    }

    public string titulo
    {
        get
        {
            return _titulo;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _titulo = value;
            }
        }
    }
    public string autor
    {
        get
        {
            return _autor;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _autor = value;
            }
        }
    }
    public int ISBN
    {

        set
        {
            _ISBN = value;
        }
        get
        {
            return _ISBN;
        }
    }

    public int numPaginas
    {

        set
        {
            _numPaginas = value;
        }
        get
        {
            return _numPaginas;
        }
    }
    public String toString()
    {
        return "El libro " + _titulo + " con ISBN " + _ISBN + ""
                + " creado por el autor " + _autor
                + " tiene " + _numPaginas + " páginas";
    }

}
