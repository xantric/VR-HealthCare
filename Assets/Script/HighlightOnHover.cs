using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HighlightOnHover : MonoBehaviour
{
    public Material highlightMaterial;
    public Material defaultMaterial;
    private SkinnedMeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<SkinnedMeshRenderer>();
        var interactable = GetComponent<XRSimpleInteractable>();

        interactable.hoverEntered.AddListener(OnHoverEnter);
        interactable.hoverExited.AddListener(OnHoverExit);
        interactable.selectEntered.AddListener(OnSelect);
    }

    void OnHoverEnter(HoverEnterEventArgs args)
    {
        Debug.Log("Hover enter!");
        meshRenderer.material = highlightMaterial;
    }

    void OnHoverExit(HoverExitEventArgs args)
    {
        Debug.Log("Hover exit!");
        meshRenderer.material = defaultMaterial;
    }

    void OnSelect(SelectEnterEventArgs args)
    {
        Debug.Log("Object Selected!");
    }
}
