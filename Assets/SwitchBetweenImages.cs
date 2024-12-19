using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBetweenImages : MonoBehaviour
{

    public Material skyBoxMaterial;

    public Texture[] images;
    
    //function to switch between images randomly
    public void SwitchImage()
    {
        int randomIndex = Random.Range(0, images.Length);
        skyBoxMaterial.mainTexture = images[randomIndex];
    }
}
