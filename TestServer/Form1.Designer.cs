
namespace TestServer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Users");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Groups");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("User&Groups", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Assing tests to user");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Review test results");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Users&Tests", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Tests explorer");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Load test");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Tests", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Server");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode10});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 39);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Users";
            treeNode1.Text = "Users";
            treeNode2.Name = "Groups";
            treeNode2.Text = "Groups";
            treeNode3.Name = "Users&Groups";
            treeNode3.Text = "User&Groups";
            treeNode4.Name = "Assing tests to user";
            treeNode4.Text = "Assing tests to user";
            treeNode5.Name = "Review test results";
            treeNode5.Text = "Review test results";
            treeNode6.Name = "Users&Tests";
            treeNode6.Text = "Users&Tests";
            treeNode7.Name = "Tests explorer";
            treeNode7.Text = "Tests explorer";
            treeNode8.Name = "Load test";
            treeNode8.Text = "Load test";
            treeNode9.Name = "Tests";
            treeNode9.Text = "Tests";
            treeNode10.Name = "Server";
            treeNode10.Text = "Server";
            treeNode11.Name = "General";
            treeNode11.Text = "General";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(121, 399);
            this.treeView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

