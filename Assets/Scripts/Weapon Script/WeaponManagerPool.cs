using System.Collections.Generic;
using Manager_Scripts;
using UnityEngine;

namespace Weapon_Script
{
    public class WeaponManagerPool : MonoBehaviour
    {
        [SerializeField] private GameObject projectile;
        List<GameObject> projectilePool = new List<GameObject>();
        [SerializeField] private GameObject projectileHolder;
        [SerializeField] private KeyCode keyToPressToShoot;
        [SerializeField] private Transform projectileSpawnPoint;
        [SerializeField] private float shootWaitTime = 0.2f;
        [SerializeField] private bool isEnemy;
        [SerializeField] private bool canShoot;

        private bool projectileSpawned;
        private float shootTimer;

        private void Awake()
        {
            if (isEnemy)
            {
                projectileHolder = GameObject.FindWithTag(TagManager.ENEMY_PROJECTILE_HOLDER_TAG);
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

        void ResetShhotingTimer()
        {
            canShoot = false;

            if (isEnemy)
            {
                shootTimer = Time.time + shootWaitTime;
            }
        }

        private void HandleEnemyShooting()
        {
        }
    }
} // Class