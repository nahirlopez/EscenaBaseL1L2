using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkinganddialogue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField] Animator anim;
    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("Talking", true);

        }

    }
     void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("Talking", false);
        }
    }
}
