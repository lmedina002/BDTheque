using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using DAL;

namespace App
{
    public partial class ConnectionForm : Form
    {
        private IUtilisateurRepository _utilisateurRepository;
        public ConnectionForm(IUtilisateurRepository utilisateurRepository)
        {            
            InitializeComponent();
            _utilisateurRepository = utilisateurRepository;
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConnection_Click(object sender, EventArgs e)
        {            
            IList<Utilisateur> listUtilisateurs = _utilisateurRepository.GetAll();
            Utilisateur utilisateurConnecte = new Utilisateur();
            bool identification = false;
            foreach (Utilisateur utilisateur in listUtilisateurs)
            {
                if (utilisateur.Login == txtLogin.Text && utilisateur.Mdp == txtMdp.Text)
                {
                    identification = true;
                    utilisateurConnecte = utilisateur;
                }


            }

            if (identification)
            {
                //Ouvrir le main form
                MainForm main = new MainForm(utilisateurConnecte);
                this.Visible = false; //On cache le formulaire de connexion
                main.ShowDialog(); //Affichage du main en modal pour bloquer tant que le form est ouvert
                this.Close(); //Fermeture de l'application

            }
            else
            {
                //Message erreur
                MessageBox.Show("Identifiants incorrects !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
