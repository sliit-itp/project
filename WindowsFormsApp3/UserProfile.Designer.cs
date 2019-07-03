namespace WindowsFormsApp3
{
    partial class UserProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.btnViewprof = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditProf = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btnViewprof
            // 
            this.btnViewprof.Activecolor = System.Drawing.Color.DarkGray;
            this.btnViewprof.BackColor = System.Drawing.Color.DarkGray;
            this.btnViewprof.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewprof.BorderRadius = 0;
            this.btnViewprof.ButtonText = "      View Profile";
            this.btnViewprof.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewprof.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewprof.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewprof.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnViewprof.Iconimage")));
            this.btnViewprof.Iconimage_right = null;
            this.btnViewprof.Iconimage_right_Selected = null;
            this.btnViewprof.Iconimage_Selected = null;
            this.btnViewprof.IconZoom = 90D;
            this.btnViewprof.IsTab = false;
            this.btnViewprof.Location = new System.Drawing.Point(0, 0);
            this.btnViewprof.Name = "btnViewprof";
            this.btnViewprof.Normalcolor = System.Drawing.Color.DarkGray;
            this.btnViewprof.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnViewprof.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewprof.selected = false;
            this.btnViewprof.Size = new System.Drawing.Size(200, 53);
            this.btnViewprof.TabIndex = 0;
            this.btnViewprof.Textcolor = System.Drawing.Color.Black;
            this.btnViewprof.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnEditProf
            // 
            this.btnEditProf.Activecolor = System.Drawing.Color.DarkGray;
            this.btnEditProf.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditProf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditProf.BorderRadius = 0;
            this.btnEditProf.ButtonText = "      Edit Profile";
            this.btnEditProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditProf.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditProf.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditProf.Iconimage")));
            this.btnEditProf.Iconimage_right = null;
            this.btnEditProf.Iconimage_right_Selected = null;
            this.btnEditProf.Iconimage_Selected = null;
            this.btnEditProf.IconZoom = 90D;
            this.btnEditProf.IsTab = false;
            this.btnEditProf.Location = new System.Drawing.Point(0, 53);
            this.btnEditProf.Name = "btnEditProf";
            this.btnEditProf.Normalcolor = System.Drawing.Color.DarkGray;
            this.btnEditProf.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnEditProf.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditProf.selected = false;
            this.btnEditProf.Size = new System.Drawing.Size(200, 53);
            this.btnEditProf.TabIndex = 1;
            this.btnEditProf.Textcolor = System.Drawing.Color.Black;
            this.btnEditProf.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLogOut
            // 
            this.btnLogOut.Activecolor = System.Drawing.Color.DarkGray;
            this.btnLogOut.BackColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.ButtonText = "      Log Out";
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Iconimage")));
            this.btnLogOut.Iconimage_right = null;
            this.btnLogOut.Iconimage_right_Selected = null;
            this.btnLogOut.Iconimage_Selected = null;
            this.btnLogOut.IconZoom = 90D;
            this.btnLogOut.IsTab = false;
            this.btnLogOut.Location = new System.Drawing.Point(0, 106);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Normalcolor = System.Drawing.Color.DarkGray;
            this.btnLogOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogOut.selected = false;
            this.btnLogOut.Size = new System.Drawing.Size(200, 59);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Textcolor = System.Drawing.Color.Black;
            this.btnLogOut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnEditProf);
            this.Controls.Add(this.btnViewprof);
            this.Name = "UserProfile";
            this.Size = new System.Drawing.Size(200, 165);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnViewprof;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditProf;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogOut;
    }
}
