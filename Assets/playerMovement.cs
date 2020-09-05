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

    public GameObject playerIdle;
    public CharacterController contoller;

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal"); // 1 is right, -1 is left
        float y = Input.GetAxis("Vertical"); // 1 is up, -1 is down

        if (y > 0 && playerLoc>=2) //press up
        {
            playerLoc -= 2;
            Debug.Log("up" + playerLoc);
        }else if (y < 0 && playerLoc<=1) //press down
        {
            playerLoc += 2;
            Debug.Log("down" + playerLoc);
        }
        if (x > 0 && playerLoc%2==0) //press right
        {
            playerLoc += 1;
            Debug.Log("right" + playerLoc);
        }
        else if (x < 0 && playerLoc%2==1) //press left
        {
            playerLoc -= 1;
            Debug.Log("left" + playerLoc);
        }

        int playertop = 1;
        if (playerLoc < 2) //player is in up position
            playertop = 0;

        if (playerLoc % 2 == 0) //player is on left
        {
            playerIdle.transform.localPosition = new Vector3(1f, 2f - (3 * playertop), -3.5f);
        }
        else if (playerLoc % 2 == 1) //player is on right
        {
            playerIdle.transform.localPosition = new Vector3(1f, 2f - (3 * playertop), 0f);
        }

        if (playerLoc < 2) //player is on top
        {
            playerIdle.transform.localPosition = new Vector3(1f, 2f, -3.5f+(3.5f*(playerLoc % 2)));
        }
        else if (playerLoc >=2) //player is on bottom
        {
            playerIdle.transform.localPosition = new Vector3(1f, -1f, -3.5f + (3.5f * (playerLoc % 2)));
        }
    }
}
