using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Slots_Game
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPull_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBet.Text) || !int.TryParse(txtBet.Text, out _))
            {
                lblCherryCount.Text = "Enter a valid integer please";
                return;
            }

            RandomizeImages();
        }
        private void RandomizeImages()
        {
            var cherryImage = "~/Images/cherry.jpg";
            var horseshoeImage = "~/Images/horseshoe.jpg";
            var shamrockImage = "~/Images/shamrock.jpg";

            string[] imageUrls = new string[]
            {
                cherryImage,
                horseshoeImage,
                shamrockImage
            };

            Random random = new Random();
            var selectedImage1 = imageUrls[random.Next(imageUrls.Length)];
            var selectedImage2 = imageUrls[random.Next(imageUrls.Length)];
            var selectedImage3 = imageUrls[random.Next(imageUrls.Length)];

            Image1.ImageUrl = selectedImage1;
            Image2.ImageUrl = selectedImage2;
            Image3.ImageUrl = selectedImage3;

            int cherryCount = 0;
            if (selectedImage1 == cherryImage)
            {
                cherryCount++;
            }
            if (selectedImage2 == cherryImage)
            {
                cherryCount++;
            }
            if (selectedImage3 == cherryImage)
            {
                cherryCount++;
            }

            lblCherryCount.Text = $"{cherryCount} Cherry";

            int horseShoeCount = 0;
            if (selectedImage1 == horseshoeImage)
            {
                horseShoeCount++;
            }
            if (selectedImage2 == horseshoeImage)
            {
                horseShoeCount++;
            }
            if (selectedImage3 == horseshoeImage)
            {
                horseShoeCount++;
            }

            if (int.TryParse(txtBet.Text, out int betAmount))
            {
                if (cherryCount == 0)
                {
                    lblMoney.Text = $"You bet ${betAmount} and lost";
                }

                if (cherryCount == 1)
                {
                    var winningOne = betAmount * 2;
                    lblMoney.Text = $"You bet ${betAmount} and won ${winningOne}";
                }
                else if (cherryCount == 2)
                {
                    var winningTwo = betAmount * 3;
                    lblMoney.Text = $"You bet ${betAmount} and won ${winningTwo}";
                }
                else if (cherryCount == 3)
                {
                    var winningThree = betAmount * 4;
                    lblMoney.Text = $"You bet ${betAmount} and won ${winningThree}";
                }
                else if (horseShoeCount == 3)
                {
                    var jackpot = betAmount * 100;
                    lblMoney.Text = $"You won the jackpot!! You bet ${betAmount} and won ${jackpot}";
                }
            }
        }

    }
}