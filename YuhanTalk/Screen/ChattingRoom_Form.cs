using YuhanTalk.Screen;
using YuhanTalkModule;

namespace YuhanTalk
{
    public partial class ChattingRoom_Form : System.Windows.Forms.Form
    {

        MainForm? mainForm;
        public ChattingRoom_Form()
        {
            InitializeComponent();
        }

        public ChattingRoom_Form(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void YuhanTalk_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}