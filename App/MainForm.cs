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
using System.IO;

namespace App
{
    public partial class MainForm : Form
    {
        IAlbumRepository _albumRepository;
        IUtilisateurRepository _utilisateurRepository;
        Utilisateur utilisateurConnecte;
        bool retour = false;

        public MainForm(Utilisateur utilisateur)
        {
            _albumRepository = new AlbumRepository();
            _utilisateurRepository = new UtilisateurRepository();
            utilisateurConnecte = utilisateur;


            InitializeComponent();
            AffichageListes();

            cmbCritere.Items.AddRange(new string[] { "Tout", "Nom", "Auteur", "Série", "Editeur", "Categorie", "Genre" });
            cmbCritere.SelectedIndex = 0;

            radNom.Select();
            tabListes.SelectedTab = tabPossede;
            if (libPossede.Items.Count > 0)
                FillTxtBox(libPossede);
            btnAjoutCollection.Visible = false;
            btnAjoutSouhait.Visible = false;
            btnRetraitCollection.Visible = true;
            btnRetraitSouhait.Visible = false;


            if (utilisateur.Admin)
                grbAdministrateur.Visible = true;
            else
                grbAdministrateur.Visible = false;
        }

        private void AffichageListes()
        {
            libCatalogue.DataSource = null;
            libCatalogue.DataSource = _albumRepository.GetAll().OrderBy(element => element.Nom).ToList<Album>();
            if (libCatalogue.Items.Count > 0)
                libCatalogue.SelectedIndex = 0;

            libPossede.DataSource = null;
            libPossede.DataSource = utilisateurConnecte.ListeAlbumPossede.OrderBy(element => element.Nom).ToList<Album>(); ;
            if (libPossede.Items.Count > 0)
                libPossede.SelectedIndex = 0;

            libSouhait.DataSource = null;
            libSouhait.DataSource = utilisateurConnecte.ListeSouhait.OrderBy(element => element.Nom).ToList<Album>(); ;
            if (libSouhait.Items.Count > 0)
                libSouhait.SelectedIndex = 0;
        }

        private void AffichageListesSansSelected()
        {
            //On enleve l'evenement SelectedIndex du handler pour que la changement de DataSource ne le declenche pas
            this.libCatalogue.SelectedIndexChanged -= new EventHandler(lib_SelectedIndexChanged);
            libCatalogue.DataSource = null;
            libCatalogue.DataSource = _albumRepository.GetAll();
            this.libCatalogue.SelectedIndexChanged += new EventHandler(lib_SelectedIndexChanged);

            this.libPossede.SelectedIndexChanged -= new EventHandler(lib_SelectedIndexChanged);
            libPossede.DataSource = null;
            libPossede.DataSource = utilisateurConnecte.ListeAlbumPossede;
            this.libPossede.SelectedIndexChanged += new EventHandler(lib_SelectedIndexChanged);

            this.libSouhait.SelectedIndexChanged -= new EventHandler(lib_SelectedIndexChanged);
            libSouhait.DataSource = null;
            libSouhait.DataSource = utilisateurConnecte.ListeSouhait;
            this.libSouhait.SelectedIndexChanged += new EventHandler(lib_SelectedIndexChanged);
        }

        private void lib_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox libSelected = libActive();
            RadioButton radSelected = getRadioButton();

            if (libSelected.SelectedItem != null && radSelected.Checked && libSelected.SelectedItem is string)
            {
                List<Album> listSorted = new List<Album>();
                string itemSelected = (string)libSelected.SelectedItem;
                listSorted = getListSorted(radSelected, itemSelected);
                libSelected.DataSource = null;
                libSelected.DataSource = listSorted;             
            }
            FillTxtBox(libActive());

        }

        private List<Album> getListSorted(RadioButton rad, string itemSelected)
        {
            List<Album> listSorted = new List<Album>();
            IList<Album> listAlbums = new List<Album>();
            ListBox libSelected = libActive();

            if (libSelected == libCatalogue)
                listAlbums = _albumRepository.GetAll();
            else if (libSelected == libPossede)
                listAlbums = utilisateurConnecte.ListeAlbumPossede;
            else
                listAlbums = utilisateurConnecte.ListeSouhait;

            if (rad == radAuteur)
            {
                foreach (Album album in listAlbums)
                {
                    if (album.Auteur == itemSelected)
                        listSorted.Add(album);
                }
            }
            else if (rad == radGenre)
            {
                foreach (Album album in listAlbums)
                {
                    if (album.Genre == itemSelected)
                        listSorted.Add(album);
                }
            }
            else if (rad == radSerie)
            {
                foreach (Album album in listAlbums)
                {
                    if (album.Serie == itemSelected)
                        listSorted.Add(album);
                }
            }
            else if (rad == radCategorie)
            {
                foreach (Album album in listAlbums)
                {
                    if (album.Categorie == itemSelected)
                        listSorted.Add(album);
                }
            }
            else if (rad == radEditeur)
            {
                foreach (Album album in listAlbums)
                {
                    if (album.Editeur == itemSelected)
                        listSorted.Add(album);
                }
            }

            return listSorted;
        }

