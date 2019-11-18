using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace ValidateXMLtoXSD
{
    public partial class frmPrincipal : Form
    {

        #region Atributos

        private bool invalido = false;
        StringBuilder strGuardaValidacao = new StringBuilder();

        #endregion 

        #region Construtor
        public frmPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.CenterToScreen();
        }

        /// <summary>
        /// Click do botão principal, gera a validação
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void btnValidar_Click(object sender, EventArgs e)
        {

            try
            {
                
                this.Cursor = Cursors.WaitCursor;
                this.Validar();
                strGuardaValidacao = new StringBuilder();
                if (ValidaXmlXsd(txtCaminhoXML.Text, txtCaminhoXSD.Text))
                {
                    MessageBox.Show("ARQUIVO VÁLIDO", "VERIFICAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else 
                {
                    if (MessageBox.Show("Arquivo inválido, deseja obter detalhes sobre o(s) erro(s)?",
                                    "",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        MessageBox.Show(strGuardaValidacao.ToString(), "ARQUIVO INVÁLIDO - DETALHES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Evento que ocorre quando é encontrado um erro no XML.
        /// Grava a mensagem para posterior exibição.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">ValidationEventArgs</param>
        private void xmlSettings_ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            invalido = true;
            strGuardaValidacao.AppendLine(e.Message);
        }

        /// <summary>
        /// Evento para busca do arquivo XML no diretório
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void btnXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.Filter = "Arquivos XML (.xml)|*.xml";
            ofd.FilterIndex = 1;


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.txtCaminhoXML.Text = ofd.FileName;
            }

        }

        /// <summary>
        /// Evento para busca do arquivo XSD no diretório
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void btnXSD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.Filter = "Arquivos XSD (.xsd)|*.xsd";
            ofd.FilterIndex = 1;


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.txtCaminhoXSD.Text = ofd.FileName;
            }

        }
        #endregion

        #region Método

        /// <summary>
        /// Método que valida o conteúdo de um XML com relação ao seu XSD,
        /// disparando um evento para gravar os erros de validação quando houver
        /// </summary>
        /// <param name="xml">Caminho do arquivo XML</param>
        /// <param name="xsd">Caminho do arquivo XSD</param>
        /// <returns>Retorna um boolean se valido TRUE senao FALSE</returns>
        private bool ValidaXmlXsd(string xml, string xsd)
        {
            try
            {
                XmlReaderSettings xmlSettings = new XmlReaderSettings();
                xmlSettings.Schemas = new System.Xml.Schema.XmlSchemaSet();
                xmlSettings.Schemas.Add("", xsd);
                xmlSettings.ValidationType = ValidationType.Schema;
                xmlSettings.ValidationEventHandler += new ValidationEventHandler(xmlSettings_ValidationEventHandler);

                using (XmlReader reader = XmlReader.Create(xml, xmlSettings))
                {
                    while (reader.Read()) ;
                }
                return !invalido;
            }
            catch (Exception ex)
            {
                strGuardaValidacao.AppendLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Método para validar os campos em tela
        /// </summary>
        private void Validar()
        {
            if (txtCaminhoXML.Text == String.Empty)
            {
                errProvider.SetError(txtCaminhoXML, "Selecione um arquivo válido!");
                invalido = true;
            }
            else if (!File.Exists(txtCaminhoXML.Text))
            {
                errProvider.SetError(txtCaminhoXML, "Selecione um arquivo válido!");
                invalido = true;
            }
            else
            {
                errProvider.SetError(txtCaminhoXML, "");
            }
            if (txtCaminhoXSD.Text == String.Empty)
            {
                errProvider.SetError(txtCaminhoXSD, "Selecione um arquivo válido!");
                invalido = true;
            }
            else if (!File.Exists(txtCaminhoXSD.Text))
            {
                errProvider.SetError(txtCaminhoXSD, "Selecione um arquivo válido!");
                invalido = true;
            }
            else
            {
                errProvider.SetError(txtCaminhoXSD, "");
            }
        }      

        #endregion

      
    }
}
