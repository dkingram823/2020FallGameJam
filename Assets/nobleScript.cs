using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nobleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        frameCount = 0;
        nobleState = 0;
        resetCount = 0;
    }

    public GameObject noble;
    public SpriteRenderer renderer;
    public int frameCount;
    public int nobleState;
    public int resetCount;

    // Update is called once per frame
    void Update()
    {
        frameCount += 1;
        if (frameCount == 59)
            frameCount = 0;

        int ran = Random.Range(0, 590);

        if(ran == frameCount*10 && nobleState == 0) //noble becomes prone
        {
            nobleState = 1;
            resetCount = 1;
        }

        
        if(nobleState == 1) //noble is prone
        {
            renderer.color = new Color(0,255,11,255);
        }

        if (resetCount > 0)
        {
            if (resetCount == 60) //noble escapes
            {
                resetCount = 0;
                nobleState = 0;

                renderer.color = new Color(255, 255, 255, 255);

            }
            else
                resetCount++;
        }

        
    }
}
