using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DivingMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public float movementspeed = 10;
    public bool wall_collidedleft = false;
    public bool wall_collidedright = false;

    public GameObject playerobject;
    public Rigidbody2D rb;
    public float move_side;
    private float move_down;
    public Slider s;
    public GameObject background;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        //check left right input 
        move_side = Input.GetAxis("Horizontal"); // <0 is left, >0 is right 

        move_down = Input.GetAxis("Vertical");  // positive is up, negative is down 
        Debug.Log("move down");

        if(move_down >= 0)
        {
            move_down = 0; 
        }

        if (move_side <0 && wall_collidedleft == true) {
            move_side = 0;
        }

        else if (move_side > 0 && wall_collidedright == true)
        {
            move_side = 0;
            Debug.Log("stop moving right");
        }


        //get screen width and object width
        //float screenW = background.GetComponent<SpriteRenderer>().bounds.size.x;
        //float objectW = playerobject.gameObject.GetComponent<BoxCollider2D>().bounds.size.x;
        //if player is moving left and hits left border, block movement
        //if (move_side < 0)
        //{
        //    if (transform.position.x <= 0 - screenW / 2 + objectW / 2)
        //    {
        //        move_side = 0;
        //        //Debug.Log("left_boder");
        //    }
        //}
        ////if player is moving right and hits right border, block movement
        //if (move_side > 0)
        //{
        //    if (transform.position.x >= screenW / 2 - objectW / 2)
        //    {
        //        move_side = 0;
        //        //Debug.Log("right_boder");
        //    }
        //}


        transform.position += new Vector3(move_side, move_down, 0) * Time.deltaTime * movementspeed;

    }

  

}
