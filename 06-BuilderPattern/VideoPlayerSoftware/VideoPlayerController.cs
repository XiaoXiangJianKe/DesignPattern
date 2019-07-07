using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.VideoPlayerSoftware
{
    class VideoPlayerController
    {
        /// <summary>
        /// 完整模式
        /// </summary>
        /// <param name="videoPlayerBuilder"></param>
        public void FullMode(VideoPlayerBuilder videoPlayerBuilder)
        {
            videoPlayerBuilder.BuildMenu();
            videoPlayerBuilder.BuildPlayList();
            videoPlayerBuilder.BuildMainWindow();
            videoPlayerBuilder.BuildControlBar();
            videoPlayerBuilder.BuildCollectionList();
        }

        /// <summary>
        /// 精简模式
        /// </summary>
        /// <param name="videoPlayerBuilder"></param>
        public void SimplifiedMode(VideoPlayerBuilder videoPlayerBuilder)
        {
            videoPlayerBuilder.BuildMainWindow();
            videoPlayerBuilder.BuildControlBar();
        }

        /// <summary>
        /// 记忆模式
        /// </summary>
        /// <param name="videoPlayerBuilder"></param>
        public void MemoryMode(VideoPlayerBuilder videoPlayerBuilder)
        {
            videoPlayerBuilder.BuildMainWindow();
            videoPlayerBuilder.BuildControlBar();
            videoPlayerBuilder.BuildCollectionList();
        }

        /// <summary>
        /// 网络模式
        /// </summary>
        /// <param name="videoPlayerBuilder"></param>
        public void NetworkMode(VideoPlayerBuilder videoPlayerBuilder)
        {
            videoPlayerBuilder.BuildMenu();
            videoPlayerBuilder.BuildPlayList();
            videoPlayerBuilder.BuildMainWindow();
            videoPlayerBuilder.BuildControlBar();
            videoPlayerBuilder.BuildCollectionList();
        }
    }
}
