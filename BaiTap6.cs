using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

          //  button21.Visible = true;
            button22.Visible = true;
            //button23.Visible = true;
           // button24.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            button27.Visible = true;
            button28.Visible = true;
            button29.Visible = true;
         //   button9.Visible = true;
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
        //    button21.Visible = false;
            button22.Visible = false;
         //   button23.Visible = false;
         //   button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
         //   button9.Visible = false;
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
          //  button21.Visible = false;
            button22.Visible = false;
            //button23.Visible = false;
           // button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
          //  button9.Visible = false;
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

        private void button24_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Trà thải độc", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
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

        private void button23_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Trà oải hương", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
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

        private void button48_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Topping khúc bạch", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Trà sữa việt quất", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
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

        private void button9_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Trà Cozy", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Topping rau câu", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
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

        private void button45_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Phô mai thạch", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
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

        private void button32_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Soda chanh dây", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "150000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { " súp hải sản", SL, DonGia, ThanhTien };

            if (dataGridView1.Visible == true)
                dataGridView1.Rows.Add(row);
            if (dataGridView2.Visible == true)
                dataGridView2.Rows.Add(row);
            if (dataGridView3.Visible == true)
                dataGridView3.Rows.Add(row);
            if (dataGridView4.Visible == true)
                dataGridView4.Rows.Add(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Trà sữa Socola", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Thạch củ năng", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
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

        private void button47_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Pudding", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
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

        private void button34_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Soda việt quất", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Trà trái cây", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Trà sữa bạc hà", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
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

        private void button12_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Trà sữa thái xanh", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
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

        private void button13_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Trà sữa Nhật", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
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

        private void button14_Click(object sender, EventArgs e)
        {
            string SL = "1";
            string DonGia = "20000";

            string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

            string[] row = new string[] { "Trà sữa thái đỏ", SL, DonGia, ThanhTien };

            dataGridView1.Rows.Add(row);
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
            int tong = 0;
            int cout = dataGridView1.Rows.Count;
            for(int i=0;i<cout;i++)
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
            richTextBox3.Text = Convert.ToString(Convert.ToInt32(richTextBox1.Text) * (1 - (Convert.ToDouble(richTextBox2.Text) / 100)));
        }
        
        //private void button43_Click(object sender, EventArgs e)
        //{
        //    string SL = "1";
        //    string DonGia = "20000";

        //    string ThanhTien = Convert.ToString(Convert.ToInt32(SL) * Convert.ToInt32(DonGia));

        //    string[] row = new string[] { "Trân châu", SL, DonGia, ThanhTien };

        //    dataGridView1.Rows.Add(row);
        //}

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
    }
}
