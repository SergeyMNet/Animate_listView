using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.Models
{
    internal class Item
    {
        public Item(string text, int id)
        {
            this.Id = id;
            this.Text = text;
        }

        public int Id { get; set; }
        public string Text { get; set; }
    }
}
