using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bullfighting
{
    public partial class FormRoom : Form
    {
        private float score = -15;

        public FormRoom()
        {
            InitializeComponent();
        }
        private void buttonTouch_Click(object sender, EventArgs e)
        {
            LocationMove(labelBird, 0, -3);
        }

        private void timerFixedUpdate_Tick(object sender, EventArgs e)
        {
            LocationMove(labelBird, 0, 1);
            foreach (var plane in planes)
                LocationMove(plane, -2, 0);
            score += 0.1f;
            labelScore.Text = score.ToString("F0") + " M";
            DestoryPlane();

            var tbl = CollisionHandler(labelBird, linkLabelTop);
            var bbl = CollisionHandler(labelBird, linkLabelBottom);
            if (bbl || tbl)
                GameOver();

        }

        private void timerTransmitter_Tick(object sender, EventArgs e)
        {
            CreatePlane();
            timerTransmitter.Interval -= 1;
        }

        private void LocationMove(Control ctl, int x, int y) {
            var bl = ctl.Location;
            bl.Offset(x, y);
            ctl.Location = bl;
        }

        private List<Control> planes = new List<Control>();

        #region Bhvr
        private void CreatePlane()
        {
            var plane = new System.Windows.Forms.Label();
            planes.Add(plane);
            plane.AutoSize = true;
            plane.BackColor = System.Drawing.Color.Red;
            Random rdm = new Random();
            var y1 = rdm.Next(linkLabelTop.Location.Y, linkLabelBottom.Location.Y);
            var y2 = rdm.Next(linkLabelTop.Location.Y, linkLabelBottom.Location.Y);
            var bl = rdm.Next(2);
            var y = bl == 1 ? y1 : y2;
            plane.Location = new System.Drawing.Point(552, y);
            plane.Name = "labelPlane";
            plane.Size = new System.Drawing.Size(29, 12);
            plane.TabIndex = 2;
            plane.Text = "飞机";

            Controls.Add(plane);
        }
        private void DestoryPlane()
        {
            for (int i = 0; i < planes.Count; i++)
            {
                var item = planes[i];
                if (item.Location.X < 0)
                {
                    planes.Remove(item);
                    Controls.Remove(item);
                }

                var bl = CollisionHandler(labelBird, item);
                if (bl)
                {
                    GameOver();
                    break;
                }
            }
        }

        private bool CollisionHandler(Control ctl1, Control ctl2) {
            var r1 = ctl1.RectangleToScreen(ctl1.ClientRectangle);
            var r2 = ctl2.RectangleToScreen(ctl2.ClientRectangle);
            if (r1.IntersectsWith(r2)) {
                return true;
            }
            return false;
        }

        void GameOver() {
            timerFixedUpdate.Stop();
            timerTransmitter.Stop();
            MessageBox.Show(string.Format("游戏结束 \n 你跑了{0}米！", score.ToString("F0")));
            Close();
        }
        #endregion
    }
}
