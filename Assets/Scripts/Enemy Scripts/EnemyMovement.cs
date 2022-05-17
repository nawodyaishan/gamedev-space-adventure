using UnityEngine;

namespace Enemy_Scripts
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private bool moveOnX, moveOnY;
        [SerializeField] private float minX, maxX;
        [SerializeField] private float minY, maxY;

        [SerializeField] private float moveSpeed = 8f;

        [SerializeField] private float horizontalMovementTreshold = 8f;
        [SerializeField] private float verticalMovementTreshold = 6f;

        private Vector3 tempMovement_Horizontal;
        private Vector3 tempMovement_Vertical;

        private bool moveLeft;
        [SerializeField] private bool moveUp = false;

        private void Start()
        {
            var transform1 = transform;
            var position = transform1.position;
            minX = position.x - horizontalMovementTreshold;
            maxX = position.x + horizontalMovementTreshold;

            maxY = position.y = verticalMovementTreshold;
            minY = position.y - verticalMovementTreshold;

            if (Random.Range(0, 2) > 0)
            {
                moveLeft = true;
            }
        }

        private void Update()
        {
            HandleEnemyMovementHorizontal();
            HandleEnemyMovementVertical();
        }

        void HandleEnemyMovementHorizontal()
        {
            if (!moveOnX)
                return;

            if (moveLeft)
            {
                var transform1 = transform;
                tempMovement_Horizontal = transform1.position;
                tempMovement_Horizontal.x -= moveSpeed * Time.deltaTime;
                transform1.position = tempMovement_Horizontal;

                if (tempMovement_Horizontal.x < minX)
                {
                    moveLeft = false;
                }
            }

            else
            {
                var transform1 = transform;
                tempMovement_Horizontal = transform1.position;
                tempMovement_Horizontal.x += moveSpeed * Time.deltaTime;
                transform1.position = tempMovement_Horizontal;

                if (tempMovement_Horizontal.x > maxX)
                {
                    moveLeft = true;
                }
            }
        }


        void HandleEnemyMovementVertical()
        {
            if (!moveOnY)
                return;

            if (moveUp)
            {
                var transform2 = transform;
                tempMovement_Vertical = transform2.position;
                tempMovement_Vertical.y += moveSpeed * Time.deltaTime;
                transform2.position = tempMovement_Vertical;

                if (tempMovement_Horizontal.y > maxY)
                {
                    moveLeft = false;
                }
            }

            else
            {
                var transform2 = transform;
                tempMovement_Vertical = transform2.position;
                tempMovement_Vertical.y -= moveSpeed * Time.deltaTime;
                transform2.position = tempMovement_Vertical;

                if (tempMovement_Vertical.y < minY)
                {
                    moveUp = true;
                }
            }
        }
    }
} //Class