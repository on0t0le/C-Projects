using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace MelodyGuess
{
    static class GameEngine
    {
        static public List<string> mList = new List<string>();
        static public int gameTime = 60;
        static public int musicTime = 10;
        static public bool randStart = false;
        static public string lastFolder="";
        static public bool innerFolder = false;
        static string regKeyName = "Software\\CrazyLemon\\GuessMelody";
        static public string answer = "";
        static public string pl1Key = "";
        static public string pl2Key = "";


        static public void MusicLoad()
        {
            try
            {
            string[] mFiles = Directory.GetFiles(lastFolder, "*.mp3", innerFolder ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            mList.Clear();
            mList.AddRange(mFiles);
            }
            catch
            {

            }
        }

        public static void WriteParam()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("RandomStart", randStart);
                rk.SetValue("GameTime", gameTime);
                rk.SetValue("MusicTime", musicTime);
                rk.SetValue("AllDirectories", innerFolder);
                rk.SetValue("Player1Key", pl1Key);
                rk.SetValue("Player2Key", pl2Key);

            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void ReadParam()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk != null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    randStart = Convert.ToBoolean(rk.GetValue("RandomStart"));
                    gameTime = (int)rk.GetValue("GameTime");
                    musicTime = (int)rk.GetValue("MusicTime");
                    innerFolder = Convert.ToBoolean(rk.GetValue("AllDirectories"));
                    pl1Key = (string)rk.GetValue("Player1Key");
                    pl2Key = (string)rk.GetValue("Player2Key");
                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}
