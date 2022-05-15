using System.Collections.Generic;
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

        private bool projectileSpawned;
        private float shooterTimer;
        private bool canShoot;
    }
} // Class