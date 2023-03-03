using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballLife : MonoBehaviour
{

    public Color32 colorBlue;
    public Color32 colorPink;
    public Color32 colorGreen;
    private Material mat;
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
            mat.setColor("_emissiveColor", colorBlue);
        }else
        if (c.tag == "triggerGreen"){
            mat.setColor("_emissiveColor", colorGreen);
        }else
        if (c.tag == "triggerPink"){
            mat.setColor("_emissiveColor", colorPink);
        }
    }


}
