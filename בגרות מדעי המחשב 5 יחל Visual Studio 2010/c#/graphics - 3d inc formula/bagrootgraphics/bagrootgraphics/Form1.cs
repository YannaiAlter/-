using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            this.panel1.DoubleClick += Panel1_DoubleClick;
            this.panel1.MouseWheel += Panel1_MouseWheel;
        }

        private void Panel1_DoubleClick(object sender, EventArgs e)
        {
            if (Resolution.Value < Resolution.Maximum)
            {
                Resolution.Value++;
                ResolutionValue.Text = Resolution.Value.ToString();
                button1_Click(null, null);
            }
        }

        private void Panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Y <= panel1.Height / 2)
            {
                if (heightBar.Value + 10 < heightBar.Maximum && widthBar.Value + 10 < widthBar.Maximum)
                {
                    heightBar.Value += 10;// דורש סיום
                    widthBar.Value += 10;
                    widthvalue.Text = widthBar.Value.ToString();
                    heightValue.Text = heightBar.Value.ToString();
                    button1_Click(null, null);
                }
            }
            else
                             if (heightBar.Value - 10 > 0 && widthBar.Value - 10 > 0)
            {
                heightBar.Value -= 10;// דורש סיום
                widthBar.Value -= 10;
                widthvalue.Text = widthBar.Value.ToString();
                heightValue.Text = heightBar.Value.ToString();
                button1_Click(null, null);
            }

        }

        Graphics g = null;
        Bitmap b;
        int col = 0;
        SolidBrush blueBrush = null;
        double res;
        float zoomW = 20;
        float zoomH = 20;
        double[,] oldXYZ;
        double[,] newX;
        float h = 0;
        float w = 0;
        double degrees = 0;
        double degreesx = 20;
        double degreesy = 20;
        double highestZ = double.MinValue;
        double lowestZ = double.MaxValue;
        double highestY = double.MinValue;
        double lowestY = double.MaxValue;
        double highestX = double.MinValue;
        double lowestX = double.MaxValue;
        double[,] newY;

        public void ClearPanel()
        {
            panel1.Controls.Clear();
            g.Clear(panel1.ForeColor);
            g.Clear(panel1.BackColor);
            panel1.Focus();
           
          
        }

        //ט. כניסה: הפונקצייה מקבלת מחרוזת הכוללת פונקצייה
        //ט. יציאה: הפונקצייה מפעילה לולאה שמחשבת את העומק ונקודות האיקס וואי החדשות לפי נוסחת המרה מדו-מימד לתלת-מימד והמחרוזת המתקבלת
        public void Draw3D(string function)
        {
             highestZ = double.MinValue;
             lowestZ = double.MaxValue;
             highestY = double.MinValue;
             lowestY = double.MaxValue;
             highestX = double.MinValue;
             lowestX = double.MaxValue;
            w = panel1.Width / 2 + int.Parse(WidthAdd.Text);
            progressBar1.Maximum = (int)Math.Pow(oldXYZ.GetLength(0)-2,2);
            if (checkedBitmap.Checked)
            {
                b = new Bitmap(panel1.Width, panel1.Height);
                g = Graphics.FromImage(b);
            }
            else
            {
                g = panel1.CreateGraphics();
            }
            for (int i = 0; i < oldXYZ.GetLength(0); i++)
            {
                for (int j = 0; j < oldXYZ.GetLength(1); j++)
                {
                    double newi = i;
                    double newj = j;

                        oldXYZ[i, j] = BinaryTree.BracketReader(function, (newi - newX.GetLength(0) / 2) / res, (newj - newY.GetLength(0) / 2) / res);
              
                    if (oldXYZ[i, j] >= int.MaxValue) oldXYZ[i, j] = 0;
                    if (oldXYZ[i, j] <= int.MinValue) oldXYZ[i, j] = 0;
             
                    if (oldXYZ[i, j] < lowestZ) lowestZ = oldXYZ[i, j];
                    if (oldXYZ[i, j] > highestZ) highestZ = oldXYZ[i, j];

                    newX[i, j] = (((i - newX.GetLength(0) / 2)/res + (Math.Cos(degreesx) * (j - newX.GetLength(0) / 2)/res) * 0.5));
                    newX[i, j] *= zoomW;
                    newY[i, j] = (oldXYZ[i, j] + (Math.Sin(degreesy) * ((j - newX.GetLength(0) / 2)/res)) * 0.5);
                    newY[i, j] *= zoomH;
                    if (newY[i, j] > highestY) highestY = newY[i, j];
                    if (newY[i, j] < lowestY) lowestY = newY[i, j];
                    if (newX[i, j] > highestX) highestX = newX[i, j];
                    if (newX[i, j] < lowestX) lowestX = newX[i, j];
                }
            }
         
        
          
            if ((lowestY > panel1.Height && highestY > panel1.Height) || (lowestY < 0 && highestY < 0) || (lowestX > panel1.Width && highestX > panel1.Width) || (lowestX < 0 && highestX < 0)) MessageBox.Show("Graph's cordinates if not between the panel's cordinates and you won't be able to see the graph");
            else if (highestY >= panel1.Height) MessageBox.Show("You won't be able to see all the graph");
            if (PaintWithOutLines.Checked == false && PaintWithLines.Checked == false)
            {

         

                for (int i = oldXYZ.GetLength(0) - 2; i > 0; i--)
                {
                    for (int j = oldXYZ.GetLength(1) - 2; j > 0; j--)
                    {


                     
                        g.DrawLine(Pens.Black, (float)(w + newX[j, i]), (float)(h - newY[j, i]), (float)(w + newX[j, i + 1]), (float)(h - newY[j, i + 1]));
                        g.DrawLine(Pens.Black, (float)(w + newX[j, i]), (float)(h - newY[j, i]), (float)(w + newX[j + 1, i]), (float)(h - newY[j + 1, i]));
                        progressBar1.Value++;
                        if (progressBar1.Value == progressBar1.Maximum) progressBar1.Value = 0;

                    }
                }

            }
        }

        //(Draw3D) הפונקצייה מציירת את הגרף לפי הנקודות במערך שהוגדר בפונקצייה הקודמת    
        public void Fill3D()
        {
            if(OnlyLines.Checked == false)
            {
            int r = 0, green = 0, b = 0, a=0, col = 0;
          
            for (int i = oldXYZ.GetLength(0) - 2; i > 0; i--)
            {
                for (int j = oldXYZ.GetLength(1) - 2; j > 0; j--)
                {
                   

                         col = (int)(((oldXYZ[i, j] - lowestZ) / (highestZ - lowestZ)) * 255);
                         

                         if (colorOption.Value == 1)
                         {
                             blueBrush = new SolidBrush(Color.FromArgb(255, col, 0, 0));
                         }
                         else if (colorOption.Value == 2)
                             blueBrush = new SolidBrush(Color.FromArgb(255, 0, col, 0));
                         else if (colorOption.Value == 3)
                             blueBrush = new SolidBrush(Color.FromArgb(255, 0, 0, col));
                         else if (colorOption.Value == 4)
                         {
                             //Red-Green
                             if (col > 255/2)
                                 blueBrush = new SolidBrush(Color.FromArgb(255, col, 0, 0));
                             else blueBrush = new SolidBrush(Color.FromArgb(255, 0, col, 0));
                         }
                         else if (colorOption.Value == 5)
                         {
                             //White-Blue
                             if (col > 255 / 2)
                                 blueBrush = new SolidBrush(Color.FromArgb(255, col, col, col));
                             else blueBrush = new SolidBrush(Color.FromArgb(255, 0, 0, col));
                         }
                         else if (colorOption.Value == 6)
                         {
                             //OceanBlue-White
                             if (col > 255 / 2)
                                 blueBrush = new SolidBrush(Color.FromArgb(255, col, col, col));
                             else blueBrush = new SolidBrush(Color.FromArgb(255, 0, col, col));
                         }
                         try
                         {
                             Point p1 = new Point((int)(w + newX[j, i]), (int)(h - newY[j, i]));
                             Point p2 = new Point((int)(w + newX[j, i + 1]), (int)(h - newY[j, i + 1]));
                             Point p3 = new Point((int)(w + newX[j + 1, i + 1]), (int)(h - newY[j + 1, i + 1]));
                             Point p4 = new Point((int)(w + newX[j + 1, i]), (int)(h - newY[j + 1, i]));
                            Point[] ptot = { p1, p2, p3, p4 };
                             g.FillPolygon(blueBrush, ptot);
                            progressBar1.Value++;
                            if (progressBar1.Value == progressBar1.Maximum) progressBar1.Value=0;
                         }
    
                    catch (Exception FillProblem)
                    {
                        MessageBox.Show("Exception \r\n" + FillProblem);
                        i = 500;
                            j=500;
                    }
                }
            }
                if(PaintWithLines.Checked == true)
                    for (int i = oldXYZ.GetLength(0) - 2; i > 0; i--)
                    {
                        for (int j = oldXYZ.GetLength(1) - 2; j > 0; j--)
                        {


                           
                            g.DrawLine(Pens.Black, (float)(w + newX[j, i]), (float)(h - newY[j, i]), (float)(w + newX[j, i + 1]), (float)(h - newY[j, i + 1]));
                            g.DrawLine(Pens.Black, (float)(w + newX[j, i]), (float)(h - newY[j, i]), (float)(w + newX[j+1, i]), (float)(h - newY[j + 1, i]));
             

                        }
                    }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
          g = panel1.CreateGraphics();
        }

        //הפונקציה מגדירה מאפיינים התחלתיים
        public void button1_Click(object sender, EventArgs e)
        {
            if (function.Text == "")
                MessageBox.Show("Please enter a function before plotting");
            else
            {
                ClearPanel();
                res = Resolution.Value;
                highestZ = double.MinValue;
                 lowestZ = double.MaxValue;
                 highestY = double.MinValue;
                 lowestY = double.MaxValue;
                 highestX = double.MinValue;
                 lowestX = double.MaxValue;
                zoomW = widthBar.Value;
                zoomH = heightBar.Value;
                degrees = WatchingDegreesBar.Value;
                degreesx = WatchingDegreesBar.Value;
                degreesy = DepthDegreesBar.Value;
                col = 0;
                blueBrush = null;
                newX = new double[(int)res*ArrayBar.Value, (int)res*ArrayBar.Value];
                newY = new double[(int)res*ArrayBar.Value, (int)res*ArrayBar.Value];
                oldXYZ = new double[ArrayBar.Value*(int)res, (int)res*ArrayBar.Value];
                w = 0;
                h = panel1.Height / 2 - int.Parse(HeightAdd.Text);



                try
                {
                    Draw3D(function.Text);

                }
                catch (Exception values)
                {
                    System.Windows.Forms.MessageBox.Show("The values you chose is high for this function");
                }
                try
                {
                    Fill3D();
                    if (checkedBitmap.Checked) panel1.BackgroundImage = b;
                }
                catch (Exception s)
                {
                    MessageBox.Show("One of the problems:\n1)Wrong Syntax\n2)Values are too high\n3)Values are too low");
                }
                
              
            }
        }



        private void Resolution_Scroll(object sender, EventArgs e)
        {
            ResolutionValue.Text = Resolution.Value.ToString();
       

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }

        private void widthBar_Scroll(object sender, EventArgs e)
        {
            widthvalue.Text = widthBar.Value.ToString();
        }

        private void ArrayBar_Scroll(object sender, EventArgs e)
        {
            ArrayTrack.Text = ArrayBar.Value.ToString();
        }

        private void heightBar_Scroll(object sender, EventArgs e)
        {
            heightValue.Text = heightBar.Value.ToString();
        }

        private void DepthDegreesBar_Scroll(object sender, EventArgs e)
        {
            DepthDegreesValue.Text = DepthDegreesBar.Value.ToString();

        }

        private void WatchingDegreesBar_Scroll(object sender, EventArgs e)
        {
            WatchingDegreesValue.Text = WatchingDegreesBar.Value.ToString();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("צבע אדום עם שחור - 1\r\n צבע ירוק עם שחור - 2 \r\n צבע כחול עם שחור - 3\r\nצבע אדום עם ירוק - 4\r\nצבע כחול עם לבן - 5\r\nצבע טורקיז עם לבן - 6","רשימת צבעים");
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.AccessibleName = "Resolution Explaintation";
            Explantation ExplantationWindow = new Explantation();
            this.Hide();
            ExplantationWindow.Text = "?חלון הסבר - מהי רזולוציה";
            ExplantationWindow.Height = 628;
            ExplantationWindow.Width = 750;
            ExplantationWindow.AccessibleName = "Resolution";
            ExplantationWindow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(".גודל המערך הוא הטווח ציור של הפונקצייה\r\n.אם גודל המערך הוא 50, הפונקצייה תצוייר ממינוס 25 עד פלוס 25","?מה זה גודל המערך");
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
      

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("טווח האיקס והוואי. משפיע על המחזוריות של הפונקצייה. ככל שגודל המערך גדול יותר כך נראה יותר מהפונקצייה");
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {
        
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
     
        }
    }
}
