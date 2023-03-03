using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureTwo.Enums;

namespace TextAdventureTwo.Models
{
    public class Player
    {
        public string Move(Direction direction)
        {
            var movement = String.Empty;
            switch (direction)
            {
                case Direction.North:
                    movement = "North";
                    break;
                case Direction.East:
                    movement = "East";
                    break;
                case Direction.South:
                    movement = "South";
                    break;
                case Direction.West:
                    movement = "West";
                    break;
            }

            return movement;
        }

        public void Interact(string objectToIneractWith)
        {
            throw new NotImplementedException();
        }

        public int Attack(string objectToAttack, string typeOfAttack)
        {
            throw new NotImplementedException();
        }

        public int Defend(string objectAttacking)
        {
            throw new NotImplementedException();
        }

    }
}
