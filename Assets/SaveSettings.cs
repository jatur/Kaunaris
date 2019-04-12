using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void save()
    {
        var component = GameObject.Find("DefaultSave").GetComponent<Save>();
        component.IsRestaurant = GameObject.Find("Restaurants").GetComponent<Toggle>().isOn;
        component.IsSight = GameObject.Find("Sights").GetComponent<Toggle>().isOn;
        component.IsBar = GameObject.Find("Bar").GetComponent<Toggle>().isOn;
        component.IsSupermarket = GameObject.Find("Shopping").GetComponent<Toggle>().isOn;
        component.IsSport = GameObject.Find("Sports").GetComponent<Toggle>().isOn;
    }

    public void load()
    {
        var component = GameObject.Find("DefaultSave").GetComponent<Save>();
        GameObject.Find("Restaurants").GetComponent<Toggle>().isOn = component.IsRestaurant;
        GameObject.Find("Sights").GetComponent<Toggle>().isOn = component.IsSight;
        GameObject.Find("Bar").GetComponent<Toggle>().isOn = component.IsBar;
        GameObject.Find("Shopping").GetComponent<Toggle>().isOn = component.IsSupermarket;
        GameObject.Find("Sports").GetComponent<Toggle>().isOn = component.IsSport;
    }
}
