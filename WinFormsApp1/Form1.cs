namespace WinFormsApp1
{
    public partial class Инвентаризация : Form
    {
        public Инвентаризация()
        {
            InitializeComponent();


            {

                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;



                ListViewItem item1 = new ListViewItem(new string[] { "", "", "" });
                ListViewItem item2 = new ListViewItem(new string[] { "", "", "" });
                ListViewItem item3 = new ListViewItem(new string[] { "", "", "" });

                listView1.Items.Add(item1);
                listView1.Items.Add(item2);

            }
            {




                void Form1_Load(object sender, EventArgs e)
                {

                }

                void label1_Click(object sender, EventArgs e)
                {

                }

                void button2_Click(object sender, EventArgs e)
                {

                }

                void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
                {

                }

                void listView1_SelectedIndexChanged(object sender, EventArgs e)
                {

                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
