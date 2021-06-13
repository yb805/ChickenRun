using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChickenController : MonoBehaviour
{
    public float speed = 20f;
    public float Maxhp;
    public float hp;
    public GameObject Cam;
    public Image healthBar;


    Rigidbody rigidbody;
    Animator animator;

    Vector3 movement;
    float horizontalMove;
    float verticalMove;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        Maxhp = 3;
        hp = 1;
        healthBar = GameObject.Find("HealthGauge").GetComponent<Image>();
        healthBar.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            var offset = Cam.transform.forward;
            offset.y = 0;
        }

        if (healthBar.fillAmount == 0)
        {
            SceneManager.LoadScene("OverScene");
        }


        Run();
        Turn();
        AnimationUpdate();
    }

    void Run()
    {
        movement.Set(horizontalMove, 0, verticalMove);
        movement = movement.normalized * speed * Time.deltaTime;

        rigidbody.MovePosition(transform.position + movement);
    }

    void Turn()
    {
        Quaternion newRotation = Quaternion.LookRotation(movement);

        rigidbody.MoveRotation(newRotation);
    }

    void AnimationUpdate()
    {
        if (horizontalMove == 0 && verticalMove == 0)
        {
            animator.SetBool("isWalking", false);
        }
        else
        {
            animator.SetBool("isWalking", true);
        }
    }


    public void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Trap")
        {
            healthBar.fillAmount -= hp / Maxhp;
        }

        if (other.gameObject.tag == "Food")
        {
            healthBar.fillAmount += hp / Maxhp;
        }

    }

}
