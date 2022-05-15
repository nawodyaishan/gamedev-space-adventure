using UnityEngine;

namespace Weapon_Script
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private float speed = 3f;

        [SerializeField] public float minDamage = 5f;
        [SerializeField] public float maxDamage = 6f;

        private float projectileDamage;


        [SerializeField] private AudioClip spawnSound;
        [SerializeField] private AudioClip destroySound;

        [SerializeField] private GameObject boomEffect;


        private void Start()
        {
            projectileDamage = (int) Random.Range(minDamage, maxDamage);
        }

        private void OnEnable()
        {
            if (spawnSound)
            {
                AudioSource.PlayClipAtPoint(spawnSound, new Vector3(0f, 6f, 0f));
            }
        }


        private void Update()
        {
            transform.Translate(0f, speed * Time.deltaTime, 0f);
        }
    }
} // Class