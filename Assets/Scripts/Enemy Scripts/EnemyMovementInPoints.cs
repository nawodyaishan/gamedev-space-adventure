using UnityEngine;

public class EnemyMovementInPoints : MonoBehaviour
{
    [SerializeField] private Transform[] movementPoints;

    private int currentMoveIndex;

    private Vector3 targetPosition;

    [SerializeField] private float moveSpeed = 8f;

    private bool moveRandomly;

    void SelectRandomPosition()
    {
    }

    void SetTargetPosition()
    {
    }

    void SelectPointToPointPosition()
    {
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            SetTargetPosition
        }
    }
} // Class