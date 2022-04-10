using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   // public Rigidbody rb;
    public CharacterController controller;
    private Vector3 playerVelocity;
    public float playerSpeed = 5f;

    private Vector3 movementx;
    private Vector3 movementz;

    public int hp;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            Debug.Log("hit food");
            Destroy(collision.gameObject);
            SFXManager.clip.audio.PlayOneShot(SFXManager.clip.pressed);
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("hit enemy");
            Destroy(collision.gameObject);
            hp--;
            damageSound.clip.audio.PlayOneShot(damageSound.clip.pressed);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        hp = 100;

        controller = gameObject.AddComponent<CharacterController>();
        controller.radius = 0.0f;
        controller.height = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

         if (move != Vector3.zero)
         {
             gameObject.transform.forward = move;
         }

         //controller.Move(playerVelocity * Time.deltaTime);

        /*movementx = new Vector3(Input.GetAxis("Horizontal") * playerSpeed, 0, 0);
        movementz = new Vector3(0, 0, Input.GetAxis("Vertical") * playerSpeed);

        transform.Translate(movementx);
        transform.Translate(movementz);*/

    }
}
