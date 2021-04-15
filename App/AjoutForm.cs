using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App
{
    public partial class AjoutForm : Form
    {
        string _coverPath;
        bool _validation;

        public AjoutForm()
        {
            InitializeComponent();
        }

        public string Nom
        {
            get { return txtName.Text; }
        }

        public string Author
        {
            get { return txtAuthor.Text; }
        }

        public string Categorie
        {
            get { return txtCategorie.Text; }
        }

        public string Serie
        {
            get { return txtSerie.Text; }
        }

        public string Genre
        {
            get { return txtGenre.Text; }
        }

        public string Cover
        {
            get { if (Path.GetFileName(_coverPath) != null) return Path.GetFileName(_coverPath); else return ""; }
        }

        public string Editeur
        {
            get { return txtEditeur.Text; }
        }

        private void btnAjoutImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Recuperation du chemin d'acces
                _coverPath = openFileDialog.FileName;

                //Copie du file dans img si un fichier du meme nom existe celui-ci est renommé avec la date + heure de la copie
                try
                {
                    File.Copy(_coverPath, "..\\..\\..\\img\\" + Path.GetFileName(_coverPath), false);
                    picCover.ImageLocation = "..\\..\\..\\img\\" + Path.GetFileName(_coverPath);
                }
                catch(IOException copyError)
                {
                    string s = "..\\..\\..\\img\\" + Path.GetFileNameWithoutExtension(_coverPath) + DateTime.Now.ToString("yyMMddhhmmssfff") + Path.GetExtension(_coverPath);
                    File.Copy(_coverPath, s, false);
                    picCover.ImageLocation = s;
                    _coverPath = Path.GetFileName(s);
                }

                //Affichage
                picCover.SizeMode = PictureBoxSizeMode.StretchImage;
                
            }
        }

        private void AjoutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Permet de vérifier la saisie de l'utilisateur une fois qu'il a validé
            if (_validation)
            {
                if (Nom == "" || Author == "")
                {
                    MessageBox.Show("Erreur de saisie !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // On annule la fermeture
                    e.Cancel = true;
                }
            }
            
            _validation = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            _validation = true;
        }
    }
}
