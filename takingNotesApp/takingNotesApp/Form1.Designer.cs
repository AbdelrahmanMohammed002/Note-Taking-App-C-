namespace takingNotesApp
{
    partial class noteTaker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.Label();
            this.previousNotesTable = new System.Windows.Forms.DataGridView();
            this.loadBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newNoteBtn = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.previousNotesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(415, 39);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(373, 23);
            this.titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(415, 91);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(373, 347);
            this.noteBox.TabIndex = 1;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(415, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(373, 27);
            this.title.TabIndex = 2;
            this.title.Text = "Title:";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // note
            // 
            this.note.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.note.Location = new System.Drawing.Point(415, 65);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(373, 23);
            this.note.TabIndex = 3;
            this.note.Text = "Note:";
            this.note.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // previousNotesTable
            // 
            this.previousNotesTable.AllowUserToAddRows = false;
            this.previousNotesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.previousNotesTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.previousNotesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.previousNotesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousNotesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.previousNotesTable.Location = new System.Drawing.Point(12, 9);
            this.previousNotesTable.Name = "previousNotesTable";
            this.previousNotesTable.RowHeadersVisible = false;
            this.previousNotesTable.RowTemplate.Height = 25;
            this.previousNotesTable.Size = new System.Drawing.Size(397, 317);
            this.previousNotesTable.TabIndex = 4;
            this.previousNotesTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousNotesTable_CellDoubleClick);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.White;
            this.loadBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadBtn.Location = new System.Drawing.Point(12, 332);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(188, 52);
            this.loadBtn.TabIndex = 5;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Location = new System.Drawing.Point(206, 332);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(203, 52);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.White;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(206, 390);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(203, 48);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newNoteBtn
            // 
            this.newNoteBtn.BackColor = System.Drawing.Color.White;
            this.newNoteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newNoteBtn.Location = new System.Drawing.Point(12, 390);
            this.newNoteBtn.Name = "newNoteBtn";
            this.newNoteBtn.Size = new System.Drawing.Size(188, 48);
            this.newNoteBtn.TabIndex = 8;
            this.newNoteBtn.Text = "New Note";
            this.newNoteBtn.UseVisualStyleBackColor = false;
            this.newNoteBtn.Click += new System.EventHandler(this.newNoteBtn_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Title";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Note";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // noteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newNoteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.previousNotesTable);
            this.Controls.Add(this.note);
            this.Controls.Add(this.title);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.titleBox);
            this.Name = "noteTaker";
            this.Text = "Note Taking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.noteTaker_FormClosing);
            this.Load += new System.EventHandler(this.noteTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previousNotesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox titleBox;
        private TextBox noteBox;
        private Label title;
        private Label note;
        private DataGridView previousNotesTable;
        private Button loadBtn;
        private Button deleteBtn;
        private Button saveBtn;
        private Button newNoteBtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}