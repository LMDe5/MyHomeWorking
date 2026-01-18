using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plohoe_TZ_result_HZ
{
    internal class Scene
    {
        private List<GameObject> objects = new List<GameObject> ();
        private Player player;
        public Scene(Player player)
        {
            this.player = player;
        }
        public void Tick()
        {
            foreach(GameObject obj in objects)
            {
                if (obj is IUpdatable updatable)
                {
                    updatable.Update();
                }
            }
        }
        public void PrintAll()
        {
            foreach (GameObject obj in objects)
            {
                obj.Info();
            }
        }
        public void PrintOnlyInteractableObjects()
        {
            foreach (GameObject obj in objects)
            {
                if (obj is IInteractable)
                {
                    obj.Info();
                }
            }
        }
        public void OnObject(int Id)
        {
            foreach(GameObject obj in objects)
            {
                if (obj.Id == Id)
                {
                    obj.Enable();
                    return;
                }
            }
            Console.WriteLine("Не найден объект по Айди!");
        }
        public void OffObject(int Id)
        {
            foreach (GameObject obj in objects)
            {
                if (obj.Id == Id)
                {
                    obj.Disable();
                    return;
                }
            }
            Console.WriteLine("Не найден объект по Айди!");
        }
        public void InteractWithObject(int Id)
        {
            foreach (GameObject obj in objects)
            {
                if (obj.Id == Id)
                {
                    if (obj is IInteractable interactable)
                    {
                        interactable.Interact(player);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Object is not interactable");
                        return;
                    }
                }
            }
            Console.WriteLine("Object was not founded");
        }
    }
}
