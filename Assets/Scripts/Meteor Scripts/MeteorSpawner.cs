using UnityEngine;

namespace Meteor_Scripts
{
    public class MeteorSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject[] meteors;

        [SerializeField] private float minX, maxX;

        [SerializeField] private int minSpawnNo = 1, maxSpawnNo = 5;

        [SerializeField] private float minSpawnInterval = 4f, maxSpawnInterval = 10f;

        private int randomSpawnNumber;

        private Vector3 randomSpawnPosition;

        private void SpawnMeteors()
        {
            randomSpawnNumber = Random.Range(minSpawnNo, maxSpawnNo);
            for (int i = 0; i < randomSpawnNumber; i++)
            {
                var spawnPosition = transform.position;
                randomSpawnPosition = new Vector3(Random.Range(minX, maxX), spawnPosition.y, 0f);
                Instantiate(meteors[Random.Range(0, meteors.Length)], randomSpawnPosition, Quaternion.identity);
            }

            Invoke(nameof(SpawnMeteors), Random.Range(minSpawnInterval, maxSpawnInterval));
        }


        private void Awake()
        {
        }

        private void Start()
        {
            Invoke(nameof(SpawnMeteors), Random.Range(minSpawnInterval, maxSpawnInterval));

            //  InvokeRepeating(nameof(SpawnMeteors), 1f,1f);

            // InvokeRepeating(nameof(SpawnMeteors), Random.Range(minSpawnInterval,maxSpawnInterval),Random.Range(minSpawnInterval,maxSpawnInterval));
        }

        private void Update()
        {
        }

        public void CheckToSpawnNewWaves(GameObject shipToRemove)
        {
        }
    }
} // Class