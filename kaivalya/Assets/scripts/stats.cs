using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public static class stats
{
    private static int electricity_saved, water_saved, lives_saved, points, lives;

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
        stats.lives = 3;
        stats.Lives_saved = 0;
        stats.Water_saved = 0;
        stats.Electricity_saved = 0;
        stats.Points = 0;
    }

   public static string[] scenes = new string[] { "start", "road", "red_button", "water", "electricity" };
    
    public static void random_scene(int curr_level)
    {
        int level = (int)Random.Range(1,3);
        while (level == curr_level)
        {
            level = (int)Random.Range(1, 3);
        }
        Application.LoadLevel(scenes[level]);
    }
   
}