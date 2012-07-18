using System;
using System.Xml;

namespace bark_GUI
{
    class File
    {
        string pathSamples = @"Samples/";
        string pathMaterials = @"Materials/";
        XmlTextReader reader;

        void Save()
        {
        }

        public void Load()
        {
            LoadXML(pathSamples + "polystyrene.brk.xml");
        }

        /// <summary> Loads any XML case file with it's Elements, Attributes and Values. </summary>
        /// <param name="fileURL"> Which file to load. </param>
        /// <returns> Load succeeded? </returns>
        bool LoadXML(string fileURL)
        {
            reader = new XmlTextReader(fileURL);
            if (reader.Read() && reader.NodeType == XmlNodeType.XmlDeclaration)
            {
                reader.Skip();
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            Program.form1.labelTest.Text += "+"+reader.Name;
                            Program.form1.labelTest.Text += reader.AttributeCount;
                            //Program.form1.labelTest.Text += "-"+reader.Value;
                            for (int i = 0; i < reader.AttributeCount; i++)
                                Program.form1.labelTest.Text += "#" + reader.GetAttribute(i);
                            break;
                        case XmlNodeType.Text:
                            //Program.form1.labelTest.Text += " TEXT  " + reader.Name;
                            Program.form1.labelTest.Text += " TEXT  " + reader.Value;
                            break;
                        case XmlNodeType.EndElement:
                            Program.form1.labelTest.Text += ">" + reader.Name;
                            //Program.form1.labelTest.Text += ">" + reader.Value;
                            break;
                        default:
                            if (reader.NodeType != XmlNodeType.Whitespace)
                                Program.form1.labelTest.Text += "     F A L S E ! ! ! ! !     ";
                            break;
                    }
                }
            }
            return true;
        }
    }
}
