using System;
using PixelCrew.Utils;

namespace PixelCrew.UI.Windows.LoadGameLevel
{
    public class LoadGameLevel : AnimatedWindow
    {
        private Action _closeAction;
        
        public void OnLevelGame1()
        {
            MainGOsUtils.GetLevelLoader().LoadLevel("Level1");
        }
        
        public void OnLevelGame2()
        {
            MainGOsUtils.GetLevelLoader().LoadLevel("Level2");
        }
        
        public void OnLevelGame3()
        {
            MainGOsUtils.GetLevelLoader().LoadLevel("Level3");
        }
        
        public void OnLevelGame4()
        {
            MainGOsUtils.GetLevelLoader().LoadLevel("Level4");
        }
        
        public void OnLevelGame5()
        {
            MainGOsUtils.GetLevelLoader().LoadLevel("Level5");
        }
        
        public void OnLevelGame6()
        {
            MainGOsUtils.GetLevelLoader().LoadLevel("Level6");
        }
        
        public void OnResumeGame()
        {
            Close();
        }
    }
}