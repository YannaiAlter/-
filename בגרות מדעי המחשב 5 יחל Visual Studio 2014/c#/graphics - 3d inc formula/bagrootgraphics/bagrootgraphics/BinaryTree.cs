using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    //מחלקת חולייה של עץ בינארי
    public class BinTreeNode<T>
    {
        private BinTreeNode<T> left;
        private T info;
        private BinTreeNode<T> right;
        public BinTreeNode(T x)
        {
            this.left = null;
            this.info = x;
            this.right = null;
        }
        public BinTreeNode(BinTreeNode<T> left, T x, BinTreeNode<T> right)
        {
            this.left = left;
            this.info = x;
            this.right = right;
        }
        public T GetInfo()
        {
            return this.info;
        }
        public void SetInfo(T x)
        {
            this.info = x;
        }
        public BinTreeNode<T> GetLeft()
        {
            return this.left;
        }
        public BinTreeNode<T> GetRight()
        {
            return this.right;
        }
        public void SetLeft(BinTreeNode<T> tree)
        {
            this.left = tree;
        }
        public void SetRight(BinTreeNode<T> tree)
        {
            this.right = tree;
        }
        public override string ToString()
        {
            return this.info.ToString();
        }
    }

    //מחלקה המייצגת עצים בינארים
    public class BinaryTree
    {
        string s;

        /*   public static void PrintInOrder(BinTreeNode<string> t)
            {
                if (t != null)
                {
                    PrintInOrder(t.GetLeft());
                    Console.Write(t.GetInfo().ToString() + "");
                    PrintInOrder(t.GetRight());
                }

            }*/


        // ט. כניסה: הפונקצייה מקבלת ביטוי אלגברי הכולל משתנה איקס ו-ואי, ושתי מספרים ממשיים
        //ט. יציאה: הפונקצייה מחזירה את תוצאת הביטוי בהצבת המספרים הממשיים ב איקס, וואי בהתאמה
        public static double BracketReader(String str1, double x, double y)
        {

            int Cb = 0;
            int Ob = 0;
            string Bb = null;
            string Ab = null;
            string Ib = null;
            double Tb;

            for (int i = str1.Length - 1; i >= 0; i--)
            {
                if (str1[i] == 'x')
                {

                    int n;
                    if (i > 0 && (int.TryParse(str1[i - 1].ToString(), out n) || str1[i - 1] == 'y' || str1[i - 1] == 'x')) // 6x or 6-x checking, Replacing 6x to 6*x
                        Bb = str1.Substring(0, i) + '*';
                    else
                        Bb = str1.Substring(0, i);
                    Ib = x.ToString();
                    Ab = str1.Substring(i + 1, str1.Length - i - 1);

                    str1 = Bb + Ib + Ab;
                }
                if (str1[i] == 'y')
                {
                    int n;
                    if (i > 0 && (int.TryParse(str1[i - 1].ToString(), out n) || str1[i - 1] == 'y' || str1[i - 1] == 'x')) // 6x or 6-x checking, Replacing 6x to 6*x
                        Bb = str1.Substring(0, i) + '*';
                    else
                        Bb = str1.Substring(0, i);
                    Ib = y.ToString();
                    Ab = str1.Substring(i + 1, str1.Length - i - 1);

                    str1 = Bb + Ib + Ab;
                }

            }

            for (int i = str1.Length - 1; i >= 0; i--)
            {

                if (str1[i] == ')')
                    Cb = i; //getting the last ')'


                if (str1[i] == '(')
                {
                    Ab = str1.Substring(Cb + 1, str1.Length - Cb - 1); // same with sqrt and unsqrt. the after will be the same
                    Ob = i;//same
                    Ib = str1.Substring(Ob + 1, Cb - Ob - 1);

                    if (str1[i] == '(' && i != 0 && str1[i - 1] == 't') // if the brackets is part of the sqrt
                    {

                        Bb = str1.Substring(0, Ob - 4); // the -1 will delete the 's' from the sentence
                        Tb = Math.Sqrt(CalculateTreeOfParser(BuildTreeOfParser(Ib)));

                    }
                    else if (str1[i] == '(' && i != 0 && str1[i - 1] == 'n') // if the brackets is part of the sqrt
                    {

                        Bb = str1.Substring(0, Ob - 3); // the -1 will delete the 's' from the sentence
                        Tb = Math.Sin(CalculateTreeOfParser(BuildTreeOfParser(Ib)));

                    }
                    else if (str1[i] == '(' && i != 0 && str1[i - 1] == 's' && str1[i - 2] == 'o') // if the brackets is part of the sqrt
                    {

                        Bb = str1.Substring(0, Ob - 3); // the -1 will delete the 's' from the sentence
                        Tb = Math.Cos(CalculateTreeOfParser(BuildTreeOfParser(Ib)));

                    }

                    else if (str1[i] == '(' && i != 0 && str1[i - 1] == 's' && str1[i - 2] == 'b') // if the brackets is part of the abs
                    {

                        Bb = str1.Substring(0, Ob - 3); // the -1 will delete the 's' from the sentence
                        Tb = Math.Abs(CalculateTreeOfParser(BuildTreeOfParser(Ib)));

                    }
                    else // if the brackets is only brackets and not part of any sqrt
                    {
                        Bb = str1.Substring(0, Ob); // there is no 's' to delete
                        Tb = CalculateTreeOfParser(BuildTreeOfParser(Ib));
                    }


                    str1 = Bb + Tb.ToString() + Ab;// same with sqrt and unsqrt
                    i = str1.Length; // same with sqrt and unsqrt


                }

            }

            return CalculateTreeOfParser(BuildTreeOfParser(str1));


        }

        //ט. כניסה: הפונקצייה מקבלת מחרוזת של ביטוי חשבוני
        //ט. יציאה: הפונקצייה מחזירה עץ בינארי המורכב משמאל לימין לפי הביטוי
        static BinTreeNode<string> BuildTreeOfParser(String str)
        {

            BinTreeNode<string> tr = null;
            for (int i = str.Length - 1; i > 0; i--)
                if (((str[i] == '+' || str[i] == '-') && tr == null) && str[i - 1] != '*' && str[i - 1] != '/' && str[i - 1] != '^')
                {
                    if (str[i - 1] == '-' || str[i - 1] == '+')
                    {
                        tr = new BinTreeNode<string>(str[i - 1].ToString());
                        tr.SetRight(BuildTreeOfParser(str.Substring(i, str.Length - i)));
                        tr.SetLeft(BuildTreeOfParser(str.Substring(0, i - 1)));
                    }
                    else
                    {
                        tr = new BinTreeNode<string>(str[i].ToString());
                        tr.SetRight(BuildTreeOfParser(str.Substring(i + 1, str.Length - i - 1)));
                        tr.SetLeft(BuildTreeOfParser(str.Substring(0, i)));
                    }
                }
            for (int i = str.Length - 1; i > 0; i--)
                if ((str[i] == '*' || str[i] == '/') && tr == null)
                {
                    tr = new BinTreeNode<string>(str[i].ToString());
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 1, str.Length - i - 1)));
                    tr.SetLeft(BuildTreeOfParser(str.Substring(0, i)));
                }
            for (int i = str.Length - 1; i > 0; i--)
                if ((str[i] == '^') && tr == null)
                {
                    tr = new BinTreeNode<string>(str[i].ToString());
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 1, str.Length - i - 1)));
                    tr.SetLeft(BuildTreeOfParser(str.Substring(0, i)));
                }

            if (tr == null)
            {
                tr = new BinTreeNode<string>(str);
            }
            return tr;
        }

        //ט. כניסה: הפונקצייה מקבלת עץ בינארי
        //ט. יציאה: הפונקצייה מחשבת את ערך העץ לפי סדר פעולות חשבון ועוברת על העץ משמאל לימין
        static double CalculateTreeOfParser(BinTreeNode<string> t)
        {
            if (t != null)
                if (t.GetInfo() == "+")
                    return CalculateTreeOfParser(t.GetLeft()) + CalculateTreeOfParser(t.GetRight());
                else
                    if (t.GetInfo() == "-")
                    return CalculateTreeOfParser(t.GetLeft()) - CalculateTreeOfParser(t.GetRight());
                else
                        if (t.GetInfo() == "*")
                    return CalculateTreeOfParser(t.GetLeft()) * CalculateTreeOfParser(t.GetRight());
                else
                            if (t.GetInfo() == "/")
                    return CalculateTreeOfParser(t.GetLeft()) / CalculateTreeOfParser(t.GetRight());
                else
                                if (t.GetInfo() == "^")
                    return Math.Pow(CalculateTreeOfParser(t.GetLeft()), CalculateTreeOfParser(t.GetRight()));
            int s;

            try
            {
                return double.Parse(t.GetInfo());
            }
            catch (Exception flow)
            {
                return 0;
            }



        }

    }
}
