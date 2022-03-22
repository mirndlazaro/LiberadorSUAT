﻿using Microsoft.Office.Interop.Outlook;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using LiberadorSUAT.Models;
using LiberadorSUAT.Screens.Modals;

namespace LiberadorSUAT
{
    public class Email
    {
        private TelaLiberador telaLiberador;
        private ModalAnexos modalAnexo;
        public Email(TelaLiberador tela, ModalAnexos modal)
        {
            telaLiberador = tela;
            modalAnexo = modal;
        }
        public Email()
        {
        }
        private string carregarHTML()
        {
            string body = string.Empty;
            string caminho = @"C:\Workspace\CCR\DesafioTecnico\LiberadorSUAT\EmailTemplate.txt";

            try
            {
                using (FileStream fs = new FileStream(caminho, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        while (!reader.EndOfStream)
                        {
                             body = reader.ReadToEnd();
                        }
                    }
                }

                //body = body.Replace("{nomeSistema}", telaLiberador.listBoxSistemas.SelectedItem.ToString());
                body = body.Replace("{numVersao}", telaLiberador.txbVersao.Text);
                body = body.Replace("{numRelease}", telaLiberador.txbRelease.Text);
               // body = body.Replace("{tpLiberacao}", telaLiberador.txbRelease.ToString());
               // body = body.Replace("", modalAnexo.listViewArquivos.Items[1].ToString());

            }
            catch
            {
                MessageBox.Show("Erro ao carregar HTML");
            }
            return body;
        }


       public void montaEmail(Outlook.Application application)
        {
            Outlook.MailItem message = (Outlook.MailItem)application.CreateItem(Outlook.OlItemType.olMailItem);
            message.To = "";
            message.CC = "";
            message.Subject = "Liberador SUAT";
            message.HTMLBody = carregarHTML();
            message.Importance = Outlook.OlImportance.olImportanceHigh;
            message.Display(false);
        }

        public Outlook.Application GetApplicationObject()
        {

            Outlook.Application application = null;

            // Check whether there is an Outlook process running.
            if (Process.GetProcessesByName("OUTLOOK").Count() > 0)
            {
                // If so, use the GetActiveObject method to obtain the process and cast it to an Application object.
                application = Marshal.GetActiveObject("Outlook.Application") as Outlook.Application;
                montaEmail(application);
            }
            else
            {

                // If not, create a new instance of Outlook and sign in to the default profile.
                application = new Outlook.Application();
                montaEmail(application);
                Outlook.NameSpace nameSpace = application.GetNamespace("MAPI");
                nameSpace.Logon("", "", Missing.Value, Missing.Value);
                nameSpace = null;
            }

            return application;
        }
    }
}