using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikValidation
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Product(int id, string name)
        {
            Name = name;
            Id = id;
        }

    }
}
