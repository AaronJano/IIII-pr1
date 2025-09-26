using UnityEngine;

public class tag_and_pos_car : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Car tag: " + gameObject.tag + " Car position: " + transform.position);
    }

}
