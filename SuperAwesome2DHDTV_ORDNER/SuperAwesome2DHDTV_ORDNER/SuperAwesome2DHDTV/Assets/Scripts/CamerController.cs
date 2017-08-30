using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour {

    public Transform player;
   
    public float xBoundsMin;
    public float xBoundsMax;

    public float yBoundsMin;
    public float yBoundsMax;
    private void Start()
    {
       
    }
    private void Update()
    {
        if(player.position.x > xBoundsMin && player.position.x < xBoundsMax && player.position.y > yBoundsMin)
        {
            transform.position = new Vector3( player.position.x,player.position.y, -10);
        }
       
        
/*        if (player.position.y > yBoundsMin && player.position.y < yBoundsMax)
        {
            transform.position = new Vector3(player.position.x, player.position.y, -10);
        }*/
        /*if (player.position.x < yBoundsMax)
        {
            transform.position = new Vector3(player.position.x, player.position.y, -10);
        }*/
    }
}
