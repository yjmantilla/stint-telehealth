using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AnimationStateControllerScript : MonoBehaviour
{
    public Dropdown ddAnimation;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        ddAnimation.onValueChanged.AddListener(delegate {
            ddAnimationValueChangedHappened(ddAnimation);
        });

        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    public void ddAnimationValueChangedHappened(Dropdown sender)
    {
                //Debug.Log(sender.value);
                Debug.Log(ddAnimation.options[ddAnimation.value].text);
    }

    public void Update(){
        animator.SetInteger("AnimationState",ddAnimation.value);
    }

}
