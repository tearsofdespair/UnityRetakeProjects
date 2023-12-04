using System;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace Command
{
    public class Client : MonoBehaviour
    {
        private CommandInvoker _invoker = new CommandInvoker();
        public GameObject ObjectPrefab;

        private void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {
                _invoker.Execute(new SpawnCommand(ObjectPrefab), getMousePositionInWorld());
            }
            else if (Input.GetMouseButtonDown(0))
            {
                _invoker.Execute(new MoveToCommand(ObjectPrefab), getMousePositionInWorld());
            }
        }



        private Vector2 getMousePositionInWorld()
        {
            Vector2 mousePos = Input.mousePosition;
            return Camera.main.ScreenToWorldPoint(mousePos);
        }
    }
    
}