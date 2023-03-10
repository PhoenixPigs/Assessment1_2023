using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegGlow : MonoBehaviour
{
    public Material PegOn;
    public Material PegOff;
    public MeshRenderer PegRenderer;
    public bool PegEnabled = false;

    private void OnCollisionEnter(Collision Other)
    {
        if (Other.gameObject.tag == "Ball")
        {            
            PegRenderer = this.gameObject.GetComponent<MeshRenderer>();
            StartCoroutine(PegTimer());
        }
    }
    IEnumerator PegTimer()
    {
        PegRenderer.material = PegOn;
        PegEnabled = true;
        yield return new WaitForSeconds(3);
        PegRenderer.material = PegOff;
        PegEnabled = false;
    }
}
