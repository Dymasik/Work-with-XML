using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace XML_LABA
{
    class SAXSearch : IStrategy
    {
        public List<Scientist> Search(Scientist scientist, string path)
        {
            try {
                List<Scientist> result = new List<Scientist>();
                XmlTextReader xmlReader = new XmlTextReader(@path);

                while (xmlReader.Read())
                {
                    if (xmlReader.HasAttributes)
                    {
                        while (xmlReader.MoveToNextAttribute())
                        {
                            string name = "", faculty = "", department = "", degree = "", status = "";
                            if (xmlReader.Name.Equals("Name") && (xmlReader.Value.Equals(scientist.Name) || scientist.Name.Equals(string.Empty)))
                            {
                                name = xmlReader.Value;
                                xmlReader.MoveToNextAttribute();
                                if (xmlReader.Name.Equals("Faculty") && (xmlReader.Value.Equals(scientist.Faculty) || scientist.Faculty.Equals(string.Empty)))
                                {
                                    faculty = xmlReader.Value;
                                    xmlReader.MoveToNextAttribute();
                                    if (xmlReader.Name.Equals("Department") && (xmlReader.Value.Equals(scientist.Department) || scientist.Department.Equals(string.Empty)))
                                    {
                                        department = xmlReader.Value;
                                        xmlReader.MoveToNextAttribute();
                                        if (xmlReader.Name.Equals("ScientyDegree") && (xmlReader.Value.Equals(scientist.Degree) || scientist.Degree.Equals(string.Empty)))
                                        {
                                            degree = xmlReader.Value;
                                            xmlReader.MoveToNextAttribute();
                                            if (xmlReader.Name.Equals("AcademicStatus") && (xmlReader.Value.Equals(scientist.Status) || scientist.Status.Equals(string.Empty)))
                                            {
                                                status = xmlReader.Value;
                                                xmlReader.MoveToNextAttribute();
                                            }
                                        }
                                    }
                                }
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
                    }
                }
                xmlReader.Close();

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
