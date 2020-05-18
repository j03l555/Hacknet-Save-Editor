/*
 * Hacknet Save Editor
 * An open-source save editor for the game Hacknet.
 * 
 * ===========================================================
 * Created by J03L
 * 
 * Discord: J0w03L#0606
 * ===========================================================
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace HackNet_SaveEditor
{
    public partial class Form1 : Form
    {
        public OpenFileDialog openFileD = new OpenFileDialog();
        public XmlNodeList computers;
        public XmlDataDocument xmlsav;
        public Form1()
        {
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        private void loadSaveButton_Click(object sender, EventArgs e)
        {
            
            openFileD.InitialDirectory = @Environment.GetEnvironmentVariable("userprofile") + @"\Documents\My Games\Hacknet\Accounts"; //Set the default directory - this is where Hacknet stores it's save files by default.
            openFileD.Title = "Load Hacknet File";
            openFileD.Filter = "save_*.xml|*.xml";
            openFileD.ShowDialog();
            Stream save_file = openFileD.OpenFile();
            //Debugging purposes: 
            Console.WriteLine(openFileD.FileName);
            //call the loading function.
            loadSAVE(save_file);
        }

        public void loadSAVE(Stream savfile)
        {
            //Load save file
            xmlsav = new XmlDataDocument();
            xmlsav.PreserveWhitespace = true;
            //=================================================================
            // Here is where we get all the data from the save file and assign
            // it all to variables.
            //=================================================================

            //first we have to ensure that it is infact a valid save file
            bool isValid = false;
            try {
                xmlsav.Load(savfile); //Load the Save file as an XML document
                XmlNodeList hackNetSaveTag;
                hackNetSaveTag = xmlsav.GetElementsByTagName("HacknetSave");
                if (hackNetSaveTag == null)
                {
                    //Save file is invalid or corrupted.
                    //Pop-up an error message before canceling the save load
                    MessageBox.Show("The file given was either corrupted or not a valid Hacknet savefile.", "Invalid Save!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }
            }
            catch
            {
                //Empty catch statement, this prevents the program from crashing in the event that something goes wrong.
                //Log this to debug log
                Console.WriteLine("DEBUG: Exception handled whilst loading save file.");
                isValid = false;
            }

            if (isValid == false)
            {
                MessageBox.Show("The file given was either corrupted or not a valid Hacknet savefile.", "Invalid Save!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Continue loading the save file.
                XmlNode hnSav = xmlsav.GetElementsByTagName("HacknetSave")[0];
                XmlAttributeCollection miscData = hnSav.Attributes;
                string plrName = miscData.GetNamedItem("Username").InnerText;
                Console.WriteLine(plrName); //For debugging purposes.
                userNameInput.Text = plrName; //Set the username input textbox to the current username.
                textBox1.Text = hnSav.Attributes.GetNamedItem("Language").InnerText; //get language
                string mailIconDisabled = hnSav.Attributes.GetNamedItem("DisableMailIcon").InnerText;
                if (mailIconDisabled == "true")
                {
                    hideMailFlag.Checked = true;
                }
                else
                {
                    hideMailFlag.Checked = false;
                }

                //Grab list of computers
                computers = xmlsav.SelectNodes("//HacknetSave//NetworkMap//network//computer");
                Console.WriteLine(computers.Count);
                for (int i = 0; i < computers.Count; i++)
                {
                    computerListBox.Items.Add(computers[i].Attributes.GetNamedItem("id").Value);
                    Console.WriteLine(i);
                    Console.WriteLine(computers[i].Attributes.GetNamedItem("id").Value);
                }

                XmlNode mission = xmlsav.GetElementsByTagName("mission")[0];
                missionInput.Text = mission.Attributes.GetNamedItem("next").Value;
                goalInput.Text = mission.Attributes.GetNamedItem("goals").Value; ;


                //====================================================
                Console.WriteLine("Load completed successfully!");

            }
                
            
        }

        public void writeSAVE(Stream oldsavefile, string @newsavepath, Stream newsavefile)
        {
            //First things first, we create a backup of the old savefile.
            FileStream save_backup;
            save_backup = File.OpenWrite(@newsavepath + ".backup");
            oldsavefile.Position = 0;
            oldsavefile.CopyTo(save_backup);
            save_backup.Close();
            
            //Load save file
            //XmlDataDocument xmlsav = new XmlDataDocument();
            //xmlsav.PreserveWhitespace = true;
            oldsavefile.Position = 0; //We have to reset the position to 0 otherwise this fails
            //xmlsav.Load(oldsavefile); //Load the Save file as an XML document
            XmlNode hnSav = xmlsav.GetElementsByTagName("HacknetSave")[0];
            XmlAttributeCollection miscData = hnSav.Attributes;
            hnSav.Attributes.GetNamedItem("Username").InnerText = userNameInput.Text; //set username
            hnSav.Attributes.GetNamedItem("Language").InnerText = textBox1.Text; //set language
            if (hideMailFlag.Checked)
            {
                hnSav.Attributes.GetNamedItem("DisableMailIcon").InnerText = "true";
            }
            else
            {
                hnSav.Attributes.GetNamedItem("DisableMailIcon").InnerText = "false";
            }
            XmlNode mission = xmlsav.GetElementsByTagName("mission")[0];
            mission.Attributes.GetNamedItem("next").Value = missionInput.Text;
            mission.Attributes.GetNamedItem("goals").Value = goalInput.Text;



            //===========================================================
            //Now we actually save the values to a file
            //===========================================================

            //xmlsav.PreserveWhitespace = false;
            newsavefile.Close();
            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = false;
            xmlSettings.NewLineHandling = System.Xml.NewLineHandling.None;
            //xmlSettings.
            XmlWriter newsavefile_final = XmlWriter.Create(newsavepath, xmlSettings);

            xmlsav.Normalize();
            xmlsav.Save(newsavefile_final);

            newsavefile_final.Close();

            Console.WriteLine("Saved successfully!");




        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileD = new SaveFileDialog();
            saveFileD.InitialDirectory = @Environment.GetEnvironmentVariable("userprofile") + @"\Documents\My Games\Hacknet\Accounts"; //Set the default directory - this is where Hacknet stores it's save files by default.
            saveFileD.OverwritePrompt = true; //Ask the user if they want to overwrite an existing save, should they select one.
            saveFileD.AddExtension = true; //Ensure that we save it with the correct extension.
            saveFileD.DefaultExt = ".xml"; //The extension that we should save with.
            saveFileD.Title = "Save Hacknet File";
            saveFileD.Filter = "save_*.xml|*.xml";
            saveFileD.ShowDialog();

            Stream save_file = saveFileD.OpenFile();
            //Debugging purposes:
            Console.WriteLine(saveFileD.FileName);
            //call the saving function.
            writeSAVE(openFileD.OpenFile(), saveFileD.FileName,save_file);
        }

        private void computerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = 0;
            for (int i = 0; i < computers.Count; i++)
            {
                if (computers[i].Attributes.GetNamedItem("id").Value == computerListBox.SelectedItem)
                {
                    Console.WriteLine("Found selected computer successfully!");
                    index = i;
                    break;
                }
                Console.WriteLine(i);
                Console.WriteLine(computers[i].Attributes.GetNamedItem("id").Value);
            }
            currentComputerName.Text = computers[index].Attributes.GetNamedItem("name").Value;
            computers[index].Attributes.GetNamedItem("name").Value = currentComputerName.Text;
            
            int index3 = 0;

            for (int i = 0; i < computers[index].ChildNodes.Count; i++)
            {
                if (computers[index].ChildNodes[i].Name == "users")
                {
                    Console.WriteLine("Found users node successfully!");
                    index3 = i;
                    break;
                }
                Console.WriteLine(i);
                //Console.WriteLine(users[i].Attributes.GetNamedItem("name").Value);
            }
            XmlNodeList users = computers[index].ChildNodes[index3].ChildNodes;
            
            int index2 = 0;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].NodeType == XmlNodeType.Element)
                {
                    if (users[i].Attributes.GetNamedItem("name").Value == "admin")
                    {
                        Console.WriteLine("Found admin user successfully!");
                        index2 = i;
                        break;
                    }
                    Console.WriteLine(i);
                    Console.WriteLine(users[i].Attributes.GetNamedItem("name").Value);
                }
            }
            if ((users[index2].Attributes.GetNamedItem("known").Value == "True") ) { adminKnownFlag.Checked = true; }
            else { adminKnownFlag.Checked = false; }
            Console.WriteLine(adminKnownFlag.Checked.ToString());
            Console.WriteLine(users[index2].Attributes.GetNamedItem("pass").Value);
            Console.WriteLine(users[index2].ParentNode.ParentNode.Attributes.GetNamedItem("name").Value);
            Console.WriteLine(index);
            Console.WriteLine(index2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = 0;
            for (int i = 0; i < computers.Count; i++)
            {
                if (computers[i].Attributes.GetNamedItem("id").Value == computerListBox.SelectedItem)
                {
                    Console.WriteLine("Found selected computer successfully!");
                    index = i;
                    break;
                }
                Console.WriteLine(i);
                Console.WriteLine(computers[i].Attributes.GetNamedItem("id").Value);
            }
            computers[index].Attributes.GetNamedItem("name").Value = currentComputerName.Text;
            int index3 = 0;

            for (int i = 0; i < computers[index].ChildNodes.Count; i++)
            {
                if (computers[index].ChildNodes[i].Name == "users")
                {
                    Console.WriteLine("Found users node successfully!");
                    index3 = i;
                    break;
                }
                Console.WriteLine(i);
                //Console.WriteLine(users[i].Attributes.GetNamedItem("name").Value);
            }
            XmlNodeList users = computers[index].ChildNodes[index3].ChildNodes;

            int index2 = 0;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].NodeType == XmlNodeType.Element)
                {
                    if (users[i].Attributes.GetNamedItem("name").Value == "admin")
                    {
                        Console.WriteLine("Found admin user successfully!");
                        index2 = i;
                        break;
                    }
                    Console.WriteLine(i);
                    Console.WriteLine(users[i].Attributes.GetNamedItem("name").Value);
                }
            }
            if (adminKnownFlag.Checked == true) { users[index2].Attributes.GetNamedItem("known").Value = "True"; }
            else { users[index2].Attributes.GetNamedItem("known").Value = "False"; }
            Console.WriteLine(adminKnownFlag.Checked.ToString());
            Console.WriteLine("DEBUG:");
            Console.WriteLine(users[index2].Attributes.GetNamedItem("known").Value);
            Console.WriteLine("Saved edits to computer '" + computers[index].Attributes.GetNamedItem("name").Value + "' successfully!");
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            AllocConsole();
        }
    }
}
