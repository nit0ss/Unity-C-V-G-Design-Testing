using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    private Material mat;

    public Color32 colorBlue;
    public Color32 colorPink;
    public Color32 colorGreen;


public class ballTrig : MonoBehaviour
{
    // Start is called before the first frame update
     void Start()
    {
        mat= GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
    }

    
      void OnTriggerEnter(Collider c) {
        if (c.tag == "triggerBlue"){
            mat.setColor("_EmissiveColor", colorBlue);
        }else
        if (c.tag == "triggerGreen"){
            mat.setColor("_EmissiveColor", colorGreen);
        }else
        if (c.tag == "triggerPink"){
            mat.setColor("_EmissiveColor", colorPink);
        }
    }  





}

 