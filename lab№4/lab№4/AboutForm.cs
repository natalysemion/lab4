using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            label1.Text = "Лабораторна робота 4 \n Семйон Наталія Петрівна\n" +
                "2 курс, група К-25, 2022 рік \n " +
                "Біатлон - зимовий вид спорту. Новий сезон стартує 29.11\n\n" +
                "Add - додати нового біатлоніста до списку,\n" +
                "Change - змінити інформацію за Id,\n" +
                "Delete - видалити біатлоніста зі списку за ім'ям,\n" +
                "Також можна зробити фільтрацію за трьома властивостями.";
        }

        
    }
}
