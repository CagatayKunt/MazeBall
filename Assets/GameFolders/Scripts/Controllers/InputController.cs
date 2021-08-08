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
        public event Action<Vector2> MousePositionChange;

        private InputActions _inputActions;
        
        protected override void OnAwake()
        {
            Initialize();
        }

        private void Initialize()
        {
            _inputActions=new InputActions();
            _inputActions.Enable();

            _inputActions.Player.Directions.performed += OnDirectionKeysPress;
            _inputActions.Player.Directions.canceled += OnDirectionKeysPress;

            _inputActions.Player.MouseDirection.started += OnMousePositionChange;
            _inputActions.Player.MouseDirection.canceled += OnMousePositionChange;
        }

        private void OnMousePositionChange(InputAction.CallbackContext callbackContext)
        {
            Vector2 mouseDelta = callbackContext.ReadValue<Vector2>();
            MousePositionChange?.Invoke(mouseDelta);
            
            Debug.Log("mouse"+mouseDelta);
        }

        private void OnDirectionKeysPress(InputAction.CallbackContext callbackContext)
        {
            Vector2 direction = callbackContext.ReadValue<Vector2>();
            DirectionKeysPress?.Invoke(direction);
            
            Debug.Log(direction);
        }
    }
}
