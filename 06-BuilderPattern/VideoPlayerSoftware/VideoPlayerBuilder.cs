using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.VideoPlayerSoftware
{
    class VideoPlayerBuilder
    {
        private VideoPlayer videoPlayer = new VideoPlayer();

        public void BuildMenu()
        {
            videoPlayer.Menu = "菜单";
        }

        public void BuildPlayList()
        {
            videoPlayer.PlayList = "播放列表";
        }

        public void BuildMainWindow()
        {
            videoPlayer.MainWindow = "主窗口";
        }

        public void BuildControlBar()
        {
            videoPlayer.ControlBar = "控制条";
        }

        public void BuildCollectionList()
        {
            videoPlayer.CollectionList = "收藏列表";
        }

        public VideoPlayer GetResult()
        {
            return videoPlayer;
        }
    }
}
