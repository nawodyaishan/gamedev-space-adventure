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
        }
    }
} //Class