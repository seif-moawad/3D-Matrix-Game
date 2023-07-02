using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace In_Lec
{
    public partial class Form1 : Form
    {
        Bitmap off;

        _3D_Model Cube = new _3D_Model();
        _3D_Model Cube1 = new _3D_Model();
        _3D_Model Cube2 = new _3D_Model();
        List<_3D_Model> plat = new List<_3D_Model>();
        List<Parmetric_Model> cones = new List<Parmetric_Model>();
        Timer tt = new Timer();
        Camera cam = new Camera();
        int ct = 0;
        int ctt = 0;
        int flag = 0;
        int k = 0;
        int r = -1;
        int s = 1;
        int move = 0;
        int pos = 0;
        int ctx = 1;
        int cty = 1;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.Load += new EventHandler(Form1_Load);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            tt.Tick += Tt_Tick;
            tt.Start();
        }

        private void Tt_Tick(object sender, EventArgs e)
        {
            ctt +=10;
            
            if (move == 0)
            {
                cam.cop.Y++;
                if (ct < 45)
                {
                    _3D_Point p1 = new _3D_Point(plat[k].L_3D_Pts[plat[k].L_Edges[0].i]);
                    _3D_Point p2 = new _3D_Point(plat[k].L_3D_Pts[plat[k].L_Edges[0].j]);
                    Transformation.RotateArbitrary(Cube1.L_3D_Pts, p1, p2, 2);
                    ct++;
                }
                else
                {
                    cty++;
                    if(cty==15)
                    {
                        tt.Stop();
                        MessageBox.Show("You win");
                    }
                    if (cty == 4 && ctx == 1)
                    {
                        move = 3;
                    }
                    if (cty == 4 && ctx == 3)
                    {
                        move = 3;
                    }
                    if (cty == 4 && ctx == 5)
                    {
                        move = 3;
                    }
                    if (cty == 4 && ctx == 7)
                    {
                        move = 3;
                    }

                    if (cty == 6 && ctx == 1)
                    {
                        move = 3;
                        //MessageBox.Show("kk");
                    }
                    if (cty == 6 && ctx == 3)
                    {
                        move = 3;
                    }
                    if (cty == 6 && ctx == 5)
                    {
                        move = 3;
                    }
                    if (cty == 6 && ctx == 7)
                    {
                        move = 3;
                    }
                    if (cty == 7 && ctx == 2)
                    {
                        move = 3;
                    }
                    if (cty == 8 && ctx == 5)
                    {
                        move = 3;
                    }
                    if (cty == 7 && ctx == 6)
                    {
                        move = 3;
                    }
                    if (flag == 1)
                    {
                        move = 1;
                        flag = 0;
                        r += 1;
                    }
                    if (flag == 2)
                    {
                        move = 2;
                        flag = 0;
                        s = r + 1;
                        r--;
                    }
                    if (flag == 0)
                    {
                        k += 8;
                    }
                    ct = 0;
                }
            }
            if(move == 1)
            {
                //k--;
                //MessageBox.Show(Convert.ToString(k));
                if (ct < 45)
                {
                    _3D_Point p1 = new _3D_Point(plat[r].L_3D_Pts[plat[r].L_Edges[1].i]);
                    _3D_Point p2 = new _3D_Point(plat[r].L_3D_Pts[plat[r].L_Edges[1].j]);
                    Transformation.RotateArbitrary(Cube1.L_3D_Pts, p1, p2, 2);
                    ct++;
                }
                else
                {
                    ctx++;
                    if (cty == 15)
                    {
                        tt.Stop();
                        MessageBox.Show("You win");
                    }
                    if (cty == 4 && ctx == 1)
                    {
                        move = 3;
                    }
                    if (cty == 4 && ctx == 3)
                    {
                        move = 3;
                    }
                    if (cty == 4 && ctx == 5)
                    {
                        move = 3;
                    }
                    if (cty == 4 && ctx == 7)
                    {
                        move = 3;
                    }

                    if (cty == 6 && ctx == 1)
                    {
                        move = 3;
                        //MessageBox.Show("kk");
                    }
                    if (cty == 6 && ctx == 3)
                    {
                        move = 3;
                    }
                    if (cty == 6 && ctx == 5)
                    {
                        move = 3;
                    }
                    if (cty == 6 && ctx == 7)
                    {
                        move = 3;
                    }
                    if (cty == 7 && ctx == 2)
                    {
                        move = 3;
                    }
                    if (cty == 8 && ctx == 5)
                    {
                        move = 3;
                    }
                    if (cty == 7 && ctx == 6)
                    {
                        move = 3;
                    }
                    if (ctx > 8)
                    {
                        move = 3;
                        MessageBox.Show("fall");
                    }
                    else if (flag == 1 && move !=3)
                    {
                        move = 1;
                        flag = 0;
                        r += 1;
                        ct = 0;
                    }
                    else if (flag == 2 && move != 3)
                    {
                        move = 2;
                        flag = 0;
                        s = r + 1;
                        r--;
                        ct = 0;
                    }
                    else if(move !=3)
                    {
                        //r += 2;
                        //k += 12;
                        move = 0;
                        ct = 0;
                        flag = 0;
                    }
                }
            }
            if (move == 2)
            {
                //k--;
                //MessageBox.Show(Convert.ToString(k));
                if (ct < 45)
                {
                    _3D_Point p1 = new _3D_Point(plat[s].L_3D_Pts[plat[s].L_Edges[3].i]);
                    _3D_Point p2 = new _3D_Point(plat[s].L_3D_Pts[plat[s].L_Edges[3].j]);
                    Transformation.RotateArbitrary(Cube1.L_3D_Pts, p1, p2, 2);
                    ct++;
                }
                else
                {
                    ctx++;
                    if (cty == 15)
                    {
                        tt.Stop();
                        MessageBox.Show("You win");
                    }
                    if (cty == 4 && ctx == 1)
                    {
                        move = 3;
                    }
                    if (cty == 4 && ctx == 3)
                    {
                        move = 3;
                    }
                    if (cty == 4 && ctx == 5)
                    {
                        move = 3;
                    }
                    if (cty == 4 && ctx == 7)
                    {
                        move = 3;
                    }

                    if (cty == 6 && ctx == 1)
                    {
                        move = 3;
                        //MessageBox.Show("kk");
                    }
                    if (cty == 6 && ctx == 3)
                    {
                        move = 3;
                    }
                    if (cty == 6 && ctx == 5)
                    {
                        move = 3;
                    }
                    if (cty == 6 && ctx == 7)
                    {
                        move = 3;
                    }
                    if (cty == 7 && ctx == 2)
                    {
                        move = 3;
                    }
                    if (cty == 8 && ctx == 5)
                    {
                        move = 3;
                    }
                    if (cty == 7 && ctx == 6)
                    {
                        move = 3;
                    }
                    if (ctx > 0)
                    {
                        move = 3;
                        MessageBox.Show("fall");
                    }
                    else if (flag == 1 && move != 3)
                    {
                        move = 1;
                        flag = 0;
                        r += 1;
                        ct = 0;
                    }
                    else if (flag == 2 && move != 3)
                    {
                        move = 2;
                        flag = 0;
                        s = r + 1;
                        r--;
                        ct = 0;
                    }
                    else if (move != 3)
                    {
                        //r += 2;
                        //k += 12;
                        move = 0;
                        ct = 0;
                        flag = 0;
                    }
                }

            }
            if(move == 3)
            {
                Transformation.TranslateZ(Cube1.L_3D_Pts, 20);
                //MessageBox.Show("Game over");
            }
            DrawDubble(this.CreateGraphics());
        }
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                flag = 1;
            }
            if (e.KeyCode == Keys.Left)
            {
                flag = 2;
            }
            switch (e.KeyCode)
            {
                case Keys.X:
                    Transformation.RotatX(Cube.L_3D_Pts, 1);
                    break;
                case Keys.Y:
                    Transformation.RotatY(Cube.L_3D_Pts, 1);
                    break;
                case Keys.Z:
                    Transformation.RotatZ(Cube.L_3D_Pts, 1);
                    break;

                case Keys.F:
                    cam.cop.Y += 10;
                    break;
                case Keys.G:
                    cam.cop.Y -= 10;
                    break;
               
                case Keys.Up:
                    cam.cop.Z += 10;
                    break;
                case Keys.Down:
                    cam.cop.Z -= 10;
                    break;

                case Keys.Space:
                    
                    break;
            }

            DrawDubble(this.CreateGraphics());
        }

        void CreateCube(_3D_Model M, float XS, float YS, float ZS, Color vvv)
        {
            float[] vert = 
                            { 
                                    -100,100,-100,
                                    100,100,-100,
                                    100,-100,-100,
                                    -100,-100,-100,
                            };


            _3D_Point pnn;
            int j = 0;
            for (int i = 0; i < 4; i++)
            {
                pnn = new _3D_Point(vert[j]+XS, vert[j + 1]+YS, vert[j + 2]+ZS);
                j += 3;
                M.AddPoint(pnn);
            }


            int[] Edges = {
                                0,1,
                                1,2,
                                2,3,
                                3,0,
                          };
            j = 0;
            //Color[] cl = { Color.Red, Color.Green, Color.Black, Color.Blue };
            for (int i = 0; i < 4; i++)
            {
                M.AddEdge(Edges[j], Edges[j + 1], Color.Purple);

                j += 2;
            }
        }

        void CreateCube2(_3D_Model M, float XS, float YS, float ZS, Color vvv)
        {
            float[] vert =
                            {
                                    -100,100,-100,
                                    100,100,-100,
                                    100,-100,-100,
                                    -100,-100,-100,
                            };


            _3D_Point pnn;
            int j = 0;
            for (int i = 0; i < 4; i++)
            {
                pnn = new _3D_Point(vert[j] + XS, vert[j + 1] + YS, vert[j + 2] + ZS);
                j += 3;
                M.AddPoint(pnn);
            }


            int[] Edges = {
                                0,1,
                                1,2,
                                2,3,
                                3,0,
                          };
            j = 0;
            //Color[] cl = { Color.Red, Color.Green, Color.Black, Color.Blue };
            for (int i = 0; i < 4; i++)
            {
                M.AddEdge(Edges[j], Edges[j + 1], Color.Blue);

                j += 2;
            }
        }

        void CreateCube1(_3D_Model M, float XS, float YS, float ZS, Color vvv)
        {
            float[] vert =
                            {
                                    -100,100,-100,
                                    100,100,-100,
                                    100,-100,-100,
                                    -100,-100,-100,
                                    -100,100,100,
                                    100,100,100,
                                    100,-100,100,
                                    -100,-100,100,

                            };


            _3D_Point pnn;
            int j = 0;
            for (int i = 0; i < 8; i++)
            {
                pnn = new _3D_Point(vert[j] + XS, vert[j + 1] + YS, vert[j + 2] + ZS);
                j += 3;
                M.AddPoint(pnn);
            }


            int[] Edges = {
                                0,1,
                                1,2,
                                2,3,
                                3,0,
                                4,5,
                                5,6,
                                6,7,
                                7,4,
                                0,4,
                                3,7,
                                2,6,
                                1,5
                          };
            j = 0;
            //Color[] cl = { Color.Red, Color.Green, Color.Black, Color.Blue };
            for (int i = 0; i < 12; i++)
            {
                M.AddEdge(Edges[j], Edges[j + 1], Color.Black);

                j += 2;
            }
        }

        void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(this.ClientSize.Width , this.ClientSize.Height);


            int cx = 400;
            int cy = 400;
            cam.ceneterX = 1100;
            cam.ceneterY = 700;
            
            cam.cxScreen = cx;
            cam.cyScreen = cy;            
            cam.BuildNewSystem();
            Cube.cam = cam;
            CreateCube(Cube , 0,0,0 , Color.Red);
            Transformation.Scale(Cube.L_3D_Pts, 1.5f, 1.5f, 1.5f);

            Cube1.cam = cam;
            CreateCube1(Cube1, 0, 0, 0, Color.Red);
            Transformation.Scale(Cube1.L_3D_Pts, 0.2f, 0.2f, 0.2f);
            Transformation.TranslateX(Cube1.L_3D_Pts, -200.0f);
            Transformation.TranslateY(Cube1.L_3D_Pts, 40.0f);
            Transformation.TranslateZ(Cube1.L_3D_Pts, -40.0f);

            Cube2.cam = cam;
            CreateCube(Cube2, 0, 0, 0 , Color.Green);
            Transformation.Scale(Cube2.L_3D_Pts, 0.5f, 0.5f, 0.5f);

            int xv = -200;
            int yv = 160;
            int zv = -20;
            int x = 0;
            int y = 0;
            for (int i = 0; i < 15; i++)
            {
                x = -200;
                y += 40;
                //Transformation.TranslateZ(pnn.L_3D_Pts, zmove);
                if (i == 14)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        _3D_Model pnn5 = new _3D_Model();
                        pnn5.cam = cam;
                        CreateCube2(pnn5, 0, 0, 0, Color.Blue);
                        Transformation.Scale(pnn5.L_3D_Pts, 0.2f, 0.2f, 0.2f);
                        Transformation.TranslateX(pnn5.L_3D_Pts, x);
                        Transformation.TranslateY(pnn5.L_3D_Pts, y);
                        //Transformation.TranslateZ(pnn.L_3D_Pts, zmove);
                        plat.Add(pnn5);
                        x += 40;
                    }
                    break;
                }
                for (int j = 0; j < 8; j++)
                {
                    _3D_Model pnn1 = new _3D_Model();
                    pnn1.cam = cam;
                    CreateCube(pnn1, 0, 0, 0, Color.Blue);
                    Transformation.Scale(pnn1.L_3D_Pts, 0.2f, 0.2f, 0.2f);
                    Transformation.TranslateX(pnn1.L_3D_Pts, x);
                    Transformation.TranslateY(pnn1.L_3D_Pts, y);
                    //Transformation.TranslateZ(pnn.L_3D_Pts, zmove);
                    if(i == 0 && j == 3)
                    {
                        Parmetric_Model pnn8 = new Parmetric_Model();
                        pnn8.cam = cam;
                        pnn8.Design(xv , yv, zv);
                        cones.Add(pnn8);
                        xv += 40;
                    }
                    if (i == 0 && j == 6)
                    {
                        xv += 40;
                        Parmetric_Model pnn8 = new Parmetric_Model();
                        pnn8.cam = cam;
                        pnn8.Design(xv, yv, zv);
                        cones.Add(pnn8);
                    }
                    if (i == 1 && j == 3)
                    {
                        xv += 80;
                        Parmetric_Model pnn8 = new Parmetric_Model();
                        pnn8.cam = cam;
                        pnn8.Design(xv, yv, zv);
                        cones.Add(pnn8);
                    }
                    if (i == 1 && j == 6)
                    {
                        xv += 80;
                        Parmetric_Model pnn8 = new Parmetric_Model();
                        pnn8.cam = cam;
                        pnn8.Design(xv, yv, zv);
                        cones.Add(pnn8);
                    }
                    if (i == 2 && j == 3)
                    {
                        yv += 80;
                        Parmetric_Model pnn8 = new Parmetric_Model();
                        pnn8.cam = cam;
                        pnn8.Design(xv, yv, zv);
                        cones.Add(pnn8);
                    }
                    if (i == 2 && j == 6)
                    {
                        yv += 0;
                        xv -= 80;
                        Parmetric_Model pnn8 = new Parmetric_Model();
                        pnn8.cam = cam;
                        pnn8.Design(xv, yv, zv);
                        cones.Add(pnn8);  
                    }
                    if (i == 3 && j == 3)
                    {
                        yv += 0;
                        xv -= 80;
                        Parmetric_Model pnn8 = new Parmetric_Model();
                        pnn8.cam = cam;
                        pnn8.Design(xv, yv, zv);
                        cones.Add(pnn8);
                    }
                    if (i == 3 && j == 6)
                    {
                        yv += 0;
                        xv -= 80;
                        Parmetric_Model pnn8 = new Parmetric_Model();
                        pnn8.cam = cam;
                        pnn8.Design(xv, yv, zv);
                        cones.Add(pnn8);
                    }
                    if (i == 3 && j == 6)
                    {
                        yv += 40;
                        xv += 40;
                        Parmetric_Model pnn8 = new Parmetric_Model();
                        pnn8.cam = cam;
                        pnn8.Design(xv, yv, zv);
                        cones.Add(pnn8);
                    }
                    if (i == 4 && j == 3)
                    {
                        yv += 40;
                        xv += 120;
                        Parmetric_Model pnn8 = new Parmetric_Model();
                        pnn8.cam = cam;
                        pnn8.Design(xv, yv, zv);
                        cones.Add(pnn8);
                    }
                    if (i == 4 && j == 6)
                    {
                        yv -= 40;
                        xv += 40;
                        Parmetric_Model pnn8 = new Parmetric_Model();
                        pnn8.cam = cam;
                        pnn8.Design(xv, yv, zv);
                        cones.Add(pnn8);
                    }
                    plat.Add(pnn1);
                    x += 40;
                }
                //plat.Add(pnn);
                
            }
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubble(e.Graphics);
        }

        void DrawScene(Graphics g)
        {
            g.Clear(Color.White);

           // Cone.DrawYourSelf(g);
            //Cone1.DrawYourSelf(g);
            //Cube.DrawYourSelf(g);
            Cube1.DrawYourSelf(g);
            //Cube2.DrawYourSelf(g);

            for (int i = 0; i < plat.Count; i++)
            {
                plat[i].DrawYourSelf(g);
            }
            for (int i = 0; i < cones.Count; i++)
            {
                cones[i].DrawYourSelf(g);
            }
        }

        void DrawDubble(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }
    }
}
