using UnityEngine;

public class tag_and_pos_player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Player tag: " + gameObject.tag + " Player position: " + gameObject.transform.position);
    }
}
