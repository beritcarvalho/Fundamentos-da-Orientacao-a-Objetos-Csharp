using System.Collections.Generic;

namespace MeuApp.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url)
        : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count;
        #region Observação
        /*
        Quanto tiver só uma linha nos acessores e não tiver o set pode trocar a expressão
        por uma expression body NomePropriedade => retorno
        public int TotalCourses
        {
            get
            {
                return Items.Count;
            }
        }
        */
        #endregion

    }

}