using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeEyes : MonoBehaviour
{
    public Material eyeMat;
    public void OnClick()
    {
        int index = Random.Range(0, 6);
        switch (index)
        {
            case 0:


                eyeMat.mainTextureOffset = new Vector2(0,0.83f);
                break;
            case 1:
                eyeMat.mainTextureOffset =  new Vector2(0, 0.67f);
                break;
            case 2:
                eyeMat.mainTextureOffset =  new Vector2(0, 0.5f);
                break;
            case 3:
                eyeMat.mainTextureOffset =  new Vector2(0, 0.33f);
                break;
            case 4:
                eyeMat.mainTextureOffset =  new Vector2(0, 0.17f);
                break;
            case 5:
                eyeMat.mainTextureOffset =  new Vector2(0, 0);
                break;
        }
    }
}
