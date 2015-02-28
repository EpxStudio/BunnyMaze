using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    public GameObject GateLeft;
    public GameObject GateRight;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    bool hasRemovedGates = false;
    void Update()
    {
        if (Global.Bunnies == 10 && !hasRemovedGates)
        {
            GameObject.Destroy(GateLeft);
            GameObject.Destroy(GateRight);
            hasRemovedGates = true;
        }
    }

    void OnGUI()
    {
        string GuiMessage = "";

        if (Global.canOpenGates)
        {
            if (Global.Bunnies == 0) GuiMessage += "You need to collect all the bunnies!";
            else if (Global.Bunnies == 1) GuiMessage += "You have collected a bunny!";
            else if (Global.Bunnies == 10) GuiMessage += "You have collected all 10 bunnies! You're free now!";
            else if (Global.Bunnies > 1 && Global.Bunnies < 10) GuiMessage += "You have collected " + Global.Bunnies.ToString() + " bunnies!";
            else GuiMessage += "You have collected too many bunnies. Leave.";
        }

        if (Global.CarrotCount == 1) GuiMessage += " You have eaten a carrot!";
        else if (Global.CarrotCount > 1) GuiMessage += " You have eaten " + Global.CarrotCount.ToString() + " carrots!";

        GUI.Label(new Rect(12, Screen.height - 42, (Screen.width - 12), 42), GuiMessage);
    }
}

public static class Global
{
    public static int CarrotCount = 0;

    public static bool canOpenGates = false;

    public static int Bunnies = 0;

    public static bool ShowEatBunny = false;
}
