namespace Program
{
    public class MouseClickedEventArgs
    {
        public MouseClickedEventArgs(int clicks)
        {
            Clicks = clicks;
        }
        public int Clicks { get; }
        
    }
    
}