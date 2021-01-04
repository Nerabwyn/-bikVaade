using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTime : MonoBehaviour
{
    public List<GameObject> Items;
    private bool enabled;

    void OnCollisionEnter(Collision collision)
    {

        if (!enabled)
        {
            foreach (var obj in Items)
                obj.SetActive(true);
        }
        else
        {
            foreach (var obj in Items)
                obj.SetActive(false);
        }
    }
}
