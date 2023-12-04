using UnityEngine;

namespace Command
{
    public interface ICommand
    {
        public void Execute(Vector2 position);
    }
}