using UnityEngine;

public class Objeto15 : MonoBehaviour
{
    [SerializeField] private float fuerzaLanzamiento = 7f;
    [SerializeField] private Vector3 direccionLanzamiento = Vector3.forward;

    private Rigidbody cuerpo;

    private void Awake()
    {
        cuerpo = GetComponent<Rigidbody>();

        PhysicsMaterial materialResbaladizo = new PhysicsMaterial("MaterialResbaladizo")
        {
            dynamicFriction = 0f,
            staticFriction = 0f,
            bounciness = 0.05f,
            frictionCombine = PhysicsMaterialCombine.Minimum,
            bounceCombine = PhysicsMaterialCombine.Minimum
        };

        GetComponent<Collider>().material = materialResbaladizo;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            cuerpo.AddForce(direccionLanzamiento.normalized * fuerzaLanzamiento, ForceMode.Impulse);
        }
    }
}
