using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace DDMamnon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
                // Tạo một instance của UserControl
                Thucdon myUserControl = new Thucdon();

                // Thiết lập vị trí và kích thước của UserControl trong Form (nếu cần)
                myUserControl.Location = new Point(189, 5); 
               
                // Thêm UserControl vào Form
                this.Controls.Add(myUserControl);

                // Đảm bảo UserControl được đưa lên trên cùng để nó không bị ẩn bởi các điều khiển khác
                myUserControl.BringToFront();
            
        }
    }
}
