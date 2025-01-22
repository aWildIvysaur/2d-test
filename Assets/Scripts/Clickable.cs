using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    [SerializeField] GameObject Controller;
    [SerializeField] string Name;
    [SerializeField] bool isSelected = false;

    // Start is called before the first frame update
    void Start()
    {
        Controller = GameObject.Find("Controller");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseOver() 
    {
        if (!isSelected)
        {
        Controller.GetComponent<Controller>().Hovering(gameObject);
        }
    }

    public void OnMouseExit() 
    {
        if (isSelected)
        {
            Controller.GetComponent<Controller>().Hovering(null);
        }
    }

    public void ChangeSelect(bool Selected, Material material)
    {
        if (Selected)
        {
            gameObject.GetComponent<Renderer>().material = material;
            isSelected = true;
        }
        else if (!Selected)
        {
            gameObject.GetComponent<Renderer>().material = material;
            isSelected = false;
        }
    }
}

