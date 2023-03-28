using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler2 : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
       // if (Input.GetKeyDown(KeyCode.UpArrow))
       // {
           // Vector3 position = this.transform.position;
            //position.y++;
           // this.transform.position = position;
        //}
       // if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
           // Vector3 position = this.transform.position;
           // position.y--;
           // this.transform.position = position;
       // }

        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            // Player shooting Projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}