        private void FillTxtBox(ListBox lib)
        {
            if (lib.SelectedItem != null && lib.SelectedItem is Album)
            {
                Album albumSelected = (Album)lib.SelectedItem;
                txtName.Text = albumSelected.Nom;
                txtAuthor.Text = albumSelected.Auteur;
                txtCategorie.Text = albumSelected.Categorie;
                txtSerie.Text = albumSelected.Serie;
                txtGenre.Text = albumSelected.Genre;
                txtEditeur.Text = albumSelected.Editeur;

                picCover.Visible = true;
                picCover.SizeMode = PictureBoxSizeMode.StretchImage;
                picCover.ImageLocation = "..\\..\\..\\img\\" + albumSelected.Cover;
            }
        }

        private void FillTxtBox(Album album)
        {
            txtName.Text = album.Nom;
            txtAuthor.Text = album.Auteur;
            txtCategorie.Text = album.Categorie;
            txtSerie.Text = album.Serie;
            txtGenre.Text = album.Genre;
            txtEditeur.Text = album.Editeur;

            picCover.Visible = true;
            picCover.SizeMode = PictureBoxSizeMode.StretchImage;
            picCover.ImageLocation = "..\\..\\..\\img\\" + album.Cover;
        }

        private void UnfillTxtBox()
        {
            txtName.Text = "";
            txtAuthor.Text = "";
            txtCategorie.Text = "";
            txtSerie.Text = "";
            txtGenre.Text = "";
            txtEditeur.Text = "";
            picCover.Visible = false;
        }

        private void tabListes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //On selectionne le premier element de la liste associée a l'onglet lorsque qu'on change d'onglet
            RadioButton radSelected = getRadioButton();

            if (tabListes.SelectedTab == tabCatalogue && libCatalogue.Items.Count > 0)
            {
                if (radSelected != radNom)
                {
                    radSelected.Checked = false;
                    radSelected.Checked = true;
                }

                FillTxtBox(libCatalogue);
                btnAjoutCollection.Visible = true;
                btnAjoutSouhait.Visible = true;
                btnRetraitCollection.Visible = false;
                btnRetraitSouhait.Visible = false;
            }

            if (tabListes.SelectedTab == tabPossede && libPossede.Items.Count > 0)
            {
                if (radSelected != radNom)
                {
                    radSelected.Checked = false;
                    radSelected.Checked = true;
                }

                FillTxtBox(libPossede);
                btnAjoutCollection.Visible = false;
                btnAjoutSouhait.Visible = false;
                btnRetraitCollection.Visible = true;
                btnRetraitSouhait.Visible = false;
            }

            if (tabListes.SelectedTab == tabSouhait && libSouhait.Items.Count > 0)
            {
                if (radSelected != radNom)
                {
                    radSelected.Checked = false;
                    radSelected.Checked = true;
                }

                FillTxtBox(libSouhait);
                btnAjoutCollection.Visible = true;
                btnAjoutSouhait.Visible = false;
                btnRetraitCollection.Visible = false;
                btnRetraitSouhait.Visible = true;
            }

