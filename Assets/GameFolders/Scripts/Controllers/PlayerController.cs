using System;
using GameFolders.Scripts.Behaviours;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameFolders.Scripts.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private MovementBehaviours _movementBehaviours;

        private void Start()
        {
            _movementBehaviours.Initialize();
        }
    }
}