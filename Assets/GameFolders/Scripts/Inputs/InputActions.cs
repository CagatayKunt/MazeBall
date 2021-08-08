// GENERATED AUTOMATICALLY FROM 'Assets/GameFolders/Scripts/Inputs/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace GameFolders.Scripts.Inputs
{
    public class @InputActions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""231cd40b-116b-4194-81e5-7fa7b04a3aa7"",
            ""actions"": [
                {
                    ""name"": ""Directions"",
                    ""type"": ""Value"",
                    ""id"": ""5a88ce26-511f-463a-a630-cb7e7262cde1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseDirection"",
                    ""type"": ""Value"",
                    ""id"": ""e509f38b-58b6-4f42-a687-9daa37b0a8c5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""c6b83a2f-0333-4ea1-9cac-b6028baae657"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5207bfc7-dfde-44db-9de0-72d5c8c660ef"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""57b89fe1-8040-498e-8b93-be550f1fbb7a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ce7cee42-0893-4f8a-b994-48de99b11b82"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c855b43c-2814-4a49-81c2-b49334f35af3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c696ec98-b312-441e-bd90-6f85fab67bf7"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Directions = m_Player.FindAction("Directions", throwIfNotFound: true);
            m_Player_MouseDirection = m_Player.FindAction("MouseDirection", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_Directions;
        private readonly InputAction m_Player_MouseDirection;
        public struct PlayerActions
        {
            private @InputActions m_Wrapper;
            public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Directions => m_Wrapper.m_Player_Directions;
            public InputAction @MouseDirection => m_Wrapper.m_Player_MouseDirection;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @Directions.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirections;
                    @Directions.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirections;
                    @Directions.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirections;
                    @MouseDirection.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseDirection;
                    @MouseDirection.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseDirection;
                    @MouseDirection.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseDirection;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Directions.started += instance.OnDirections;
                    @Directions.performed += instance.OnDirections;
                    @Directions.canceled += instance.OnDirections;
                    @MouseDirection.started += instance.OnMouseDirection;
                    @MouseDirection.performed += instance.OnMouseDirection;
                    @MouseDirection.canceled += instance.OnMouseDirection;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        public interface IPlayerActions
        {
            void OnDirections(InputAction.CallbackContext context);
            void OnMouseDirection(InputAction.CallbackContext context);
        }
    }
}
