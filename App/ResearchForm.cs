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

namespace App
{
    public partial class ResearchForm : Form
    {
        public ResearchForm(List<(Album, string)> listResultat)
        {
            InitializeComponent();
            dgvRecherche.ColumnCount = 3;
            dgvRecherche.Columns[0].Name = "Critère";
            dgvRecherche.Columns[1].Name = "Résultat";
            dgvRecherche.Columns[2].Name = "Index";
            dgvRecherche.Columns[2].Visible = false;
            List<(string, string)> memory = new List<(string, string)>();

            for (int i = 0; i < listResultat.Count; i++)
            {
                if (listResultat[i].Item2 == "Nom")
                    dgvRecherche.Rows.Add(new string[] { listResultat[i].Item2, listResultat[i].Item1.Nom, i.ToString() });
                else if (listResultat[i].Item2 == "Auteur" && memory.Contains((listResultat[i].Item1.Auteur,"Auteur")) == false)
                {
                    dgvRecherche.Rows.Add(new string[] { listResultat[i].Item2, listResultat[i].Item1.Auteur, i.ToString() });
                    memory.Add((listResultat[i].Item1.Auteur,"Auteur"));
                }
                else if (listResultat[i].Item2 == "Serie" && memory.Contains((listResultat[i].Item1.Serie, "Serie")) == false)
                {
                    dgvRecherche.Rows.Add(new string[] { listResultat[i].Item2, listResultat[i].Item1.Serie, i.ToString() });
                    memory.Add((listResultat[i].Item1.Serie, "Serie"));
                }
                else if (listResultat[i].Item2 == "Editeur" && memory.Contains((listResultat[i].Item1.Editeur, "Editeur")) == false)
                {
                    dgvRecherche.Rows.Add(new string[] { listResultat[i].Item2, listResultat[i].Item1.Editeur, i.ToString() });
                    memory.Add((listResultat[i].Item1.Editeur,"Editeur"));
                }
                else if (listResultat[i].Item2 == "Genre" && memory.Contains((listResultat[i].Item1.Genre, "Genre")) == false)
                {
                    dgvRecherche.Rows.Add(new string[] { listResultat[i].Item2, listResultat[i].Item1.Genre, i.ToString() });
                    memory.Add((listResultat[i].Item1.Genre, "Genre"));
                }
                else if (listResultat[i].Item2 == "Categorie" && memory.Contains((listResultat[i].Item1.Categorie, "Categorie")) == false)
                {
                    dgvRecherche.Rows.Add(new string[] { listResultat[i].Item2, listResultat[i].Item1.Categorie, i.ToString() });
                    memory.Add((listResultat[i].Item1.Categorie, "Categorie"));
                }
            }

            dgvRecherche.Rows[0].Selected = true;
        }

        public DataGridViewRow SelectedRow
        {
            get { return dgvRecherche.SelectedRows[0]; }
        }
    }
}
