using UnityEngine;

public class name_and_pos_car : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Car name: " + gameObject.name + " Car position: " + transform.position);
    }

}
