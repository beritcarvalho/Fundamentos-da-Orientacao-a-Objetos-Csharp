using System;
using MeuApp.NotificationContext;

namespace MeuApp.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); // Deixando criar um id nesta classe, descarta a necessidade de criar um id para classe de curso, artigo e carreira. Fazendo isso fazemos o SPOF (Ponto unico de falha)
        }
        public Guid Id { get; set; }
    }
}