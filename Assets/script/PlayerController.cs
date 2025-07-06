using Unity.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody playetRb;
    public float jumpForce = 10;
    public float gravityModifier;


    void Start()
    {
        playetRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playetRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
