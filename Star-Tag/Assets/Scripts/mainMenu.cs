using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Must be manually imported (like this), to change scenes in code.
// SceneManager.LoadScene("name")

public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update

   
   
public void playW1()
    {
        // Winter Normal
        Debug.Log("Winter Normal Selected");
        SceneManager.LoadScene("Winter");
        Debug.Log("Entering scene Desert");
    }
    
    public void playGame ()
    {


    }


    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Quit Button Pressed!");
    }
// Winter Gamemode selection:

    

        public void playW2()
    {
        // Winter Poison
        Debug.Log("Winter Poison Selected");
    }

        public void playW3()
    {
        // Winter Timed
        Debug.Log("Winter Timed Selected");
    }

    // Jungle Gamemode selection:

       public void playJ1()
    {
        // Jungle Normal
    }

        public void playJ2()
    {
        // Jungle Poison
    }

        public void playJ3()
    {
        // Jungle Timed
    }

    // Desert Gamemode selection:

       public void playD1()
    {
        // Desert Normal
    }

        public void playD2()
    {
        // Desert Poison
    }

        public void playD3()
    {
        // Desert Timed
    }

}
