using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFlow : MonoBehaviour
{
    private Transform player;

    private float yOffset = 5;
    private float xOffset = -15;

    void Start()
    {
        player = GameObject.Find("SockeyeSalmon").transform;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x + xOffset, player.position.y + yOffset, player.position.z);
    }
}
