using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
   // public Rigidbody rb;
    public CharacterController controller;
    private Vector3 playerVelocity;
    public float playerSpeed = 5f;

    private Vector3 movementx;
    private Vector3 movementz;

    public GameObject popBox;
    public Animator animator;
   // public TMP_Text popUpText;

    public int hp;

    private TriggerBoundary tb;
    

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
        else if (collision.gameObject.tag == "Boundary")
        {
            Debug.Log("hit boundary");

            //Pop Up Section
            popBox.SetActive(true);
            animator.SetTrigger("pop");

            Destroy(collision.gameObject);
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

       // tb = gameObject.AddComponent<TriggerBoundary>(); 
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

    }
}
