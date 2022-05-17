using UnityEngine;

public class EnemyMovementInPoints : MonoBehaviour
{
    [SerializeField] private Transform[] movementPoints;

    private int currentMoveIndex;

    private Vector3 targetPosition;

    [SerializeField] private float moveSpeed = 8f;

    private bool moveRandomly;

    private void Move()
    {
    }
} // Class