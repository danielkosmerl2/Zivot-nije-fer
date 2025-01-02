using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHoverPriority : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Vector3 hoverScale = new Vector3(1.2f, 1.2f, 1.2f); // Scale on hover
    private Vector3 originalScale;
    private int originalSiblingIndex;

    private void Start()
    {
        originalScale = transform.localScale; // Store the original scale
        originalSiblingIndex = transform.GetSiblingIndex(); // Store the original sibling index
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = hoverScale; // Scale up
        transform.SetAsLastSibling(); // Move to the top of the hierarchy to render above others
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = originalScale; // Revert to original scale
        transform.SetSiblingIndex(originalSiblingIndex); // Restore original sibling index
    }
}
