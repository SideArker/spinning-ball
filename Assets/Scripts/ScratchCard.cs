using System.Collections.Generic;
using UnityEngine;

public class ScratchCard : MonoBehaviour
{
   
    public GameObject maskPrefab;
    public bool isOver = false;
    public List<GameObject> masks = new List<GameObject>();

    private void OnMouseOver()
    {
        isOver = true;
    }

    private void OnMouseExit()
    {
        isOver = false;
    }


    void Update()
    {
        if (isOver)
        {
           
            var mousePos = Input.mousePosition;
            mousePos.z = 50;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            if (Input.GetMouseButton(0))
            {
                GameObject maskSprite = Instantiate(maskPrefab, mousePos, Quaternion.identity);
                masks.Add(maskSprite);
                maskSprite.transform.SetParent(gameObject.transform);
            }
        }
    }
}
