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
using System.Xml;
using System.Xml.Xsl;

namespace XML_LABA
{

    public partial class Form : System.Windows.Forms.Form
    {
        Strategy algo;
        string path;
        string xslPath;

        public Form()
        {
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void getAllScientists()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"D:\XML\dataBase.xml");
                List<string> needToAdd = new List<string>();

                needToAdd = getAttr("Name");
                NameBox.Items.Clear();
                foreach (string obj in needToAdd)
                {
                    NameBox.Items.Add(obj);
                }

                needToAdd = getAttr("Faculty");
                FacultyBox.Items.Clear();
                foreach (string obj in needToAdd)
                {
                    FacultyBox.Items.Add(obj);
                }

                needToAdd = getAttr("Department");
                DepartmentBox.Items.Clear();
                foreach (string obj in needToAdd)
                {
                    DepartmentBox.Items.Add(obj);
                }

                needToAdd = getAttr("ScientyDegree");
                DegreeBox.Items.Clear();
                foreach (string obj in needToAdd)
                {
                    DegreeBox.Items.Add(obj);
                }

                needToAdd = getAttr("AcademicStatus");
                StatusBox.Items.Clear();
                foreach (string obj in needToAdd)
                {
                    StatusBox.Items.Add(obj);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private List<string> getAttr(string s)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\XML\dataBase.xml");
            List<string> ans = new List<string>();

            foreach (XmlNode n in doc.SelectNodes("//Scientist[@" + s + "]"))
            {
                if (!ans.Contains(n.Attributes[s].Value))
                    ans.Add(n.Attributes[s].Value);

            }
            return ans;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            getAllScientists();
        }

        private void openFile()
        {
            MessageBox.Show("Оберіть файл формату xml");
            if (openFileXML.ShowDialog() != DialogResult.Cancel)
                path = openFileXML.FileName;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            openFile();
            if (DOM.Checked)
            {
                TextBox.Clear();
                algo = new Strategy(new DOMSearch(), makeScientist(), path);
                show(algo.SearchAlgorithm());
            }
            else if (SAX.Checked)
            {
                TextBox.Clear();
                algo = new Strategy(new SAXSearch(), makeScientist(), path);
                show(algo.SearchAlgorithm());
            }
            else
            {
                if (!LINQ.Checked)
                    LINQ.Checked = true;
                TextBox.Clear();
                algo = new Strategy(new LINQSearch(), makeScientist(), path);
                show(algo.SearchAlgorithm());
            }
            
        }

        private Scientist makeScientist()
        {
            Scientist scientist = new Scientist();
            if(NAME.Checked == true)
            {
                scientist.Name = NameBox.Text;
            }
            if (Faculty.Checked == true)
            {
                scientist.Faculty = FacultyBox.Text;
            }
            if (Department.Checked == true)
            {
                scientist.Department = DepartmentBox.Text;
            }
            if (Degree.Checked == true)
            {
                scientist.Degree = DegreeBox.Text;
            }
            if (Status.Checked == true)
            {
                scientist.Status = StatusBox.Text;
            }


            return scientist;
        }

        private void show(List<Scientist> scientists)
        {
            int i = 0;
            foreach(Scientist scientist in scientists)
            {
                i++;
                TextBox.Text += i.ToString() + " робітник: \n";
                TextBox.Text += scientist.Name + "\n";
                TextBox.Text += scientist.Faculty + "\n";
                TextBox.Text += scientist.Department + "\n";
                TextBox.Text += scientist.Degree + "\n";
                TextBox.Text += scientist.Status + "\n";
                TextBox.Text += '\n';
            }
        }

        private void openFileXSL()
        {
            MessageBox.Show("Оберіть файл формату xsl");
            if (openXSL.ShowDialog() != DialogResult.Cancel)
                xslPath = openXSL.FileName;
        }

        private void ToHTML_Click(object sender, EventArgs e)
        {
            openFileXSL();
            openFile();
            try
            {
                XslCompiledTransform xct = new XslCompiledTransform();
                xct.Load(@xslPath);
                string fXML = @path;
                string fHTML = @"D:\XML\dataBase.html";
                xct.Transform(fXML, fHTML);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
