
namespace StudentResidence.Views
{
    partial class RoomForm
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
            this.btnApply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numNumberOfRoom = new System.Windows.Forms.NumericUpDown();
            this.numSeatsCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeatsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(92, 185);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(167, 43);
            this.btnApply.TabIndex = 13;
            this.btnApply.Text = "ОК";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label3.Location = new System.Drawing.Point(23, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Количество мест:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Номер комнаты:";
            // 
            // numNumberOfRoom
            // 
            this.numNumberOfRoom.Location = new System.Drawing.Point(169, 77);
            this.numNumberOfRoom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNumberOfRoom.Name = "numNumberOfRoom";
            this.numNumberOfRoom.Size = new System.Drawing.Size(147, 20);
            this.numNumberOfRoom.TabIndex = 20;
            // 
            // numSeatsCount
            // 
            this.numSeatsCount.Location = new System.Drawing.Point(169, 104);
            this.numSeatsCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSeatsCount.Name = "numSeatsCount";
            this.numSeatsCount.Size = new System.Drawing.Size(147, 20);
            this.numSeatsCount.TabIndex = 21;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 290);
            this.Controls.Add(this.numSeatsCount);
            this.Controls.Add(this.numNumberOfRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnApply);
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Редактирование комнат";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoomForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeatsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numNumberOfRoom;
        private System.Windows.Forms.NumericUpDown numSeatsCount;
    }
}