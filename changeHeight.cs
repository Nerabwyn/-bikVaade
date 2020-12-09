using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeHeight : MonoBehaviour
{
    public GameObject sliderVal;
    
    public float val = 25f;
    public Vector3 w;

    private void Start()
    {
        w = gameObject.transform.position;
        gameObject.transform.position = new Vector3(w.x, w.y + val, w.z);

    }

    private void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(w.x, w.y+val-25, w.z);
    }

    public void ChangeValue()
    {
        val = sliderVal.GetComponent<Slider>().value;
    }
}
