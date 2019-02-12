using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML_LABA
{
    class DOMSearch : IStrategy
    {
        public List<Scientist> Search(Scientist scientist, string path)
        {
            try {
                List<Scientist> result = new List<Scientist>();
                XmlDocument doc = new XmlDocument();
                try
                {
                    doc.Load(@path);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                XmlNode root = doc.DocumentElement;
                foreach (XmlNode node in root.ChildNodes)
                {
                    string name = "", faculty = "", department = "", degree = "", status = "";
                    foreach (XmlAttribute attr in node.Attributes)
                    {
                        if (attr.Name.Equals("Name") && (attr.Value.Equals(scientist.Name) || scientist.Name.Equals(string.Empty))) name = attr.Value;
                        if (attr.Name.Equals("Faculty") && (attr.Value.Equals(scientist.Faculty) || scientist.Faculty.Equals(string.Empty))) faculty = attr.Value;
                        if (attr.Name.Equals("Department") && (attr.Value.Equals(scientist.Department) || scientist.Department.Equals(string.Empty))) department = attr.Value;
                        if (attr.Name.Equals("ScientyDegree") && (attr.Value.Equals(scientist.Degree) || scientist.Degree.Equals(string.Empty))) degree = attr.Value;
                        if (attr.Name.Equals("AcademicStatus") && (attr.Value.Equals(scientist.Status) || scientist.Status.Equals(string.Empty))) status = attr.Value;
                    }
                    if (!name.Equals("") && !faculty.Equals("") && !department.Equals("") && !degree.Equals("") && !status.Equals(""))
                    {
                        Scientist newScientist = new Scientist();
                        newScientist.Name = name;
                        newScientist.Faculty = faculty;
                        newScientist.Department = department;
                        newScientist.Degree = degree;
                        newScientist.Status = status;
                        result.Add(newScientist);
                    }
                }

                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
