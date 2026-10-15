using UnityEngine;

public class Recolectable4 : MonoBehaviour
{
    private void Awake()
    {
        int recolectablesLayer = LayerMask.NameToLayer("Recolectables");
        int jugadorLayer = LayerMask.NameToLayer("Jugador");

        gameObject.layer = recolectablesLayer;
        Physics.IgnoreLayerCollision(recolectablesLayer, jugadorLayer, false);

        foreach (Collider collider in GetComponentsInChildren<Collider>())
        {
            collider.isTrigger = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.gameObject.layer == LayerMask.NameToLayer("Jugador"))
        {
            Debug.Log(name + " ha sido detectado por el jugador");
        }
    }
}
