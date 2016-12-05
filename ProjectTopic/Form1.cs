using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTopic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            string Name = Convert.ToString(txtName.Text); //ประกาศตัวแปลรับชื่อเข้ามา
            string date = DateTime.Now.ToString("dd-MM-yyyy"); //วันเดือนปีปัจจุบัน
            DateTime now = DateTime.Now; 
            DateTime select = dateTimePicker1.Value; //ประกาศตัวแปลรับค่าวันเดือนปีเกิด
            txtResult.Text = "คุณ    "+Name+"    มีอายุ    "+ CalAge(now, select).ToString()+"  ปี"; //แสดงผล


        }
        //คำนวณอายุ
        public long CalAge(System.DateTime now,System.DateTime select)
        {
            long age = 0;  //ประกาศตัวแปล
            System.TimeSpan ts = new TimeSpan(now.Ticks - select.Ticks); //ปีปัจจุบันลบด้วยค่าวันเดือนปีที่เรารับมา 
            age = (long)(ts.Days / 365); //วันที่ ที่ลบกันออกมาแร้วมาหารด้วย 365 วัน

            return age;
        }
        //คำสั่งลบ
        private void btnClaer_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtResult.Clear();
        }
        //เวลารันโปรแกรมขึ้นมาให้วันเดือนปีไปโชร์ที่ Labell เฉยๆค่ะ
        private void Form1_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd-MM-yyyy"); 
            label1.Text = date.ToString();
        }
    }
}
