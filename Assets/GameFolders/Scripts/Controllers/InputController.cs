using System;
using System.Runtime.CompilerServices;
using GameFolders.Scripts.Inputs;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameFolders.Scripts.Controllers
{
    public class InputController: Singleton<InputController>
    {
        public event Action<Vector2> DirectionKeysPress;

        private InputActions _inputActions;

        public Vector2 Direction { get; private set; }
        protected override void OnAwake()
        {
            Initialize();
            Direction=Vector2.zero;
        }

        private void Initialize()
        {
            _inputActions=new InputActions();
            _inputActions.Enable();

            _inputActions.Player.Directions.performed += OnDirectionKeysPress;
            _inputActions.Player.Directions.canceled += OnDirectionKeysPress;
        }

        private void OnDirectionKeysPress(InputAction.CallbackContext callbackContext)
        {
            Direction = callbackContext.ReadValue<Vector2>();
            DirectionKeysPress?.Invoke(Direction);

            Debug.Log(Direction);
        }
    }
}
