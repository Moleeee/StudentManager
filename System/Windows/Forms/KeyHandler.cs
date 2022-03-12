namespace System.Windows.Forms
{
    internal class KeyHandler
    {
        private Action<object, KeyPressEventArgs> textBox3_KeyPress;

        public KeyHandler(Action<object, KeyPressEventArgs> textBox3_KeyPress)
        {
            this.textBox3_KeyPress = textBox3_KeyPress;
        }
    }
}