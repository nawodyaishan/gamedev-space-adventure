using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy_Scripts
{
    public class EnemySpawner : MonoBehaviour
    {
        public static EnemySpawner Instance;

        [SerializeField] private GameObject[] enemies;

        private List<GameObject> spawnedEnemies = new List<GameObject>();

        [SerializeField] private Transform[] spawnPoints;

        [SerializeField] private float spawnWaitTime = 2f;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
        }

        private void SpawnNewWaveOfEnemies()
        {
            if (spawnedEnemies.Count > 0)
                return;

            for (int i = 0; i < spawnPoints.Length; i++)
            {
                int randIndex = Random.Range(0, enemies.Length);
                GameObject newEnemy = Instantiate(enemies[randIndex], spawnPoints[i].position, Quaternion.identity);
            }
        }

        IEnumerator _SpawnWave(float waitTime)
        {
            yield return new WaitForSeconds(waitTime);

            SpawnNewWaveOfEnemies();
        }


        private void Start()
        {
        }

        private void Update()
        {
        }
    }
} // Class