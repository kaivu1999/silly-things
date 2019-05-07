using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public static class stats
{
    private static int electricity_saved, water_saved, lives_saved, points, lives;
    public static bool result;
    public static int levels = 1 ;
    public static string prev_level = "road";
    public static int Levels
    {
        get
        {
            return levels;
        }
        set
        {
            levels = value;
        }
    }
    public static int Lives_saved
    {
        get
        {
            return lives_saved;
        }
        set
        {
            lives_saved = value;
        }
    }

    public static int Water_saved
    {
        get
        {
            return water_saved;
        }
        set
        {
            water_saved = value;
        }
    }

    public static int Electricity_saved
    {
        get
        {
            return electricity_saved;
        }
        set
        {
            electricity_saved = value;
        }
    }

    public static int Points
    {
        get
        {
            return points;
        }
        set
        {
            points = value;
        }
    }

    public static int Lives
    {
        get
        {
            return lives;
        }
        set
        {
            lives = value;
            if (lives <= 0)
            {
                SceneManager.LoadScene("fail");
            }
        }
    }

    public static void clear()
    {
        stats.result = true;
        stats.lives = 3;
        stats.Lives_saved = 0;
        stats.Water_saved = 0;
        stats.Electricity_saved = 0;
        stats.Points = 0;
    }

   public static string[] scenes = new string[] { "start", "road", "lights" , "red_button", "electricity" };

    public static void what_next()
    {
        int level = (int)Random.Range(1, 4);
        while (level>3 || level <1)
        {
            level = (int)Random.Range(1, 4);
        }
        if(prev_level == "red_button")
        {
            while((level > 2 || level < 1))
            {
                level = (int)Random.Range(1, 3); 
            }
        }
        stats.levels += 1;
        prev_level = scenes[level];
        Application.LoadLevel(scenes[level]);

    }

    public static void random_scene(bool status)
    {
        if(status == true)
        {
            stats.result = true;
        }
        else
        {
            stats.result = false;
            Handheld.Vibrate();
            stats.lives -= 1;
        }

        if(stats.lives <= 0)
        {
            Application.LoadLevel("fail");
        }
        else
        {
            Application.LoadLevel("in_between_scene");
        }

        //int level = (int)Random.Range(1,3);
        //while (level == curr_level)
        //{
          //  level = (int)Random.Range(1, 3);
        //}
        //Application.LoadLevel(scenes[level]);
    }

 
   
}