using UnityEngine;

namespace Weapon_Script
{
    public class WeaponManager : MonoBehaviour
    {
        [SerializeField] private GameObject[] projectiles;

        [SerializeField] private Transform[] projectileSpawnPoints;

        [SerializeField] private float shootTimerThreshold = 1f;

        [SerializeField] private float shootTimer;

        [SerializeField] private bool canShoot;


        private void Update()
        {
            if (Time.time > shootTimer)
            {
                canShoot = true;
            }

            HandlePlayerShooting();
        }

        private void HandlePlayerShooting()
        {
            // if canShoot is false  -  if we cant shoot
            if (!canShoot)
            {
                // Exit function (Method)
                return;
            }

            // Shoot Blaster 1
            if (Input.GetKeyDown(KeyCode.J))
            {
                Instantiate(projectiles[0], projectileSpawnPoints[0].position, Quaternion.identity);

                // Shooting two times in a row
                Instantiate(projectiles[0], projectileSpawnPoints[1].position, Quaternion.identity);
            }

            // Shoot Blaster 2
            if (Input.GetKeyDown(KeyCode.K))
            {
                Instantiate(projectiles[1], projectileSpawnPoints[0].position, Quaternion.identity);

                // Shooting two times in a row
                Instantiate(projectiles[1], projectileSpawnPoints[1].position, Quaternion.identity);
            }

            // Shoot Laser
            if (Input.GetKeyDown(KeyCode.L))
            {
                Instantiate(projectiles[2], projectileSpawnPoints[0].position, Quaternion.identity);

                // Shooting two times in a row
                Instantiate(projectiles[2], projectileSpawnPoints[1].position, Quaternion.identity);
            }

            // Shoot Heavy Rocket
            if (Input.GetKeyDown(KeyCode.O))
            {
                Instantiate(projectiles[3], projectileSpawnPoints[2].position, Quaternion.identity);
            }

            // Shoot Missile
            if (Input.GetKeyDown(KeyCode.I))
            {
                Instantiate(projectiles[4], projectileSpawnPoints[2].position, Quaternion.identity);
            }
        } // Handle Shooting

        void ResetShootingTimer()
        {
            canShoot = false;
            shootTimer = Time.time + shootTimerThreshold;
        }
    }
} // Class - Controller