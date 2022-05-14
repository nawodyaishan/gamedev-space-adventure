using System;
using UnityEngine;

namespace Weapon_Script
{
    public class ProjectileLifeTimer : MonoBehaviour
    {
        [SerializeField] private float destroyTimer = 3f;

        private void Start()
        {
            Destroy(gameObject, destroyTimer);
        }
    }
}