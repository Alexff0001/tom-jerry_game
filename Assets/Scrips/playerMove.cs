using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float speed;
    float x;
    Rigidbody2D rb;
    Vector2 move;
    private bool FacingRight = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        move = new Vector2(x * speed, rb.velocity.y);
        rb.velocity = move;


        if (x < 0 && !FacingRight)
        {
            Flip();
        }
        else if(x > 0 && FacingRight) 
        {
            Flip();
        }
    }

    private void Flip()
    {
        FacingRight = !FacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
