namespace Delegate_Forms
{
    public delegate void DelegateEvent();
    class Program : Form
    {
        public event DelegateEvent addEvent;

        public Program()
        {
            Button button = new Button();
            button.Parent = this;
            button.Text = "Click Me";
            button.Location = new Point(100, 50);
            button.Click += new EventHandler(Button_Click);
            addEvent += new DelegateEvent(OnAddEvent);

            this.Text = "Delegate Forms Example";
            this.Size = new Size(300, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(button);
            this.FormClosing += new FormClosingEventHandler(Program_FormClosing);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            addEvent?.Invoke();
        }
        private void OnAddEvent()
        {
            MessageBox.Show("Button Clicked! Event Triggered.");
        }
        private void Program_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form is closing.");
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }
    }
}