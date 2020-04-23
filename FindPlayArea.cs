using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayArea : MonoBehaviour
{

    private ScoreBehaviour scoreBehaviour;
    RectTransform playArea;
    Rigidbody2D rigid2D;
    RespawnCoin1 respawnCoin1;
    RespawnCoin1 respawnCoin2;
    RespawnCoin1 respawnCoin3;
    Laser1 laser1;
    Laser2 laser2;
    Laser3 laser3;
    Laser4 laser4;
    Laser5 laser5;
    Laser6 laser6;
    Laser7 laser7;
    Laser8 laser8;
    public static float width;
    public static float height;
    public static float maxX;
    public static float maxY;
    public static float xPos;
    public static float yPos;


    public static void setCoin1Bounds()
    {
        RespawnCoin1.respawnCoin(maxX, maxY, xPos, yPos);
    }
    public static void setCoin2Bounds()
    {
        RespawnCoin2.respawnCoin(maxX, maxY, xPos, yPos);
    }
    public static void setCoin3Bounds()
    {
        RespawnCoin3.respawnCoin(maxX, maxY, xPos, yPos);
    }
    public static void setLaser1Bounds()
    {
        Laser1.respawnLaser(maxX, maxY, xPos, yPos);
    }
    public static void setLaser2Bounds()
    {
        Laser2.respawnLaser(maxX, maxY, xPos, yPos);
    }
    public static void setLaser3Bounds()
    {
        Laser3.respawnLaser(maxX, maxY, xPos, yPos);
    }
    public static void setLaser4Bounds()
    {
        Laser4.respawnLaser(maxX, maxY, xPos, yPos);
    }
    public static void setLaser5Bounds()
    {
        Laser5.respawnLaser(maxX, maxY, xPos, yPos);
    }
    public static void setLaser6Bounds()
    {
        Laser6.respawnLaser(maxX, maxY, xPos, yPos);
    }
    public static void setLaser7Bounds()
    {
        Laser7.respawnLaser(maxX, maxY, xPos, yPos);
    }
    public static void setLaser8Bounds()
    {
        Laser8.respawnLaser(maxX, maxY, xPos, yPos);
    }
    // Use this for initialization
    void Start()
    {
        playArea = GetComponent<RectTransform>();
        scoreBehaviour = GetComponent<ScoreBehaviour>();
        rigid2D = GetComponent<Rigidbody2D>();
        respawnCoin1 = GetComponent<RespawnCoin1>();
        respawnCoin2 = GetComponent<RespawnCoin1>();
        respawnCoin3 = GetComponent<RespawnCoin1>();
        laser1 = GetComponent<Laser1>();
        laser2 = GetComponent<Laser2>();
		laser3 = GetComponent<Laser3> ();	
		laser4 = GetComponent<Laser4> ();	
		laser5 = GetComponent<Laser5> ();	
		laser6 = GetComponent<Laser6> ();	
		laser7 = GetComponent<Laser7> ();	
		laser8 = GetComponent<Laser8> ();
        width = playArea.rect.width;
        height = playArea.rect.height;
        maxX = width / 2;
        maxY = height / 2;
        xPos = playArea.rect.x;
        yPos = playArea.rect.y;
    }
}
