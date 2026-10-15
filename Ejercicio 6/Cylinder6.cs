using UnityEngine;

public class Cylinder6 : MonoBehaviour
{
    [SerializeField] private Color colorObjetivo = Color.green;

    private void Awake()
    {
        Renderer renderizador = GetComponent<Renderer>();
        if (renderizador != null)
        {
            renderizador.material.color = colorObjetivo;
        }
    }
}
