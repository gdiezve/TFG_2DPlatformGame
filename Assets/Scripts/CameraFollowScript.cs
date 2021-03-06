using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public GameObject player;
    private float deltaX;
    public float deltaY;
    private float cameraY;
    private float cameraZ;
    
    // Start is called before the first frame update
    void Start()
    {
        deltaX = Mathf.Abs(player.transform.position.x - transform.position.x);
        cameraY = transform.position.y;
        cameraZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        YFollow();
        setCameraPosition();
    }

    void setCameraPosition()
    {
        transform.position = new Vector3(player.transform.position.x + deltaX, cameraY, cameraZ);
    }

    void YFollow()
    {
        if (player.transform.position.y < transform.position.y -  deltaY) 
        {
            cameraY = player.transform.position.y + deltaY;
        }
        else if (player.transform.position.y > transform.position.y + deltaY)
        {
            cameraY = player.transform.position.y - deltaY;
        }
    }
}
