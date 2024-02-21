using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasherController : MonoBehaviour
{
    GameObject player;
    public float walkSpeed = 1f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        transform.LookAt(player.transform.position);
        transform.position += transform.forward * Time.deltaTime * walkSpeed;
    }
}