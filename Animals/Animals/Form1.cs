using Animals.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animals
{
    public partial class Form1 : Form, IAnimalDialogParent
    {
        private PetDb db = new PetDb();
        private BindingSource bs = new BindingSource();
        private IList<Animal> animals;

        public Form1()
        {
            InitializeComponent();
            animals = db.Animal.ToList();
            bs.DataSource = animals;
            AnimalGridView.DataSource = bs;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new AnimalDialog(this).ShowDialog();

        }

        public void AddedNewAnimal(Animal newAnimal)
        {
            db.Animal.Add(newAnimal);
            db.SaveChanges();
            animals.Add(newAnimal);
            bs.ResetBindings(false);
        }
    }
}
