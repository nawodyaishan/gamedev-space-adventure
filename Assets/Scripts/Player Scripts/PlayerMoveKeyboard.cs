using UnityEngine;

namespace Player_Scripts
{
    public class PlayerMoveKeyboard : MonoBehaviour
    {
        [SerializeField] private float speed = 600f;
        private Rigidbody2D myBody;

        private void Awake()
        {
            myBody = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            HandleMovement();
        }

        void HandleMovement()
        {
            // Move Upwards
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                myBody.AddForce(transform.up * speed);

            // Move Down
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                myBody.AddForce(-transform.up * speed);

            // Move Left
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                myBody.AddForce(-transform.right * speed);

            // Move Right
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                myBody.AddForce(transform.right * speed);
        }
    }
} //Class 