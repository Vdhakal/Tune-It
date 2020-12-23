using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Animation : MonoBehaviour
{
    public Animation animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = gameObject.GetComponent<Animation>();
    }

    public void button_touch()
    {
        // animation.Play("ButtonAnim");
    }
}
