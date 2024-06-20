using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetodosPets
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTutor tutor = new frmTutor();
            tutor.Show();
            this.Hide();
        }

        private void petToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPet pet = new frmPet();
            pet.Show();
            this.Hide();
        }

        private void veterinárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVet vet = new frmVet();
            vet.Show();
            this.Hide();
        }

        private void espécieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEspecie especie = new frmEspecie();
            especie.Show();
            this.Hide();
        }

        private void raçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaca raca = new frmRaca();
            raca.Show();
            this.Hide();
        }

        private void examesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExames exame = new frmExames();
            exame.Show();
            this.Hide();
        }
    }
}
