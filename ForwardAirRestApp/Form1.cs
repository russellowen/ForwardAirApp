namespace ForwardAirRestApp
{
    public partial class Form1 : Form
    {
        static HttpClient client = new();
        public Form1()
        {
            client.DefaultRequestHeaders.Add("user", "highddfw");
            client.DefaultRequestHeaders.Add("password", "G6rgDBI6rcg0WgSa");
            client.DefaultRequestHeaders.Add("customerId", "HIGHDDFW");
            client.DefaultRequestHeaders.Add("Content-Type", "application/xml");
           
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

        }
        static async Task ProcessRequestAsync(HttpClient client)
        {

        }
    }
}