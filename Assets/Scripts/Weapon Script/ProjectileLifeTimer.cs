using UnityEngine;

namespace Weapon_Script
{
    public class ProjectileLifeTimer : MonoBehaviour
    {
        [SerializeField] private float timer = 3f;

        void OnEnable()
        {
            Invoke(nameof(DeactivateProjectile), timer);
        }

        void DeactivateProjectile()
        {
            if (gameObject.activeInHierarchy)
                gameObject.SetActive(false);
        }
    }
}