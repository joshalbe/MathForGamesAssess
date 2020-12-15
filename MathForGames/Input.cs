using System;
using System.Collections.Generic;
using System.Text;
using TestLibrary;
using Raylib_cs;
using RL = Raylib_cs.Raylib;

namespace MathForGames
{
    class Input
    {
        //Returns whether the key was pressed since the last frame
        public static bool IsKeyPressed(int key)
        {
            return RL.IsKeyPressed((KeyboardKey)key);
        }

        //Returns whether the key is currently down
        public static bool IsKeyDown(int key)
        {
            return RL.IsKeyDown((KeyboardKey)key);
        }

        //Returns whether the key was release since the last frame
        public static bool IsKeyReleased(int key)
        {
            return RL.IsKeyReleased((KeyboardKey)key);
        }

        //Returns whether the key is currently up
        public static bool IsKeyUp(int key)
        {
            return RL.IsKeyUp((KeyboardKey)key);
        }
    }
}
