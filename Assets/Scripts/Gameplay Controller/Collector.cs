using Manager_Scripts;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(TagManager.PRIJECTILE_TAG))
            collision.gameObject.SetActive(false);
    }
} //class