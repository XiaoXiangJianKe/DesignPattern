using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.VideoPlayerSoftware
{
    /*
    Sunny软件公司欲开发一个视频播放软件，为了给用户使用提供方便，该播放软件提供多种界面显示模式，
    如完整模式、精简模式、记忆模式、网络模式等。在不同的显示模式下主界面的组成元素有所差异，
    如在完整模式下将显示菜单、播放列表、主窗口、控制条等，在精简模式下只显示主窗口和控制条，
    而在记忆模式下将显示主窗口、控制条、收藏列表等。尝试使用建造者模式设计该软件。
     */

    class VideoPlayer
    {
        private string menu;
        private string playList;
        private string mainWindow;
        private string controlBar;
        private string collectionList;

        public string Menu { get { return menu; } set { menu = value; } }
        public string PlayList { get { return playList; } set { playList = value; } }
        public string MainWindow { get { return mainWindow; } set { mainWindow = value; } }
        public string ControlBar { get { return controlBar; } set { controlBar = value; } }
        public string CollectionList { get { return collectionList; } set { collectionList = value; } }

        public void Show()
        {
            Console.WriteLine("");
            Console.WriteLine(menu);
            Console.WriteLine(playList);
            Console.WriteLine(mainWindow);
            Console.WriteLine(controlBar);
            Console.WriteLine(collectionList);
        }
    }
}
