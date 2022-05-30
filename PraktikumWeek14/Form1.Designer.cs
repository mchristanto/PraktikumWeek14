namespace PraktikumWeek14
{
    partial class FormTeam
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
            this.dgvTeam = new System.Windows.Forms.DataGridView();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWorstDicipline = new System.Windows.Forms.Label();
            this.lblStadiumIsi = new System.Windows.Forms.Label();
            this.lblManagerIsi = new System.Windows.Forms.Label();
            this.lblWorstDiciplineIsi = new System.Windows.Forms.Label();
            this.lblTopScorerIsi = new System.Windows.Forms.Label();
            this.lblTopScorer = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.lblTeamNameIsi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeam
            // 
            this.dgvTeam.Location = new System.Drawing.Point(12, 175);
            this.dgvTeam.Name = "dgvTeam";
            this.dgvTeam.Size = new System.Drawing.Size(436, 165);
            this.dgvTeam.TabIndex = 0;
            this.dgvTeam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeam_CellContentClick);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(13, 13);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(59, 37);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(78, 13);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(59, 37);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(143, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(59, 37);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(208, 12);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(59, 37);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(13, 57);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(68, 13);
            this.lblTeamName.TabIndex = 5;
            this.lblTeamName.Text = "Team Name:";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(13, 79);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(52, 13);
            this.lblManager.TabIndex = 6;
            this.lblManager.Text = "Manager:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // lblWorstDicipline
            // 
            this.lblWorstDicipline.AutoSize = true;
            this.lblWorstDicipline.Location = new System.Drawing.Point(13, 146);
            this.lblWorstDicipline.Name = "lblWorstDicipline";
            this.lblWorstDicipline.Size = new System.Drawing.Size(81, 13);
            this.lblWorstDicipline.TabIndex = 9;
            this.lblWorstDicipline.Text = "Worst Dicipline:";
            // 
            // lblStadiumIsi
            // 
            this.lblStadiumIsi.AutoSize = true;
            this.lblStadiumIsi.Location = new System.Drawing.Point(102, 101);
            this.lblStadiumIsi.Name = "lblStadiumIsi";
            this.lblStadiumIsi.Size = new System.Drawing.Size(16, 13);
            this.lblStadiumIsi.TabIndex = 10;
            this.lblStadiumIsi.Text = "...";
            // 
            // lblManagerIsi
            // 
            this.lblManagerIsi.AutoSize = true;
            this.lblManagerIsi.Location = new System.Drawing.Point(102, 79);
            this.lblManagerIsi.Name = "lblManagerIsi";
            this.lblManagerIsi.Size = new System.Drawing.Size(16, 13);
            this.lblManagerIsi.TabIndex = 11;
            this.lblManagerIsi.Text = "...";
            // 
            // lblWorstDiciplineIsi
            // 
            this.lblWorstDiciplineIsi.AutoSize = true;
            this.lblWorstDiciplineIsi.Location = new System.Drawing.Point(102, 146);
            this.lblWorstDiciplineIsi.Name = "lblWorstDiciplineIsi";
            this.lblWorstDiciplineIsi.Size = new System.Drawing.Size(16, 13);
            this.lblWorstDiciplineIsi.TabIndex = 12;
            this.lblWorstDiciplineIsi.Text = "...";
            // 
            // lblTopScorerIsi
            // 
            this.lblTopScorerIsi.AutoSize = true;
            this.lblTopScorerIsi.Location = new System.Drawing.Point(102, 124);
            this.lblTopScorerIsi.Name = "lblTopScorerIsi";
            this.lblTopScorerIsi.Size = new System.Drawing.Size(16, 13);
            this.lblTopScorerIsi.TabIndex = 13;
            this.lblTopScorerIsi.Text = "...";
            // 
            // lblTopScorer
            // 
            this.lblTopScorer.AutoSize = true;
            this.lblTopScorer.Location = new System.Drawing.Point(13, 124);
            this.lblTopScorer.Name = "lblTopScorer";
            this.lblTopScorer.Size = new System.Drawing.Size(63, 13);
            this.lblTopScorer.TabIndex = 14;
            this.lblTopScorer.Text = "Top Scorer:";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(13, 101);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(48, 13);
            this.lblStadium.TabIndex = 15;
            this.lblStadium.Text = "Stadium:";
            // 
            // lblTeamNameIsi
            // 
            this.lblTeamNameIsi.AutoSize = true;
            this.lblTeamNameIsi.Location = new System.Drawing.Point(102, 57);
            this.lblTeamNameIsi.Name = "lblTeamNameIsi";
            this.lblTeamNameIsi.Size = new System.Drawing.Size(16, 13);
            this.lblTeamNameIsi.TabIndex = 16;
            this.lblTeamNameIsi.Text = "...";
            // 
            // FormTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 352);
            this.Controls.Add(this.lblTeamNameIsi);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lblTopScorer);
            this.Controls.Add(this.lblTopScorerIsi);
            this.Controls.Add(this.lblWorstDiciplineIsi);
            this.Controls.Add(this.lblManagerIsi);
            this.Controls.Add(this.lblStadiumIsi);
            this.Controls.Add(this.lblWorstDicipline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.dgvTeam);
            this.Name = "FormTeam";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.FormTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeam;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWorstDicipline;
        private System.Windows.Forms.Label lblStadiumIsi;
        private System.Windows.Forms.Label lblManagerIsi;
        private System.Windows.Forms.Label lblWorstDiciplineIsi;
        private System.Windows.Forms.Label lblTopScorerIsi;
        private System.Windows.Forms.Label lblTopScorer;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label lblTeamNameIsi;
    }
}

