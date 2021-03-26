namespace UnityEngine.InputSystem
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.InputSystem;

    [RequireComponent(typeof(CharacterController))]

    public class ThirdPersonController : MonoBehaviour
    {
        private Vector3 movement;

        void Start()
        {

        }

        void Update()
        {

        }

        public void Move(InputAction.CallbackContext context)
        {
            var moveInput = context.ReadValue<Vector2>();
            movement = new Vector3(moveInput.x, 0f, moveInput.y).normalized;
        }
    }
}