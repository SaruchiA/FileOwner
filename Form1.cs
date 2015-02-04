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

//using System.MarshalByRefObject.ComponentModel.Component.DirectoryServices.DirectoryEntry.AccountManagement.PrincipalContext;


namespace FileOwner
{
    public partial class Form1 : Form
    {
        IdentityReference owner;
        List<String> owners = new List<string>();
        List<String> files = new List<string>(); 
        
        public Form1()
        {
            InitializeComponent();
            //comboBox1 .Items .Add 
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

        public void changeOwner(String path)
        {

            SecurityIdentifier builtinAdminSid = new SecurityIdentifier(WellKnownSidType.BuiltinAdministratorsSid, null);

            PrincipalContext ctx = new PrincipalContext(ContextType.Machine);

            GroupPrincipal group = GroupPrincipal.FindByIdentity(ctx, builtinAdminsSid.Value);

            foreach (Principal p in group.Members)
            {
                Console.WriteLine(p.Name);
            }

            //IdentityReference ir;
            //FileSecurity fs=comboBox1 .SelectedItem ;
            
            //for (int i = 0; i < 1 ; i++)
            //{
            //    ir = File.GetAccessControl(files[i]).GetOwner(typeof(SecurityIdentifier));
            //    owner = File.SetAccessControl(files[i], ir);
            //}
        }

        private void buttonChangeOwner_Click(object sender, EventArgs e)
        {
            //owner = System.IO.File.GetAccessControl(files[i]).GetOwner(typeof(SecurityIdentifier));

            //var ntAccount = new NTAccount("DOMAIN", "username");
            //fs.SetOWner(ntAccount);

            //try
            //{
            //    File.SetAccessControl(FILE, fs);
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine("You cannot assign ownership to that user." +
            //     "Either you don't have TakeOwnership permissions, or it is not your user account."
            //    );
                
            //}
        }
    }
}
