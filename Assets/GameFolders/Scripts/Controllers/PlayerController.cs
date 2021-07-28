using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameFolders.Scripts.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        private Vector3 _playerPosition;
        private PlayerController _playerController;
        private InputController _inputController;
        private Rigidbody rb;
        
        private void Awake()
        {
        }

        private void Update()
        {
        }

        private void FixedUpdate()
        {
            Vector3 currentPosition = transform.position;
            var direction = InputController.Instance.Direction;
            Vector3 newDirection = new Vector3(direction.x,currentPosition.y,direction.y);
            transform.Translate(newDirection*_moveSpeed);
        }
    }
}