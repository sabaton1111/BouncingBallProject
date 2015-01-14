using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new concentrate_testEntities())
            {
                var username = textBox1.Text;
                var password = textBox2.Text;
                user current = db.users
                    .Where(u => u.Username == username && u.Password == password)
                    .FirstOrDefault();
                if(current == null)
                {
                    MessageBox.Show("Wrong");
                }
                else
                {
                    MessageBox.Show("Successful Login");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(var db = new concentrate_testEntities())
            {
                var username = @textBox1.Text;
                var password = @textBox2.Text;
                if(username == "" || password == "")
                {
                    MessageBox.Show("Username and Password required");
                }
                else
                {
                    user temp = new user()
                    {
                        Username = username,
                        Password = password
                    };
                    db.users.Add(temp);
                    db.SaveChanges();
                    MessageBox.Show("Successful Registration");
                }
            }
        }
    }
}
