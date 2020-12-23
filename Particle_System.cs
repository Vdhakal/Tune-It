using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Particle_System : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem particleSystem1, particleSystem2;
    GameObject selectedBtn;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ToggleParticles()
    {
        EventSystem currentEvent = EventSystem.current;
        selectedBtn = currentEvent.currentSelectedGameObject;
        particleSystem1.transform.position = new Vector3(selectedBtn.transform.position.x, selectedBtn.transform.position.y + Mathf.Abs(selectedBtn.transform.position.y), selectedBtn.transform.position.z);
        particleSystem2.transform.position = new Vector3(selectedBtn.transform.position.x, selectedBtn.transform.position.y + Mathf.Abs(selectedBtn.transform.position.y), selectedBtn.transform.position.z);
        particleSystem1.Play();
        particleSystem2.Play();
    }
}
