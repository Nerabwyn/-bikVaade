using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.Rendering;
using UnityTemplateProjects;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
using UnityEngine.VR;

public class GameManager : MonoBehaviour
{
    public GameObject camera;
    public GameObject cameraTarget;
    public GameObject DayTimeObjects;
    public GameObject Lights;
    public bool playing = false;
    public bool started = false;
    public bool nightview;
    public Vector3 pos;
    public Vector3 rot;


    public List<GameObject> menuDisable;
    public List<GameObject> menuButtons;
    public List<GameObject> levelButtons;
    public List<GameObject> LightSettings;


    public List<Light> StripLightTop;


    // Start is called before the first frame update
    void Start()
    {
        camera.GetComponent<CameraMove>().enabled = false;
        SetCamera();
        if(Application.loadedLevel == 0 || Application.loadedLevel == 1)
        {
            XRSettings.enabled = false;
        }
        else
        {
            XRSettings.enabled = true;
        }
    }

    private void Update()
    {
        if (nightview == true)
        {
            foreach (var obj in LightSettings)
                obj.SetActive(true);
        }
        else
        {
            foreach (var obj in LightSettings)
                obj.SetActive(false);
        }
    }

    public void StartGame()
    {
        foreach (var obj in menuButtons)
            obj.SetActive(false);

        foreach (var obj in levelButtons)
            obj.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void ToMenu()
    {
        camera.GetComponent<CameraMove>().enabled = false;
        SetCamera();
        hideLightMenu();




        foreach (var obj in levelButtons)
            obj.SetActive(true);

        foreach (var obj in menuDisable)
            obj.SetActive(false);
    }


    public void toMainMenu()
    {
        camera.GetComponent<CameraMove>().enabled = false;
        SetCamera();
        hideLightMenu();

        foreach (var obj in menuButtons)
            obj.SetActive(true);

        foreach (var obj in menuDisable)
            obj.SetActive(false);

        foreach (var obj in levelButtons)
            obj.SetActive(false);
    }
    public void FreelookToggle()
    {
        if (GameObject.Find("Toggle").GetComponent<Toggle>().isOn)
        {
            camera.GetComponent<CameraMove>().enabled = false;
            camera.GetComponent<SimpleCameraController>().enabled = true;
        }
        else
        {
            camera.GetComponent<CameraMove>().enabled = true;
            camera.GetComponent<SimpleCameraController>().enabled = false;
        }

    }
    public void NightView()
    {
        Lights.SetActive(true);
        DayTimeObjects.SetActive(false);
        camera.GetComponent<CameraMove>().enabled = true;
        HideMenu();
        nightview = true;


    }
    public void DayView()
    {
        Lights.SetActive(false);
        DayTimeObjects.SetActive(true);
        camera.GetComponent<CameraMove>().enabled = true;
        HideMenu();

    }

    public void SetCamera()
    {
        camera.transform.position = cameraTarget.transform.position;
        camera.transform.rotation = cameraTarget.transform.rotation;
    }

    public void HideMenu()
    {
        foreach (var obj in menuButtons)
            obj.SetActive(false);

        foreach (var obj in menuDisable)
            obj.SetActive(true);

        foreach (var obj in levelButtons)
            obj.SetActive(false);
    }

    private void hideLightMenu()
    {
        if (nightview)
        {
            nightview = false;
        }
    }


}
