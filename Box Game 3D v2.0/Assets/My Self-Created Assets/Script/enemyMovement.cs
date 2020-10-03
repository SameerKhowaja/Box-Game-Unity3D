using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform tf;
    public float force;
    public float xPos;
    Random randomDirection = new Random();
    public float timer;
    public float score=0;
    public Material mt;


    private void Start()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        mt.color = newColor;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Backwall")
        {
            xPos = Random.Range(-5.0f, 5.0f);
            //Debug.Log("Hit");
            tf.transform.localPosition = new Vector3(xPos, -1.75f, 117f);
            
        }

        if (collision.collider.name == "Player")
        {
            var parentObjects = GameObject.FindGameObjectsWithTag("Enemies");
            foreach (var gameObject in parentObjects)
            {
                var components = gameObject.GetComponentsInChildren<Component>();
                foreach (var component in components)
                {
                    var collider = component as BoxCollider;
                    if (collider)
                        collider.enabled = false;

                    var renderer = component as Renderer;
                    if (renderer)
                        renderer.enabled = false;

                    var script = component as enemyMovement;
                    if (script)
                    {
                        script.force = 0f;

                        script.enabled = false;
                    }
                        
                }
            }
            
            Debug.Log("Game End");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        force = -1000;
        timer += Time.deltaTime;
        
        if (timer > 10f)
        {
            score += 300;
            //Reset the timer to 0.
            timer = 0;
        }
        rb.AddForce(0,0, (force-score) * Time.deltaTime);
    }
}
