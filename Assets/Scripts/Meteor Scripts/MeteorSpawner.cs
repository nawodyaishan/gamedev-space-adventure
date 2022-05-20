using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Meteor_Scripts
{
    public class MeteorSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject[] meteors;

        [SerializeField] private float minX, maxX;

        [SerializeField] private float minSpawnInterval = 4f, maxSpawnInterval = 10f;

        private int randomSpawnNumber;

        private Vector3 randomSpawnPosition;

        void SpawnMeteors()
        {
            randomSpawnNumber = Random.Range(0, meteors.Length);
            for (int i = 0; i < randomSpawnNumber; i++)
            {
                var spawnPosition = transform.position;
                randomSpawnPosition = new Vector3(Random.Range(minX, maxX), spawnPosition.y, 0f);
                Instantiate(meteors[Random.Range(0, meteors.Length)], randomSpawnPosition, quaternion.identity);
            }
        }


        private void Awake()
        {
        }

        private void Start()
        {
        }

        private void Update()
        {
        }
    }
} // Class