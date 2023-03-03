using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureTwo.Enums;

namespace TextAdventureTwo.Models
{
    public interface IGameCharcter
    {
        public void Move(Direction direction);
        public void Interact(string objectToIneractWith);
        public int Attack(string objectToAttack, string typeOfAttack);
        public int Defend(string objectAttacking);
    }
}
