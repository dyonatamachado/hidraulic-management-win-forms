namespace TesteLogicaMastersul
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sensor1Label = new System.Windows.Forms.Label();
            this.sensor1Input = new System.Windows.Forms.TextBox();
            this.sensor2Label = new System.Windows.Forms.Label();
            this.sensor2Input = new System.Windows.Forms.TextBox();
            this.sensor3Label = new System.Windows.Forms.Label();
            this.sensor3Input = new System.Windows.Forms.TextBox();
            this.sensor4Label = new System.Windows.Forms.Label();
            this.sensor4Input = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.valvula1Label = new System.Windows.Forms.Label();
            this.valvula1Value = new System.Windows.Forms.Label();
            this.bomba1Label = new System.Windows.Forms.Label();
            this.bomba1Value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sensor1Label
            // 
            this.sensor1Label.AutoSize = true;
            this.sensor1Label.Location = new System.Drawing.Point(49, 66);
            this.sensor1Label.Name = "sensor1Label";
            this.sensor1Label.Size = new System.Drawing.Size(65, 20);
            this.sensor1Label.TabIndex = 0;
            this.sensor1Label.Text = "Sensor 1";
            // 
            // sensor1Input
            // 
            this.sensor1Input.Location = new System.Drawing.Point(120, 63);
            this.sensor1Input.Name = "sensor1Input";
            this.sensor1Input.Size = new System.Drawing.Size(80, 27);
            this.sensor1Input.TabIndex = 1;
            this.sensor1Input.TextChanged += new System.EventHandler(this.sensor1Input_TextChanged);
            this.sensor1Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sensor1Input_KeyPress);
            // 
            // sensor2Label
            // 
            this.sensor2Label.AutoSize = true;
            this.sensor2Label.Location = new System.Drawing.Point(49, 110);
            this.sensor2Label.Name = "sensor2Label";
            this.sensor2Label.Size = new System.Drawing.Size(65, 20);
            this.sensor2Label.TabIndex = 2;
            this.sensor2Label.Text = "Sensor 2";
            // 
            // sensor2Input
            // 
            this.sensor2Input.Location = new System.Drawing.Point(120, 107);
            this.sensor2Input.Name = "sensor2Input";
            this.sensor2Input.Size = new System.Drawing.Size(80, 27);
            this.sensor2Input.TabIndex = 3;
            this.sensor2Input.TextChanged += new System.EventHandler(this.sensor2Input_TextChanged);
            this.sensor2Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sensor2Input_KeyPress);
            // 
            // sensor3Label
            // 
            this.sensor3Label.AutoSize = true;
            this.sensor3Label.Location = new System.Drawing.Point(49, 154);
            this.sensor3Label.Name = "sensor3Label";
            this.sensor3Label.Size = new System.Drawing.Size(65, 20);
            this.sensor3Label.TabIndex = 4;
            this.sensor3Label.Text = "Sensor 3";
            // 
            // sensor3Input
            // 
            this.sensor3Input.Location = new System.Drawing.Point(120, 151);
            this.sensor3Input.Name = "sensor3Input";
            this.sensor3Input.Size = new System.Drawing.Size(80, 27);
            this.sensor3Input.TabIndex = 5;
            this.sensor3Input.TextChanged += new System.EventHandler(this.sensor3Input_TextChanged);
            this.sensor3Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sensor3Input_KeyPress);
            // 
            // sensor4Label
            // 
            this.sensor4Label.AutoSize = true;
            this.sensor4Label.Location = new System.Drawing.Point(49, 198);
            this.sensor4Label.Name = "sensor4Label";
            this.sensor4Label.Size = new System.Drawing.Size(65, 20);
            this.sensor4Label.TabIndex = 6;
            this.sensor4Label.Text = "Sensor 4";
            // 
            // sensor4Input
            // 
            this.sensor4Input.Location = new System.Drawing.Point(120, 195);
            this.sensor4Input.Name = "sensor4Input";
            this.sensor4Input.Size = new System.Drawing.Size(80, 27);
            this.sensor4Input.TabIndex = 7;
            this.sensor4Input.TextChanged += new System.EventHandler(this.sensor4Input_TextChanged);
            this.sensor4Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sensor4Input_KeyPress);
            // 
            // sendBtn
            // 
            this.sendBtn.Enabled = false;
            this.sendBtn.Location = new System.Drawing.Point(258, 63);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(317, 27);
            this.sendBtn.TabIndex = 8;
            this.sendBtn.Text = "Enviar dados";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // valvula1Label
            // 
            this.valvula1Label.AutoSize = true;
            this.valvula1Label.Location = new System.Drawing.Point(330, 136);
            this.valvula1Label.Name = "valvula1Label";
            this.valvula1Label.Size = new System.Drawing.Size(68, 20);
            this.valvula1Label.TabIndex = 9;
            this.valvula1Label.Text = "Válvula 1";
            // 
            // valvula1Value
            // 
            this.valvula1Value.AutoSize = true;
            this.valvula1Value.Location = new System.Drawing.Point(429, 136);
            this.valvula1Value.Name = "valvula1Value";
            this.valvula1Value.Size = new System.Drawing.Size(64, 20);
            this.valvula1Value.TabIndex = 10;
            this.valvula1Value.Text = "Fechada";
            // 
            // bomba1Label
            // 
            this.bomba1Label.AutoSize = true;
            this.bomba1Label.Location = new System.Drawing.Point(330, 181);
            this.bomba1Label.Name = "bomba1Label";
            this.bomba1Label.Size = new System.Drawing.Size(69, 20);
            this.bomba1Label.TabIndex = 9;
            this.bomba1Label.Text = "Bomba 1";
            // 
            // bomba1Value
            // 
            this.bomba1Value.AutoSize = true;
            this.bomba1Value.Location = new System.Drawing.Point(429, 181);
            this.bomba1Value.Name = "bomba1Value";
            this.bomba1Value.Size = new System.Drawing.Size(76, 20);
            this.bomba1Value.TabIndex = 10;
            this.bomba1Value.Text = "Desligada";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 300);
            this.Controls.Add(this.bomba1Value);
            this.Controls.Add(this.bomba1Label);
            this.Controls.Add(this.valvula1Value);
            this.Controls.Add(this.valvula1Label);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.sensor4Input);
            this.Controls.Add(this.sensor4Label);
            this.Controls.Add(this.sensor3Input);
            this.Controls.Add(this.sensor3Label);
            this.Controls.Add(this.sensor2Input);
            this.Controls.Add(this.sensor2Label);
            this.Controls.Add(this.sensor1Input);
            this.Controls.Add(this.sensor1Label);
            this.Name = "Main";
            this.Text = "Controle Hidráulico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label sensor1Label;
        private TextBox sensor1Input;
        private Label sensor2Label;
        private TextBox sensor2Input;
        private Label sensor3Label;
        private TextBox sensor3Input;
        private Label sensor4Label;
        private TextBox sensor4Input;
        private Button sendBtn;
        private Label valvula1Label;
        private Label valvula1Value;
        private Label bomba1Label;
        private Label bomba1Value;
    }
}