namespace Program
{
    public class MouseClickPublisher
    {
        public event EventHandler<MouseClickedEventArgs> MouseClicked = delegate { };
        protected virtual void OnMouseClicked(MouseClickedEventArgs e)
        {
            var evt = MouseClicked;
            evt?.Invoke(this, e);
        }
        private void TrackMouseClicks()
        {
            OnMouseClicked(new MouseClickedEventArgs(2));
        }
        
    }

    

}