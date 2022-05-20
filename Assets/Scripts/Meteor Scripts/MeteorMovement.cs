using UnityEngine;

namespace Meteor_Scripts
{
    public class MeteorMovement : MonoBehaviour
    {
        [SerializeField] private float minSpeed = 4f, maxSpeed = 10f;

        private float speedX, speedY;

        [SerializeField] bool moveOnX, moveOnY = true;

        [SerializeField] private float minRotationSpeed = 15f, maxRotationSpeed = 50f;

        [SerializeField] float rotationSpeed;

        private Vector3 tempMovement;

        private float zRotation;

        private void Awake()
        {
            rotationSpeed = Random.Range(minRotationSpeed, maxRotationSpeed);

            speedX = Random.Range(minSpeed, maxSpeed);
            speedY = speedX;

            if (Random.Range(0, 2) > 0)
            {
                // Changing Direction of Meteor
                speedX *= -1;
            }

            if (Random.Range(0, 2) > 0)
            {
                rotationSpeed *= -1f;
            }

            if (Random.Range(0, 2) > 0)
            {
                moveOnX = true;
            }
        }


        private void Start()
        {
        }

        private void Update()
        {
        }
    }
} // Class