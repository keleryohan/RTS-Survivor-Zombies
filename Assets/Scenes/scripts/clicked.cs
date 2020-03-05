using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicked : MonoBehaviour
{
    [SerializeField]
    private Material selected;

    [SerializeField]
    private Material unselected;

    private MeshRenderer MRend;

    // Start is called before the first frame update
    void Start()
    {
        MRend = GetComponent<MeshRenderer>();
    }

    public void gotCliked()
    {
        MRend.material = selected;
    }
}
