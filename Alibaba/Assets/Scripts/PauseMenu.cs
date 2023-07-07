using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject canva;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }

    }

    public void back()
    {
        canva.SetActive(false);
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f; // Detiene el tiempo
            // Mostrar el menú de pausa (activar el Canvas)
            canva.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f; // Reanuda el tiempo
            // Ocultar el menú de pausa (desactivar el Canvas)
            canva.SetActive(false);
        }
    }
}