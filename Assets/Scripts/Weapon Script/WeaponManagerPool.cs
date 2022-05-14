using System.Collections.Generic;
using UnityEngine;

namespace Weapon_Script
{
    public class WeaponManagerPool : MonoBehaviour
    {

        [SerializeField] private GameObject projectile;
        
        [SerializeField] List<GameObject> projectilePool = new List<GameObject>();
         
        
        
        
        private void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                GameObject g = Instantiate(projectile);
                projectilePool.Add(g);
                
            }

        }
        
        
        
         
    }
} // Class