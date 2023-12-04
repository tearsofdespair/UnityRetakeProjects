using UnityEngine;

namespace Command
{
    public class CommandInvoker
    {
        public void Execute(ICommand command, Vector2 position)
        {
            command.Execute(position);
        }
    }
}