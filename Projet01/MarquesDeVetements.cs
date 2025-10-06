using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet01
{
    public partial class marqueVetementsForm : Form
    {
        public marqueVetementsForm()
        {
            InitializeComponent();
            InitialiserFormulaire();

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
        private void policeToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

    }
}
