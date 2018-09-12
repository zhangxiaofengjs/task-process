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

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void 开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 添加工作ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            string path = file.FileName;
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            //doc.Load(@"C:\a.xml");

            XmlNodeList topM = doc.SelectNodes("workprocess/list");
            foreach (XmlElement element in topM)
            {
                ListViewItem xmldate = new ListViewItem();
                xmldate.SubItems[0].Text = element.GetElementsByTagName("id")[0].InnerText;
                xmldate.SubItems.Add(element.GetElementsByTagName("level")[0].InnerText);
                xmldate.SubItems.Add(element.GetElementsByTagName("detil")[0].InnerText);
                xmldate.SubItems.Add(element.GetElementsByTagName("do")[0].InnerText);
                xmldate.SubItems.Add(element.GetElementsByTagName("add")[0].InnerText);
                xmldate.SubItems.Add(element.GetElementsByTagName("admin")[0].InnerText);
                xmldate.SubItems.Add(element.GetElementsByTagName("worker")[0].InnerText);
                xmldate.SubItems.Add(element.GetElementsByTagName("condition")[0].InnerText);
                xmldate.SubItems.Add(element.GetElementsByTagName("affirmant")[0].InnerText);
                xmldate.SubItems.Add(element.GetElementsByTagName("adate")[0].InnerText);
                xmldate.SubItems.Add(element.GetElementsByTagName("update")[0].InnerText);
              
        
                listView1.Items.Add(xmldate);
                


                
            }  
        }
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].Index != -1)
            {
                ListViewItem oldItem = listView1.SelectedItems[1];
                FormTaskEdit nform = new FormTaskEdit();//将这一行ListViewItem作为参数传给另外一个窗体
                nform.Show();
                if (nform.ShowDialog() == DialogResult.OK)//如果被修改，刷新listView1
                {
                    listView1.Refresh();
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                //nform.Show();
                //if (listView1.SelectedItems[0].Index != -1)
                //{
                    //ListViewItem oldItem = listView1.SelectedItems[0];
                    //Form2 nform = new Form2(oldItem);//将这一行ListViewItem作为参数传给另外一个窗体
                    
                    //if (nform.ShowDialog() == DialogResult.OK)//如果被修改，刷新listView1
                    //{
                       // listView1.Refresh();
                   // }
               // }
                try
                {
                     if (listView1.SelectedItems[0].Index != -1)
                     {
                         ListViewItem oldItem = listView1.SelectedItems[0];
                         FormTaskEdit nform = new FormTaskEdit();//将这一行ListViewItem作为参数传给另外一个窗体

                         if (nform.ShowDialog() == DialogResult.OK)//如果被修改，刷新listView1
                         {
                             listView1.Refresh();
                         }
                     }
              
                }
                catch (Exception )
                {
                    MessageBox.Show("请选择工作");// 错误处理代码
                }


            }
        
        
        
   
        



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            { 

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListViewItem  nwork = listView1.Items.Add((listView1.Items.Count + 1) + "");
            nwork.SubItems.Add("");
            nwork.SubItems.Add("新工作");
            nwork.SubItems.Add("");
            nwork.SubItems.Add("");
            nwork.SubItems.Add("");
            nwork.SubItems.Add("");
            nwork.SubItems.Add("");
            nwork.SubItems.Add("");
            nwork.SubItems.Add("");
            nwork.SubItems.Add("");
            nwork.SubItems.Add("");
            
          




        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem item = listView1.SelectedItems[i];
                listView1.Items.Remove(item);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
      
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
