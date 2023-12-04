using Unity.Mathematics;
using UnityEngine;

namespace Command
{
    public class SpawnCommand : ICommand
    {
        private GameObject _gameObject;
        private GameObject spawnedObject;
        public SpawnCommand(GameObject gameObject)
        {
            _gameObject = gameObject;
        }
        
        public GameObject Execute(Vector2 position)
        {
            spawnedObject = Object.Instantiate(_gameObject, position, quaternion.identity);
            return spawnedObject;
        }

        public void Undo()
        {
            Object.DestroyImmediate(spawnedObject, true);
        }
    }
}