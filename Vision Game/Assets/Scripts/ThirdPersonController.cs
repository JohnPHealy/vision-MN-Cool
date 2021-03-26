namespace UnityEngine.InputSystem
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.InputSystem;

    [RequireComponent(typeof(CharacterController))]

    public class ThirdPersonController : MonoBehaviour
    {
        [SerializeField] private float speed = 10f;
        [SerializeField] private float rotationSmoothing = 0.1f;

        private Vector3 movement;
        private CharacterController myController;
        private float rotateVelocity;

        void Start()
        {
            myController = GetComponent<CharacterController>();
        }

        void Update()
        {
            float angle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;
            angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, angle, ref rotateVelocity, rotationSmoothing);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            myController.Move(movement.normalized * (speed * Time.deltaTime));
        }

        public void Move(InputAction.CallbackContext context)
        {
            var moveInput = context.ReadValue<Vector2>();
            movement = new Vector3(moveInput.x, 0f, moveInput.y).normalized;
        }
    }
}