using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGround : MonoBehaviour
{
    public static bool isGround;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Terrain"))
        {
            isGround = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGround = false;
    }
}
