using BuilderPattern.CharacterSystem;
using BuilderPattern.VideoPlayerSoftware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder builderA = new BuilderA();
            Builder builderB = new BuilderB();

            director.Construct(builderA);
            Product product1 = builderA.GetResult();
            product1.Show();

            director.Construct(builderB);
            Product product2 = builderB.GetResult();
            product2.Show();

            CharacterController characterController = new CharacterController();
            ManHeroBuilder manHeroBuilder = new ManHeroBuilder();
            FemanHeroBuilder femanHeroBuilder = new FemanHeroBuilder();

            characterController.Construct(manHeroBuilder);
            Character character1 = manHeroBuilder.GetCharacter();
            character1.Show();

            characterController.Construct(femanHeroBuilder);
            Character character2 = femanHeroBuilder.GetCharacter();
            character2.Show();

            VideoPlayerController videoPlayerController = new VideoPlayerController();
            VideoPlayerBuilder fullVideoPlayerBuilder = new VideoPlayerBuilder();
            VideoPlayerBuilder SimplifiedVideoPlayerBuilder = new VideoPlayerBuilder();
            VideoPlayerBuilder memoryVideoPlayerBuilder = new VideoPlayerBuilder();

            videoPlayerController.FullMode(fullVideoPlayerBuilder);
            VideoPlayer videoPlayer1 = fullVideoPlayerBuilder.GetResult();
            videoPlayer1.Show();

            videoPlayerController.SimplifiedMode(SimplifiedVideoPlayerBuilder);
            VideoPlayer videoPlayer2 = SimplifiedVideoPlayerBuilder.GetResult();
            videoPlayer2.Show();

            videoPlayerController.MemoryMode(memoryVideoPlayerBuilder);
            VideoPlayer videoPlayer3 = memoryVideoPlayerBuilder.GetResult();
            videoPlayer3.Show();
        }
    }
}
