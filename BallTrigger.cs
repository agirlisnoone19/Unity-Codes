using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrigger : MonoBehaviour
{
  
   
    GameManager gameManager;
    private void OnEnable()
    {
        gameManager = GetComponent<GameManager>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "1")
        {
            GLOBAL.CylinderOneCount += 1;

            if (gameObject.GetComponent<Renderer>().material.color == Color.red)
            {
                GLOBAL.c1r += 1;
            }
            else if (gameObject.GetComponent<Renderer>().material.color == Color.blue)
            {
                GLOBAL.c1b += 1;
            }
            else if (gameObject.GetComponent<Renderer>().material.color == Color.green)
            {
                GLOBAL.c1g += 1;
            }
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "2")
        {
            GLOBAL.CylinderTwoCount += 1;
            if (gameObject.GetComponent<Renderer>().material.color == Color.red)
            {
                GLOBAL.c2r += 1;
            }
            else if (gameObject.GetComponent<Renderer>().material.color == Color.blue)
            {
                GLOBAL.c2b += 1;
            }
            else if (gameObject.GetComponent<Renderer>().material.color == Color.green)
            {
                GLOBAL.c2g += 1;
            }
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "3")
        {
            GLOBAL.CylinderThreeCount += 1;
            if (gameObject.GetComponent<Renderer>().material.color == Color.red)
            {
                GLOBAL.c3r += 1;
            }
            else if (gameObject.GetComponent<Renderer>().material.color == Color.blue)
            {
                GLOBAL.c3b += 1;
            }
            else if (gameObject.GetComponent<Renderer>().material.color == Color.green)
            {
                GLOBAL.c3g += 1;
            }
            Destroy(this.gameObject);
        }
    }
}
