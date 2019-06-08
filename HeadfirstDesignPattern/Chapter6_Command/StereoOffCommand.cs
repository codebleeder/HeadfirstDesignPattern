namespace HeadfirstDesignPattern.Chapter6_Command
{
    internal class StereoOffCommand: Command 
    {
        private Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume();
        }
    }
}