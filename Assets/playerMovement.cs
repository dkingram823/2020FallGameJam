using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerLoc;
    void Start()
    {
        playerLoc = 0;
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal"); // 1 is right, -1 is left
        float y = Input.GetAxis("Vertical"); // 1 is up, -1 is down

        if (y > 0 && playerLoc>=2) //press up
        {
            playerLoc -= 2;
        }else if (y < 0 && playerLoc<=1) //press down
        {
            playerLoc += 2;
        }
        if (x > 0 && playerLoc%2==0) //press right
        {
            playerLoc += 1;
        }
        else if (x < 0 && playerLoc%2==1) //press left
        {
            playerLoc -= 1;
        }




    }
}
