using リスコフの配置原則.Objects;

namespace リスコフの配置原則
{
    public partial class Form1 : Form
    {
        private Member.MemberKind _loginKind = Member.MemberKind.Silver;
        private Member _member;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.Text = _loginKind.ToString();
            _member = Member.Create(_loginKind);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var price = Convert.ToInt32(PriceTextBox.Text);
            button1.Text = _member.GetPoint(price).ToString();
        }
    }
}
