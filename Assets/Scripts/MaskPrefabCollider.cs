using UnityEngine;

public class MaskPrefabCollider : MonoBehaviour
{
   
    [SerializeField] ScratchCard card;

    private void OnMouseOver()
    {
        card.isOver = false;
    }

  

}
