using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{

    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform TargetTransform;
    [SerializeField] Transform BaseTransform;
    bool ChaseMode = false;
    bool IsOnStart = true;
    //[SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ChaseMode)
        {
            agent.destination = TargetTransform.position;
            //anim.SetBool("iswalking", true);
        }
        else
        {
            agent.destination = BaseTransform.position;
        }

        //if (IsOnStart)
        //{
        //    anim.SetBool("iswalking", false);
        //}
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ChaseMode = true;
            StartCoroutine(SetOffChaseMode());
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "START")
        {
            IsOnStart = true;
        }
        else
        {
            IsOnStart = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ChaseMode = false;
        }
        
    }
    IEnumerator SetOffChaseMode()
    {
        yield return new WaitForSeconds(5);
        ChaseMode = false;
    }
}
