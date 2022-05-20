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