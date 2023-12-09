using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{

    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 7f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;   
    public Sprite kangan;
    public Sprite pudong;

    private Animator anim;
    private SpriteRenderer sprite;
    private Rigidbody2D rb;
    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    public float speed = 5;

    public float jumpSpeed = 5;
    bool isGrounded;
    bool canDoubleJump;
    public float delayBeforeDoubleJump;

    private enum MovementState {  idle, running, jumping}

    public static int numberOfCoins;
    public TextMeshProUGUI coinsText;

    private void Awake()
    {
        numberOfCoins = PlayerPrefs.GetInt("NumberOfCoins", 0);
    }
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();

        moveLeft = false;
        moveRight = false;



    }

    public void SkillDash()
    {
        if (isDashing)
        {
            return;
        }
        if(canDash == true)
        {
        StartCoroutine(Dash());
        }
    }

    private IEnumerator Dash()
    {

        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        yield return new WaitForSeconds(dashingTime);
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;

    }


    

    public void PointerDownLeft()
    {
        moveLeft = true;
    }

    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    public void PointerDownRight()
    {
        moveRight = true;
    }

    public void PointerUpRight()
    {
        moveRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = numberOfCoins.ToString();
        MovePlayer(); 

    }

    private void MovePlayer()
    {
        MovementState state;

        if(moveLeft)
        {
            horizontalMove = -speed;
            state = MovementState.running;
            sprite.flipX = true;
        }
        else if (moveRight)
        {
            
            horizontalMove = speed;
            state = MovementState.running;
            sprite.flipX = false;
        }
        else
        {
            horizontalMove = 0;
            state = MovementState.idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }

        anim.SetInteger("state", (int)state);
    }




    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            isGrounded = true;
            canDoubleJump = false;
        }
        

    }

    public void jumpButton()
    {


        if(isGrounded)
        {
            isGrounded = false;
            rb.velocity = Vector2.up * jumpSpeed;
            Invoke("EnableDoubleJump" , delayBeforeDoubleJump);

        }
        if (canDoubleJump)
        {
            rb.velocity = Vector2.up * jumpSpeed;
            canDoubleJump = false;
        }


    }

    void EnableDoubleJump()
    {
        canDoubleJump = true;
    }

    private void FixedUpdate()
    {

        
        if (isDashing)
        {
            return;
        }


        rb.velocity = new Vector2(horizontalMove, rb.velocity.y );

    }

    public void addCoins()
    {
        numberOfCoins += 50;
        Update();  // Update UI to show the new coin count

        // Save the updated number of coins to PlayerPrefs
        PlayerPrefs.SetInt("NumberOfCoins", numberOfCoins);
        PlayerPrefs.Save();
    }
    
}