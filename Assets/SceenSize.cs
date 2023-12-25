using UnityEngine;

public class ScreenSizeController : MonoBehaviour
{
    void Start()
    {
        Screen.SetResolution(1920, 1080, true);
    }
}