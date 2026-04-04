using UnityEngine;

public class TapCube : MonoBehaviour
{
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    public void TapOn()
    {
        rend.material.color = Color.green; //Dont do this at scale
    }

    public void TapOff()
    {
        rend.material.color = Color.black;
    }
}
