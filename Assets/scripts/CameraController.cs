using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //pozycja gracza
    Transform player;
    //offset kamery
    Vector3 offset;
    //prędkość kamery
    Vector3 cameraSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //linkujemy pozycje gracza do zmiennej lokalnej
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //zapisujemy aktualny offset kamery
        offset = transform.position - player.position;
    }
    void Update()
    {
        Vector3 targetPosition = player.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref cameraSpeed, 0.3f);
    }
}
