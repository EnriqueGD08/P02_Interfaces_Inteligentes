using UnityEngine;

public class MovFis : MonoBehaviour
{
    Rigidbody rb;
    public float damage = 30f;

    void FixedUpdate()
    {
        rb = GetComponent<Rigidbody>();
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.transform.Translate(movement * Time.deltaTime * 5);
    }
}