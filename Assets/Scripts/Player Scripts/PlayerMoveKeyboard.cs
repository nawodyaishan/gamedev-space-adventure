using UnityEngine;

namespace Player_Scripts
{
    public class PlayerMoveKeyboard : MonoBehaviour
    {
        [SerializeField] private float speed = 600f;
        private Rigidbody2D _myBody;

        private void Awake()
        {
            _myBody = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            HandleMovement();
        }

        void HandleMovement()
        {
        }
    }
} //Class 