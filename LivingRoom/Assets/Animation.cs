using UnityEngine;
using System.Collections;

public class Animation : MonoBehaviour {
  
    private Animator anim;
    float v,h;



	void Start () {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        v= Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");
    }
	// Update is called once per frame
	void FixedUpdate () {

        anim.SetFloat("walk", v);
        anim.SetFloat("turn", h);
        
	}
}
