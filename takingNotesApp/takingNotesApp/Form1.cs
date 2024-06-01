using System.Data;
using System.Collections.Generic;

namespace takingNotesApp
{
    public partial class noteTaker : Form
    {

        DataTable notes = new DataTable();

        bool editing = false;
        
      
        public noteTaker()
        {
            InitializeComponent();
        }

        private void noteTaker_Load(object sender, EventArgs e)
        {
            /*
             Making the column of the data table
             */
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            /*
                1) the "using" function makes an stream reader and closes it automatically
                2) store the data of the line in the file "notes.txt" in the array "fields" and split it by ','
                3) making a DataRow "row" in the datatable "notes" 
                4) copy the values in the array "fields" to the datarow "row" through a for loop
                5) add the datarow "row" to the datatable "notes"
             */
            using (StreamReader sr = new StreamReader("notes.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    DataRow row = notes.NewRow();
                    for (int i=0; i< fields.Length-1; i++)
                    {
                        row[i] = fields[i].Trim();
                    }
                    notes.Rows.Add(row);
                }
            }

            /*
             assign the columns of datagrid "previousNotesTable" column to the dataTable "notes" columns
             */
            previousNotesTable.Columns[0].DataPropertyName = notes.Columns[0].ColumnName;
            previousNotesTable.Columns[1].DataPropertyName = notes.Columns[1].ColumnName;

            /*
             put the data in the datatable (notes) to the grid (previousNotesTable)
             */
            previousNotesTable.DataSource = notes;


        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            /*
             if the user clicked on a cell in the grid (previousNotesTable)
                1) we get the index of the cell clicked, reference it in the dataTable (notes) 
                2) put the note into the textbox (titleBox) and (noteBox).
                3) enable editing to true.
             */

            titleBox.Text = notes.Rows[previousNotesTable.CurrentCell.RowIndex].ItemArray[0]?.ToString();
            noteBox.Text = notes.Rows[previousNotesTable.CurrentCell.RowIndex].ItemArray[1]?.ToString();
            editing = true;
        }

        /*
         when the delete is clicked:
            it removes the note form the datagrid "previousNotesTable" and from the datatable "notes"
         */
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows.Remove(notes.Rows[previousNotesTable.CurrentCell.RowIndex]);
                

            }catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /*
         the next function clears the text boxes to make a new note
         */
        private void newNoteBtn_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";

        }
        /*
         the next function have to modes:
        1) the note in the text boxes is already exists and is being edited
        2) the note is a new one and you want to save it with the other notes
        then it clears the text boxes
         */
        private void saveBtn_Click(object sender, EventArgs e)
        {
           
            if (editing)
            {
                notes.Rows[previousNotesTable.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notes.Rows[previousNotesTable.CurrentCell.RowIndex]["Note"] = noteBox.Text;
            }
            else
            {
                notes.Rows.Add(titleBox.Text, noteBox.Text);
            }
            editing = false;
            titleBox.Text = "";
            noteBox.Text = "";
            
        }

        //the next function deos the same as load function
        private void previousNotesTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                titleBox.Text = notes.Rows[previousNotesTable.CurrentCell.RowIndex].ItemArray[0]?.ToString();
                noteBox.Text = notes.Rows[previousNotesTable.CurrentCell.RowIndex].ItemArray[1]?.ToString();
                editing = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        // the next function works when you close the app
        /*
         so it prints the datatable "notes" to the text file "notes.txt"
         */
        private void noteTaker_FormClosing(object sender, FormClosingEventArgs e)
        {
            using(StreamWriter sw = new StreamWriter("notes.txt", false))
            {
                foreach(DataRow row in notes.Rows)
                {
                    for (int i=0; i< notes.Columns.Count; i++)
                    {
                        sw.Write(row[i].ToString() + ',');
                    }
                    sw.WriteLine();
                }
            }
        }
    }
}