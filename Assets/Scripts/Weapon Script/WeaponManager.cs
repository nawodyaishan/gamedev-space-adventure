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
        }
    }
} // Controller