using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInteger {
    class FileManager {

        public string[] loadedFiles = new string[100];
        public int loadedSize = 0;

        private static FileManager instance;

        public static FileManager GetInstance() {

            if (instance == null) {
                instance = new FileManager();
            }
            return instance;
        }

        public string LoadFile(string path) {
            loadedFiles[loadedSize++] = path;
            StreamReader streamReader = File.OpenText(path);
            return streamReader.ReadToEnd();
        }

        // Pure function
        public static string LoadFile2(string path) {
            //loadedFiles[loadedSize++] = path;
            StreamReader streamReader = File.OpenText(path);
            return streamReader.ReadToEnd();
        }
    }
}
/*
 * Питання до самих себе
 * 1. Моя функція має залежності не в середині себе (ззовні) - (pure function) - USE static function
 * 2. Моя функція має залежності інші окрім своїх параметрів і Ви хочете користуватися нею як статичною - то треба використовувати Singleton
 */
