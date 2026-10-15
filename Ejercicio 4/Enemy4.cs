using UnityEngine;

public class Enemy4 : MonoBehaviour
{
    private void Awake()
    {
        int enemigosLayer = LayerMask.NameToLayer("Enemigos");
        int jugadorLayer = LayerMask.NameToLayer("Jugador");

        gameObject.layer = enemigosLayer;
        Physics.IgnoreLayerCollision(enemigosLayer, jugadorLayer, false);

        foreach (Collider collider in GetComponentsInChildren<Collider>())
        {
            collider.isTrigger = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.transform.root.gameObject.layer == LayerMask.NameToLayer("Jugador"))
        {
            Debug.Log(name + " ha colisionado con el jugador");
        }
    }
}
