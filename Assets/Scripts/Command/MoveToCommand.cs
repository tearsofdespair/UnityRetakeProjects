using DefaultNamespace;
using UnityEngine;

namespace Command
{
    public class MoveToCommand : ICommand
    {
        private GameObject _gameObject;
        private Vector2 _undoPosition;
        public MoveToCommand(GameObject gameObject)
        {
            _gameObject = gameObject;
        }
        
        public GameObject Execute(Vector2 position)
        {
            _undoPosition = _gameObject.transform.position;
            _gameObject.transform.position = position;
            
            return _gameObject;
        }

        public void Undo()
        {
            _gameObject.transform.position = _undoPosition;
        }
    }
}