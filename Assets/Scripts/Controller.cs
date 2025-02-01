using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Controller : MonoBehaviour
{
    [SerializeField] GameObject selectedObject = null;
    [SerializeField] Material selectedMaterial;
    [SerializeField] Material hoveredMaterial;
    [SerializeField] Material defaultMaterial;

    bool isMouseClicked = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isMouseClicked = Input.GetMouseButtonDown(0);
    }

    public void Hovering(GameObject hoveree)
    {
        if (selectedObject != null)
        {
            selectedObject.GetComponent<Clickable>().ChangeSelect(false, defaultMaterial);
        }
        selectedObject = hoveree;
        if (selectedObject != null)
        {
            if (isMouseClicked)
            {
                selectedObject.GetComponent<Clickable>().ChangeSelect(true, selectedMaterial);
            }
            else
            {
            selectedObject.GetComponent<Clickable>().ChangeSelect(true, hoveredMaterial);
            }
        }
    }
}
