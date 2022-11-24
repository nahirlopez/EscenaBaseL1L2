using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    [SerializeField] GameObject instructions;
    [SerializeField] Animator anim;
    bool canopen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canopen)
        {
            anim.SetBool("OPEN", true);
        }
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            instructions.SetActive(true);
            canopen = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            instructions.SetActive(false);
            canopen = false;
        }
    }
}
