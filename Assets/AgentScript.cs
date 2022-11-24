using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class AgentScript : MonoBehaviour
{

    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform TargetTransform;
    [SerializeField] Transform BaseTransform;
    bool ChaseMode = false;
    [SerializeField] GameObject CUIDADO;
    [SerializeField] Text vida;
    int VidaDeMutante = 10;
 
    //[SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        vida.text = ("VIDA DEL MUTANTE: " + VidaDeMutante);
        if (ChaseMode)
        {
            agent.destination = TargetTransform.position;
            
        }
        else
        {
            agent.destination = BaseTransform.position;
        }
        if (Input.GetKeyDown(KeyCode.Q) && ChaseMode)
        {
            VidaDeMutante--;
        }

        if(VidaDeMutante == 0)
        {
            CUIDADO.SetActive(false);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ChaseMode = true;
            CUIDADO.SetActive(true);
        }
    }
  
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ChaseMode = false;
            CUIDADO.SetActive(false);
            VidaDeMutante = 10; 
        }
        
    }
   
}
