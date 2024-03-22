using BepInEx;
using UnityEngine;

[BepInPlugin("com.Spycrab.enablecheatsmod", "Cheats Mod", "1.0.0")]
public class CheatsMod : BaseUnityPlugin
{
    void Update()
    {
        // BRUH FUCKING WORK
        CheatScript cheating = FindObjectOfType<CheatScript>();

        // This took 2 min
        if (cheating != null && !cheating.enabled)
        {
            cheating.enabled = true;
        }
        else if (cheating == null)
        {
            Debug.Log("Cheat script is not enabled bozo");
        }
        else
        {
            Debug.Log("chatscript is installed not easy");
        }
    }
}
