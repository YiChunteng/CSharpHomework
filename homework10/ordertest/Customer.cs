using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ordertest
{

    public class Customer {

		[Key]
        public string Id { get; set; }
        public string Name { get; set; }

        public Customer() { }


        public Customer(string id, string name)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Name = name;
        }


        public override string ToString()
        {
            return Name;
        }


    }
}
