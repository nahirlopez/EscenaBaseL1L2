using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GRABGLASSES : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] GameObject instructions;
    bool cangrab = false;
    [SerializeField] Transform PlaceIt;
    [SerializeField] GameObject GANASTE;
    bool YAESTA = false;

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.E) && cangrab && instructions)
        {

            
            YAESTA = true;
             gameObject.GetComponent<BoxCollider>().enabled = false;
            instructions.SetActive(false);
            GameObject.FindGameObjectWithTag("postprocess").SetActive(false);
            GANASTE.SetActive(true);
            StartCoroutine(TurnOff());
        }
            if (YAESTA)
        {
            gameObject.transform.position = PlaceIt.position;
             gameObject.transform.rotation = PlaceIt.rotation;
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            instructions.SetActive(true);
            cangrab = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            instructions.SetActive(false);
            cangrab = false;
        }
    }
    public IEnumerator TurnOff()
    {
        yield return new WaitForSeconds(5);
        GANASTE.SetActive(false);
    }
    
   
       
    
}
