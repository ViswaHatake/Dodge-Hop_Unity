using UnityEngine;
using UnityEngine.UIElements;

public class Spinner : MonoBehaviour
{
    [SerializeField] float x = 2f;
    [SerializeField] float y = 2f;
    [SerializeField] float z = 2f;
    
    void Update()
    {
        transform.Rotate(x, y, z);   
    }
}
