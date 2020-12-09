using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class GameStart : MonoBehaviour
{
    private void Start()
    {
        XRSettings.enabled = false;
    }
    public void VR()
    {
        SceneManager.LoadScene(2);
        XRSettings.enabled = true;
    }
    public void Desktop()
    {
        SceneManager.LoadScene(1);
        XRSettings.enabled = false;
    }
}
