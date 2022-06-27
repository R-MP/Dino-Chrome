using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dino : MonoBehaviour
{
    public float jumpPower;
    bool isJumping = false;
    float pontos;
    public Text pontosText;
    Rigidbody2D rb;
    Animator animator;
    public GameManager gameManager;

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

        pontos += Time.deltaTime * 10;
        pontosText.text = "Pontos: " + Mathf.FloorToInt(pontos).ToString();
    }
    void OnCollisionEnter2D(Collision2D collision){
        isJumping = false;

        if(collision.gameObject.tag=="obstaculos"){
            gameManager.GameOver();
        }
    }
    
}
