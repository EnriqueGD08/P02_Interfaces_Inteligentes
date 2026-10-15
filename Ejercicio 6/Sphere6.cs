using UnityEngine;

public class Sphere6 : MonoBehaviour
{
    [SerializeField] private float velocidad = 2f;

    private Cylinder6 objetivo;
    private Cube6 obstaculo;
    private bool haAlcanzadoElObstaculo;

    private void Start()
    {
        objetivo = FindFirstObjectByType<Cylinder6>();
        obstaculo = FindFirstObjectByType<Cube6>();
    }

    private void Update()
    {
        if (objetivo == null || obstaculo == null || haAlcanzadoElObstaculo)
        {
            return;
        }

        Vector3 posicionAnterior = transform.position;
        transform.position = Vector3.MoveTowards(
            transform.position,
            objetivo.transform.position,
            velocidad * Time.deltaTime);

        if (Vector3.Distance(transform.position, obstaculo.transform.position) <= 1f)
        {
            transform.position = posicionAnterior;
            haAlcanzadoElObstaculo = true;
            obstaculo.CambiarMaterial();
        }
    }
}
