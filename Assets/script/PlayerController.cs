using Unity.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Animator playerAnim;
    private Rigidbody playetRb;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOneGround = true;
    public bool gameOver = false;


    void Start()
    {
        playerAnim = GetComponent<Animator>();
        playetRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOneGround && gameOver == false)
        {
            playetRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOneGround = false;
            playerAnim.SetTrigger("Jump_trig");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOneGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        }
    }
}
