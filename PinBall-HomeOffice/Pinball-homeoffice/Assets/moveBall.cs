using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;

    public Vector2 horizontalMovement;
    private float horizontalMoveForce = 2;
    private float jumpForce = 2;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        rigidbody2D.AddForce(horizontalMovement * horizontalMoveForce);

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    public void Jump()
    {
        rigidbody2D.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
    }
}
