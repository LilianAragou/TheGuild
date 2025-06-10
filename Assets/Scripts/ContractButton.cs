using UnityEngine;
using UnityEngine.EventSystems;

public class ContractButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerEnter == gameObject)
        {
            switch (eventData.button)
            {
                case PointerEventData.InputButton.Left:
                    Refuser();
                    break;
                case PointerEventData.InputButton.Right:
                    Accepter();
                    break;
            }
        }
    }

    private void Accepter()
    {
        Debug.Log("Contrat accepté");
    }

    private void Refuser()
    {
        Debug.Log("Contrat refusé");
    }
}
