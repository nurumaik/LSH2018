using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UltraGodScript {
    static public int LastScore = 0;
    static public int LastMaxScore = 0;

    static public void GoToLevel()
    {
        Application.LoadLevel("GameScene");
    }
}
