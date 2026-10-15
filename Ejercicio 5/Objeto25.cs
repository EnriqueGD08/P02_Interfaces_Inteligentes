using UnityEngine;

public class Objeto25 : MonoBehaviour
{
    [SerializeField] private float fuerzaLanzamiento = 7f;
    [SerializeField] private Vector3 direccionLanzamiento = Vector3.forward;

    private Rigidbody cuerpo;

    private void Awake()
    {
        cuerpo = GetComponent<Rigidbody>();

        PhysicsMaterial materialRugoso = new PhysicsMaterial("MaterialRugoso")
        {
            dynamicFriction = 1f,
            staticFriction = 1f,
            bounciness = 0f,
            frictionCombine = PhysicsMaterialCombine.Maximum,
            bounceCombine = PhysicsMaterialCombine.Minimum
        };

        GetComponent<Collider>().material = materialRugoso;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            cuerpo.AddForce(direccionLanzamiento.normalized * fuerzaLanzamiento, ForceMode.Impulse);
        }
    }
}
