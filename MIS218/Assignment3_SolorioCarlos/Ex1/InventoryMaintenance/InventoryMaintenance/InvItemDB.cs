using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace InventoryMaintenance
{
    public static class InvItemDB
    {
        private const string Path = @"..\..\InventoryItems.xml";

        public static List<InvItem> GetItems()
        {
            // create the list
            List<InvItem> items = new List<InvItem>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(Path, settings);

            // read past all nodes to the first Book node
            if (xmlIn.ReadToDescendant("Item"))
            {
                // create one Product object for each Product node
                do
                {
                    InvItem item;
                    xmlIn.ReadStartElement("Item");
                    string type = xmlIn.ReadElementContentAsString();
                    if (type == "Plant")
                    {
                        Plant p = new Plant();
                        ReadBase(xmlIn, p);
                        p.Size = xmlIn.ReadElementContentAsString();
                        item = p;
                    }
                    else
                    {
                        Supply s = new Supply();
                        ReadBase(xmlIn, s);
                        s.Manufacturer = xmlIn.ReadElementContentAsString();
                        item = s;
                    }
                    items.Add(item);
                }
                while (xmlIn.ReadToNextSibling("Item"));
            }
            
            // close the XmlReader object
            xmlIn.Close();

            return items;
        }

        private static void ReadBase(XmlReader xmlIn, InvItem i)
        {
            i.ItemNo = xmlIn.ReadElementContentAsInt();
            i.Description = xmlIn.ReadElementContentAsString();
            i.Price = xmlIn.ReadElementContentAsDecimal();
        }
        public static void SaveItems(List<InvItem> items)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Items");

            // write each product object to the xml file
            foreach (InvItem item in items)
            {
                xmlOut.WriteStartElement("Item");
                if (item.GetType().Name == "Plant")
                {
                    Plant p = (Plant)item;
                    xmlOut.WriteElementString("Type", "Plant");
                    WriteBase(p, xmlOut);
                    xmlOut.WriteElementString("Size", p.Size);
                }
                else
                {
                    Supply s = (Supply)item;
                    xmlOut.WriteElementString("Type", "Supply");
                    WriteBase(s, xmlOut);
                    xmlOut.WriteElementString("Manufacturer", s.Manufacturer);
                }
                xmlOut.WriteEndElement();
            }

            // write the end tag for the root element
            xmlOut.WriteEndElement();

            // close the xmlWriter object
            xmlOut.Close();
        }

        private static void WriteBase(InvItem item, XmlWriter xmlOut)
        {
            xmlOut.WriteElementString("ItemNo", Convert.ToString(item.ItemNo));
            xmlOut.WriteElementString("Description", item.Description);
            xmlOut.WriteElementString("Price", Convert.ToString(item.Price));
        }
    }
}
