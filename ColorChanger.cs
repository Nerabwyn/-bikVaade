using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Light light;
    public Color Currentcolor;
    public float CurrentIntensity;
    public int opt;

    public Color GirlColor;
    public Color BoyColor;
    public Color ChristmasColor;

    public float GirlIntensity = 2186208f;
    public float BoyIntensity = 2186208f;
    public float ChristmasIntensity = 2186208f;

    private void Start()
    {
        light.intensity = 2186208f;
    }
    void Update()
    {
        Currentcolor = light.color;
        CurrentIntensity = light.intensity;
    }


    public void ItsAGirl()
    {
        StartCoroutine(switchColor(GirlColor, GirlIntensity));
    }
    public void ItsABoy()
    {
        StartCoroutine(switchColor(BoyColor, BoyIntensity));
    }
    public void ItsAChristmas()
    {
        StartCoroutine(switchColor(ChristmasColor, ChristmasIntensity));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (opt == 0)
        {
            StartCoroutine(switchColor(GirlColor, GirlIntensity));
        }
        else if (opt == 1)
        {
            StartCoroutine(switchColor(BoyColor, BoyIntensity));
        }
        else if (opt == 2)
        {
            StartCoroutine(switchColor(ChristmasColor, ChristmasIntensity));
        }
    }

    IEnumerator switchColor(Color GivenColor, float GivenIntensity)
    {
        var animSpeed = 0.5f;

        Color color = light.color;
        float intensity = light.intensity;
        

        float progress = 0.0f;  //This value is used for lerping

        while (progress < 1.0f)
        {
            light.color = Color.Lerp(color, GivenColor, progress);
            light.intensity = Mathf.Lerp(intensity, GivenIntensity, progress);
            yield return new WaitForEndOfFrame();
            progress += Time.deltaTime * animSpeed;
        }

        //Set final transform
        light.color = GivenColor;
        light.intensity = GivenIntensity;
    }
}
