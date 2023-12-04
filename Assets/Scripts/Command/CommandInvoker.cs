using UnityEngine;

namespace Command
{
    public class CommandInvoker
    {
        public GameObject Execute(ICommand command, Vector2 position)
        {
            return command.Execute(position);
        }
    }
}