using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms;

public class clickedByMe : MonoBehaviour
{
    // Imgs 
    public Image D_SHB7; // My dead ghost
    public Sprite A_SHB7; // My alive ghost
    public Sprite B_SHB7; // My angry ghost
    public Sprite C_SHB7; // My angry ghost

    // Score clicked
    public int score = 0;
    public int Dxp = 1;
    public int x = 0;
    public TextMeshProUGUI MainTextMid;
    public TextMeshProUGUI GhostyScoreText;

    // space
    public string Stop = "---------------------------------------------";

    // needed items for next lvl 
    public Image lvl0_SHB7;
    public Sprite lv1_SHB7;
    public Sprite lv2_SHB7;
    public Sprite done_SHB7;
    public TextMeshProUGUI Needed;

    public Image UpgradeImg;
    public void Pressed()
    {
        score = score + Dxp;
        GhostyScoreText.text = "Ghosty lvl = " + score;
        print("your score is : " + score + " | " + "Your Dxp : " + Dxp);
        MainTextMid.text = "";
    }

    public void Upgrade() 
    {
        if (score >= 15 && x == 0){
            D_SHB7.sprite = A_SHB7;
            score = score - 15;
            GhostyScoreText.text = "Ghosty lvl = " + score;
            Dxp++;
            print("you up to lvl 1");
            x = 1;

            // needed
            Needed.text = "Next lvl Needed = 30";
            lvl0_SHB7.sprite = lv1_SHB7;
        } else if (score >= 30 & x == 1) 
        {
            score = score - 30;
            GhostyScoreText.text = "Ghosty lvl = " + score;
            Dxp++;
            print("you up to lvl 2");
            x = 2;

            // needed
            Needed.text = "Next lvl Needed = 60";
            lvl0_SHB7.sprite = lv2_SHB7;
        }
        else if(score >= 60 && x == 2) {
            score = score - 60;
            GhostyScoreText.text = "I am now a Happy Ghooostyyy" ;
            Dxp++;
            print("you up to lvl 3");
            x = 3;

            // needed
            Needed.text = " \t  Max";
            lvl0_SHB7.sprite = done_SHB7;
        }else {
            MainTextMid.text = "Yooou Neeeed Tooo Cliick Moooore"; 
        }
       
    }


    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if(x == 1){
            D_SHB7.sprite = A_SHB7;
        }else if(x == 2){
            D_SHB7.sprite = B_SHB7;
        }else if(x == 3){
            D_SHB7.sprite = C_SHB7;
            UpgradeImg.sprite = done_SHB7;
            MainTextMid.text = " \t \t Your Done";
        }
    }

}
