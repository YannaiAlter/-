using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char Turn = 'X';
        int lasti=-1;
        int lastj=-1;
        int alpha;
  
        int v_Depth;
        int v_boardSize0;
        int v_boardSize1;
        int v_Sequence;
        string[,] a_XOstatus2;
        string[,] a_XOstatus6;
        string[,] a_XOstatus3;
        string[,] a_XOstatus1;


   

        string[,] a_Tafoos;
        string[,] a_dTafoos;
        int bestI;
        int bestJ;
        Button[,] a_Button;

        int x1;
        int y1;

  
        int scoreO;

        
        
        //הפונקצייה בודקת אם יש אפשרות למחשב לנצח או לחסום את המשתמש ואם יש היא חוסמת או מנצחת 
        //       
        public bool WinOrBlock()
        {
            bool checkDraw = false;
            int best = 500; // 1 - O Wins, 2 - O Blocks one step between two x, 4 - O put 1 between two Os, 5- O put 1 near 1 O. 6-O put 1 near one O 7 - O blocks between 2 X 8 - O Blocks near x 9- O block near X
            #region First Diagonal
            for (int i = 0; i < a_XOstatus1.GetLength(0); i++)
            {
                for (int j = 0; j < a_XOstatus1.GetLength(1); j++)
                {
                    #region Check Draw
                    if (!a_XOstatus1[i, j].Contains("X") || !a_XOstatus1[i, j].Contains("O")) checkDraw = true; 
                    #endregion
                    #region Win Step On First Diagonal
                    if (!a_XOstatus1[i, j].Contains('X') && a_XOstatus1[i, j].Length == v_Sequence - 1)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if(a_Tafoos[i+k,j-k+v_Sequence-1] == null)
                            {
                                   bestI = i + k;
                                bestJ = j - k + v_Sequence -1;
                                best = 1;
                             
                                      return true;
                            }
                        }
                      
                    }
                    #endregion
                    #region Block Win On First Diagonal 
                    else if (!a_XOstatus1[i, j].Contains('O') && a_XOstatus1[i, j].Length == v_Sequence - 1)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if (a_Tafoos[i + k, j - k + v_Sequence - 1] == null)
                            {
                               
                                if (best > 2)
                                {
                                    best = 2;
                                    bestI = i + k;
                                    bestJ = j - k + v_Sequence - 1;
                                    break;
                                }
                               
                            }
                        }

                    }
                    #endregion
                    #region Check Rezef-2 Computer On First Diagonal
                    else if (!a_XOstatus1[i, j].Contains('X') && a_XOstatus1[i, j].Length == v_Sequence - 2)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if (a_Tafoos[i + k, j - k + v_Sequence - 1] == null)
                            {
               
                                #region Check If Can Put O near 1 O
                                 if (i + k + 1 < a_Tafoos.GetLength(0) && j - k - 1 + v_Sequence - 1 >= 0 && a_Tafoos[i + k + 1, j - k - 1 + v_Sequence - 1] == "O")
                                {
                                    if (best > 4)
                                    {
                                        best = 4;
                                        bestI = i + k;
                                        bestJ = j - k + v_Sequence - 1;
                                        break;
                                    }
                                }
                                else if (i + k - 1 >= 0 && j - k + 1 + v_Sequence - 1 < a_Tafoos.GetLength(1) && a_Tafoos[i + k - 1, j - k + 1 + v_Sequence - 1] == "O")
                                { 
                                    if (best > 5)
                                    {
                                        best = 5;
                                        bestI = i + k;
                                        bestJ = j - k + v_Sequence - 1;
                                        break;
                                    }
                                }
                                #endregion
                                #region Check If Can Put O Between 2 O's
                               else if (((i + k - 1 >= 0 && i + k + 1 < a_Tafoos.GetLength(0) && j - k + 1 + v_Sequence - 1 < a_Tafoos.GetLength(1) && j - k - 1 + v_Sequence - 1 >= 0 && a_Tafoos[i + k - 1, j - k + 1 + v_Sequence - 1] == "O" && a_Tafoos[i + k + 1, j - k - 1 + v_Sequence - 1] == "O")))
                                {
                                    if (best > 6)
                                    {
                                        best = 6;
                                        bestI = i + k;
                                        bestJ = j - k + v_Sequence - 1;
                                        break;
                                    }

                                }
                                #endregion


                            }
                        }

                    }
                    #endregion
                    #region Check Rezef-2 User On First Diagonal
                    else if (!a_XOstatus1[i, j].Contains('O') && a_XOstatus1[i, j].Length == v_Sequence - 2)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if (a_Tafoos[i + k, j - k + v_Sequence - 1] == null)
                            {
                                if (i + k + 1 < a_Tafoos.GetLength(0) && j - k - 1 + v_Sequence - 1 >= 0 && a_Tafoos[i + k + 1, j - k - 1 + v_Sequence - 1] == "X")
                                {
                                    if (best > 7)
                                    {
                                        best = 7;
                                        bestI = i + k;
                                        bestJ = j - k + v_Sequence - 1;
                                        break;
                                    }
                                }
                                else if (i + k - 1 >= 0 && j - k + 1 + v_Sequence - 1 < a_Tafoos.GetLength(1) && a_Tafoos[i + k - 1, j - k + 1 + v_Sequence - 1] == "X")
                                {
                                    if (best > 8)
                                    {
                                        best = 8;
                                        bestI = i + k;
                                        bestJ = j - k + v_Sequence - 1;
                                        break;
                                    }
                                }
                                else if (((i + k - 1 >= 0 && i + k + 1 < a_Tafoos.GetLength(0) && j - k + 1 + v_Sequence - 1 < a_Tafoos.GetLength(1) && j - k - 1 + v_Sequence - 1 >= 0 && a_Tafoos[i + k - 1, j - k + 1 + v_Sequence - 1] == "X" && a_Tafoos[i + k + 1, j - k - 1 + v_Sequence - 1] == "X")))
                                {
                                    if (best > 9)
                                    { 
                                        best = 9;
                                        bestI = i + k;
                                        bestJ = j - k + v_Sequence - 1;
                                        break;
                                    }

                                }
                                #endregion


                            }
                        }

                    }
                }
            }
            #endregion
            #region Amuda
            
            for (int i = 0; i < a_XOstatus2.GetLength(0); i++)
            {
                for (int j = 0; j < a_XOstatus2.GetLength(1); j++)
                {
                    #region Check Draw
                    if (!a_XOstatus2[i, j].Contains("X") || !a_XOstatus2[i, j].Contains("O")) checkDraw = true;
                    #endregion
                    if (!a_XOstatus2[i, j].Contains('X') && a_XOstatus2[i, j].Length == v_Sequence - 1)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if (a_Tafoos[i + k, j] == null)
                            {
                                bestI = i + k;
                                bestJ = j;
                                best = 1;
                                return true;
                            }
                        }

                    }
                    else if (!a_XOstatus2[i, j].Contains('O') && a_XOstatus2[i, j].Length == v_Sequence - 1)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if (a_Tafoos[i + k, j] == null)
                            {
                                if(best>2)
                                {
                                    best = 2;
                                    bestI = i + k;
                                    bestJ = j;
                                    break;
                                }
                         
                             
                            }
                        }

                    }

                    else if (!a_XOstatus2[i, j].Contains('X') && a_XOstatus2[i, j].Length == v_Sequence - 2)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if (a_Tafoos[i + k, j] == null)
                            {
                  
                                if (i + k + 1 < a_Tafoos.GetLength(0) && a_Tafoos[i + k + 1, j] == "O")
                                {
                                    if (best > 4)
                                    {
                                        best = 4;
                                        bestI = i + k;
                                        bestJ = j;
                                        break;
                                    }
                                }
                                else if (i + k - 1 >= 0 && a_Tafoos[i + k - 1, j] == "O")
                                {
                                    if (best > 5)
                                    {
                                        best = 5;
                                        bestI = i + k;
                                        bestJ = j;
                                        break;
                                    }
                                }
                               else if (i + k + 1 < a_Tafoos.GetLength(0) && i + k - 1 >= 0 && a_Tafoos[i + k + 1, j] == "O" && a_Tafoos[i + k - 1, j] == "O")
                                {
                                    if (best > 6)
                                    {
                                        best = 6;
                                        bestI = i + k;
                                        bestJ = j;
                                        break;
                                    }
                                }




                            }
                        }

                    }

                    else if (!a_XOstatus2[i, j].Contains('O') && a_XOstatus2[i, j].Length == v_Sequence - 2)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if (a_Tafoos[i + k, j] == null)
                            {

                                    if (i + k + 1 < a_Tafoos.GetLength(0) && a_Tafoos[i + k + 1, j] == "X")
                                {
                                    if (best > 7)
                                    {
                                        best = 7;
                                        bestI = i + k;
                                        bestJ = j;
                                        break;
                                    }
                                }
                                else if (i + k - 1 >= 0 && a_Tafoos[i + k - 1, j] == "X")
                                {
                                    if (best > 8)
                                    {
                                        best = 8;
                                        bestI = i + k;
                                        bestJ = j;
                                        break;
                                    }
                                }
                               else if (i + k + 1 < a_Tafoos.GetLength(0) && i + k - 1 >= 0 && a_Tafoos[i + k + 1, j] == "X" && a_Tafoos[i + k - 1, j] == "X")
                                {
                                    if (best > 9)
                                    {
                                        best = 9;
                                        bestI = i + k;
                                        bestJ = j;
                                        break;
                                    }
                                }
                    
                            }
                        }

                    }
                }


            }
            #endregion
            #region Second Diagonal
            for (int i = 0; i < a_XOstatus3.GetLength(0); i++)
            {
                for (int j = 0; j < a_XOstatus3.GetLength(1); j++)
                {
                    #region Check Draw
                    if (!a_XOstatus3[i, j].Contains("X") || !a_XOstatus3[i, j].Contains("O")) checkDraw = true;
                    #endregion
                    if (!a_XOstatus3[i, j].Contains('X') && a_XOstatus3[i, j].Length == v_Sequence - 1)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if (a_Tafoos[i + k, j + k] == null)
                            {
                                bestI = i +k;
                                bestJ = j + k;
                                best = 1;
                                return true;
                            }
                        }

                    }
                    else if (!a_XOstatus3[i, j].Contains('O') && a_XOstatus3[i, j].Length == v_Sequence - 1)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if (a_Tafoos[i + k, j + k] == null)
                            {
                                if (best > 2)
                                {
                                    best = 2;
                                    bestI = i + k;
                                    bestJ = j + k;
                                    break;
                                }
                            }
                        }

                    }

                    else if (!a_XOstatus3[i, j].Contains('X') && a_XOstatus3[i, j].Length == v_Sequence - 2)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if (a_Tafoos[i + k, j + k] == null)
                            {
                         
                                 if (i + k - 1 >= 0 && j + k - 1 >= 0 && a_Tafoos[i + k - 1, j + k - 1] == "O")
                                {
                                    if (best > 4)
                                    {
                                        best = 4;
                                        bestI = i + k;
                                        bestJ = j + k;
                                        break;
                                    }
                                }
                                else if (i + k + 1 < a_Tafoos.GetLength(0) && j + k + 1 < a_Tafoos.GetLength(1) && a_Tafoos[i + k + 1, j + k + 1] == "O")
                                {
                                    if (best > 5)
                                    {
                                        best = 5;
                                        bestI = i + k;
                                        bestJ = j + k;
                                        break;
                                    }
                                }

                                else if (i + k + 1 < a_Tafoos.GetLength(0) && j + k + 1 < a_Tafoos.GetLength(0) && i + k - 1 >= 0 && j + k - 1 >= 0 && a_Tafoos[i + k + 1, j + k + 1] == "O" && a_Tafoos[i + k - 1, j + k - 1] == "O")
                                {
                                    if (best > 6)
                                    {
                                        best = 6;
                                        bestI = i + k;
                                        bestJ = j + k;
                                        break;
                                    }
                                }

                            }
                        }

                    }
                    else if (!a_XOstatus3[i, j].Contains('O') && a_XOstatus3[i, j].Length == v_Sequence - 2)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if (a_Tafoos[i + k, j + k] == null)
                            {
                                   if (i + k - 1 >= 0 && j + k - 1 >= 0 && a_Tafoos[i + k - 1, j + k - 1] == "X")
                                {
                                    if (best > 7)
                                    {
                                        best = 7;
                                        bestI = i + k;
                                        bestJ = j + k;
                                        break;
                                    }
                                }
                                else if (i + k + 1 < a_Tafoos.GetLength(0) && j + k + 1 < a_Tafoos.GetLength(1) && a_Tafoos[i + k + 1, j + k + 1] == "X")
                                {
                                    if (best > 8)
                                    {
                                        best = 8;
                                        bestI = i + k;
                                        bestJ = j + k;
                                        break;
                                    }
                                }

                                if (i + k + 1 < a_Tafoos.GetLength(0) && j + k + 1 < a_Tafoos.GetLength(0) && i + k - 1 >= 0 && j + k - 1 >= 0 && a_Tafoos[i + k + 1, j + k + 1] == "X" && a_Tafoos[i + k - 1, j + k - 1] == "X")
                                {
                                    if (best > 9)
                                    {
                                        best = 9;
                                        bestI = i + k;
                                        bestJ = j + k;
                                        break;
                                    }
                                }
                      
                            }
                        }

                    }

                }
            }
            #endregion
            #region Check Shura
            for (int i = 0; i < a_XOstatus6.GetLength(0); i++)
            {
              
                for (int j = 0; j < a_XOstatus6.GetLength(1); j++)
                {
                    #region Check Draw
                    if (!a_XOstatus6[i, j].Contains("X") || !a_XOstatus6[i, j].Contains("O")) checkDraw = true;
                    #endregion
                    if (!a_XOstatus6[i, j].Contains('X') && a_XOstatus6[i, j].Length == v_Sequence - 1)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if (a_Tafoos[i, j + k ] == null)
                            {
                                bestI = i;
                                bestJ = j + k;
                                best = 1;
                                return true;
                            }
                        }

                    }
                    else if(!a_XOstatus6[i, j].Contains('O') && a_XOstatus6[i, j].Length == v_Sequence - 1)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if (a_Tafoos[i, j + k] == null)
                            {
                                if(best>2)
                                {
                                    best = 2;
                                    bestI = i;
                                    bestJ = j + k;
                                    break;
                                }
                      
                            }
                        }
                    }
                    else if (!a_XOstatus6[i, j].Contains('X') && a_XOstatus6[i, j].Length == v_Sequence - 2)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if (a_Tafoos[i, j + k] == null)
                            {
                 

                                 if (j + k + 1 < a_Tafoos.GetLength(1) && a_Tafoos[i, j + k + 1] == "O")
                                {
                                    if (best > 4)
                                    {
                                        best = 4;
                                        bestI = i;
                                        bestJ = j + k;
                                        break;
                                    }
                                }
                                else if (j + k - 1 >= 0 && a_Tafoos[i, j + k - 1] == "O")
                                {
                                    if (best > 5)
                                    {
                                        best = 5;
                                        bestI = i;
                                        bestJ = j + k;
                                        break;
                                    }
                                }
                               else if (j + k + 1 < a_Tafoos.GetLength(1) && j + k - 1 >= 0 && a_Tafoos[i, j + k - 1] == "O" && a_Tafoos[i, j + k + 1] == "O")
                                {
                                    if (best > 6)
                                    {
                                        best = 6;
                                        bestI = i;
                                        bestJ = j + k;
                                        break;
                                    }
                                }

                            }
                        }
                    }

                    else if (!a_XOstatus6[i, j].Contains('O') && a_XOstatus6[i, j].Length == v_Sequence - 2)
                    {
                        for (int k = 0; k < v_Sequence; k++)
                        {
                            if (a_Tafoos[i, j + k] == null)
                            {
                                 if (j + k + 1 < a_Tafoos.GetLength(1) && a_Tafoos[i, j + k + 1] == "X")
                                {
                                    if (best > 7)
                                    {
                                        best = 7;
                                        bestI = i;
                                        bestJ = j + k;
                                        break;
                                    }
                                }
                                else if (j + k - 1 >= 0 && a_Tafoos[i, j + k - 1] == "X")
                                {
                                    if (best > 8)
                                    {
                                        best = 8;
                                        bestI = i;
                                        bestJ = j + k;
                                        break;
                                    }
                                }
                               else if (j + k + 1 < a_Tafoos.GetLength(1) && j + k - 1 >= 0 && a_Tafoos[i, j + k - 1] == "X" && a_Tafoos[i, j + k + 1] == "X")
                                {
                                    if (best > 9)
                                    {
                                        best = 9;
                                        bestI = i;
                                        bestJ = j + k;
                                        break;
                                    }
                                }
                    
                            }
                        }
                    }

                }
            }
            #endregion
            if (!checkDraw) ResetPanelWithMessagebox("Draw");
            if (best != 500) return true;
            return false;
        }


