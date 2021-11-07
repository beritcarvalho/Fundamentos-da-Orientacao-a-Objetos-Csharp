using System.Collections.Generic;
using MeuApp.SharedContext;

namespace MeuApp.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            var Lecture = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }
}