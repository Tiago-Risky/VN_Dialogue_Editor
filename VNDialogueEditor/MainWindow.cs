using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VNDialogueEditor {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }

        private XElement XmlFile;

        private void LoadXML() {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*",
                FilterIndex = 1
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                XmlFile = XElement.Load(openFileDialog.FileName);
                PopulateTree(treeView1, XmlFile);
            }
        }

        private void ExportXML() {
            Stream fileStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog {
                Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*",
                FilterIndex = 1
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                if ((fileStream = saveFileDialog.OpenFile()) != null) {
                    StreamWriter streamWriter = new StreamWriter(fileStream);
                    streamWriter.Write(treeView1.Nodes[0].Tag.ToString());
                    streamWriter.Flush();
                    fileStream.Position = 0;
                    fileStream.Close();
                }
                else {
                    MessageBox.Show("Can't write the file.", "Error writing file",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        public void PopulateTree(TreeView treeview, XElement xmlDocument) {
            treeview.Nodes.Clear();
            treeview.Enabled = false;
            TreeNode Document = new TreeNode("Document");
            Document.Tag = xmlDocument;
            treeview.Nodes.Add(Document);
            AddNodes(Document, xmlDocument);
            treeview.ExpandAll();
            treeview.Nodes[0].EnsureVisible();
            treeview.Enabled = true;
        }

        private void AddNodes(TreeNode treeNode, XElement parent) {
            foreach (XElement child in parent.Elements()) {
                TreeNode childNode = treeNode.Nodes.Add(child.Name.ToString());
                childNode.Tag = child;
                AddNodes(childNode, child);
            }
        }

        private void RebuildNodes(TreeNode treeNode) {
            while (treeNode.Parent != null && treeNode.Parent.Tag != null) {
                XElement parentElement = (XElement)treeNode.Parent.Tag;
                parentElement.RemoveNodes();
                foreach (TreeNode node in treeNode.Parent.Nodes) {
                    parentElement.Add((XElement)node.Tag);
                }
                treeNode = treeNode.Parent;
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            textBox1.Text = treeView1.SelectedNode.Tag.ToString();
            textBox2.Text = treeView1.SelectedNode.Tag.ToString();
        }

        private void OpenXMLFile_Click(object sender, EventArgs e) {
            LoadXML();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            treeView1.SelectedNode.Tag = XElement.Parse(textBox2.Text);
            RebuildNodes(treeView1.SelectedNode);
        }

        private void ExportXMLFile_Click(object sender, EventArgs e) {
            ExportXML();
        }
    }
}
