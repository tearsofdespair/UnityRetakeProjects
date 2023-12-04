using DefaultNamespace;
using UnityEngine;

namespace Command
{
    public class MoveToCommand : ICommand
    {
        private GameObject _gameObject;
        
        public MoveToCommand(GameObject gameObject)
        {
            _gameObject = gameObject;
        }
        
        public void Execute(Vector2 position)
        {
            Vector3.MoveTowards(_gameObject.transform.position, position, 0.5f);
        }
    }
}