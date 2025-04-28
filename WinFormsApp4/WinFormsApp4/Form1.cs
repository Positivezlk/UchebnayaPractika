namespace WinFormsApp4
{
	public partial class Form1 : Form
	{
		private string correctPin = "1234";

		public Form1()
		{
			InitializeComponent();
			button1.Click += new EventHandler(button1_Click);

		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBoxPin.Text == correctPin)
			{
				MessageBox.Show("Доступ разрешён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Неверный пин-код!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textBoxPin.Clear();
				textBoxPin.Focus();
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}
	}
}

