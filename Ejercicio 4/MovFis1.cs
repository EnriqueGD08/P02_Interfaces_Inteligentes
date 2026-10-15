using UnityEngine;

public class MovFis : MonoBehaviour
{
    Rigidbody rb;
    public float damage = 30f;

    void Awake()
    {
        gameObject.layer = LayerMask.NameToLayer("Jugador");
        rb = GetComponent<Rigidbody>();

        int jugadorLayer = LayerMask.NameToLayer("Jugador");
        int enemigosLayer = LayerMask.NameToLayer("Enemigos");
        int recolectablesLayer = LayerMask.NameToLayer("Recolectables");

        for (int layer = 0; layer < 32; layer++)
        {
            if (layer != jugadorLayer)
            {
                Physics.IgnoreLayerCollision(enemigosLayer, layer, true);
                Physics.IgnoreLayerCollision(recolectablesLayer, layer, true);
            }
        }

        Physics.IgnoreLayerCollision(jugadorLayer, enemigosLayer, false);
        Physics.IgnoreLayerCollision(jugadorLayer, recolectablesLayer, false);
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime * 5);
    }
}