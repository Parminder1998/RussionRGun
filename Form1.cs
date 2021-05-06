using RUSSIONRGun.GameEngine;
using RUSSIONRGun.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUSSIONRGun
{
    public partial class Form1 : Form
    {

        Bullets Bullets;
        SoundPlayer player;
        int chance, Bulletposition, angle;
        Random random;
        Timer timer;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text.Contains("Start"))
            {
                buttonStart.Text = "End Game";
                lblMsg.Text = "Click To Load the Bullet...";
                chance = 3;
                Bullets = new Bullets();
                pictureProcess.Visible = true;

                buttonLoad.Enabled = true;
            }
            else
            {
                MessageBox.Show("Quit The Game...?", "Alert");
                this.Close();
            }
        }

        private async void buttonSpin_Click(object sender, EventArgs e)
        {

            buttonSpin.Enabled = false;
            lblMsg.Text = "Spinning the Chamber...";
            Bullets.Spin();
            angle = 0;
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start();
           await Task.Delay(2500);
            timer.Stop();

            buttonPress.Enabled = true;
            ChangePicture(pictureProcess, Resources.gunwithoutfire);
            lblMsg.Text = "Click Press Trigger to Fire Bullet...";
         
            Bulletposition = 0;
        }

        private void ChangePicture(PictureBox pictureBox, Bitmap image)
        {
            pictureBox.Image = image;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            angle += 20;
            if (angle == 360)
            {
                angle = 0;
            }
            Image image = new Bitmap(Resources.withbullet);
            //Store our old image so we can delete it
            Image oldImage = pictureProcess.Image;
            pictureProcess.Image = GameUtility.RotateBulletChamberImage(image, new Point(), angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }

        private void buttonPress_Click(object sender, EventArgs e)
        {
            player = new System.Media.SoundPlayer();
            if (Bullets.FireBullet(Bulletposition))
            {
                player.Stream = Resources.GunShot;
                player.Play();
              //  ChangePicture(pictureProcess, Resources.gunwithfire);
                //ChangePicture(pictureResult, Resources.dead);
                //await Task.Delay(900);
                //lblRemaining.Text = "You are Dead!!!";
                MessageBox.Show("You Loose...", "Alert");
                this.Close();
                return;
            }
            else
            {
                player.Stream = Resources.Empty;
                player.Play();
               // await Task.Delay(900);
            }
            Bulletposition++;
            chance--;
            if (chance == 0)
            {
               // lblRemaining.Text = "Thank God! You Are Lucky! You Survived!!!";
                //ChangePicture(pictureResult, Resources.lucky);
                //await Task.Delay(400);
                MessageBox.Show("You Made it!! You Won The Game!!!", "Congratulations");
                this.Close();
            }
            else
            {
               // lblRemaining.Text = "Remaining Chance: " + chance;
            }
        }

        private async void buttonLoad_Click(object sender, EventArgs e)
        {

            buttonLoad.Enabled = false;
            Bulletposition = random.Next(0, 6);

            player = new System.Media.SoundPlayer();
            player.Stream = Resources.LoadBUllet;
            player.Play();

            lblMsg.Text = "Loading The Bullet at : " + (Bulletposition + 1);
            Bullets.LoadBullet(Bulletposition);
            await Task.Delay(800);
            int angle = (Bulletposition + 1) * 30;
            Image image = new Bitmap(Resources.withbullet);
            //Store our old image so we can delete it
            Image oldImage = pictureProcess.Image;
            //Pass in our original image and return a new image rotated 35 degrees right
            pictureProcess.Image = GameUtility.RotateBulletChamberImage(image, new Point(), angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
            lblMsg.Text = "Click to Spin it...";
            buttonSpin.Enabled = true;
        }

        private void pictureProcess_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            buttonLoad.Enabled = buttonPress.Enabled = buttonSpin.Enabled = false;
            random = new Random();
            pictureProcess.Visible = false;
        }

        private async Task buttonLoad_ClickAsync(object sender, EventArgs e)
        {

            buttonLoad.Enabled = false;
            Bulletposition = random.Next(0, 6);

            player = new System.Media.SoundPlayer();
            player.Stream = Resources.LoadBUllet;
            player.Play();

            lblMsg.Text = "Loading The Bullet at : " + (Bulletposition + 1);
            Bullets.LoadBullet(Bulletposition);
            await Task.Delay(800);
            int angle = (Bulletposition + 1) * 30;
            Image image = new Bitmap(Resources.withbullet);
            //Store our old image so we can delete it
            Image oldImage = pictureProcess.Image;
            //Pass in our original image and return a new image rotated 35 degrees right
            pictureProcess.Image = GameUtility.RotateBulletChamberImage(image, new Point(), angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
            lblMsg.Text = "Click to Spin it...";
            buttonSpin.Enabled = true;
        }
    }
}
