using UnityEngine;

namespace Enemy_Scripts
{
    public class EnemyMovementInPoints : MonoBehaviour
    {
        [SerializeField] private Transform[] movementPoints;

        private int currentMoveIndex;

        private Vector3 targetPosition;

        [SerializeField] private float moveSpeed = 8f;

        private bool moveRandomly;

        void SelectRandomPosition()
        {
            while (movementPoints[currentMoveIndex].position == targetPosition)
            {
                currentMoveIndex = Random.Range(0, movementPoints.Length);
            }

            targetPosition = movementPoints[currentMoveIndex].position;
        }

        void SetTargetPosition()
        {
            if (currentMoveIndex == movementPoints.Length)
            {
                currentMoveIndex = 0;
            }

            targetPosition = movementPoints[currentMoveIndex].position;

            currentMoveIndex++;
        }

        void SelectPointToPointPosition()
        {
            if (moveRandomly)
            {
                SelectRandomPosition();
            }
            else
            {
                SelectPointToPointPosition();
            }
        }

        private void Move()
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                SetTargetPosition();
            }
        }
    }
} // Class