
namespace Remake_portal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label reg_noLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label email_addressLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label confirm_passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.registryDataSet = new Remake_portal.registryDataSet();
            this.student_registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_registrationTableAdapter = new Remake_portal.registryDataSetTableAdapters.student_registrationTableAdapter();
            this.tableAdapterManager = new Remake_portal.registryDataSetTableAdapters.TableAdapterManager();
            this.student_registrationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.student_registrationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.reg_noTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.email_addressTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirm_passwordTextBox = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            reg_noLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            email_addressLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            confirm_passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_registrationBindingNavigator)).BeginInit();
            this.student_registrationBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // reg_noLabel
            // 
            reg_noLabel.AutoSize = true;
            reg_noLabel.Location = new System.Drawing.Point(68, 115);
            reg_noLabel.Name = "reg_noLabel";
            reg_noLabel.Size = new System.Drawing.Size(58, 20);
            reg_noLabel.TabIndex = 1;
            reg_noLabel.Text = "reg no:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(68, 147);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(83, 20);
            first_nameLabel.TabIndex = 3;
            first_nameLabel.Text = "first name:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(68, 179);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(82, 20);
            last_nameLabel.TabIndex = 5;
            last_nameLabel.Text = "last name:";
            // 
            // email_addressLabel
            // 
            email_addressLabel.AutoSize = true;
            email_addressLabel.Location = new System.Drawing.Point(68, 211);
            email_addressLabel.Name = "email_addressLabel";
            email_addressLabel.Size = new System.Drawing.Size(111, 20);
            email_addressLabel.TabIndex = 7;
            email_addressLabel.Text = "email address:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(68, 243);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(81, 20);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "password:";
            // 
            // confirm_passwordLabel
            // 
            confirm_passwordLabel.AutoSize = true;
            confirm_passwordLabel.Location = new System.Drawing.Point(68, 275);
            confirm_passwordLabel.Name = "confirm_passwordLabel";
            confirm_passwordLabel.Size = new System.Drawing.Size(137, 20);
            confirm_passwordLabel.TabIndex = 11;
            confirm_passwordLabel.Text = "confirm password:";
            // 
            // registryDataSet
            // 
            this.registryDataSet.DataSetName = "registryDataSet";
            this.registryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_registrationBindingSource
            // 
            this.student_registrationBindingSource.DataMember = "student registration";
            this.student_registrationBindingSource.DataSource = this.registryDataSet;
            // 
            // student_registrationTableAdapter
            // 
            this.student_registrationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.student_registrationTableAdapter = this.student_registrationTableAdapter;
            this.tableAdapterManager.UpdateOrder = Remake_portal.registryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // student_registrationBindingNavigator
            // 
            this.student_registrationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.student_registrationBindingNavigator.BindingSource = this.student_registrationBindingSource;
            this.student_registrationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.student_registrationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.student_registrationBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.student_registrationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.student_registrationBindingNavigatorSaveItem});
            this.student_registrationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.student_registrationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.student_registrationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.student_registrationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.student_registrationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.student_registrationBindingNavigator.Name = "student_registrationBindingNavigator";
            this.student_registrationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.student_registrationBindingNavigator.Size = new System.Drawing.Size(800, 33);
            this.student_registrationBindingNavigator.TabIndex = 0;
            this.student_registrationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // student_registrationBindingNavigatorSaveItem
            // 
            this.student_registrationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.student_registrationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("student_registrationBindingNavigatorSaveItem.Image")));
            this.student_registrationBindingNavigatorSaveItem.Name = "student_registrationBindingNavigatorSaveItem";
            this.student_registrationBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.student_registrationBindingNavigatorSaveItem.Text = "Save Data";
            this.student_registrationBindingNavigatorSaveItem.Click += new System.EventHandler(this.student_registrationBindingNavigatorSaveItem_Click);
            // 
            // reg_noTextBox
            // 
            this.reg_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_registrationBindingSource, "reg no", true));
            this.reg_noTextBox.Location = new System.Drawing.Point(211, 112);
            this.reg_noTextBox.Name = "reg_noTextBox";
            this.reg_noTextBox.Size = new System.Drawing.Size(100, 26);
            this.reg_noTextBox.TabIndex = 2;
            this.reg_noTextBox.TextChanged += new System.EventHandler(this.reg_noTextBox_TextChanged);
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_registrationBindingSource, "first name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(211, 144);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.first_nameTextBox.TabIndex = 4;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_registrationBindingSource, "last name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(211, 176);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.last_nameTextBox.TabIndex = 6;
            // 
            // email_addressTextBox
            // 
            this.email_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_registrationBindingSource, "email address", true));
            this.email_addressTextBox.Location = new System.Drawing.Point(211, 208);
            this.email_addressTextBox.Name = "email_addressTextBox";
            this.email_addressTextBox.Size = new System.Drawing.Size(100, 26);
            this.email_addressTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_registrationBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(211, 240);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 26);
            this.passwordTextBox.TabIndex = 10;
            // 
            // confirm_passwordTextBox
            // 
            this.confirm_passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_registrationBindingSource, "confirm password", true));
            this.confirm_passwordTextBox.Location = new System.Drawing.Point(211, 272);
            this.confirm_passwordTextBox.Name = "confirm_passwordTextBox";
            this.confirm_passwordTextBox.Size = new System.Drawing.Size(100, 26);
            this.confirm_passwordTextBox.TabIndex = 12;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(211, 324);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(100, 37);
            this.registerBtn.TabIndex = 13;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(reg_noLabel);
            this.Controls.Add(this.reg_noTextBox);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.last_nameTextBox);
            this.Controls.Add(email_addressLabel);
            this.Controls.Add(this.email_addressTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(confirm_passwordLabel);
            this.Controls.Add(this.confirm_passwordTextBox);
            this.Controls.Add(this.student_registrationBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_registrationBindingNavigator)).EndInit();
            this.student_registrationBindingNavigator.ResumeLayout(false);
            this.student_registrationBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private registryDataSet registryDataSet;
        private System.Windows.Forms.BindingSource student_registrationBindingSource;
        private registryDataSetTableAdapters.student_registrationTableAdapter student_registrationTableAdapter;
        private registryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator student_registrationBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton student_registrationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox reg_noTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox email_addressTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox confirm_passwordTextBox;
        private System.Windows.Forms.Button registerBtn;
    }
}

