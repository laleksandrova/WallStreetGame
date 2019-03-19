using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WallStreetGame
{
    public class PlayerManager
    {
        public static string currentPlayerUsername;

        #region PlayerRegister
        public void PlayerRegister(string fullName, string userName, string password, decimal money, string sex, byte[] image)
        {
            using (var db = new PlayerEntities())
            {
                var query = db.Players.Where(p => p.Username == userName);

                // if there aren't players with that username Any allows register
                if (!query.Any())
                {
                    var player = new Player
                    {
                        FullName = fullName,
                        Username = userName,
                        Password = password,
                        Money = money,
                        Sex = sex,
                        Image = image
                    };

                    db.Players.Add(player);
                    db.SaveChanges();
                }
                else MessageBox.Show("This username is taken, choose another one!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region PlayerLogin
        public IQueryable<Player> PlayerLogin(string userName, string password)
        {
            using (var db = new PlayerEntities())
            {
                var query = db.Players.Where(p => p.Username == userName && p.Password == password);

                if (!query.Any()) return null;
                else
                {
                    currentPlayerUsername = userName;
                    return query;
                }
            }
        }
        #endregion

        #region PlayerPasswordChange
        public void PlayerPasswordChange(string password)
        {
            using (var db = new PlayerEntities())
            {
                Player player = db.Players.SingleOrDefault(p => p.Username == currentPlayerUsername);
                player.Password = password;
                db.SaveChanges();
            }
        }
        #endregion

        #region PlayerDeleteAccount
        public void PlayerDeleteAccount()
        {
            using (var db = new PlayerEntities())
            {
                Player player = db.Players.SingleOrDefault(p => p.Username == currentPlayerUsername);
                db.Players.Remove(player);
                db.SaveChanges();
            }
        }
        #endregion

        #region GetCurrentPlayer
        public Player GetCurrentPlayer()
        {
            using (var db = new PlayerEntities())
            {
                Player player = db.Players.SingleOrDefault(p => p.Username == currentPlayerUsername);
                return player;
            }
        }
        #endregion

        #region ConvertImageToByte
        public byte[] ConvertImageToByte(string path)
        {
            byte[] image = null;
            var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            var br = new BinaryReader(fs);
            image = br.ReadBytes((int)fs.Length);
            return image;
        }
        #endregion

        #region ConvertByteToImage
        public MemoryStream ConvertByteToImage()
        {
            using (var db = new PlayerEntities())
            {
                var player = db.Players.SingleOrDefault(p => p.Username == currentPlayerUsername);
                byte[] image = player.Image;
                var ms = new MemoryStream(image);
                return ms;
            }
        }
        #endregion

        #region PlayerRestartAccount
        public void PlayerRestartAccount()
        {
            using (var db = new PlayerEntities())
            {
                Player player = db.Players.SingleOrDefault(p => p.Username == currentPlayerUsername);
                player.Money = 0;
                player.Gold = 0;
                player.Petrol = 0;
                player.Bitcoin = 0;
                player.Antiques = 0;
                player.Shares = 0;
                player.Technologies = 0;
                db.SaveChanges();
            }
        }
        #endregion

        #region PlayerImageChange
        public void PlayerImageChange(PictureBox pictureBox)
        {
            using (var db = new PlayerEntities())
            {
                var player = db.Players.SingleOrDefault(p => p.Username == currentPlayerUsername);
                using (var dialog = new OpenFileDialog() { Filter = "PNG|*.png|JPG|*.jpg|GIF|*.gif", Title = "Please select a photo", Multiselect = false })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox.ImageLocation = dialog.FileName;
                        string imagePath = pictureBox.ImageLocation;
                        byte[] image = ConvertImageToByte(imagePath);
                        player.Image = image;
                        db.SaveChanges();
                    }
                }
            }
        }
        #endregion

        #region PlayerMoney
        public void PlayerMoney(decimal money, decimal loan)
        {
            using (var db = new PlayerEntities())
            {
                var player = db.Players.SingleOrDefault(p => p.Username == currentPlayerUsername);
                player.Money = money;
                player.Loan = loan;
                db.SaveChanges();
            }
        }
        #endregion

    }
}


