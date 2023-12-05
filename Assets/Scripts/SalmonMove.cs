using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalmonMove : MonoBehaviour
{
    public SpawnManager spawnManager;
    public float movementSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(movementSpeed, 0, 0) * Time.deltaTime;
        float hMovement = Input.GetAxis("Horizontal") * 10;

        transform.Translate(new Vector3(0, 0, hMovement) * Time.deltaTime);
    }


    // Update is called once per frame


    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}
