namespace WindowsFormsApp2
{
    partial class PizzaOrder
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
            this.makeyourpizza = new System.Windows.Forms.Label();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnresetform = new System.Windows.Forms.Button();
            this.gbtoppinrs = new System.Windows.Forms.GroupBox();
            this.chkonion = new System.Windows.Forms.CheckBox();
            this.chkgreenpeppers = new System.Windows.Forms.CheckBox();
            this.chkolives = new System.Windows.Forms.CheckBox();
            this.chktomatoes = new System.Windows.Forms.CheckBox();
            this.chkmushrooms = new System.Windows.Forms.CheckBox();
            this.chkchees = new System.Windows.Forms.CheckBox();
            this.gbwheretoeat = new System.Windows.Forms.GroupBox();
            this.rbtakeout = new System.Windows.Forms.RadioButton();
            this.rbeatin = new System.Windows.Forms.RadioButton();
            this.gbsize = new System.Windows.Forms.GroupBox();
            this.rblarge = new System.Windows.Forms.RadioButton();
            this.rbmeduim = new System.Windows.Forms.RadioButton();
            this.rbsmall = new System.Windows.Forms.RadioButton();
            this.gbcrusttype = new System.Windows.Forms.GroupBox();
            this.rbthin = new System.Windows.Forms.RadioButton();
            this.rbthink = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPriceTotal = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.rbrecipe = new System.Windows.Forms.GroupBox();
            this.gbtoppinrs.SuspendLayout();
            this.gbwheretoeat.SuspendLayout();
            this.gbsize.SuspendLayout();
            this.gbcrusttype.SuspendLayout();
            this.rbrecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // makeyourpizza
            // 
            this.makeyourpizza.AutoSize = true;
            this.makeyourpizza.BackColor = System.Drawing.Color.PapayaWhip;
            this.makeyourpizza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.makeyourpizza.Font = new System.Drawing.Font("Bernard MT Condensed", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeyourpizza.ForeColor = System.Drawing.Color.DarkRed;
            this.makeyourpizza.Location = new System.Drawing.Point(258, 30);
            this.makeyourpizza.Name = "makeyourpizza";
            this.makeyourpizza.Size = new System.Drawing.Size(353, 50);
            this.makeyourpizza.TabIndex = 6;
            this.makeyourpizza.Text = "Make Your Pizaa :)";
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.Color.Pink;
            this.btnorder.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnorder.Location = new System.Drawing.Point(222, 442);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(149, 47);
            this.btnorder.TabIndex = 8;
            this.btnorder.Text = "Oreder Pizza";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btnresetform
            // 
            this.btnresetform.BackColor = System.Drawing.Color.Pink;
            this.btnresetform.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetform.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnresetform.Location = new System.Drawing.Point(420, 442);
            this.btnresetform.Name = "btnresetform";
            this.btnresetform.Size = new System.Drawing.Size(149, 47);
            this.btnresetform.TabIndex = 9;
            this.btnresetform.Text = "Reset Form";
            this.btnresetform.UseVisualStyleBackColor = false;
            this.btnresetform.Click += new System.EventHandler(this.btnresetform_Click);
            // 
            // gbtoppinrs
            // 
            this.gbtoppinrs.Controls.Add(this.chkonion);
            this.gbtoppinrs.Controls.Add(this.chkgreenpeppers);
            this.gbtoppinrs.Controls.Add(this.chkolives);
            this.gbtoppinrs.Controls.Add(this.chktomatoes);
            this.gbtoppinrs.Controls.Add(this.chkmushrooms);
            this.gbtoppinrs.Controls.Add(this.chkchees);
            this.gbtoppinrs.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtoppinrs.ForeColor = System.Drawing.Color.DarkRed;
            this.gbtoppinrs.Location = new System.Drawing.Point(251, 107);
            this.gbtoppinrs.Name = "gbtoppinrs";
            this.gbtoppinrs.Size = new System.Drawing.Size(343, 151);
            this.gbtoppinrs.TabIndex = 4;
            this.gbtoppinrs.TabStop = false;
            this.gbtoppinrs.Text = "Toppings :";
            // 
            // chkonion
            // 
            this.chkonion.AutoSize = true;
            this.chkonion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkonion.ForeColor = System.Drawing.Color.Black;
            this.chkonion.Location = new System.Drawing.Point(18, 32);
            this.chkonion.Name = "chkonion";
            this.chkonion.Size = new System.Drawing.Size(74, 22);
            this.chkonion.TabIndex = 5;
            this.chkonion.Tag = "15";
            this.chkonion.Text = "Onion";
            this.chkonion.UseVisualStyleBackColor = true;
            this.chkonion.CheckedChanged += new System.EventHandler(this.chkonion_CheckedChanged);
            // 
            // chkgreenpeppers
            // 
            this.chkgreenpeppers.AutoSize = true;
            this.chkgreenpeppers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkgreenpeppers.ForeColor = System.Drawing.Color.Black;
            this.chkgreenpeppers.Location = new System.Drawing.Point(139, 63);
            this.chkgreenpeppers.Name = "chkgreenpeppers";
            this.chkgreenpeppers.Size = new System.Drawing.Size(140, 22);
            this.chkgreenpeppers.TabIndex = 4;
            this.chkgreenpeppers.Tag = "5";
            this.chkgreenpeppers.Text = "Green Peppers";
            this.chkgreenpeppers.UseVisualStyleBackColor = true;
            this.chkgreenpeppers.CheckedChanged += new System.EventHandler(this.chkgreenpeppers_CheckedChanged);
            // 
            // chkolives
            // 
            this.chkolives.AutoSize = true;
            this.chkolives.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkolives.ForeColor = System.Drawing.Color.Black;
            this.chkolives.Location = new System.Drawing.Point(18, 63);
            this.chkolives.Name = "chkolives";
            this.chkolives.Size = new System.Drawing.Size(78, 22);
            this.chkolives.TabIndex = 3;
            this.chkolives.Tag = "15";
            this.chkolives.Text = "Olives";
            this.chkolives.UseVisualStyleBackColor = true;
            this.chkolives.CheckedChanged += new System.EventHandler(this.chkolives_CheckedChanged);
            // 
            // chktomatoes
            // 
            this.chktomatoes.AutoSize = true;
            this.chktomatoes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chktomatoes.ForeColor = System.Drawing.Color.Black;
            this.chktomatoes.Location = new System.Drawing.Point(18, 94);
            this.chktomatoes.Name = "chktomatoes";
            this.chktomatoes.Size = new System.Drawing.Size(102, 22);
            this.chktomatoes.TabIndex = 2;
            this.chktomatoes.Tag = "10";
            this.chktomatoes.Text = "Tomatoes";
            this.chktomatoes.UseVisualStyleBackColor = true;
            this.chktomatoes.CheckedChanged += new System.EventHandler(this.chktomatoes_CheckedChanged);
            // 
            // chkmushrooms
            // 
            this.chkmushrooms.AutoSize = true;
            this.chkmushrooms.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkmushrooms.ForeColor = System.Drawing.Color.Black;
            this.chkmushrooms.Location = new System.Drawing.Point(139, 94);
            this.chkmushrooms.Name = "chkmushrooms";
            this.chkmushrooms.Size = new System.Drawing.Size(115, 22);
            this.chkmushrooms.TabIndex = 1;
            this.chkmushrooms.Tag = "30";
            this.chkmushrooms.Text = "Mushrooms";
            this.chkmushrooms.UseVisualStyleBackColor = true;
            this.chkmushrooms.CheckedChanged += new System.EventHandler(this.chkmushrooms_CheckedChanged);
            // 
            // chkchees
            // 
            this.chkchees.AutoSize = true;
            this.chkchees.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkchees.ForeColor = System.Drawing.Color.Black;
            this.chkchees.Location = new System.Drawing.Point(139, 32);
            this.chkchees.Name = "chkchees";
            this.chkchees.Size = new System.Drawing.Size(119, 22);
            this.chkchees.TabIndex = 0;
            this.chkchees.Tag = "20";
            this.chkchees.Text = "Extra Chees";
            this.chkchees.UseVisualStyleBackColor = true;
            this.chkchees.CheckedChanged += new System.EventHandler(this.chkchees_CheckedChanged);
            // 
            // gbwheretoeat
            // 
            this.gbwheretoeat.Controls.Add(this.rbtakeout);
            this.gbwheretoeat.Controls.Add(this.rbeatin);
            this.gbwheretoeat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbwheretoeat.ForeColor = System.Drawing.Color.DarkRed;
            this.gbwheretoeat.Location = new System.Drawing.Point(251, 281);
            this.gbwheretoeat.Name = "gbwheretoeat";
            this.gbwheretoeat.Size = new System.Drawing.Size(254, 78);
            this.gbwheretoeat.TabIndex = 5;
            this.gbwheretoeat.TabStop = false;
            this.gbwheretoeat.Text = "Where To Eat ? ";
            // 
            // rbtakeout
            // 
            this.rbtakeout.AutoSize = true;
            this.rbtakeout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtakeout.ForeColor = System.Drawing.Color.Black;
            this.rbtakeout.Location = new System.Drawing.Point(139, 30);
            this.rbtakeout.Name = "rbtakeout";
            this.rbtakeout.Size = new System.Drawing.Size(96, 22);
            this.rbtakeout.TabIndex = 1;
            this.rbtakeout.TabStop = true;
            this.rbtakeout.Tag = "5";
            this.rbtakeout.Text = "Take Out";
            this.rbtakeout.UseVisualStyleBackColor = true;
            this.rbtakeout.CheckedChanged += new System.EventHandler(this.rbtakeout_CheckedChanged);
            // 
            // rbeatin
            // 
            this.rbeatin.AutoSize = true;
            this.rbeatin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbeatin.ForeColor = System.Drawing.Color.Black;
            this.rbeatin.Location = new System.Drawing.Point(18, 30);
            this.rbeatin.Name = "rbeatin";
            this.rbeatin.Size = new System.Drawing.Size(73, 22);
            this.rbeatin.TabIndex = 0;
            this.rbeatin.TabStop = true;
            this.rbeatin.Tag = "20";
            this.rbeatin.Text = "Eat In";
            this.rbeatin.UseVisualStyleBackColor = true;
            this.rbeatin.CheckedChanged += new System.EventHandler(this.rbeatin_CheckedChanged);
            // 
            // gbsize
            // 
            this.gbsize.Controls.Add(this.rblarge);
            this.gbsize.Controls.Add(this.rbmeduim);
            this.gbsize.Controls.Add(this.rbsmall);
            this.gbsize.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsize.ForeColor = System.Drawing.Color.DarkRed;
            this.gbsize.Location = new System.Drawing.Point(12, 107);
            this.gbsize.Name = "gbsize";
            this.gbsize.Size = new System.Drawing.Size(193, 151);
            this.gbsize.TabIndex = 3;
            this.gbsize.TabStop = false;
            this.gbsize.Text = "Size :";
            // 
            // rblarge
            // 
            this.rblarge.AutoSize = true;
            this.rblarge.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblarge.ForeColor = System.Drawing.Color.Black;
            this.rblarge.Location = new System.Drawing.Point(18, 97);
            this.rblarge.Name = "rblarge";
            this.rblarge.Size = new System.Drawing.Size(72, 22);
            this.rblarge.TabIndex = 2;
            this.rblarge.TabStop = true;
            this.rblarge.Tag = "30";
            this.rblarge.Text = "Large";
            this.rblarge.UseVisualStyleBackColor = true;
            this.rblarge.CheckedChanged += new System.EventHandler(this.rblarge_CheckedChanged);
            // 
            // rbmeduim
            // 
            this.rbmeduim.AutoSize = true;
            this.rbmeduim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmeduim.ForeColor = System.Drawing.Color.Black;
            this.rbmeduim.Location = new System.Drawing.Point(18, 63);
            this.rbmeduim.Name = "rbmeduim";
            this.rbmeduim.Size = new System.Drawing.Size(87, 22);
            this.rbmeduim.TabIndex = 1;
            this.rbmeduim.TabStop = true;
            this.rbmeduim.Tag = "20";
            this.rbmeduim.Text = "Meduim";
            this.rbmeduim.UseVisualStyleBackColor = true;
            this.rbmeduim.CheckedChanged += new System.EventHandler(this.rbmeduim_CheckedChanged);
            // 
            // rbsmall
            // 
            this.rbsmall.AutoSize = true;
            this.rbsmall.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsmall.ForeColor = System.Drawing.Color.Black;
            this.rbsmall.Location = new System.Drawing.Point(18, 32);
            this.rbsmall.Name = "rbsmall";
            this.rbsmall.Size = new System.Drawing.Size(71, 22);
            this.rbsmall.TabIndex = 0;
            this.rbsmall.TabStop = true;
            this.rbsmall.Tag = "10";
            this.rbsmall.Text = "Small";
            this.rbsmall.UseVisualStyleBackColor = true;
            this.rbsmall.CheckedChanged += new System.EventHandler(this.rbsmall_CheckedChanged);
            // 
            // gbcrusttype
            // 
            this.gbcrusttype.Controls.Add(this.rbthin);
            this.gbcrusttype.Controls.Add(this.rbthink);
            this.gbcrusttype.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbcrusttype.ForeColor = System.Drawing.Color.DarkRed;
            this.gbcrusttype.Location = new System.Drawing.Point(12, 281);
            this.gbcrusttype.Name = "gbcrusttype";
            this.gbcrusttype.Size = new System.Drawing.Size(193, 126);
            this.gbcrusttype.TabIndex = 4;
            this.gbcrusttype.TabStop = false;
            this.gbcrusttype.Text = "Crust Type :";
            // 
            // rbthin
            // 
            this.rbthin.AutoSize = true;
            this.rbthin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbthin.ForeColor = System.Drawing.Color.Black;
            this.rbthin.Location = new System.Drawing.Point(18, 42);
            this.rbthin.Name = "rbthin";
            this.rbthin.Size = new System.Drawing.Size(105, 22);
            this.rbthin.TabIndex = 4;
            this.rbthin.TabStop = true;
            this.rbthin.Tag = "10";
            this.rbthin.Text = "Thin Crust";
            this.rbthin.UseVisualStyleBackColor = true;
            this.rbthin.CheckedChanged += new System.EventHandler(this.rbthin_CheckedChanged);
            // 
            // rbthink
            // 
            this.rbthink.AutoSize = true;
            this.rbthink.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbthink.ForeColor = System.Drawing.Color.Black;
            this.rbthink.Location = new System.Drawing.Point(18, 73);
            this.rbthink.Name = "rbthink";
            this.rbthink.Size = new System.Drawing.Size(114, 22);
            this.rbthink.TabIndex = 3;
            this.rbthink.TabStop = true;
            this.rbthink.Tag = "25";
            this.rbthink.Text = "Think Crust";
            this.rbthink.UseVisualStyleBackColor = true;
            this.rbthink.CheckedChanged += new System.EventHandler(this.rbthink_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Size :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Toppings :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(25, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Crust Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(25, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Where To Eat :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(66, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Price :";
            // 
            // lblPriceTotal
            // 
            this.lblPriceTotal.AutoSize = true;
            this.lblPriceTotal.BackColor = System.Drawing.Color.DarkRed;
            this.lblPriceTotal.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblPriceTotal.Location = new System.Drawing.Point(53, 324);
            this.lblPriceTotal.Name = "lblPriceTotal";
            this.lblPriceTotal.Size = new System.Drawing.Size(106, 72);
            this.lblPriceTotal.TabIndex = 16;
            this.lblPriceTotal.Text = "$0";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.DarkRed;
            this.lblSize.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSize.Location = new System.Drawing.Point(87, 73);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(17, 21);
            this.lblSize.TabIndex = 17;
            this.lblSize.Text = "-";
            this.lblSize.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.BackColor = System.Drawing.Color.DarkRed;
            this.lblToppings.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblToppings.Location = new System.Drawing.Point(25, 151);
            this.lblToppings.MaximumSize = new System.Drawing.Size(220, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(17, 21);
            this.lblToppings.TabIndex = 18;
            this.lblToppings.Text = "-";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.BackColor = System.Drawing.Color.DarkRed;
            this.lblCrustType.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCrustType.Location = new System.Drawing.Point(143, 223);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(17, 21);
            this.lblCrustType.TabIndex = 19;
            this.lblCrustType.Text = "-";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.BackColor = System.Drawing.Color.DarkRed;
            this.lblWhereToEat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWhereToEat.Location = new System.Drawing.Point(165, 265);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(17, 21);
            this.lblWhereToEat.TabIndex = 20;
            this.lblWhereToEat.Text = "-";
            // 
            // rbrecipe
            // 
            this.rbrecipe.BackColor = System.Drawing.Color.DarkRed;
            this.rbrecipe.Controls.Add(this.lblWhereToEat);
            this.rbrecipe.Controls.Add(this.lblCrustType);
            this.rbrecipe.Controls.Add(this.lblToppings);
            this.rbrecipe.Controls.Add(this.lblSize);
            this.rbrecipe.Controls.Add(this.lblPriceTotal);
            this.rbrecipe.Controls.Add(this.label6);
            this.rbrecipe.Controls.Add(this.label5);
            this.rbrecipe.Controls.Add(this.label4);
            this.rbrecipe.Controls.Add(this.label3);
            this.rbrecipe.Controls.Add(this.label2);
            this.rbrecipe.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbrecipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbrecipe.Location = new System.Drawing.Point(618, 101);
            this.rbrecipe.Name = "rbrecipe";
            this.rbrecipe.Size = new System.Drawing.Size(244, 426);
            this.rbrecipe.TabIndex = 21;
            this.rbrecipe.TabStop = false;
            this.rbrecipe.Text = "Recipe :";
            // 
            // PizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._193069428608041e144192f4c52231f1;
            this.ClientSize = new System.Drawing.Size(874, 552);
            this.Controls.Add(this.rbrecipe);
            this.Controls.Add(this.gbcrusttype);
            this.Controls.Add(this.btnresetform);
            this.Controls.Add(this.gbwheretoeat);
            this.Controls.Add(this.gbsize);
            this.Controls.Add(this.gbtoppinrs);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.makeyourpizza);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PizzaOrder";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.PizzaOrder_Load);
            this.gbtoppinrs.ResumeLayout(false);
            this.gbtoppinrs.PerformLayout();
            this.gbwheretoeat.ResumeLayout(false);
            this.gbwheretoeat.PerformLayout();
            this.gbsize.ResumeLayout(false);
            this.gbsize.PerformLayout();
            this.gbcrusttype.ResumeLayout(false);
            this.gbcrusttype.PerformLayout();
            this.rbrecipe.ResumeLayout(false);
            this.rbrecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label makeyourpizza;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnresetform;
        private System.Windows.Forms.GroupBox gbtoppinrs;
        private System.Windows.Forms.CheckBox chkonion;
        private System.Windows.Forms.CheckBox chkgreenpeppers;
        private System.Windows.Forms.CheckBox chkolives;
        private System.Windows.Forms.CheckBox chktomatoes;
        private System.Windows.Forms.CheckBox chkmushrooms;
        private System.Windows.Forms.CheckBox chkchees;
        private System.Windows.Forms.GroupBox gbwheretoeat;
        private System.Windows.Forms.RadioButton rbtakeout;
        private System.Windows.Forms.RadioButton rbeatin;
        private System.Windows.Forms.GroupBox gbsize;
        private System.Windows.Forms.RadioButton rblarge;
        private System.Windows.Forms.RadioButton rbmeduim;
        private System.Windows.Forms.RadioButton rbsmall;
        private System.Windows.Forms.GroupBox gbcrusttype;
        private System.Windows.Forms.RadioButton rbthin;
        private System.Windows.Forms.RadioButton rbthink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPriceTotal;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.GroupBox rbrecipe;
    }
}