            if (libActive().Items.Count == 0)
                libActive().DataSource = null;

        }

        private void btnAjoutCollection_Click(object sender, EventArgs e)
        {
            Album albumSelected = new Album();
            ListBox libSelected = libActive();
            if (libSelected.SelectedItem is Album)
            {
                albumSelected = (Album)libSelected.SelectedItem;
                if (utilisateurConnecte.ListeAlbumPossede.Contains(albumSelected))
                {
                    //L'utilisateur possede déja l'album
                    MessageBox.Show("Cet album se trouve déjà dans votre collection", "Déjà possédé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    utilisateurConnecte.ListeAlbumPossede.Add(albumSelected);

                    if (utilisateurConnecte.ListeSouhait.Contains(albumSelected))
                        utilisateurConnecte.ListeSouhait.Remove(albumSelected);

                    _utilisateurRepository.Save(utilisateurConnecte);
                    AffichageListes();
                }
            }
            else
                MessageBox.Show("Veuillez sélectionner un album", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void btnAjoutSouhait_Click(object sender, EventArgs e)
        {
            if (libCatalogue.SelectedItem is Album)
            {
                Album albumSelected = (Album)libCatalogue.SelectedItem;
                if (utilisateurConnecte.ListeSouhait.Contains(albumSelected))
                {
                    //L'album est déjà dans la liste de souhait
                    MessageBox.Show("Cet album se trouve déjà dans votre liste de souhait", "Déjà présent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (utilisateurConnecte.ListeAlbumPossede.Contains(albumSelected))
                {
                    //L'utilisateur possede déja l'album
                    MessageBox.Show("Cet album se trouve déjà dans votre collection", "Déjà possédé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    utilisateurConnecte.ListeSouhait.Add(albumSelected);
                    _utilisateurRepository.Save(utilisateurConnecte);
                    AffichageListes();
                }
            }
            else
                MessageBox.Show("Veuillez sélectionner un album", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnRetraitCollection_Click(object sender, EventArgs e)
        {
            if (libPossede.SelectedItem is Album)
            {
                Album albumSelected = (Album)libPossede.SelectedItem;
                utilisateurConnecte.ListeAlbumPossede.Remove(albumSelected);
                _utilisateurRepository.Save(utilisateurConnecte);
                AffichageListes();
            }
            else
                MessageBox.Show("Veuillez sélectionner un album", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRetraitSouhait_Click(object sender, EventArgs e)
        {
            if (libSouhait.SelectedItem is Album)
            {
                Album albumSelected = (Album)libSouhait.SelectedItem;
                utilisateurConnecte.ListeSouhait.Remove(albumSelected);
                _utilisateurRepository.Save(utilisateurConnecte);
                AffichageListes();
            }
            else
                MessageBox.Show("Veuillez sélectionner un album", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAjoutAlbum_Click(object sender, EventArgs e)
        {
            AjoutForm ajoutForm = new AjoutForm();
            Album newAlbum = new Album();
            if (ajoutForm.ShowDialog() == DialogResult.OK)
            {
                newAlbum.Nom = ajoutForm.Nom;
                newAlbum.Auteur = ajoutForm.Author;
                newAlbum.Categorie = ajoutForm.Categorie;
                newAlbum.Cover = ajoutForm.Cover;
                newAlbum.Serie = ajoutForm.Serie;
                newAlbum.Genre = ajoutForm.Genre;
                newAlbum.Editeur = ajoutForm.Editeur;
                _albumRepository.Save(newAlbum);
                AffichageListes();
            }
        }

        private void btnDisconnection_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private ListBox libActive()
        {
            ListBox listBoxSelected = new ListBox();

            if (tabListes.SelectedTab == tabCatalogue)
                listBoxSelected = libCatalogue;
            if (tabListes.SelectedTab == tabPossede)
                listBoxSelected = libPossede;
            if (tabListes.SelectedTab == tabSouhait)
                listBoxSelected = libSouhait;

            return listBoxSelected;
        }

        private RadioButton getRadioButton()
        {
            RadioButton radSelected = new RadioButton();
            foreach (RadioButton rad in grbClasser.Controls.OfType<RadioButton>())
            {
                if (rad.Checked)
                    radSelected = rad;
            }

            return radSelected;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            ListBox listBoxSelected = libActive();
            RadioButton radSelected = getRadioButton();
            if (radSelected.Checked && listBoxSelected.SelectedItem != null && listBoxSelected.SelectedItem is Album)
            {
                retour = true;
                radSelected.Checked = false;
                radSelected.Checked = true;
                UnfillTxtBox();
            }
            else
            {
                if(radSelected == radSerie || radSelected == radCategorie)
                    MessageBox.Show("Retour impossible, sélectionnez d'abord une "+radSelected.Text.ToLower().Remove(radSelected.Text.Length-1, 1), "Retour impossible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Retour impossible, sélectionnez d'abord un " + radSelected.Text.ToLower().Remove(radSelected.Text.Length - 1, 1), "Retour impossible", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radNom_CheckedChanged(object sender, EventArgs e)
        {
            if (radNom.Checked)
                AffichageListes();

        }

        private void radAuteur_CheckedChanged(object sender, EventArgs e)
        {
            AffichageListesSansSelected();
            List<string> listAuteurs = new List<string>();
            IList<Album> listAlbums = new List<Album>();
            ListBox listBoxSelected = new ListBox();

            if (radAuteur.Checked)
            {
                listBoxSelected = libActive();

                if (retour)
                    AffichageListes();

                listAlbums = (IList<Album>)listBoxSelected.DataSource;

                foreach (Album album in listAlbums)
                {
                    if (listAuteurs.Contains(album.Auteur) == false)
                        listAuteurs.Add(album.Auteur);
                }

                listBoxSelected.DataSource = null;
                listBoxSelected.DataSource = listAuteurs.OrderBy(element => element).ToList<string>();

                retour = false;
                UnfillTxtBox();
            }
        }

        private void radSerie_CheckedChanged(object sender, EventArgs e)
        {

            if (radSerie.Checked)
            {
                List<string> listSeries = new List<string>();
                IList<Album> listAlbums = new List<Album>(); //utilisation de Ilist pour nhibernate
                ListBox listBoxSelected = new ListBox();
                AffichageListesSansSelected();

                listBoxSelected = libActive();

                if (retour)
                    AffichageListes();

                listAlbums = (IList<Album>)listBoxSelected.DataSource;

                foreach (Album album in listAlbums)
                {
                    if (listSeries.Contains(album.Serie) == false)
                        listSeries.Add(album.Serie);
                }

                listBoxSelected.DataSource = null;
                listBoxSelected.DataSource = listSeries.OrderBy(element => element).ToList<string>(); ;

                retour = false;
                UnfillTxtBox();
            }

        }

        private void radGenre_CheckedChanged(object sender, EventArgs e)
        {

            if (radGenre.Checked)
            {
                AffichageListesSansSelected();
                List<string> listGenres = new List<string>();
                IList<Album> listAlbums = new List<Album>();
                ListBox listBoxSelected = new ListBox();

                listBoxSelected = libActive();

                if (retour)
                    AffichageListes();

                listAlbums = (IList<Album>)listBoxSelected.DataSource;

                foreach (Album album in listAlbums)
                {
                    if (listGenres.Contains(album.Genre) == false)
                        listGenres.Add(album.Genre);
                }

                listBoxSelected.DataSource = null;
                listBoxSelected.DataSource = listGenres.OrderBy(element => element).ToList<string>(); ;

                retour = false;
                UnfillTxtBox();
            }

        }

        private void radCategorie_CheckedChanged(object sender, EventArgs e)
        {

            if (radCategorie.Checked)
            {
                AffichageListesSansSelected();
                List<string> listCategories = new List<string>();
                IList<Album> listAlbums = new List<Album>();
                ListBox listBoxSelected = new ListBox();

                listBoxSelected = libActive();

                if (retour)
                    AffichageListes();

                listAlbums = (IList<Album>)listBoxSelected.DataSource;

                foreach (Album album in listAlbums)
                {
                    if (listCategories.Contains(album.Categorie) == false)
                        listCategories.Add(album.Categorie);
                }

                listBoxSelected.DataSource = null;
                listBoxSelected.DataSource = listCategories.OrderBy(element => element).ToList<string>(); ;

                retour = false;
                UnfillTxtBox();
            }

        }

        private void radEditeur_CheckedChanged(object sender, EventArgs e)
        {

            if (radEditeur.Checked)
            {
                AffichageListesSansSelected();
                List<string> listEditeurs = new List<string>();
                IList<Album> listAlbums = new List<Album>();
                ListBox listBoxSelected = new ListBox();

                listBoxSelected = libActive();

                if (retour)
                    AffichageListes();

                listAlbums = (IList<Album>)listBoxSelected.DataSource;

                foreach (Album album in listAlbums)
                {
                    if (listEditeurs.Contains(album.Editeur) == false)
                        listEditeurs.Add(album.Editeur);
                }

                listBoxSelected.DataSource = null;
                listBoxSelected.DataSource = listEditeurs.OrderBy(element => element).ToList<string>(); ;

                retour = false;
                UnfillTxtBox();
            }

        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            if (txtRecherche.Text != "")
            {
                List<(Album, string)> listResultat = new List<(Album, string)>();
                if (cmbCritere.SelectedItem.ToString() == "Tout")
                    listResultat = _albumRepository.SearchAllCriteria(txtRecherche.Text, libActive().Name, utilisateurConnecte.Id);
                else
                    listResultat = _albumRepository.SearchByOneCriteria(txtRecherche.Text, libActive().Name, utilisateurConnecte.Id, cmbCritere.SelectedItem.ToString());

                if (listResultat.Count > 0)
                {
                    ResearchForm form = new ResearchForm(listResultat);
                    if(form.ShowDialog() == DialogResult.OK)
                    {
                        string critere = form.SelectedRow.Cells[0].Value.ToString();
                        string valeur = form.SelectedRow.Cells[1].Value.ToString();

                        if(critere == "Nom")
                        {
                            AffichageListesSansSelected();
                            FillTxtBox(listResultat[int.Parse(form.SelectedRow.Cells[2].Value.ToString())].Item1);
                            libActive().SelectedItem = listResultat[int.Parse(form.SelectedRow.Cells[2].Value.ToString())].Item1;
                        }
                        if(critere == "Auteur")
                        {
                            radAuteur.Checked = false;
                            radAuteur.Checked = true;

                            this.libActive().SelectedIndexChanged -= new EventHandler(lib_SelectedIndexChanged);
                            libActive().SelectedItem = listResultat[int.Parse(form.SelectedRow.Cells[2].Value.ToString())].Item1.Auteur;
                            this.libActive().SelectedIndexChanged += new EventHandler(lib_SelectedIndexChanged);
                        }
                        if(critere == "Serie")
                        {
                            radSerie.Checked = false;
                            radSerie.Checked = true;

                            this.libActive().SelectedIndexChanged -= new EventHandler(lib_SelectedIndexChanged);
                            libActive().SelectedItem = listResultat[int.Parse(form.SelectedRow.Cells[2].Value.ToString())].Item1.Serie;
                            this.libActive().SelectedIndexChanged += new EventHandler(lib_SelectedIndexChanged);
                        }
                        if(critere == "Editeur")
                        {
                            radEditeur.Checked = false;
                            radEditeur.Checked = true;

                            this.libActive().SelectedIndexChanged -= new EventHandler(lib_SelectedIndexChanged);
                            libActive().SelectedItem = listResultat[int.Parse(form.SelectedRow.Cells[2].Value.ToString())].Item1.Editeur;
                            this.libActive().SelectedIndexChanged += new EventHandler(lib_SelectedIndexChanged);
                        }
                        if (critere == "Genre")
                        {
                            radGenre.Checked = false;
                            radGenre.Checked = true;

                            this.libActive().SelectedIndexChanged -= new EventHandler(lib_SelectedIndexChanged);
                            libActive().SelectedItem = listResultat[int.Parse(form.SelectedRow.Cells[2].Value.ToString())].Item1.Genre;
                            this.libActive().SelectedIndexChanged += new EventHandler(lib_SelectedIndexChanged);
                        }
                        if (critere == "Categorie")
                        {
                            radCategorie.Checked = false;
                            radCategorie.Checked = true;

                            this.libActive().SelectedIndexChanged -= new EventHandler(lib_SelectedIndexChanged);
                            libActive().SelectedItem = listResultat[int.Parse(form.SelectedRow.Cells[2].Value.ToString())].Item1.Categorie;
                            this.libActive().SelectedIndexChanged += new EventHandler(lib_SelectedIndexChanged);
                        }
                    }
                }
                else
                    MessageBox.Show("La recherche n'a retourné aucun résultat", "Aucun résultats", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Veuillez saisir au moins une lettre", "Saisie incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnEnleverAlbum_Click(object sender, EventArgs e)
        {
            if(libActive() == libCatalogue && libActive().SelectedItem is Album)
            {
                Album albumSelected = (Album)libActive().SelectedItem;
                _albumRepository.Delete(albumSelected);
                utilisateurConnecte.ListeAlbumPossede.Remove(albumSelected);
                utilisateurConnecte.ListeSouhait.Remove(albumSelected);
                try
                {
                    if(albumSelected.Cover != "")
                        File.Delete("..\\..\\..\\img\\" + albumSelected.Cover);
                }
                catch(UnauthorizedAccessException)
                {
                    MessageBox.Show("Accès refusé au dossier image, l'image de couverture n'a pas pu être supprimée", "Accès interdit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                AffichageListes();
                }
            else if(libActive() != libCatalogue)
                MessageBox.Show("La suppression d'albums du catalogue est disponible uniquement sur l'onglet 'Catalogue'", "Onglet incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(libActive().SelectedItem is Album == false)
                MessageBox.Show("Veuillez sélectionner un album", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
