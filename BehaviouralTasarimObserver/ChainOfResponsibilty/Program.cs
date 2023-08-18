namespace ChainOfResponsibilty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerHandler mp4 = new Mp4();
            PlayerHandler mpg = new Mpg();
            PlayerHandler avi = new Avi();

            mp4.SonrakiHandler = mpg;
            mpg.SonrakiHandler = avi;

            mp4.Play("mp4");
            mp4.Play("avi");
            mp4.Play("mpg");
            mp4.Play("swf");
        }
    }
}