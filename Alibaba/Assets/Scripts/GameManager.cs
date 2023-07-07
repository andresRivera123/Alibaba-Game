using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text textGemScore;
    public static int gem = 0;

    private void Start()
    {
        // Recuperar el valor de gem del PlayerPrefs al iniciar la escena
        gem = PlayerPrefs.GetInt("GemScore", 0);
        UpdateGemScore();
    }

    public void CountGems()
    {
        gem++;
        UpdateGemScore();
    }

    private void UpdateGemScore()
    {
        textGemScore.text = gem.ToString();
    }

    private void OnDestroy()
    {
        // Guardar el valor de gem en PlayerPrefs al destruir el objeto
        PlayerPrefs.SetInt("GemScore", gem);
    }
}
