using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollected : MonoBehaviour
{
    [SerializeField] GameObject gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.GetComponent<GameManager>().CountGems();
            Destroy(gameObject, 0);
        }
    }
}
