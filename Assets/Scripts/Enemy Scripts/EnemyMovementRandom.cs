using UnityEngine;

namespace Enemy_Scripts
{
    public class EnemyMovementRandom : MonoBehaviour
    {
        [SerializeField] private float minX, maxX;
        [SerializeField] private float minY, maxY;

        [SerializeField] private float moveSpeed = 8f;

        private Vector3 targetPosition;

        private void Start()
        {
            SetTargetPosition();
        }

        private void Update()
        {
            Move();
        }

        void SetTargetPosition()
        {
            targetPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0f);
        }

        void Move()
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * moveSpeed);


            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                SetTargetPosition();
            }
        }
    }
} // Class