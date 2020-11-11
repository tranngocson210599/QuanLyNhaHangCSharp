using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace BT6
{
    public partial class BaiTap6 : Form
    {
       
        public BaiTap6()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //tra sua
        private void button5_Click(object sender, EventArgs e)
        {
           
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button22.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            
            button33.Visible = false;
           
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
          

        }
        //tra/hồng trà 
        private void button4_Click(object sender, EventArgs e)
        {
           
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button22.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            button27.Visible = true;
            button28.Visible = true;
            button29.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
           
            button30.Visible = false;
            button31.Visible = false;
          
            button33.Visible = false;
           
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
           
        }
        //soda
        private void button6_Click(object sender, EventArgs e)
        {
          
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button22.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button30.Visible = true;
            button31.Visible = true;
            button33.Visible = true;
            button35.Visible = true;
            button36.Visible = true;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
          
        }
        //yaourt
        private void button7_Click(object sender, EventArgs e)
        {
           
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button22.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
          
            button33.Visible = false;
           
            button35.Visible = false;
            button36.Visible = false;

            button37.Visible = true;
            button38.Visible = true;
            button39.Visible = true;
            button40.Visible = true;
            button41.Visible = true;
            button42.Visible = true;
           
        }
        //topping
        private void button8_Click(object sender, EventArgs e)
        {
           
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
        
            button22.Visible = false;
            
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
        
            button10.Visible = false;
            button11.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
           
            button33.Visible = false;
           
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
           
        }
        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

          
        }

      

        private void button29_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "150000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Mực Chiên Giòn", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "100000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Gỏi Ngó Sen", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

      
        private void button27_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "200000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Chả Giò", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "30000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Lẩu hải sản", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Bánh phô mai", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

        

    

        private void button37_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Bánh trứng muối", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "300000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Lẩu bò", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

      

       

        private void button38_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Bánh pudding", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "250000";
           
            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));
           
            string[] row = new string[] { "Lẩu gà lá giang", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "150000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Gỏi tai heo", SL, DonGia, ThanhTien };
            if(dataGridView1.Visible==true)
            dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "200000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Gà Hấp lá chanh", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

       
        private void button39_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Chè hạt sen", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

       
        private void button11_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "150000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Súp hải sản", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

     

     

        private void button40_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Bánh nướng táo", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "200000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Lẩu nấm", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "200000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Salad hải sản", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "3500000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Dê nướng", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

       

        private void button41_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Bánh trứng phồng", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

      

      

      

        private void button35_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "200000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Lẩu thái", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "180000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Cá Phile Tẩm Mè", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "200000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Ca ri bánh mì", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Súp cua", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

      

        private void button18_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "250000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Bò nhúng giấm ", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

       

        private void button19_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "250000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Tôm hấp bia ", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

       

        private void button20_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "200000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Gà bó xôi", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {



            // int cout = dataGridView1.Rows.Count;
            int cout = 0;
            int tong = 0;
            int cout1 = dataGridView1.Rows.Count;
            int cout2 = dataGridView2.Rows.Count;
            int cout3 = dataGridView3.Rows.Count;
            int cout4 = dataGridView4.Rows.Count;
            
            if (dataGridView1.Visible == true)
                cout = cout1;
            if (dataGridView2.Visible == true)
                cout = cout2;
            if (dataGridView3.Visible == true)
                cout = cout3;
            if (dataGridView4.Visible == true)
                cout = cout4;
            for (int i=0;i<cout;i++)
            {
                if (dataGridView1.Visible == true)
                    tong += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                if (dataGridView2.Visible == true)
                    tong += Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value);
                if (dataGridView3.Visible == true)
                    tong += Convert.ToInt32(dataGridView3.Rows[i].Cells[2].Value);
                if (dataGridView4.Visible == true)
                    tong += Convert.ToInt32(dataGridView4.Rows[i].Cells[2].Value);
               
            }
            richTextBox1.Text = Convert.ToString(tong);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)

        {
            try
            {
                if(Convert.ToDouble(richTextBox2.Text)>=1&& Convert.ToDouble(richTextBox2.Text)<=100)
                richTextBox3.Text = Convert.ToString(Convert.ToInt32(richTextBox1.Text) * (1 - (Convert.ToDouble(richTextBox2.Text) / 100)));
                else
                    MessageBox.Show("Giảm giá phải lớn hơn bằng 1 và nhỏ hơn bằng 100", "Error");
            }
            catch
            {
                MessageBox.Show("Giảm giá không đúng", "Error");
            }
        }
        
      

        private void Bàn1_Click(object sender, EventArgs e)
        {
            tenban2.Visible = false;
            tenban3.Visible = false;
            tenban4.Visible = false;
            hd2.Visible = false;
            hd3.Visible = false;
            hd4.Visible = false;
            kh2.Visible = false;
            kh3.Visible = false;
            kh4.Visible = false;
            nhanvien2.Visible = false;
            nhanvien3.Visible = false;
            nhanvien4.Visible = false;

            tenban1.Text = "Bàn 1";
            tenban1.Visible = true;
            hd1.Visible = true;
            kh1.Visible = true;
            nhanvien1.Visible = true;

            dataGridView4.Visible = false;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
        }
        //ban2
        private void button55_Click(object sender, EventArgs e)
        {
            tenban2.Visible = true;
            tenban3.Visible = false;
            tenban4.Visible = false;
            hd2.Visible = true;
            hd3.Visible = false;
            hd4.Visible = false;
            kh2.Visible = true;
            kh3.Visible = false;
            kh4.Visible = false;
            nhanvien2.Visible = true;
            nhanvien3.Visible = false;
            nhanvien4.Visible = false;
            tenban2.Text = "Bàn 2";
            tenban1.Visible = false;
            hd1.Visible = false;
            kh1.Visible = false;
            nhanvien1.Visible = false;
            dataGridView4.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
        }

        private void ban3_Click(object sender, EventArgs e)
        {
            tenban2.Visible = false;
            tenban3.Visible = true;
            tenban4.Visible = false;
            hd2.Visible = false;
            hd3.Visible = true;
            hd4.Visible = false;
            kh2.Visible = false;
            kh3.Visible = true;
            kh4.Visible = false;
            nhanvien2.Visible = false;
            nhanvien3.Visible = true;
            nhanvien4.Visible = false;
            tenban3.Text = "Bàn 3";
            tenban1.Visible = false;
            hd1.Visible = false;
            kh1.Visible = false;
            nhanvien1.Visible = false;
            dataGridView4.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
        }

        private void ban4_Click(object sender, EventArgs e)
        {
            tenban2.Visible = false;
            tenban3.Visible = false;
            tenban4.Visible = true;
            hd2.Visible = false;
            hd3.Visible = false;
            hd4.Visible = true;
            kh2.Visible = false;
            kh3.Visible = false;
            kh4.Visible = true;
            nhanvien2.Visible = false;
            nhanvien3.Visible = false;
            nhanvien4.Visible = true;
            tenban4.Text = "Bàn 4";
            tenban1.Visible = false;
            hd1.Visible = false;
            kh1.Visible = false;
            nhanvien1.Visible = false;
            dataGridView4.Visible = true;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
        }

        private void hd2_TextChanged(object sender, EventArgs e)
        {

        }
        // in hóa đơn
        private void button52_Click(object sender, EventArgs e)
        {

            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument; 
            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(MakeBill); 

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();

            }
            if (dataGridView1.Visible == true)
            {
                this.dataGridView1.Rows.Clear();
                hd1.Text = "";
                nhanvien1.Text = "";
                kh1.Text = "";

            }
            if (dataGridView2.Visible == true)
            {
                this.dataGridView1.Rows.Clear();
                hd1.Text = "";
                nhanvien1.Text = "";
                kh1.Text = "";
            }
            if (dataGridView3.Visible == true)
            {
                this.dataGridView3.Rows.Clear();
                hd3.Text = "";
                nhanvien3.Text = "";
                kh3.Text = "";
            }
            if (dataGridView4.Visible == true)
            {
                this.dataGridView4.Rows.Clear();
                hd4.Text = "";
                nhanvien4.Text = "";
                kh4.Text = "";
            }
            richTextBox3.Text = "";
            richTextBox2.Text = "";
            richTextBox1.Text = "";

           
        }
        public void MakeBill(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12); 

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;
            string tenban="", soHD="", KH="", NV="";
            graphic.DrawString(" Tran Ngoc Son Restaurant", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            if (dataGridView1.Visible == true)
            {
                tenban = "Tên bàn : " + tenban1.Text;
                soHD = "Số hóa đơn : " + hd1.Text;
                KH = "Tên khác hàng : " + kh1.Text;
                NV = "Tên nhân viên phục vụ : " + nhanvien1.Text;
            }
            if (dataGridView2.Visible == true)
            {
                tenban = "Tên bàn : " + tenban2.Text;
                soHD = "Số hóa đơn : " + hd2.Text;
                KH = "Tên khác hàng : " + kh2.Text;
                NV = "Tên nhân viên phục vụ : " + nhanvien2.Text;
            }

            if (dataGridView3.Visible == true)
            {
                tenban = "Tên bàn : " + tenban3.Text;
                soHD = "Số hóa đơn : " + hd3.Text;
                KH = "Tên khác hàng : " + kh3.Text;
                NV = "Tên nhân viên phục vụ : " + nhanvien3.Text;
            }
            if (dataGridView4.Visible == true)
            {
                tenban = "Tên bàn : " + tenban4.Text;
                soHD = "Số hóa đơn : " + hd4.Text;
                KH = "Tên khác hàng : " + kh4.Text;
                NV = "Tên nhân viên phục vụ : " + nhanvien4.Text;
            }



            string datagridString = "Tên món".PadRight(30) + "Số lượng".PadRight(10) + "Đơn giá".PadRight(10) + "Thành tiền";


           // string top = "Item Name".PadRight(30) + "Price";
            graphic.DrawString(tenban, font, new SolidBrush(Color.Black), startX, startY + offset);
            startY += 30;
            graphic.DrawString(soHD, font, new SolidBrush(Color.Black), startX, startY + offset);
            startY += 30;
            graphic.DrawString(KH, font, new SolidBrush(Color.Black), startX, startY + offset);
            startY += 30;
            graphic.DrawString(NV, font, new SolidBrush(Color.Black), startX, startY + offset);
            startY += 30;
            graphic.DrawString("-----------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            startY += 30;
            graphic.DrawString(datagridString, font, new SolidBrush(Color.Black), startX, startY + offset);
            startY += 30;
            string tmp="";
            

            int cout = 0;
            int cout1 = dataGridView1.Rows.Count;
            int cout2 = dataGridView2.Rows.Count;
            int cout3 = dataGridView3.Rows.Count;
            int cout4 = dataGridView4.Rows.Count;
            if (dataGridView1.Visible == true)
                cout = cout1;
            if (dataGridView2.Visible == true)
                cout = cout2;
            if (dataGridView3.Visible == true)
                cout = cout3;
            if (dataGridView4.Visible == true)
                cout = cout4;
            for (int i=0;i< cout; i++)
            {
                if(dataGridView1.Visible==true)
                {
                    tmp = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value).PadRight(30)
                   + Convert.ToString(dataGridView1.Rows[i].Cells[1].Value).PadRight(10)
                   + Convert.ToString(dataGridView1.Rows[i].Cells[2].Value).PadRight(10)
                   + Convert.ToString(dataGridView1.Rows[i].Cells[3].Value).PadRight(10);
                }
                if (dataGridView2.Visible == true)
                {
                    tmp = Convert.ToString(dataGridView2.Rows[i].Cells[0].Value).PadRight(30)
                   + Convert.ToString(dataGridView2.Rows[i].Cells[1].Value).PadRight(10)
                   + Convert.ToString(dataGridView2.Rows[i].Cells[2].Value).PadRight(10)
                   + Convert.ToString(dataGridView2.Rows[i].Cells[3].Value).PadRight(10);
                }
                if (dataGridView3.Visible == true)
                {
                    tmp = Convert.ToString(dataGridView3.Rows[i].Cells[0].Value).PadRight(30)
                   + Convert.ToString(dataGridView3.Rows[i].Cells[1].Value).PadRight(10)
                   + Convert.ToString(dataGridView3.Rows[i].Cells[2].Value).PadRight(10)
                   + Convert.ToString(dataGridView3.Rows[i].Cells[3].Value).PadRight(10);
                }
                if (dataGridView4.Visible == true)
                {
                    tmp = Convert.ToString(dataGridView4.Rows[i].Cells[0].Value).PadRight(30)
                   + Convert.ToString(dataGridView4.Rows[i].Cells[1].Value).PadRight(10)
                   + Convert.ToString(dataGridView4.Rows[i].Cells[2].Value).PadRight(10)
                   + Convert.ToString(dataGridView4.Rows[i].Cells[3].Value).PadRight(10);
                }
                graphic.DrawString(tmp, font, new SolidBrush(Color.Black), startX, startY + offset);
                startY += 30;
            }

            string TienHang, GiamGia, TongTien;
            TienHang = "Tiền hàng : "+richTextBox1.Text;
            GiamGia = "Giảm giá :" + richTextBox2.Text+"%";
            TongTien = "Tổng tiền :" + richTextBox3.Text;

            graphic.DrawString(TienHang, font, new SolidBrush(Color.Black), startX, startY + offset);
            startY += 30;
            graphic.DrawString(GiamGia, font, new SolidBrush(Color.Black), startX, startY + offset);
            startY += 30;
            graphic.DrawString(TongTien, font, new SolidBrush(Color.Black), startX, startY + offset);
            startY += 30;
            graphic.DrawString("                 Cảm ơn quý khách", font, new SolidBrush(Color.Black), startX, startY + offset);
            startY += 30;
            graphic.DrawString("                 Hẹn gặp lại", font, new SolidBrush(Color.Black), startX, startY + offset);

        }
    }
}
