namespace YuhanTalk.CustomControl
{
    public partial class Lchat : UserControl
    {
        public Lchat() : this("테스트테스테스테스테스테스테스테스테스테스", "관리자","00-00-00")
        {
        }
        public Lchat(string context, string name, string time)
        {
            InitializeComponent();
            lblContext.Text = context;
            lblName.Text = name;
            lblTime.Text = time;
            rbtnChat.Size = new Size(lblContext.Size.Width + 16, lblContext.Size.Height + 16);
            lblTime.Location = new Point(rbtnChat.Left + rbtnChat.Width + 9, rbtnChat.Top + rbtnChat.Height - lblTime.Height);
            this.Height = rbtnChat.Height + rbtnChat.Top + 3;
        }


        private void Lchat_Load(object sender, EventArgs e)
        {
        }
    }
}
