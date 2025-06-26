using UnityEngine;

public class Trigdrop : MonoBehaviour
{
    public GameObject Dropper;
    void Start()
    {
        GetComponent<BoxCollider>().isTrigger = true;
    }
    
    void OnTriggerEnter(Collider other)
    {
        Rigidbody rigidbody = Dropper.GetComponent<Rigidbody>();

        if(other.gameObject.tag =="Player")
        {
            Dropper.SetActive(true);
            rigidbody.useGravity = true;
        }
    }
}
