using UnityEngine;

public class Dropper : MonoBehaviour
{

    Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
        
        gameObject.SetActive(false);
        
    }
}
