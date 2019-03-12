using Equin.ApplicationFramework;
using Slooier_voorraad.Classes;
using Slooier_voorraad.Classes.CommonFunctions;
using Slooier_voorraad.Classes.CustomMessageBox;
using Slooier_voorraad.Classes.StartingScreenFunctions;
using System;
using System.Collections.Generic;
//using System.Drawing;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms
{
  public partial class Voorraad : Form
  {
    string ConnString;

    List<MagazijnItems> ListMagazijnItems = new List<MagazijnItems>();
    List<BestelItems> ListBestelItems = new List<BestelItems>();
    public Voorraad()
    {
      InitializeComponent();
      this.ConnString = Properties.Settings.Default.DBConnectionString;
    }

    private void Voorraad_Shown(object sender, EventArgs e)
    {
      GetVoorraad();
    }

    private void GetVoorraad()
    {
      ListMagazijnItems = CommonFunctions.GetMagazijnItems(ListMagazijnItems, ConnString);
      BindingListView<MagazijnItems> view = new BindingListView<MagazijnItems>(ListMagazijnItems);
      DgvVoorraad.EndEdit();
      DgvVoorraad.DataSource = view;
      DgvVoorraad.Refresh();
    }

    private void Voorraad_Load(object sender, EventArgs e)
    {
      MinimumSize = new System.Drawing.Size(Properties.Settings.Default.MinimumSizeX, Properties.Settings.Default.MinimumSizeY);
      BackColor = Properties.Settings.Default.BackGroundColor;
    }

    private void BtnRefresh_Click(object sender, EventArgs e)
    {
      GetVoorraad();
    }

    private void DgvVoorraad_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      foreach (DataGridViewColumn column in DgvVoorraad.Columns)
      {
        column.ReadOnly = true;
      }
      DgvVoorraad.Columns["Bestellen"].ReadOnly = false;
    }



    ////// Implementing search function
    private int MatchesFound = 0;
    private int CurrentRowIndex = 0;
    private bool MatchFound = false;
    private DataGridViewCellStyle ResetCellStyle = new DataGridViewCellStyle();
    private DataGridViewCellStyle FoundMatchCellStyle = new DataGridViewCellStyle();

    // Set findmatches to false to allow user to stop searching at current match
    // set findmatches to true to highlight all found results
    private bool FindAllMatches = false;

    private void BtnSearch_Click(object sender, EventArgs e)
    {
      string UserInput = TxbSearch.Text;

      // Check the input
      if (string.IsNullOrWhiteSpace(UserInput))
      {
        FlexibleMessageBox.Show("Geen waarde ingevuld om naar te zoeken!", "Ongeldige invoerwaarde!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      if (UserInput.Length < 3)
      {
        FlexibleMessageBox.Show("De zoekopdracht is te kort.\nProbeer een langere zoekopdracht.", "Zoekopdracht Te Kort!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      Cursor.Current = Cursors.WaitCursor;
      BtnSearch.Enabled = false;

      // Reset variables
      CurrentRowIndex = DgvVoorraad.CurrentRow.Index;
      MatchFound = false;
      ResetCellStyle.BackColor = System.Drawing.Color.White;
      FoundMatchCellStyle.BackColor = System.Drawing.Color.Yellow;

      // Select current row
      DgvVoorraad.ClearSelection();
      DgvVoorraad.Rows[CurrentRowIndex].Selected = true;

      // If a previous search has returned some results
      if (MatchesFound > 0)
      {
        for (int RowIndex = 0; RowIndex < DgvVoorraad.Rows.Count; RowIndex++)
        {
          foreach (DataGridViewCell CellValue in DgvVoorraad.Rows[RowIndex].Cells)
          {
            CellValue.Style = ResetCellStyle;
          }
        }
      }
      // reset matches found
      MatchesFound = 0;

      // Start searching DGV
      SearchDGV(0, DgvVoorraad.Rows.Count, UserInput);

      // Display message depending on the amount of matches found
      if (MatchFound == false)
      {
        FlexibleMessageBox.Show("De opgegeven waarde is niet gevonden.", "Niet gevonden");
      }
      else
      {
        FlexibleMessageBox.Show(MatchesFound + " overeenkomst(en) gevonden", "Gevonden Overeenkomsten");
      }
      BtnSearch.Enabled = true;
      Cursor.Current = Cursors.Default;
    }

    private void SearchDGV(int StartIndex, int EndIndex, string SearchString)
    {
      // Iterate through DGV rows, from StartIndex to EndIndex of DGV
      for (int RowIndex = StartIndex; RowIndex < EndIndex; RowIndex++)
      {
        bool MatchFoundInCell = false;

        // Iterate through each cell of current row (RowIndex) and check for a match
        foreach (DataGridViewCell CellValue in DgvVoorraad.Rows[RowIndex].Cells)
        {
          // Ignore checkboxes
          if (CellValue.GetType() == typeof(DataGridViewCheckBoxCell))
          {
            continue;
          }
          // If match is found, set matchFoundInCell to true;
          if (CellValue.Value.ToString().ToLower().Contains(SearchString.ToLower()))
          {
            if (CellValue.Visible == true)
            {
              MatchFoundInCell = true;
            }
          }
        }
        // Highlight each cell in a row if it a match was found
        if (MatchFoundInCell == true)
        {
          MatchFound = true;
          MatchesFound += 1;

          // Change cell BackGround Color
          foreach (DataGridViewCell CellValue in DgvVoorraad.Rows[RowIndex].Cells)
          {
            CellValue.Style = FoundMatchCellStyle;
          }
          // Continue searching or stop search at current match
          if (FindAllMatches == false && MatchFoundInCell == true)
          {
            DgvVoorraad.ClearSelection();
            DgvVoorraad.Rows[RowIndex].Selected = true;
            DgvVoorraad.CurrentCell = DgvVoorraad.Rows[RowIndex].Cells[0];
          }
        }
      }
    }

    StartingScreenFunctions.GenericFormOpener<AlterDataPopup.AlterItemPopup> mAlterArtikel;
    private void DgvVoorraad_DoubleClick(object sender, EventArgs e)
    {
      mAlterArtikel.Show(ParentForm);

    }
  }
}
