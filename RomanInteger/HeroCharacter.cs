using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInteger {
    internal class HeroCharacter {


        public void HitWithTheSword() {

            // play animation
            // check hitboxes

            // play sound of sword hit
            FileManager fileManager = new FileManager();
            AudioPlayer player = new AudioPlayer(fileManager);
            player.PlaySound("sword_hit.wav");

        }
    }
}
