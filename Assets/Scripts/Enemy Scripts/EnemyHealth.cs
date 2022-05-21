using UnityEngine;

namespace Enemy_Scripts
{
    public class EnemyHealth : MonoBehaviour
    {
        [SerializeField] private GameObject healthBar;

        private Vector3 healthBarScale;

        [SerializeField] private float health = 100;

        [SerializeField] private GameObject destroyEffect;

        [SerializeField] private GameObject hitEffect;

        public void TakeDamage(float damageAmount, float damageResistance)
        {
            damageAmount -= damageResistance;
            health -= damageAmount;

            if (health <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
            }

            SetHealthBar();
        }

        void SetHealthBar()
        {
            if (!healthBar)
            {
                return;
            }

            healthBarScale = healthBar.transform.localScale;
            healthBarScale.x = health / 100;
            healthBar.transform.localScale = healthBarScale;
        }

        private void Update()
        {
        }

        private void Start()
        {
        }


        private void Awake()
        {
        }
    }
} // class