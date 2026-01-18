using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plohoe_TZ_result_HZ
{
    internal class Trap : GameObject, IInteractable, IDamageable
    {
        public int Damage {  get; set; } 
        public Trap(int Id, string Name, bool IsActive, int damage) : base(Id, Name, IsActive)
        {
            Damage = damage;
        }

        public void ApplyDamage(int amount)
        {
            Disable();
            Console.WriteLine("The trap has been broken");
        }
        public string Interact(Player player)
        {
            if (Damage > 0) 
            {
                player.Hp = player.Hp - Damage;
                return $"player got damage. He's HP: {player.Hp}"; 
            }
            return null;
        }
        public override string Info()
        {
            throw new NotImplementedException();
        }
    }
}
