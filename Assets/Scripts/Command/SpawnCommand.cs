using Unity.Mathematics;
using UnityEngine;

namespace Command
{
    public class SpawnCommand : ICommand
    {
        private GameObject _gameObject;

        public SpawnCommand(GameObject gameObject)
        {
            _gameObject = gameObject;
        }
        
        public void Execute(Vector2 position)
        {
            Object.Instantiate(_gameObject, position, quaternion.identity);
        }
    }
}