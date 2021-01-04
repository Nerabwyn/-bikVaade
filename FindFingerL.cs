using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindFingerL : MonoBehaviour
{
    public GameObject finger;
    private float searchTime = 2;
    // Start is called before the first frame update
    void Start()
    {
        finger = GameObject.Find("finger_index_l_aux");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (searchTime > 0)
        {
            searchTime -= Time.deltaTime;
        }
        else
        {
            finger = GameObject.Find("finger_index_l_aux");
            searchTime = 2;
        }

        if(finger != null)
        {
            gameObject.transform.SetParent(finger.transform);
            gameObject.transform.position = new Vector3(finger.transform.position.x + 0.029883f, finger.transform.position.y, finger.transform.position.z);
            Destroy(this);
        }
    }
}
