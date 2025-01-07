using UnityEngine;

public class ShowEnergy : MonoBehaviour
{
    public GameObject elementPrefab; // Assign your prefab in the Inspector
    public Transform panel; // Assign the parent panel with the Vertical Layout Group


    public void Start()
    {
        UpdateElements(3);
    }
    /// <summary>
    /// Updates the number of elements in the panel to match the given amount.
    /// </summary>
    /// <param name="amount">The desired number of elements.</param>
    public void UpdateElements(int amount)
    {
        // Get the current number of elements
        int currentCount = panel.childCount;

        // Add elements if the amount is greater than the current count
        if (amount > currentCount)
        {
            for (int i = currentCount; i < amount; i++)
            {
                AddElement();
            }
        }
        // Remove elements if the amount is less than the current count
        else if (amount < currentCount)
        {
            for (int i = currentCount - 1; i >= amount; i--)
            {
                RemoveElement(i);
            }
        }
    }

    /// <summary>
    /// Adds a new element to the top of the stack.
    /// </summary>
    private void AddElement()
    {
        GameObject newElement = Instantiate(elementPrefab, panel);
        newElement.transform.SetAsFirstSibling(); // Add the new element to the top
        ConfigureElement(newElement); // Ensure consistent size
    }

    /// <summary>
    /// Removes the element at the specified index.
    /// </summary>
    /// <param name="index">The index of the element to remove.</param>
    private void RemoveElement(int index)
    {
        if (index >= 0 && index < panel.childCount)
        {
            Destroy(panel.GetChild(index).gameObject);
        }
    }

    /// <summary>
    /// Configures the size and appearance of an element.
    /// </summary>
    /// <param name="element">The element to configure.</param>
    private void ConfigureElement(GameObject element)
    {
        RectTransform rectTransform = element.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(200, 50); // Set fixed width and height
    }
}
