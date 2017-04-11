using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Player
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public List<Building> Buildings { get; set; }
        // фишка отдельный класс или фишка-свойство 
    }
}
