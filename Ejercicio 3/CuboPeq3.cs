using UnityEngine;

public class CuboPeq3 : MonoBehaviour
{
    public float incrementoDamage = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        other.GetComponent<MovFis>().damage += incrementoDamage;
        Debug.Log("Daño aumentado a " + other.GetComponent<MovFis>().damage);
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        other.GetComponent<MovFis>().damage -= incrementoDamage;
        Debug.Log("Daño reducido a " + other.GetComponent<MovFis>().damage);
        Debug.Log("El jugador ha salido de la zona de daño");
    }
}
