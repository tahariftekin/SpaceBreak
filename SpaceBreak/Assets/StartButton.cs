using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button startButton;
    public Animator anim;
    public Sprite startSprite;

    //if clicked sprite run the changeStartButton function

    public void changeStartButton(){
        anim.enabled = false;
        startButton.image.sprite = startSprite;
    }
}
