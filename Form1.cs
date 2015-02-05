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
using System.Security.AccessControl;
using System.Security.Principal;
using System.DirectoryServices;
//using System.MarshalByRefObject.ComponentModel.Component.DirectoryServices.DirectoryEntry.AccountManagement.PrincipalContext;


namespace FileOwner
{
    public partial class Form1 : Form
    {
        IdentityReference owner;
        List<String> owners = new List<string>();
        List<String> files = new List<string>();
        String userAccountPath = string.Format("WinNT://{0},computer", Environment.MachineName);

        public Form1()
        {
            InitializeComponent();
            populateOwner(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textFile.Text = "";            
            getOwner(textPath .Text );            
        }

        public void getOwner(String path)
        {
                      
            try
            {
                files.AddRange(Directory.GetFiles(path,"*",SearchOption.AllDirectories));
            }
            catch (Exception ex)
            {
                textFile.Text = ex.Message ;
            } 

            // populate List of Owners
            for (int i = 0; i < files.Count; i++)
            {
                //var owner = System.IO.File.GetAccessControl(files [i]).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString ();
                
                try
                {
                    owner = File.GetAccessControl(files[i]).GetOwner(typeof(SecurityIdentifier));
                    owners.Add(owner.Translate(typeof(NTAccount)).ToString());
                }

                //exception thrown in case the folder @ specified path belonged to a user whose account has been formatted
                catch(System.Security.Principal.IdentityNotMappedException x)
                {
                    owners.Add("Unknown User");
                }    
            }

            for (int i = 0; i < files.Count; i++)
            {
                textFile.Text += files[i].Substring(path.Length) + " | " + owners[i] + System.Environment.NewLine;
            }

        }

        public void populateOwner()
        {            
           // String path1 = "WinNT://"+ Environment.MachineName+"/"+Environment .UserName ;
            using (var computerEntry = new DirectoryEntry(userAccountPath))
                foreach (DirectoryEntry childEntry in computerEntry.Children)
                    if (childEntry.SchemaClassName == "User")
                        comboBox1 .Items .Add (childEntry.Name);
        }

        public void setOwner()
        {
            IdentityReference owner = new NTAccount(userAccountPath);
            DirectoryInfo directory = new DirectoryInfo(textPath.Text);
            DirectorySecurity directorySecurity = directory.GetAccessControl();
            directorySecurity.SetOwner(owner);
            directory.SetAccessControl(directorySecurity);
        }

        private void buttonChangeOwner_Click(object sender, EventArgs e)
        {
            setOwner();
        }
    }
}
