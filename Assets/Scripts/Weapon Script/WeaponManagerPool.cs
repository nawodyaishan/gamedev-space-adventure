using System.Collections.Generic;
using Manager_Scripts;
using UnityEngine;

namespace Weapon_Script
{
    public class WeaponManagerPool : MonoBehaviour
    {
        [SerializeField] private GameObject projectile;
        [SerializeField] List<GameObject> projectilePool = new List<GameObject>();
        [SerializeField] private KeyCode keyToPressToShoot;
        [SerializeField] private Transform projectileSpawnPoint;
        [SerializeField] private float shootWaitTime = 0.2f;
        [SerializeField] private bool isEnemy;
        [SerializeField] private bool canShoot;

        private GameObject projectileHolder;
        private bool projectileSpawned;
        private float shootTimer;

        private void Awake()
        {
            if (isEnemy)
            {
                projectileHolder = GameObject.FindWithTag(TagManager.ENEMY_PROJECTILE_HOLDER_TAG);
                ResetShootingTimer();
            }
            else
            {
                projectileHolder = GameObject.FindWithTag(TagManager.PLAYER_PROJECTILE_HOLDER_TAG);
            }
        }

        private void Update()
        {
            if (Time.time > shootTimer)
                canShoot = true;
            HandlePlayerShooting();
            HandleEnemyShooting();
        }

        private void HandlePlayerShooting()
        {
            if (!canShoot || isEnemy)
                return;

            if (Input.GetKeyDown(keyToPressToShoot))
            {
                GetObjectFromPoolOrGetANewOne();
                ResetShootingTimer();
            }
        }

        private void GetObjectFromPoolOrGetANewOne()
        {
            for (int i = 0; i < projectilePool.Count; i++)
            {
                if (!projectilePool[i].activeInHierarchy)
                {
                    projectilePool[i].transform.position = projectileSpawnPoint.position;
                    projectilePool[i].SetActive(true);
                    projectileSpawned = true;
                    break;
                }
                else
                {
                    projectileSpawned = false;
                }
            }

            if (!projectileSpawned)
            {
                GameObject newProjectile = Instantiate(projectile, projectileSpawnPoint.position, Quaternion.identity);
                projectilePool.Add(newProjectile);

                newProjectile.transform.SetParent(projectileHolder.transform);

                projectileSpawned = true;
            }
        }

        void ResetShootingTimer()
        {
            canShoot = false;

            if (isEnemy)
            {
                shootTimer = Time.time + Random.Range(shootWaitTime, (shootWaitTime + 1));
            }
            else
            {
                shootTimer = Time.time + shootWaitTime;
            }
        }

        private void HandleEnemyShooting()
        {
            if (!isEnemy || !canShoot)
                return;

            ResetShootingTimer();
            GetObjectFromPoolOrGetANewOne();
        }
    }
} // Class   