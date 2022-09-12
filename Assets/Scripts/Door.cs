using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private CameraController cam;
    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag== "Player")
        {
            if (collision.transform.position.x < transform.position.x)
                cam.MoveTonewRoom(nextRoom);
            else
                cam.MoveTonewRoom(previousRoom);
        }
    }
}
