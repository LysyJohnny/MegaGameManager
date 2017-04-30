using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace Model
{
    public class Player
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public List<Building> Buildings { get; set; }
       public Ellipse Fishka { get; set; }
        
       
    }
}
