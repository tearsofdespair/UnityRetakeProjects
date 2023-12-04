using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace Command
{
    public class Client : MonoBehaviour
    {
        private CommandInvoker _invoker = new CommandInvoker();
        public GameObject ObjectPrefab;
        private GameObject lastSpawnedObject;
        private Queue<ICommand> _commands = new Queue<ICommand>();
        public const int N = 5;
        private ICommand _command;
        private void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {
                _command = new SpawnCommand(ObjectPrefab);
                AddCommand(_command);
                lastSpawnedObject = _invoker.Execute(_command, getMousePositionInWorld());
            }
            
            
            if (Input.GetMouseButtonDown(0))
            {
                _command = new MoveToCommand(lastSpawnedObject);
                AddCommand(_command);
                _invoker.Execute(_command, getMousePositionInWorld());
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                Undo();
            }
        }
        
        public void AddCommand(ICommand command)
        {
            if(_commands.Count >= 5)
            {
                _commands.Dequeue();
            }
            _commands.Enqueue(command);
        }

        public void Undo()
        {
            Debug.Log("undo");
            _commands.Dequeue().Undo();
        }

        private Vector2 getMousePositionInWorld()
        {
            Vector2 mousePos = Input.mousePosition;
            return Camera.main.ScreenToWorldPoint(mousePos);
        }
    }
}