using UnityEngine;

public class CuboGrand3 : MonoBehaviour
{
    public Color colorInicial = Color.white;


    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        colorInicial = other.GetComponent<Renderer>().material.color;
        other.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        other.GetComponent<Renderer>().material.color = colorInicial;
    }
}
