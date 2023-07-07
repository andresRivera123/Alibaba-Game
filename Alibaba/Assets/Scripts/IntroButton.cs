using UnityEngine;
using UnityEngine.UI;

public class TextListChanger : MonoBehaviour
{
    public Text[] textComponents;

    public void ChangeText()
    {
        foreach (Text textComponent in textComponents)
        {
            textComponent.text = "Nuevo texto";
        }
    }
}