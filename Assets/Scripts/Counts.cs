using Unity.VisualScripting;
using UnityEngine;

public class Counts : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You Hit This many times : " + hits);
        }
    }
 
}
