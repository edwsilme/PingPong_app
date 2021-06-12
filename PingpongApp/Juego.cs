using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PingpongApp
{
    public partial class Juego : Form
    {

        public Juego()
        {
            InitializeComponent();
        }

        int vBall = 10;
        int cont = 0;
        int score = 0;

        bool up;
        bool izq;

        private void Juego_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void timerJuego_Tick(object sender, EventArgs e)
        {
            if (imgBall.Left > imgRacket.Left)
            {
                timerJuego.Enabled = false;
                MessageBox.Show("Puntaje: " + score.ToString() + " veces!");
                score = 0;
                vBall = 10;
                cont = 0;
            }

            /** Rebote de la pelota **/
            if (imgBall.Left + imgBall.Width >= imgRacket.Left && /** Verifica que esté dentro del rango izquierda a derecha de la raqueta **/
                imgBall.Left + imgBall.Width <= imgRacket.Left + imgRacket.Width && /** Verifica que no se pase de la posición de la raqueta **/
                imgBall.Top + imgBall.Height >= imgRacket.Top && /** Verifica que no se pase de la parte de arriba de la raqueta **/
                imgBall.Top + imgBall.Height <= imgRacket.Top + imgRacket.Height) /** Verifica que no se pase de la parte de abajo de la raqueta **/
            {
                izq = false;
                score += 1;
                this.Text = "Puntuación: " + score.ToString() + "";
                cont += 1;
                
                /** Cada 5 puntos, la velocidad sube **/
                if (cont > 5)
                {
                    vBall += 1;
                    cont = 0;
                }
            }

                #region Movimiento Pelota

                if (izq)
            {
                imgBall.Left += vBall; /** Dirección va hacia la derecha **/
            }else
            {
                imgBall.Left -= vBall; /** Dirección va hacia la izquierda **/
            }

            if (up)
            {
                imgBall.Top += vBall; /** Dirección va hacia la abajo **/
            }
            else
            {
                imgBall.Top -= vBall; /** Dirección va hacia la arriba **/
            }

            if (imgBall.Top >= this.Height -66) /** si golpea la pared de abajo **/
            {
                up = false;
            }

            if (imgBall.Top <= 0) /** si golpea la pared de arriba **/
            {
                up = true;
            }

            if (imgBall.Left <= 0) /** si golpea la pared de la izquierda **/
            {
                izq = true;
            }

           #endregion
        }

        private void Juego_MouseMove(object sender, MouseEventArgs e)
        {
            imgRacket.Top = e.Y; /** La raqueta se mueve en el eje y **/
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            this.Text = "Puntaje: 0";
            Random j = new Random(); /** La pelota aparece en posición aleatoria **/
            imgBall.Location = new Point(0, j.Next(this.Height));
            up = true;
            izq = true;
            timerJuego.Enabled = true;
            score = 0;
        }
    }
}
