using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace xworks.taskprocess
{
    public partial class FormTaskList : Form
    {
        public FormTaskList()
        {
            InitializeComponent();
        }

		private void _toolStripButtonOpen_Click(object sender, EventArgs e)
		{
			//TaskFile tf = new TaskFile();
			//List<Task> tasks = tf.LoadTasks();

			//add to list view
			//TODO
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			FormTaskEdit f = new FormTaskEdit();
			f.ShowDialog();
		}

		private void toolStripButton8_Click(object sender, EventArgs e)
		{
			FormTaskEdit f = new FormTaskEdit();
			f.ShowDialog();
		}

		private void toolStripButton7_Click(object sender, EventArgs e)
		{
			FormTaskProcess f = new FormTaskProcess();
			f.ShowDialog();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			FormTaskConfirm f = new FormTaskConfirm();
			f.ShowDialog();
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			FormLinkFile f = new FormLinkFile();
			f.ShowDialog();
		}
    }
}
