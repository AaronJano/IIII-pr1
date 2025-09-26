using UnityEngine;

public class name_and_pos_player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Player name: " + gameObject.name + " Player position: " + gameObject.transform.position);
    }
}
