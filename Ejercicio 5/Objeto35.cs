using UnityEngine;

public class Objeto35 : MonoBehaviour
{
    [SerializeField] private float fuerzaLanzamiento = 7f;
    [SerializeField] private Vector3 direccionLanzamiento = Vector3.forward;

    private Rigidbody cuerpo;

    private void Awake()
    {
        cuerpo = GetComponent<Rigidbody>();

        PhysicsMaterial materialReboteAlto = new PhysicsMaterial("MaterialReboteAlto")
        {
            dynamicFriction = 0.2f,
            staticFriction = 0.2f,
            bounciness = 1f,
            frictionCombine = PhysicsMaterialCombine.Minimum,
            bounceCombine = PhysicsMaterialCombine.Maximum
        };

        GetComponent<Collider>().material = materialReboteAlto;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            cuerpo.AddForce(direccionLanzamiento.normalized * fuerzaLanzamiento, ForceMode.Impulse);
        }
    }
}
