//By SheepYhangCN
using System;
using Godot;

namespace SheepYhangCN.WindowCenter
{   
    public static class WindowCenter
    {
        public static void CenterWindow()
        {
            DisplayServer.WindowSetPosition(new Vector2I(Mathf.RoundToInt(DisplayServer.ScreenGetUsableRect().Size.X/2-DisplayServer.WindowGetSize().X/2),Mathf.RoundToInt(DisplayServer.ScreenGetUsableRect().Size.Y/2-DisplayServer.WindowGetSize().Y/2)));
        }
        public static Vector2I GetWindowCenter(Rect2I ScreenUsableRect,Vector2I WindowSize)
        {
            return new Vector2I(Mathf.RoundToInt(ScreenUsableRect.Size.X/2-WindowSize.X/2),Mathf.RoundToInt(ScreenUsableRect.Size.Y/2-WindowSize.Y/2));
        }
    }
}