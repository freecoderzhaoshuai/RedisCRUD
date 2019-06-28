using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisCRUD
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Edit(bool value)
        {
            txtID.ReadOnly = value;
            txtManufacture.ReadOnly = value;
            txtModel.ReadOnly = value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (RedisClient client = new RedisClient("localhost", 6379))
            {
                IRedisTypedClient<Phone> phone = client.As<Phone>();
                phoneBindingSource.DataSource = phone.GetAll();
                Edit(true);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }
    }
}
