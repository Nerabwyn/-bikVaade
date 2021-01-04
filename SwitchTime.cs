using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public List<GameObject> Items;
    private bool enabled = true;
    private float timef = 2;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        timef -= Time.deltaTime;
    }


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided");
        if (!enabled && timef < 0)
        {
            Debug.Log("activated");
            foreach (var obj in Items)
                if (obj.active)
                {
                    obj.SetActive(false);
                }
                else
                {
                    obj.SetActive(true);
                }
            enabled = true;
            timef = 2;
        }
        else if(enabled && timef < 0)
        {
            Debug.Log("activated");
            foreach (var obj in Items)
                if (obj.active)
                {
                    obj.SetActive(false);
                }
                else
                {
                    obj.SetActive(true);
                }
            enabled = false;
            timef = 2;
        }
        else { }
    }
}
