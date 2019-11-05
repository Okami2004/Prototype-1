using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerCam : MonoBehaviour
{
    public GameObject player; 
    private Vector3 offset = new Vector3(0, 11, -12);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //offset the camera by adding the players position
      transform.position = player.transform.position + offset; 
    }
}
