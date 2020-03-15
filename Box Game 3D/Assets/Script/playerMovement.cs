using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    public playerMovement pmove;
    public Material mt;
    public AudioSource ad, backsound;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemies")
        {
            Debug.Log("Game End");
            ad.enabled = true;
            backsound.enabled = false;
            pmove.enabled = false;
        }
    }

    private void Start()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        mt.color = newColor;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //For Keyboard
        //float h = Input.GetAxis("Horizontal") * speed;
        //For Mobile JoyStick
        float h = SimpleInput.GetAxis("Horizontal") * speed;
        //
        this.transform.Translate(h * Time.deltaTime, 0, 0);
    }
}
