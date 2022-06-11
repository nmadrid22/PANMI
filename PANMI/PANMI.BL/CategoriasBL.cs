using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PANMI.BL
{
    public class CategoriasBL
    { 
        Contexto _contexto;
        
        public List<Categoria> ListadeCategorias { get; set; }
        
        public CategoriasBL()
    {
        _contexto = new Contexto();
        ListadeCategorias = new List<Categoria>();
    }

    public List<Categoria> ObtenerCategorias()
    {
        ListadeCategorias = _contexto.Categorias.ToList();
        return ListadeCategorias;
    }
    public void GuardarCategoria(Categoria Categoria)
    {
        if (Categoria.Id == 0)
        {
            _contexto.Categorias.Add(Categoria);
        }

            else
        {
                var categoriaExistente = _contexto.Categorias.Find(Categoria.Id);
            categoriaExistente.Descripcion = Categoria.Descripcion;
    
        }

        _contexto.SaveChanges();

    }
    public Categoria ObtenerCategoria(int id)
    {
        var categoria = _contexto.Categorias.Find(id);

        return categoria;
    }
        public void EliminarCategoria(int id)
        {
            var Categoria = _contexto.Categorias.Find(id);

            _contexto.Categorias.Remove(Categoria);
            _contexto.SaveChanges();
        }
    }

}




