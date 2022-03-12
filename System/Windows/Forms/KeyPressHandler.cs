namespace System.Windows.Forms
{
    internal class KeyPressHandler
    {
        private Action<object, KeyPressEventArgs> textBox3_KeyPress;

        public KeyPressHandler(Action<object, KeyPressEventArgs> textBox3_KeyPress)
        {
            this.textBox3_KeyPress = textBox3_KeyPress;
        }
    }
}