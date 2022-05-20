using Manager_Scripts;
using UnityEngine;

namespace Gameplay_Controller
{
    public class Collector : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag(TagManager.PRIJECTILE_TAG))
                collision.gameObject.SetActive(false);

            if (collision.CompareTag(TagManager.METEOR_TAG))
                collision.gameObject.SetActive((false));
        }
    }
} //class