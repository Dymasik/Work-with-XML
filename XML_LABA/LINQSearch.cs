using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace XML_LABA
{
    class LINQSearch : IStrategy
    {
        public List<Scientist> Search(Scientist scientist, string path)
        {
            try {
                List<Scientist> result = new List<Scientist>();
                var doc = XDocument.Load(@path);

                var answer = from obj in doc.Descendants("Scientist")
                             where (
                             (obj.Attribute("Name").Value == scientist.Name || scientist.Name == string.Empty) &&
                             (obj.Attribute("Faculty").Value == scientist.Faculty || scientist.Faculty == string.Empty) &&
                             (obj.Attribute("Department").Value == scientist.Department || scientist.Department == string.Empty) &&
                             (obj.Attribute("ScientyDegree").Value == scientist.Degree || scientist.Degree == string.Empty) &&
                             (obj.Attribute("AcademicStatus").Value == scientist.Status || scientist.Status == string.Empty)
                             )
                             select new
                             {
                                 name = (string)obj.Attribute("Name").Value,
                                 faculty = (string)obj.Attribute("Faculty").Value,
                                 department = (string)obj.Attribute("Department").Value,
                                 degree = (string)obj.Attribute("ScientyDegree").Value,
                                 status = (string)obj.Attribute("AcademicStatus").Value,
                             };
                foreach (var n in answer)
                {
                    Scientist newScientist = new Scientist();
                    newScientist.Name = n.name;
                    newScientist.Faculty = n.faculty;
                    newScientist.Department = n.department;
                    newScientist.Degree = n.degree;
                    newScientist.Status = n.status;
                    result.Add(newScientist);

                }
                return result;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
