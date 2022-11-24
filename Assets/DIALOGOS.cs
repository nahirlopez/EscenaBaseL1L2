using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DIALOGOS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextoDelDialogo.text = Dialogo[IncDialogo];

        if (Input.GetKeyDown(KeyCode.E) && interaction )
            {
                IncDialogo++;

                if (IncDialogo == Dialogo.Length)
                {
                    IncDialogo = 0;
                }



            }

    }
    public string[] Dialogo;
    int IncDialogo = 0;
    public TextMeshProUGUI TextoDelDialogo;
    public GameObject Master;
    bool interaction = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Master.SetActive(true);
            
            interaction = true;

        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Master.SetActive(false);
            interaction = false;
        }
    }
}
