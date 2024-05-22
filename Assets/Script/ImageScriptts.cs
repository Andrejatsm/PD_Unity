using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScriptts : MonoBehaviour
{

    public Sprite[] spriteArrays;
    public Sprite[] spriteArrayss;
    public Sprite[] spriteArraysss;
    public GameObject imageHolders;
    public GameObject imageHolderss;
    public GameObject imageHoldersss;

    public void changeImag(int index)
    {
        if (index == 0)
            imageHolders.GetComponent<Image>().sprite = spriteArrays[0];

        else if (index == 1)
            imageHolders.GetComponent<Image>().sprite = spriteArrays[1];

        else if (index == 2)
            imageHolders.GetComponent<Image>().sprite = spriteArrays[2];
    }
    public void changeImages(int index)
    {
        if (index == 0)
            imageHolderss.GetComponent<Image>().sprite = spriteArrayss[0];

        else if (index == 1)
            imageHolderss.GetComponent<Image>().sprite = spriteArrayss[1];

        else if (index == 2)
            imageHolderss.GetComponent<Image>().sprite = spriteArrayss[2];
    }
    public void changeImagess(int index)
    {
        if (index == 0)
            imageHoldersss.GetComponent<Image>().sprite = spriteArraysss[0];

        else if (index == 1)
            imageHoldersss.GetComponent<Image>().sprite = spriteArraysss[1];

        else if (index == 2)
            imageHoldersss.GetComponent<Image>().sprite = spriteArraysss[2];
    }


}
