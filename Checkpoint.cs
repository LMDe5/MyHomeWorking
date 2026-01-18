using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plohoe_TZ_result_HZ
{
    internal class Checkpoint : GameObject, IInteractable
    {
        public Checkpoint(int Id, string Name, bool IsActive) : base(Id, Name, IsActive)
        {

        }
        public string Interact(Player player)
        {
            player.LastCheckpointId = Id;
            return "checkPoint was saved";
        }

        public override string Info()
        {
            throw new NotImplementedException();
        }
    }
}