public void ResetPanelWithMessagebox(string s)
        {
            MessageBox.Show(s);
            resetPanel();
        }

        //הפונקצייה מחשבת את ניקוד הלוח לפי מערכי המונים, ומחזירה את הניקוד
        //
        private int ScoreCalculate()
        {
            int score = 0;//Check O's
            int score2 = 0; //Check Trick
          
            for (int i = 0; i < a_XOstatus1.GetLength(0); i++)
            {
                for (int j = 0; j < a_XOstatus1.GetLength(1); j++)
                {
                    if (!a_XOstatus1[i, j].Contains("X")) score += a_XOstatus1[i, j].Length;
                    if (!a_XOstatus1[i, j].Contains("O") && a_XOstatus1.Length >= v_Sequence - 1) score2 += a_XOstatus1[i, j].Length;
      
                }
            }
            for (int i = 0; i < a_XOstatus2.GetLength(0); i++)
            {
                for (int j = 0; j < a_XOstatus2.GetLength(1); j++)
                {
                    if (!a_XOstatus2[i, j].Contains("X")) score += a_XOstatus2[i, j].Length;
                    if (!a_XOstatus2[i, j].Contains("O") && a_XOstatus2.Length >= v_Sequence - 1) score2 += a_XOstatus2[i, j].Length;
                }
            }
            for (int i = 0; i < a_XOstatus3.GetLength(0); i++)
            {
                for (int j = 0; j < a_XOstatus3.GetLength(1); j++)
                {
                    if (!a_XOstatus3[i, j].Contains("X")) score += a_XOstatus3[i, j].Length;
                    if (!a_XOstatus3[i, j].Contains("O") && a_XOstatus3.Length >= v_Sequence - 1) score2 += a_XOstatus3[i, j].Length;
                }
            }
            for (int i = 0; i < a_XOstatus6.GetLength(0); i++)
            {
                for (int j = 0; j < a_XOstatus6.GetLength(1); j++)
                {
                    if (!a_XOstatus6[i, j].Contains("X")) score += a_XOstatus6[i, j].Length;
                    if (!a_XOstatus6[i, j].Contains("O") && a_XOstatus6.Length >= v_Sequence - 1) score2 += a_XOstatus6[i, j].Length;
                }
            }

            //   MessageBox.Show(score.ToString());
         if (score2 >=2)
            {
                score2 *= 3;
                return score - score2;
            }
            return score;
          
            //  MessageBox.Show((scoreIgool - scoreIks - mone).ToString());


        }

 
        //ט. כניסה: הפונקצייה קולטת את עומק החשיבה והתור (איקס או עיגול 
        //ט. יציאה: הפונקצייה מחזירה ניקוד (מספר שלם) הגבוהה או הנמוך ביותר שהתקבל בלולאה
        //אם התור הוא איקס, יוחזר הערך הנמוך ביותר שהתקבל בלולאה
        //אם התור הוא עיגול, יוחזר הערך הגבוהה ביותר שהתקבל בלולאה
        public int MiniMaxNext(int depth, char Turn)
  
        {
            int maxScore = -100000;
            int minScore = 100000;
            int theScoreO = 0;
            int theScoreX = 0;
            if (depth == 0)
            {

                return ScoreCalculate();
            }
          

            if (Turn == 'O')
            {
                for (int i = 0; i < a_Button.GetLength(0); i++)
                {
                    for (int j = 0; j < a_Button.GetLength(1); j++)
                    {
                        if (a_Tafoos[i, j] == null)
                        {
                            a_Button[i, j].Text = "O";

                            addPoints(i, j, 1,false);
                     
                            a_Tafoos[i, j] = "O";
                         
                            theScoreO = MiniMaxNext(depth - 1, 'X');
                         
                            a_Button[i, j].Text = "";
                            addPoints(i, j, -1,false);
                            a_Tafoos[i, j] = null;


                      

                            if (theScoreO > maxScore)
                            {
                                maxScore = theScoreO;


                            }


                        }


                    }


                }
                return maxScore;

            }
            else if (Turn == 'X')
            {
           
                for (int i = 0; i < a_Button.GetLength(0) ; i++)
                {
                    for (int j = 0; j < a_Button.GetLength(1); j++)
                    {

                        if (a_Tafoos[i, j] == null)
                        {
                            a_Button[i, j].Text = "X";

                            addPoints(i, j, 1,false);

                            a_Tafoos[i, j] = "X";
                     
                            theScoreX = MiniMaxNext(depth - 1, 'O');
                           
                            a_Button[i, j].Text = "";
                            addPoints(i, j, -1,false);
                            a_Tafoos[i, j] = null;

                       
                            if (theScoreX < minScore)
                            {
                                minScore = theScoreX;

                            }



                        }


                    }

                    
                }
                return minScore;

            }

            return ScoreCalculate();
        }

        //ט. כניסה: הפונקצייה קולטת את עומק החשיבה
        //ט. יציאה: הפונקצייה מגדירה את השורה והעמודה הכי טובים לעיגול לפי הניקוד שהיא מקבלת מהפונקצייה מינימקס
        private void MiniMax(int depth)
        {
            int mxScore = -1000000;
            int checkDepth = 0;
            for (int i = 0; i < a_Button.GetLength(0); i++)
            {
                for (int j = 0; j < a_Button.GetLength(1); j++)
                {
                    if (a_Tafoos[i, j] == null) checkDepth++;
                }
            }
            if (depth > checkDepth) depth = checkDepth;
       
            for (int i = 0; i < a_Button.GetLength(0); i++)
            {
                for (int j = 0; j < a_Button.GetLength(1); j++)
                {
               
                    if (a_Tafoos[i, j] == null)
                    {
                        x1 = i;
                        y1 = j;
                
                        a_Button[i, j].Text = "O";
                        a_Tafoos[i, j] = "O";
                        addPoints(i, j, 1,false);
                        scoreO = MiniMaxNext(depth - 1, 'X');
           
                        a_Button[i, j].Text = "";
                        addPoints(i, j, -1,false);
                        a_Tafoos[i, j] = null;

                        if (scoreO > mxScore)
                        {
                            alpha = scoreO;
                            mxScore = scoreO;
                            bestI = i;
                            bestJ = j;
                        }

                    }
                  
                        progressBar1.Value++;
                        if (progressBar1.Value == progressBar1.Maximum) progressBar1.Value = 0;
                    
                }

            }
       
        }

        //הפונקצייה קוראת לשיטת הניקוי של הפאנל וכך מנקה את הפאנל
        //
        private void resetPanel()
        {
            for (int i = 0; i < a_Tafoos.GetLength(0); i++)
            {
                for (int j = 0; j < a_Tafoos.GetLength(1); j++)
                {
                    a_Tafoos[i, j] = null;
                }
            }
            for (int i = 0; i < a_XOstatus1.GetLength(0); i++)
            {
                for (int j = 0; j < a_XOstatus1.GetLength(1); j++)
                {
                    a_XOstatus1[i, j] = "";
                    a_XOstatus1[i, j] = "";
            
                }
            }
            for (int i = 0; i < a_XOstatus2.GetLength(0); i++)
            {
                for (int j = 0; j < a_XOstatus2.GetLength(1); j++)
                {
                    a_XOstatus2[i, j] = "";
                    a_XOstatus2[i, j] = "";

                }
            }
            for (int i = 0; i < a_XOstatus3.GetLength(0); i++)
            {
                for (int j = 0; j < a_XOstatus3.GetLength(1); j++)
                {
                    a_XOstatus3[i, j] ="";
                    a_XOstatus3[i, j] = "";

                }
            }
            for (int i = 0; i < a_XOstatus6.GetLength(0); i++)
            {
                for (int j = 0; j < a_XOstatus6.GetLength(1); j++)
                {
                    a_XOstatus6[i, j] = "";
                    a_XOstatus6[i, j] = "";

                }
            }


            b_Submit.Visible = true;
            panel1.Controls.Clear();
        }

         //ט. כניסה: הפונקצייה קולטת שורה, עמודה, פסוק בוליאני, אופרציה, ותור   
         //  ט. יציאה: הפונקצייה מוסיפה ניקוד למערכי המונים לפי הפרמטרים שהתקבלו
        private void addPoints(int i, int j,int sign,bool dimion)
        {

            int x = i;
            int y = j;
            string[,] ar1;
            string[,] ar2;
            string[,] ar3;
            string[,] ar6;
            if(dimion)
            {
                ar1 = a_XOstatus1;
                ar2 = a_XOstatus2;
                ar3 = a_XOstatus3;
                ar6 = a_XOstatus6;
            }
            else
            {
                ar1 = a_XOstatus1;
                ar2 = a_XOstatus2;
                ar3 = a_XOstatus3;
                ar6 = a_XOstatus6;
            }
            for (int n = 0; n < v_Sequence; n++)
            {
                if (x < ar6.GetLength(0) && y < ar6.GetLength(1) && x >= 0 && y >= 0)
                {
                    
                    if (sign != -1)//Adding Xs
                    {
                        if (Turn == 'X')
                        {
                            ar6[x, y] += "X";
                            if (!dimion && ar6[x, y].Length == v_Sequence && !ar6[x, y].Contains("O")) ResetPanelWithMessagebox("X Won");
                        }
                        else if (Turn == 'O')
                        {
                            ar6[x, y] += "O";
                            if (!dimion && ar6[x, y].Length == v_Sequence && !ar6[x, y].Contains("X")) ResetPanelWithMessagebox("O Won");
                        }
                    }
                    else
                    {

                        if (Turn == 'X')
                        {
                            int xPlace = ar1[x, y].IndexOf('X');
                            if (xPlace == 0)
                            {
                                ar6[x, y] = ar6[x, y].Substring(1);
                            }
                            else if (xPlace == ar6[x, y].Length - 1) ar6[x, y] = ar6[x, y].Substring(0, ar6[x, y].Length - 1);
                            else
                            {
                                ar6[x, y] = ar6[x, y].Substring(0, xPlace) + ar6[x, y].Substring(xPlace + 1, ar6[x, y].Length-xPlace-1);
                            }
                        }
                        else if (Turn == 'O')
                        {
                            int oPlace = ar6[x, y].IndexOf('O');
                            if (oPlace == 0)
                            {
                                ar6[x, y] = ar6[x, y].Substring(1);
                            }
                            else if (oPlace == ar6[x, y].Length - 1) ar6[x, y] = ar6[x, y].Substring(0, ar6[x, y].Length - 1);
                            else
                            {

                                ar6[x, y] = ar6[x, y].Substring(0, oPlace) + ar6[x, y].Substring(oPlace + 1, ar6[x, y].Length-oPlace-1);
                            }
                        }
                    }
                }
                y--;
            }

                y = j;

            for (int n = 0; n < v_Sequence; n++)
            {
                if (x < ar2.GetLength(0) && y < ar2.GetLength(1) && x >= 0 && y >= 0)
                {


                    if (sign != -1)//Adding Xs
                    {
                        if (Turn == 'X')
                        {
                            ar2[x, y] += "X";
                            if (!dimion && ar2[x, y].Length == v_Sequence && !ar2[x, y].Contains("O")) ResetPanelWithMessagebox("X Won");

                        }
                        else if (Turn == 'O')
                        {
                            ar2[x, y] += "O";
                            if (!dimion && ar2[x, y].Length == v_Sequence && !ar2[x, y].Contains("X")) ResetPanelWithMessagebox("O Won");

                        }
                    }
                    else
                    {

                        if (Turn == 'X')
                        {
                            int xPlace = ar2[x, y].IndexOf('X');
                            if (xPlace == 0)
                            {
                                ar2[x, y] = ar2[x, y].Substring(1);
                            }
                            else if (xPlace == ar2[x, y].Length - 1) ar2[x, y] = ar2[x, y].Substring(0, ar2[x, y].Length - 1);
                            else
                            {
                                ar2[x, y] = ar2[x, y].Substring(0, xPlace) + ar2[x, y].Substring(xPlace + 1, ar2[x, y].Length-xPlace-1);
                            }
                        }
                        else if (Turn == 'O')
                        {
                            int oPlace = ar2[x, y].IndexOf('O');
                            if (oPlace == 0)
                            {
                                ar2[x, y] = ar2[x, y].Substring(1);
                            }
                            else if (oPlace == ar2[x, y].Length - 1) ar2[x, y] = ar2[x, y].Substring(0, ar2[x, y].Length - 1);
                            else
                            {

                                ar2[x, y] = ar2[x, y].Substring(0, oPlace) + ar2[x, y].Substring(oPlace + 1, ar2[x, y].Length-oPlace-1);
                            }
                        }
                    }

                }
                
                x--;
            }
                x = i;

            for (int n = 0; n < v_Sequence; n++)
            {
                if (x < ar3.GetLength(0) && y < ar3.GetLength(1) && x >= 0 && y >= 0)
                {
                    
                    if (sign != -1)//Adding Xs
                    {
                        if (Turn == 'X')
                        {
                            ar3[x, y] += "X";
                            if (!dimion && ar3[x, y].Length == v_Sequence && !ar3[x, y].Contains("O")) ResetPanelWithMessagebox("X Won");
                        }
                        else if (Turn == 'O')
                        {
                            ar3[x, y] += "O";
                            if (!dimion && ar3[x, y].Length == v_Sequence && !ar3[x, y].Contains("X")) ResetPanelWithMessagebox("O Won");
                        }
                    }
                    else
                    {

                        if (Turn == 'X')
                        {
                            int xPlace = ar1[x, y].IndexOf('X');
                            if (xPlace == 0)
                            {
                                ar3[x, y] = ar3[x, y].Substring(1);
                            }
                            else if (xPlace == ar3[x, y].Length - 1) ar3[x, y] = ar3[x, y].Substring(0, ar3[x, y].Length - 1);
                            else
                            {
                                ar3[x, y] = ar3[x, y].Substring(0, xPlace) + ar3[x, y].Substring(xPlace + 1, ar3[x, y].Length-xPlace-1);
                            }
                        }
                        else if (Turn == 'O')
                        {
                            int oPlace = ar3[x, y].IndexOf('O');
                            if (oPlace == 0)
                            {
                                ar3[x, y] = ar3[x, y].Substring(1);
                            }
                            else if (oPlace == ar3[x, y].Length - 1) ar3[x, y] = ar3[x, y].Substring(0, ar3[x, y].Length - 1);
                            else
                            {

                                ar3[x, y] = ar3[x, y].Substring(0, oPlace) + ar3[x, y].Substring(oPlace + 1, ar3[x, y].Length-oPlace-1);
                            }
                        }
                    }
             
                    
                }
                x--;
                y--;
            }
                x = i;
            y = j;

            for (int n = 0; n < v_Sequence; n++)
            {
                int newY = y - v_Sequence + 1;
                if (x < ar1.GetLength(0) && newY < ar1.GetLength(1) && x >= 0 && newY >= 0)
                {


                    if (sign != -1)//Adding Xs
                    {
                        if (Turn == 'X')
                        {
                            ar1[x, newY] += "X";
                            if (!dimion && ar1[x, newY].Length == v_Sequence && !ar1[x, newY].Contains("O")) ResetPanelWithMessagebox("X Won");
                        }
                        else if (Turn == 'O')
                        {
                            ar1[x, newY] += "O";
                            if (!dimion && ar1[x, newY].Length == v_Sequence && !ar1[x, newY].Contains("X")) ResetPanelWithMessagebox("O Won");
                        }
                    }
                    else
                    {

                        if (Turn == 'X')
                        {
                            int xPlace = ar1[x, newY].IndexOf('X');
                            if (xPlace == 0)
                            {
                                ar1[x, newY] = ar1[x, newY].Substring(1);
                            }
                            else if (xPlace == ar1[x, newY].Length - 1) ar1[x, newY] = ar1[x, newY].Substring(0, ar1[x, newY].Length - 1);
                            else
                            {
                                ar1[x, newY] = ar1[x, newY].Substring(0, xPlace) + ar1[x, newY].Substring(xPlace + 1, ar1[x, newY].Length-xPlace-1);
                            }
                        }
                        else if (Turn == 'O')
                        {
                            int oPlace = ar1[x, newY].IndexOf('O');
                            if (oPlace == 0)
                            {
                                ar1[x, newY] = ar1[x, newY].Substring(1);
                            }
                            else if (oPlace == ar1[x, newY].Length - 1) ar1[x, newY] = ar1[x, newY].Substring(0, ar1[x, newY].Length - 1);
                            else
                            {

                                ar1[x, newY] = ar1[x, newY].Substring(0, oPlace) + ar1[x, newY].Substring(oPlace + 1, ar1[x, newY].Length-oPlace-1);
                            }
                       
                        }
                      
                    }
                 //   MessageBox.Show(ar1[0, 3].ToString());

                }
                x--;
                y++;
            }
            if(dimion)
            {
                a_XOstatus1 = ar1;
                a_XOstatus2 = ar2;
                a_XOstatus3 = ar3;
                a_XOstatus6 = ar6;
            }
            else
            {
                a_XOstatus1 = ar1;
                a_XOstatus2 = ar2;
                a_XOstatus3 = ar3;
                a_XOstatus6 = ar6;
            }
       
        }

        

        //הפונקצייה מגדירה משתנים התחלתיים וקבועים, גבולות של מערכים, מטפלת במקרי קצה
        //
        private void setProperties()
        {
  
              
      
            int v_PlaceOfPsik = t_BoardSize.Text.IndexOf('x');
  
         
                v_boardSize0 = int.Parse(t_BoardSize.Text.Substring(0, v_PlaceOfPsik));
                if (t_BoardSize.Text.Length == 5)
                    v_boardSize1 = int.Parse(t_BoardSize.Text.Substring(v_PlaceOfPsik + 1, t_BoardSize.Text.Length - 3));
                else v_boardSize1 = int.Parse(t_BoardSize.Text.Substring(v_PlaceOfPsik + 1, t_BoardSize.Text.Length - 2));

            if (v_boardSize0 < 5) v_boardSize0 = -5;
            if (v_boardSize1 < 5) v_boardSize1 = -5;

            v_Sequence = int.Parse(t_Sequence.Text);
            if (v_Sequence < 5) v_boardSize0 = -5; // Create exception.

            v_Depth = int.Parse(t_Depth.Text);
                 if (v_Depth < 1 || v_Depth > 3) v_boardSize0 = -5; // Create exception.
                a_XOstatus2 = new string[v_boardSize0 - v_Sequence + 1, v_boardSize1];
                a_XOstatus6 = new string[v_boardSize0, v_boardSize1 - v_Sequence + 1];
                a_XOstatus3 = new string[v_boardSize0 - v_Sequence + 1, v_boardSize1 - v_Sequence + 1];
                a_XOstatus1 = new string[v_boardSize0 - v_Sequence + 1, v_boardSize1 - v_Sequence + 1];//Hardest -

                a_XOstatus2 = new string[v_boardSize0 - v_Sequence + 1, v_boardSize1];
                a_XOstatus6 = new string[v_boardSize0, v_boardSize1 - v_Sequence + 1];
                a_XOstatus3 = new string[v_boardSize0 - v_Sequence + 1, v_boardSize1 - v_Sequence + 1];
                a_XOstatus1 = new string[v_boardSize0 - v_Sequence + 1, v_boardSize1 - v_Sequence + 1];//Hardest -
                a_Tafoos = new string[v_boardSize0, v_boardSize1];
                a_dTafoos = new string[v_boardSize0, v_boardSize1];

            Turn = 'X';
            
        }

        //הפונקצייה מציירת על הפאנל לוח ממערך כפתורים לפי גודל השורה והעמודה
        //
        private void drawButtons()
        {
            int x = 0, y = 0;
            a_Button = new Button[v_boardSize0, v_boardSize1];
            progressBar1.Maximum = a_Button.GetLength(0)*a_Button.GetLength(1);
            for (int i = 0; i < a_Button.GetLength(0); i++)
            {
                for (int j = 0; j < a_Button.GetLength(1); j++)
                {

                    a_Button[i, j] = new Button();
                    a_Button[i, j].Width = panel1.Width / a_Button.GetLength(1);
                    a_Button[i, j].Height = panel1.Height / a_Button.GetLength(0);
                    a_Button[i, j].Left = x;
                    x += panel1.Width / a_Button.GetLength(1);
                    a_Button[i, j].Top = y;
                    a_Button[i, j].Click += call_xTurn;
                    a_Button[i, j].AccessibleDescription = i + ", " + j;
                    panel1.Controls.Add(a_Button[i, j]);
                }
                x = 0;
                y += panel1.Height / a_Button.GetLength(0);

            }
        }

        //הפונקצייה בודקת אם יש ניצחון לאחד מהשחקנים
        //
        public void CheckWin()
        {
     
        }

        void call_xTurn(object sender, EventArgs e)
        {
            if (Turn == 'X')
            {
     
           
                string Size = ((Button)(sender)).AccessibleDescription;
                int psik = Size.IndexOf(',');
                int i = int.Parse(Size.Substring(0, psik));
                int j = int.Parse(Size.Substring(psik + 1, Size.Length - psik - 1));
                a_Button[i, j].BackColor = Color.Red;
                a_Button[i, j].Enabled = false;
                a_Button[i, j].Text = "X";
                addPoints(i, j, 1,false);
           
                a_Tafoos[i, j] = "X";
                a_dTafoos[i, j] = "X";
                CheckWin();
      
                Turn = 'O';
            }

            if (!WinOrBlock())
            {
                MiniMax(v_Depth);
            }
            a_Button[bestI, bestJ].BackColor = Color.Blue;
            lasti = bestI;
            lastj = bestJ;
            a_Button[bestI, bestJ].Text = "O";
            a_Button[bestI, bestJ].Enabled = false;
            addPoints(bestI, bestJ, 1,false);

            a_Tafoos[bestI, bestJ] = "O";
            a_dTafoos[bestI, bestJ] = "O";
            Turn = 'X';
            CheckWin();

        }

        private void b_Submit_Click(object sender, EventArgs e)
        {
  
            try
            {
                setProperties();
                resetPanel();
                drawButtons();
 
            }
            catch
            {
                MessageBox.Show("Error in syntax of properties.");
            }
         
            //call_xTurn();

            ////////////////EvolutionFunction();
            //MiniMaxNext();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void b_pcSubmit_Click(object sender, EventArgs e)
        {


            MiniMax(v_Depth);
            a_Button[bestI, bestJ].BackColor = Color.Blue;
            lasti = bestI;
            lastj = bestJ;
            a_Button[bestI, bestJ].Text = "O";
            a_Button[bestI, bestJ].Enabled = false;

            addPoints(bestI, bestJ, 1, false);
            a_Tafoos[bestI, bestJ] = "O";
            Turn = 'X';
            CheckWin();
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turn = 'O';
            MiniMax(v_Depth);
            a_Button[bestI, bestJ].BackColor = Color.Red;
            lasti = bestI;
            lastj = bestJ;
            a_Button[bestI, bestJ].Text = "X";
            a_Button[bestI, bestJ].Enabled = false;

                addPoints(bestI, bestJ, 1,false);
            a_Tafoos[bestI, bestJ] = "X";
            Turn = 'X';
            CheckWin();
   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                setProperties();
                resetPanel();
                drawButtons();
     
                b_Submit.Visible = false;
                addPoints(0, 0, 1, false);
                addPoints(0, 0, 1, true);
                a_Tafoos[0, 0] = "X";
                a_Button[0, 0].Text = "X";
            }
            catch
            {
                MessageBox.Show("Invaild Syntax.");
            }
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
