/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 11/7/2025
 * Time: 6:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace coalzConjusture
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		public Graphics g;
		public Pen p = new Pen(Color.Red,2);
		public Font f;
		public Brush b = new SolidBrush(Color.Black);
		
		
		
		public List<int>cdate = new List<int>();
		public void cc(int n)
		{
		
			int counter = 0;
            while (n != 1)
            {
            	counter++;
            	textBox1.Text += counter.ToString() + " : " + n.ToString() + "\r\n";
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                cdate.Add(n);
            }
            textBox1.Text += "1";
            cdate.Add(1);
       
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			g = this.CreateGraphics();
			f = this.Font;
			textBox2.Text = "1000";
		}
		void Button1Click(object sender, EventArgs e)
		{
			cc(int.Parse(this.textBox2.Text));
		}
		public void grafic()
		{
			for(int i = 0 ; i < cdate.Count ; i++)
			{
				try{
					
					g.DrawLine(p,100+(i*5),cdate[i]+50,100+(i*5),cdate[i-1]+50);
				g.DrawEllipse(p,100+(i*5),cdate[i]+50,5,5);
				g.DrawString(cdate[i].ToString(),f,b,(i*5)+100,cdate[i]+50+50);
				}catch{};
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			grafic();
		}
		void Button3Click(object sender, EventArgs e)
		{
			cdate.Clear();
			g.Clear(this.BackColor);
		}
	}
}


