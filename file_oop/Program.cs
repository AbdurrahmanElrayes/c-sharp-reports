using System;

namespace file_oop
{
   public class File {
        public string extension;
        public string expectedSize;
    }
    public class imageFile : File, aboutFiles {
        public imageFile(){
            extension = ".jpg, .png,...";
            expectedSize = "small";
        }
        public string getExpectedSize() {
            return expectedSize;
        }
        public string getExtension(){
            return extension;
        }
    }
    public class textFile : File, aboutFiles {
        public textFile(){
            extension = ".txt,...";
            expectedSize = "very small";
        }
        public string getExpectedSize() {
            return expectedSize;
        }
        public string getExtension(){
            return extension;
        }
    }
    public class audioFile : File, aboutFiles {
        public audioFile(){
            extension = ".mp3,...";
            expectedSize = "large";
        }
        public string getExpectedSize() {
            return expectedSize;
        }
        public string getExtension(){
            return extension;
        }
    }
    public class videoFile : File , aboutFiles {
        public videoFile(){
            extension = ".mp4, .avi, .mkv, ...";
            expectedSize = "very large";
        }
        public string getExpectedSize() {
            return expectedSize;
        }
        public string getExtension(){
            return extension;
        }
        
    }
    public interface aboutFiles{
        string getExpectedSize();
        string getExtension();
    }
    class Test
    {
        static void Main(string[] args)
        {
            imageFile img = new imageFile();
            videoFile vid = new videoFile();
            audioFile aud = new audioFile();
            textFile txt = new textFile();
            Console.WriteLine("for image calss:\nexpectedSize: "+img.getExpectedSize()+"\nextensions: "+img.getExtension()+"\n\n");
            Console.WriteLine("for video calss:\nexpectedSize: "+vid.getExpectedSize()+"\nextensions: "+vid.getExtension()+"\n\n");
            Console.WriteLine("for audio calss:\nexpectedSize: "+aud.getExpectedSize()+"\nextensions: "+aud.getExtension()+"\n\n");
            Console.WriteLine("for text calss:\nexpectedSize: "+txt.getExpectedSize()+"\nextensions: "+txt.getExtension()+"\n\n");
            Console.ReadKey();
        }
    }
}
