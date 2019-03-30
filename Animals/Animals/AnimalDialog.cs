using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animals.Models;

namespace Animals
{
  public interface IAnimalDialogParent
    {
        void AddedNewAnimal(Animal newAnimal);
    }

    public partial class AnimalDialog : Form
    {
        private IAnimalDialogParent _parent;

        public AnimalDialog(IAnimalDialogParent parent)
        {
            InitializeComponent();
            _parent = parent;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            var newAnimal = new Animal
            {
                ClientFirstName = textBox1.Text,
                ClientLastName = textBox2.Text,
                BirthDate = dateTimePicker1.Value,
                PetName = textBox3.Text
            };
            _parent.AddedNewAnimal(newAnimal);
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

     
    }
}
