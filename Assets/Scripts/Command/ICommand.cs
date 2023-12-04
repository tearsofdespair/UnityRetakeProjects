using UnityEngine;

namespace Command
{
    public interface ICommand
    {
        public GameObject Execute(Vector2 position);


        public void Undo();
    }
}