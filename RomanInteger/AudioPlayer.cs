using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInteger {
    class AudioPlayer {

        //public static AudioPlayer GetInstance() { return new AudioPlayer(); }

        

        private float musicTiming;
        private float soundTiming;

        private FileManager fileManager;

        public AudioPlayer(FileManager fileManager) {
            this.fileManager = fileManager;
        }

        public void PlaySound(string fileName) {
            this.fileManager.LoadFile(fileName);
            /// play sound
        }
        public void PlayMusic(string fileName) {
            this.fileManager.LoadFile(fileName);
            // play music
        }

        public void UpdateFillBuffer(float deltaTime) {

        }
    }
}
