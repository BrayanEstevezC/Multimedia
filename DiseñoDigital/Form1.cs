using OpenTK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace DiseñoDigital
{
    public partial class View : Form
    {
        private Size originalSize;
        private string Ruta = "";
        private double currentPosition = 0;
        private GLControl glControl;
        private float angle = 0.0f;

        public View()
        {
            InitializeComponent();
            this.MinimumSize = this.MaximumSize = this.Size;
            originalSize = YT.Size;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Reproductor.uiMode = "none";
            panelDibujo.Paint += new PaintEventHandler(panelDibujo_Paint);

            // Crear un nuevo control GLControl
            glControl = new GLControl();
            glControl.Dock = DockStyle.Fill;

            // Agregar el control GLControl al formulario
            this.Controls.Add(glControl);

            // Manejar el evento Load del formulario
            this.Load += Form1_Load;
        }

       

        //**********************************************************************************
        //                                  MENU
        //**********************************************************************************

        //EFECTO HOVER
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            int newSizeWidth = (int)(originalSize.Width * 1.1);
            int newSizeHeight = (int)(originalSize.Height * 1.1);
            YT.Size = new Size(newSizeWidth, newSizeHeight);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            YT.Size = originalSize;
        }

        private void SP_MouseEnter(object sender, EventArgs e)
        {
            int newSizeWidth = (int)(originalSize.Width * 1.1);
            int newSizeHeight = (int)(originalSize.Height * 1.1);
            SP.Size = new Size(newSizeWidth, newSizeHeight);
        }

        private void SP_MouseLeave(object sender, EventArgs e)
        {

            SP.Size = originalSize;
        }

        private void FG_MouseEnter(object sender, EventArgs e)
        {

            int newSizeWidth = (int)(originalSize.Width * 1.1);
            int newSizeHeight = (int)(originalSize.Height * 1.1);
            FIGURE.Size = new Size(newSizeWidth, newSizeHeight);
        }

        private void FG_MouseLeave(object sender, EventArgs e)
        {

            FIGURE.Size = originalSize;
        }

        //MUESTRA O OCULTA LOS ELEMENTOS EN LA VISTA
        private void YT_Click(object sender, EventArgs e)
        {
            YT.Visible = false;
            SP.Visible = false;
            FIGURE.Visible = false;
            Home.Visible = true;
            pReproductor2.Visible = true;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            YT.Visible = true;
            SP.Visible = true;
            FIGURE.Visible = true;
            Home.Visible = false;
            pReproductor2.Visible = false;
            Reproductor.Ctlcontrols.stop();
            panelDibujo.Visible = false;
        }

        private void SP_Click(object sender, EventArgs e)
        {
            YT.Visible = false;
            SP.Visible = false;
            FIGURE.Visible = false;
            Home.Visible = true;
            pReproductor2.Visible = true;


        }

        private void FIGURE_Click(object sender, EventArgs e)
        {
            YT.Visible = false;
            SP.Visible = false;
            FIGURE.Visible = false;
            Home.Visible = true;
            panelDibujo.Visible = true;

        }

        private void Cubo_Click(object sender, EventArgs e)
        {
            YT.Visible = false;
            SP.Visible = false;
            FIGURE.Visible = false;
            Home.Visible = true;
        }

        //**********************************************************************************
        //                          REPRODUCTOR
        //**********************************************************************************

        //VERIFICA SI LA POCICION ES DIFERENTE A 0, SI ES DIFERENTE RENUDA LA REPRODUCION EN LA POSICION ACTUAL
        
        //SUBE LOS ARCHIVOS AL REPRODUCTOR
        private void Files_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Ruta = openFileDialog1.FileName;
                lblRut.Text = Ruta;
            }

        }
        //PLAY E IDENTIFICA LA POSICION EN LA QUE SE QUEDO EL REPRODUCTOR

        private void Play_Click(object sender, EventArgs e)
        {
            Reproductor.URL = Ruta;
            if (currentPosition != 0)
            {
                Reproductor.Ctlcontrols.currentPosition = currentPosition;
            }
            Reproductor.Ctlcontrols.play();
        }

        //PAUSA Y OPTIENE LA POSICION EN LA QUE SE QUEDO EL REPRODUCTOR
        private void Pause_Click(object sender, EventArgs e)
        {
            currentPosition = Reproductor.Ctlcontrols.currentPosition;
            Reproductor.Ctlcontrols.pause();
        }
        //DETIENE LA CANCION/VIDEO
        private void Stop_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();

        }

        //**********************************************************************************
        //                         DIBUJO
        //**********************************************************************************
        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Dibuja un cuadrado
            Pen penCuadrado = new Pen(Color.Orange, 3);
            Rectangle cuadrado = new Rectangle(150, 250, 100, 100);
            g.DrawRectangle(penCuadrado, cuadrado);
            penCuadrado.Dispose();

            // Dibuja un rectángulo
            Pen penRectangulo = new Pen(Color.Blue, 3); //Crea un lápiz azul con grosor 3
            Rectangle rectangulo = new Rectangle(50, 50, 100, 50);// Define el rectángulo en (50, 50) con dimensiones 100x50
            g.DrawRectangle(penRectangulo, rectangulo);// Dibuja el rectángulo
            penRectangulo.Dispose();// Libera los recursos del lápiz

            // Dibuja un círculo
            Pen penCirculo = new Pen(Color.Red, 3);
            Rectangle circulo = new Rectangle(200, 50, 100, 100);
            g.DrawEllipse(penCirculo, circulo);
            penCirculo.Dispose();

            // Dibuja un triángulo
            Pen penTriangulo = new Pen(Color.Purple, 3);
            Point[] puntosTriangulo = new Point[] {
                new Point(350, 200),
                new Point(400, 300),
                new Point(300, 300)
            };// Define los puntos del triángulo
            g.DrawPolygon(penTriangulo, puntosTriangulo);
            penTriangulo.Dispose();

            // Define los vértices del polígono
            Point[] puntosPoligono = new Point[] {
                new Point(500, 150),
                new Point(600, 200),
                new Point(550, 300),
                new Point(450, 300),
                new Point(400, 200)
            };

            // Dibuja el polígono
            Pen penPoligono = new Pen(Color.Green, 3);
            g.DrawPolygon(penPoligono, puntosPoligono);
            penPoligono.Dispose();
        }

        //**********************************************************************************
        //                          FIGURAS 3D
        //**********************************************************************************

        private void Form1_Load(object sender, EventArgs e)
        {
            // Manejar el evento Paint del control GLControl
            glControl.Paint += GlControl_Paint;

            // Inicializar OpenGL
            glControl.MakeCurrent();
            GL.ClearColor(Color.Black);

            // Iniciar el temporizador de animación
            Timer timer = new Timer();
            timer.Interval = 16; // Aproximadamente 60 fps
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void GlControl_Paint(object sender, PaintEventArgs e)
        {
            // Limpiar el buffer de color y el buffer de profundidad
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // Configurar la proyección de perspectiva
            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, (float)glControl.Width / (float)glControl.Height, 0.1f, 10.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);

            // Configurar la matriz del modelo-vista (posición de la cámara)
            Matrix4 lookat = Matrix4.LookAt(new Vector3(2, 2, 2), Vector3.Zero, Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);

            // Aplicar rotación al cilindro
            GL.Rotate(angle, Vector3.UnitY);

            // Dibujar el cilindro
            DrawCylinder();

            // Aplicar una traslación para separar la pirámide del cilindro
            GL.Translate(0.0f, 0.0f, -2.0f);

            // Dibujar la pirámide
            DrawPyramid();

            // Aplicar una nueva traslación para colocar el cubo en la otra cara plana del cilindro
            GL.Translate(0.0f, 0.0f, 4.0f);

            // Dibujar el cubo
            DrawCube();

            // Intercambiar los buffers
            glControl.SwapBuffers();
        }



        private void DrawCube()
        {
            // Dibujar un cubo
            GL.Begin(PrimitiveType.Quads);

            // Cara frontal
            GL.Color3(Color.Red);
            GL.Vertex3(-0.5f, -0.5f, 0.5f);
            GL.Vertex3(0.5f, -0.5f, 0.5f);
            GL.Vertex3(0.5f, 0.5f, 0.5f);
            GL.Vertex3(-0.5f, 0.5f, 0.5f);

            // Cara trasera
            GL.Color3(Color.Blue);
            GL.Vertex3(-0.5f, -0.5f, -0.5f);
            GL.Vertex3(-0.5f, 0.5f, -0.5f);
            GL.Vertex3(0.5f, 0.5f, -0.5f);
            GL.Vertex3(0.5f, -0.5f, -0.5f);

            // Cara superior
            GL.Color3(Color.Green);
            GL.Vertex3(-0.5f, 0.5f, 0.5f);
            GL.Vertex3(0.5f, 0.5f, 0.5f);
            GL.Vertex3(0.5f, 0.5f, -0.5f);
            GL.Vertex3(-0.5f, 0.5f, -0.5f);

            // Cara inferior
            GL.Color3(Color.Yellow);
            GL.Vertex3(-0.5f, -0.5f, 0.5f);
            GL.Vertex3(-0.5f, -0.5f, -0.5f);
            GL.Vertex3(0.5f, -0.5f, -0.5f);
            GL.Vertex3(0.5f, -0.5f, 0.5f);

            // Cara izquierda
            GL.Color3(Color.Cyan);
            GL.Vertex3(-0.5f, -0.5f, 0.5f);
            GL.Vertex3(-0.5f, 0.5f, 0.5f);
            GL.Vertex3(-0.5f, 0.5f, -0.5f);
            GL.Vertex3(-0.5f, -0.5f, -0.5f);

            // Cara derecha
            GL.Color3(Color.Magenta);
            GL.Vertex3(0.5f, -0.5f, 0.5f);
            GL.Vertex3(0.5f, -0.5f, -0.5f);
            GL.Vertex3(0.5f, 0.5f, -0.5f);
            GL.Vertex3(0.5f, 0.5f, 0.5f);

            GL.End();
        }

        private void DrawCylinder()
        {
            // Número de lados del cilindro (cuantos más lados, más suave será el cilindro)
            int sides = 20;
            float radius = 0.5f;
            float height = 1.0f;

            // Dibujar la parte lateral del cilindro
            GL.Begin(PrimitiveType.QuadStrip);
            for (int i = 0; i <= sides; i++)
            {
                float angle = (float)i / (float)sides * 2.0f * (float)Math.PI;
                float x = (float)Math.Cos(angle) * radius;
                float y = (float)Math.Sin(angle) * radius;

                GL.Color3(Color.Green);
                GL.Vertex3(x, y, 0.5f);
                GL.Vertex3(x, y, -0.5f);
            }
            GL.End();

            // Dibujar las tapas del cilindro
            GL.Begin(PrimitiveType.TriangleFan);

            GL.Color3(Color.Blue); // Color de la tapa superior
            GL.Vertex3(0.0f, 0.0f, 0.5f); // Centro de la tapa superior
            for (int i = 0; i <= sides; i++)
            {
                float angle = (float)i / (float)sides * 2.0f * (float)Math.PI;
                float x = (float)Math.Cos(angle) * radius;
                float y = (float)Math.Sin(angle) * radius;
                GL.Vertex3(x, y, 0.5f); // Puntos en la tapa superior
            }

            GL.End();

            GL.Begin(PrimitiveType.TriangleFan);

            GL.Color3(Color.Red); // Color de la tapa inferior
            GL.Vertex3(0.0f, 0.0f, -0.5f); // Centro de la tapa inferior
            for (int i = 0; i <= sides; i++)
            {
                float angle = (float)i / (float)sides * 2.0f * (float)Math.PI;
                float x = (float)Math.Cos(angle) * radius;
                float y = (float)Math.Sin(angle) * radius;
                GL.Vertex3(x, y, -0.5f); // Puntos en la tapa inferior
            }

            GL.End();
        }

        private void DrawPyramid()
        {
            GL.Begin(PrimitiveType.Triangles);

            // Base de la pirámide
            GL.Color3(Color.Yellow);
            GL.Vertex3(0.0f, -0.5f, 0.0f);
            GL.Vertex3(0.5f, -0.5f, -0.5f);
            GL.Vertex3(-0.5f, -0.5f, -0.5f);

            // Caras de la pirámide
            GL.Color3(Color.Red);
            GL.Vertex3(0.0f, -0.5f, 0.0f);
            GL.Vertex3(0.5f, -0.5f, -0.5f);
            GL.Vertex3(0.0f, 0.5f, 0.0f);

            GL.Color3(Color.Green);
            GL.Vertex3(0.0f, -0.5f, 0.0f);
            GL.Vertex3(-0.5f, -0.5f, -0.5f);
            GL.Vertex3(0.0f, 0.5f, 0.0f);

            GL.Color3(Color.Blue);
            GL.Vertex3(-0.5f, -0.5f, -0.5f);
            GL.Vertex3(0.5f, -0.5f, -0.5f);
            GL.Vertex3(0.0f, 0.5f, 0.0f);

            GL.End();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualizar el ángulo de rotación
            angle -= 1.0f; // Cambiar la dirección de rotación a negativa
            if (angle <= 0.0f)
                angle += 360.0f;

            // Volver a dibujar el control GL
            glControl.Invalidate();
        }
    }
}