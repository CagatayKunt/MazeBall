using GameFolders.Scripts.Controllers;
using UnityEngine;

namespace GameFolders.Scripts.Behaviours
{
    public class MovementBehaviours : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;

        [SerializeField] private Transform _head;
        
        private Vector2 _playerDirection;
        private Vector2 _playerRotate;
        
        public void Initialize()
        {
            InputController.Instance.DirectionKeysPress+=OnDirectionKeysPress;
            InputController.Instance.MousePositionChange += OnMousePositionChange;
        }

        private void OnMousePositionChange(Vector2 delta)
        {
            _playerRotate = delta;
        }

        private void OnDirectionKeysPress(Vector2 wasd)
        {
            _playerDirection = wasd;
        }

        private void PlayerMove()
        {
            Vector3 newDirection = new Vector3(_playerDirection.x,0f,_playerDirection.y);
            transform.Translate(newDirection*_moveSpeed);
        }

        private void PlayerLeftRightLook()
        {
            Vector3 newLeftRigtRotation = new Vector3(0f,_playerRotate.x,0f);
            transform.Rotate(newLeftRigtRotation);
        }

        private void PlayerHeadUpDownLook()
        {
            Vector3 newUpDownRotation = new Vector3(-_playerRotate.y, 0f, 0f);
            _head.Rotate(newUpDownRotation);
        }
        
        private void Update()
        {
            PlayerMove();
            PlayerLeftRightLook();
            PlayerHeadUpDownLook();
        }
    }
}
