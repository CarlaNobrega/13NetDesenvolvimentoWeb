using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP01.ViewComponents
{
    public class NoticiasViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int total, bool noticiasUrgentes)
        {
            var view = "noticias";
            if (noticiasUrgentes)
            {
                view = "noticiasUrgentes";
            }

            var itens = GetItens(total);

            return View(view, itens);
        }

        private IEnumerable<Noticia> GetItens(int total)
        {
            // var retorno = new List<Noticia>();
            for (int i = 0; i < total; i++)
            {
                yield return new Noticia() { Id = i + 1, Titulo = $"Notícia sobre: {i}" };
            }
        }

        //private IEnumerable<Noticia> GetItems(int total)
        //{

        //}

    }

    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Link { get; set; }

    }
}



