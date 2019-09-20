using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_AniTest : MonoBehaviour {

    Animator anim;

	
	void Start () {

        anim = GetComponent<Animator>();
		
	}
	
    public void Idle_Ani()
    {
        anim.SetTrigger("Idle");
    }

    public void Move_Ani()
    {
        anim.SetTrigger("Move");
    }

    public void Damage_Ani()
    {
        anim.SetTrigger("Damage");
    }

    public void Death_Ani()
    {
        anim.SetTrigger("Death");
    }


}
