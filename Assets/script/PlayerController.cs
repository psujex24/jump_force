using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody playetRb;

    void Start()
    {
        playetRb = GetComponent<Rigidbody>();
        playetRb.AddForce(Vector3.up * 1000);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
