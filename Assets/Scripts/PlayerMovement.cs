using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    private bool soundTime;
    private float soundTimer = 0.4f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (soundTime)
        {
            if (x == 1 || x == -1 || z == 1 || z == -1)
            {
                AkSoundEngine.PostEvent("footstep", this.gameObject);

                soundTime = false;
                soundTimer = 0.4f;
            }
        }
    
    if (!soundTime)
		{
            soundTimer -= Time.deltaTime;
            if (soundTimer < 0)
			{
                soundTime = true;
			}
		}

     controller.Move(move * speed * Time.deltaTime);
    }
}
