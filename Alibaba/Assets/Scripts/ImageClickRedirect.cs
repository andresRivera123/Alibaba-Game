using UnityEngine;
using UnityEngine.EventSystems;

public class ImageClickRedirect : MonoBehaviour
{
    public string URL = "https://github.com/andresRivera123";

    public void openURL()
    {
        Application.OpenURL(URL);
    }


}