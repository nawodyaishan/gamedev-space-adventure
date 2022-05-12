using UnityEngine;

namespace Weapon_Script
{
    public class WeaponManager : MonoBehaviour
    {
        [SerializeField] private GameObject[] projectiles;

        [SerializeField] private Transform[] projectileSpawnPoints;

        [SerializeField] private float shootTimerThreshold = 0.2f;

        [SerializeField] private float shootTimer;

        [SerializeField] private bool canShoot;


        private void Update()
        {
        }

        private void HandlePlayerShooting()
        {
            // if canShoot is false  -  if we cant shoot
            if (!canShoot)
            {
                // Exit function (Method)
                return;
            }

            if (Input.GetKey(KeyCode.J))
            {
                Instantiate(projectiles[0], projectileSpawnPoints[0]);
            }
        }
    }
} // Controller