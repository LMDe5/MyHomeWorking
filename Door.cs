using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plohoe_TZ_result_HZ
{
    internal class Door : GameObject, IInteractable
    {
        private bool requiredAccess = true;
        public Door(int id, string name, bool isActive) : base(id, name, isActive)
        {

        }
        public override string Info()
        {
            throw new NotImplementedException();
        }

        public string Interact(Player player)
        {
            if (requiredAccess == false)
            {
                return "Door's open";
            }
            if (player.HasAccessCard == true)
            {
                return "Door's open. The card was used";
            }
            return "Access denied";
        }
    }
}
