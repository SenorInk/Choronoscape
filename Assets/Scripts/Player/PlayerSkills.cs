using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
    private bool isDashing = false;
    public float dashSpeed = 10f;
    public float dashDuration = 0.2f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update called.");
        if (Input.touchCount > 0) 
        {
            Debug.Log("Touch detected.");
            if(Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Debug.Log("Touch detected.");
            }
        }
{
    Dash();
}
    }

    // Time Leap
    public void Dash()
    {
        Debug.Log("Dash called.");
        if (!isDashing)
        {
            isDashing = true;
            Invoke("StopDash", dashDuration);
            // Set the player's velocity for the dash
            rb.velocity = new Vector2(transform.localScale.x * dashSpeed, rb.velocity.y);
        }
    }

    private void StopDash()
    {
        isDashing = false;
        // Additional logic to stop the dash if needed...
    }
}
