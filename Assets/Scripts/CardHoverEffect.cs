using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHoverAdjust : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Vector3 hoverScale = new Vector3(1.2f, 1.2f, 1.2f); // Scale on hover
    public float hoverOffsetY = 10f; // How much to move up when hovered

    private Vector3 originalScale;
    private Vector3 originalPosition;

    private void Start()
    {
        originalScale = transform.localScale; // Store the original scale
        originalPosition = transform.localPosition; // Store the original position
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = hoverScale; // Scale up
        transform.localPosition = originalPosition + new Vector3(0, hoverOffsetY, 0); // Move up
        transform.SetAsLastSibling(); // Render above other buttons
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = originalScale; // Revert scale
        transform.localPosition = originalPosition; // Revert position
    }
}
