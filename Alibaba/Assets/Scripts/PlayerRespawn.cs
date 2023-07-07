using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector2 startPosition;
    public Animator animator;
    private bool isRespawning = false;
    private float respawnDelay = 0.1f; // Tiempo de espera antes de reposicionar al personaje

    private void Start()
    {
        startPosition = player.transform.position;
    }

    public void Respawn()
    {
        if (!isRespawning)
        {
            isRespawning = true;
            animator.Play("Hit");
            StartCoroutine(RespawnCoroutine());
        }
    }

    private IEnumerator RespawnCoroutine()
    {
        // Esperar el tiempo de duración de la animación "Hit"
        float animationDuration = animator.GetCurrentAnimatorStateInfo(0).length;
        yield return new WaitForSeconds(animationDuration + respawnDelay);
        // Reposicionar al personaje y restablecer la bandera
        player.transform.position = startPosition;
        isRespawning = false;
    }
}
