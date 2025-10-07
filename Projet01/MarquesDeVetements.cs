using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet01
{
    public partial class MarqueVetementsForm : Form
    {
        public MarqueVetementsForm()
        {
            InitializeComponent();
            InitialiserFormulaire();

        }

        //Load
        private void MarqueVetementsForm_Load(object sender, EventArgs e)
        {
            FichierRtf();
        }

        #region Méthode d’initialisation

        private void InitialiserFormulaire()
        {
            try
            {

                policeToolStripComboBox.Items.Clear();

                var polices = FontFamily.Families
                    .Select(p => p.Name)
                    .OrderByDescending(p => p)
                    .ToList();

                foreach (string nomPolice in polices)
                {
                    policeToolStripComboBox.Items.Add(nomPolice);
                }

                if (policeToolStripComboBox.Items.Count > 0)
                    policeToolStripComboBox.SelectedIndex = 0;


                AdapterPoliceRichTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l’initialisation du formulaire : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Mehode Police
        private void PoliceToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdapterPoliceRichTextBox();
        }
        private void AdapterPoliceRichTextBox()
        {
            try
            {
                if (policeToolStripComboBox.SelectedItem != null)
                {
                    string policeChoisie = policeToolStripComboBox.SelectedItem.ToString();
                    vetementRichTextBox.Font = new Font(policeChoisie, 12, FontStyle.Regular);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l’application de la police : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Section RichTextBox
   
        private void FichierRtf()
        {
            try
            {
                string cheminFichier = Path.Combine(Application.StartupPath, "Data", "MarqueVetements.rtf");    // Chemin relatif vers le fichier RTF
                if (File.Exists(cheminFichier))
                {
                    vetementRichTextBox.LoadFile(cheminFichier,RichTextBoxStreamType.RichText); // Chargement du fichier RTF
                    vetementRichTextBox.Select(18,4);   // Selection active par defaut
                }
                else
                {
                    MessageBox.Show("Le fichier RTF est introuvable dans le dossier Data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement du fichier : " + ex.Message);
            }
        }



        #endregion

        #region Section recherche

        private void CompteurMarqueButton_Click(object sender, EventArgs e)
        {

            try
            {
                string marqueRecherche = rechercheTextBox.Text.Trim();

                if (string.IsNullOrEmpty(marqueRecherche))
                {
                    MessageBox.Show("Veuillez entrer une marque à rechercher.",
                                    "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int compteur = 0;   // Compteur d'occurrences
                int index = 0;      // Index de recherche initial

                // Recherche de toutes les occurrences de la marque avec une boucle while
                while (index < vetementRichTextBox.TextLength)
                {
                    index = vetementRichTextBox.Find(marqueRecherche, index, RichTextBoxFinds.None);

                    if (index == -1)
                    {
                        break; // Sort de la boucle si aucune autre occurrence n'est trouvée
                    }

                    compteur++;
                    index += marqueRecherche.Length; // Avancer l'index pour éviter de trouver la même occurrence

                    // la boucle s'arrête quand -1 est retourné par la méthode Find
                }

                MessageBox.Show("Nombre de marques = " + compteur);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du comptage des marques : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        #endregion


    }






}
