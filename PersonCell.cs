using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1
{
    internal class PersonCell
    {
        public string Name;
        public PersonCell Next;
        public PersonCell() { }


        public PersonCell(string name, PersonCell next)
        {
            Name = name;
            Next = next;
        }
        public void push(string newName)
        {
            PersonCell newCell = new PersonCell();
            newCell.Name = newName;
            newCell.Next = this.Next;
            this.Next = newCell;
        }
        public void pop(PersonCell TopCell)
        {
            PersonCell FirstCell = TopCell.Next;
            TopCell.Next = FirstCell.Next;

        }
    }
}
