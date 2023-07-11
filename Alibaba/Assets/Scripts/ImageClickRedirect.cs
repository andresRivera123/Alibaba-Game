using UnityEngine;
using UnityEngine.EventSystems;

public class ImageClickRedirect : MonoBehaviour
{
    public string URL = null;

    public void openURL()
    {
        Application.OpenURL(URL);
    }


}