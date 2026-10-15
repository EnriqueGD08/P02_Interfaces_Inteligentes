using UnityEngine;

public class Cube6 : MonoBehaviour
{
    [SerializeField] private Color materialAlcanzado = Color.red;

    private Renderer renderizador;
    private bool materialCambiado;

    private void Awake()
    {
        renderizador = GetComponent<Renderer>();
    }

    public void CambiarMaterial()
    {
        if (materialCambiado || renderizador == null)
        {
            return;
        }

        renderizador.material.color = materialAlcanzado;
        materialCambiado = true;
    }
}
