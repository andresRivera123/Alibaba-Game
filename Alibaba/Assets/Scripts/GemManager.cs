using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GemManager : MonoBehaviour
{
    public GameObject transition;
    public GameObject playerDesactive;

    void Update()
    {
        AllGemCompleted();
    }

    public void AllGemCompleted()
    {
        if(transform.childCount == 0)
        {
            transition.SetActive(true);
            playerDesactive.SetActive(false);
            Invoke("ChangeScene", 2);
        }
    }

    void ChangeScene()
    {
        //Exportamos la libreria UnityEngine.SceneManagement;
        //Con esta linea de codigo aumentamos 1 en la lista de escenas y pasa a la siguiente
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
