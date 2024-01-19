using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   public float HorizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public  GameObject ProjectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //Gives Limit to the players movements from left to right
        if (transform.position.x < -xRange) {
        transform.position = new Vector3 (-xRange, transform.position.y, transform.position.z);
    }
    {   if (transform.position.x > xRange) {
        transform.position = new Vector3 (xRange, transform.position.y, transform.position.z);
    }
        //Allows the player to move left and right
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);
    }

    // when Space is pressed a prefab is created into our game.
    if(Input.GetKeyDown(KeyCode.Space)) {
        Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);
    }
}
}
