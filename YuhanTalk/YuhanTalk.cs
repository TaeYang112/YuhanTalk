using YuhanTalkModule;

namespace YuhanTalk
{
    public partial class YuhanTalk : Form
    {
        private YuhanTalkManager talkManager = YuhanTalkManager.GetInstance();
        public YuhanTalk()
        {
            InitializeComponent();
        }

        private void YuhanTalk_Load(object sender, EventArgs e)
        {
            talkManager.Start(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageGenerator generator = new MessageGenerator(Protocols.C_MSG);
            generator.AddString(textBox1.Text);
            talkManager.SendMessage(generator.Generate());
        }
    }
}