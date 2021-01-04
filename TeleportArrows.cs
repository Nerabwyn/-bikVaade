using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportArrows : MonoBehaviour
{
    public GameObject destination;
    public GameObject Player;

    private void Start()
    {
        Player = GameObject.Find("Player");
    }
    void OnCollisionEnter(Collision collision)
    {
        Player.transform.position = new Vector3(destination.transform.position.x + 1, destination.transform.position.y, destination.transform.position.z);
    }
}