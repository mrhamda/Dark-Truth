using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterCertainTime : MonoBehaviour
{
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("DestroyAfterCertainTimeMethod", delay);
    }

    void DestroyAfterCertainTimeMethod()
    {
        Destroy(gameObject);
        return;
    }
}
