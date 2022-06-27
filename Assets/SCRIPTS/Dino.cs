using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dino : MonoBehaviour
{
    public float jumpPower;
    bool isJumping = false;
    Rigidbody2D rb;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isJumping == false){
            rb.AddForce(new Vector2(0, jumpPower));
            isJumping = true;
        }  
        if(Input.GetKey(KeyCode.DownArrow)){
            animator.SetBool("abaixado", true);   
        }else{
            animator.SetBool("abaixado", false);
        }
    }
    void OnCollisionEnter2D(Collision2D collision){
        isJumping = false;
    }
    
}
