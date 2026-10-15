using UnityEngine;

public class ColorCol2 : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(name + " ha colisionado con " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Cube") || collision.gameObject.CompareTag("Sphere"))
        {
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube") || collision.gameObject.CompareTag("Sphere"))
        {
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}