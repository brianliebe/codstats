using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace DeathTracker
{
    public partial class DeathTracker : Form
    {
        private readonly List<string> coords;

        public DeathTracker()
        {
            InitializeComponent();
            coords = new List<string>();
        }

        private void DeathTracker_Load(object sender, EventArgs e)
        {
            LoadMaps();
            LoadModes();
            LoadTeams();
        }

        private void LoadTeams()
        {
            List<string> teams = File.ReadAllLines("config/teams").ToList();
            teamABox.Items.Add("");
            teamBBox.Items.Add("");
            if (teams.Any())
            {
                teamABox.Items.AddRange(teams.ToArray());
                teamABox.SelectedIndex = 0;
                teamBBox.Items.AddRange(teams.ToArray());
                teamBBox.SelectedIndex = 0;
            }
        }

        private void LoadModes()
        {
            List<string> modes = File.ReadAllLines("config/modes").ToList();
            modeBox.Items.Add("");
            if (modes.Any())
            {
                modeBox.Items.AddRange(modes.ToArray());
                modeBox.SelectedIndex = 0;
            }
        }

        private void LoadMaps()
        {
            List<string> imageNames = Directory.GetFiles("maps/", "*.png", SearchOption.TopDirectoryOnly).ToList();
            foreach (string fileName in imageNames)
            {
                string mapName = fileName.Substring(fileName.IndexOf("/") + 1);
                mapName = mapName.Substring(0, mapName.LastIndexOf("."));
                mapBox.Items.Add(GetNameFromFile(mapName));
            }
            if (mapBox.Items.Count > 0)
            {
                mapBox.SelectedIndex = 0;
            }
        }

        private void MapBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mapName = mapBox.Text;
            string filename = GetFileFromName(mapName);
            if (File.Exists(filename))
            {
                map.ImageLocation = filename;
                map.Load();
            }
        }

        private string GetNameFromFile(string file)
        {
            string[] splitName = file.Split('_');
            for (int i = 0; i < splitName.Length; i++)
            {
                string word = splitName[i];
                if (word.Length > 1)
                {
                    splitName[i] = word.Substring(0, 1).ToUpper() + word.Substring(1);
                }
                else
                {
                    splitName[i] = word.ToUpper();
                }
            }
            return string.Join(" ", splitName);
        }

        private string GetFileFromName(string name)
        {
            return string.Format("maps/{0}.png", name.ToLower().Replace(' ', '_'));
        }

        private void Map_MouseClick(object sender, MouseEventArgs e)
        {
            string hardpointLocation = hardpointCombobox.Enabled ? hardpointCombobox.Text : "-1";
            if (e.Button == MouseButtons.Left)
            {
                if (ModifierKeys == Keys.Control)
                {
                    // red o
                    coords.Add(string.Format("{0},{1},{2},{3},{4}", "A", "D", e.X * 2, e.Y * 2, hardpointLocation));
                }
                else if (ModifierKeys == Keys.Shift)
                {
                    // red square
                    coords.Add(string.Format("{0},{1},{2},{3},{4}", "A", "O", e.X * 2, e.Y * 2, hardpointLocation));
                }
                else
                {
                    // red X
                    coords.Add(string.Format("{0},{1},{2},{3},{4}", "A", "K", e.X * 2, e.Y * 2, hardpointLocation));
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (ModifierKeys == Keys.Control)
                {
                    // blue X
                    coords.Add(string.Format("{0},{1},{2},{3},{4}", "B", "K", e.X * 2, e.Y * 2, hardpointLocation));
                }
                else if (ModifierKeys == Keys.Shift)
                {
                    // blue square
                    coords.Add(string.Format("{0},{1},{2},{3},{4}", "B", "O", e.X * 2, e.Y * 2, hardpointLocation));
                }
                else
                {
                    // blue o
                    coords.Add(string.Format("{0},{1},{2},{3},{4}", "B", "D", e.X * 2, e.Y * 2, hardpointLocation));
                }
            }
            CreateNewImage();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (coords.Any())
            {
                string mapName = string.Join("_", mapBox.Text.Split(' '));
                string date = DateTime.Now.ToString("MMddyyy_hhmmss");
                string filename = string.Format("{0}.{1}.{2}.{3}.{4}.{5}.txt",
                    mapName, modeBox.Text, ASideButton.Text, teamABox.Text, teamBBox.Text, date);
                filename = filename.Replace("&", "").Replace("\\", "").Replace("/", "").Replace(" ", "_");

                if (!Directory.Exists("generated")) Directory.CreateDirectory("generated");
                File.WriteAllText(string.Format("generated/{0}", filename), string.Join("\n", coords));

                if (openFileCheckbox.Checked)
                {
                    string currDir = Directory.GetCurrentDirectory();
                    Process.Start(string.Format("{0}/generated/{1}", currDir, filename));
                }

                coords.Clear();
                string imageFilename = GetFileFromName(mapBox.Text);
                Image background = Image.FromFile(imageFilename);
                map.Image = background;
            }
        }

        private void CreateNewImage()
        {
            string mapName = mapBox.Text;
            string filename = GetFileFromName(mapName);
            Image background = Image.FromFile(filename);

            Image newImage = new Bitmap(512, 512);
            using (Graphics gr = Graphics.FromImage(newImage))
            {
                gr.DrawImage(background, 0, 0, 512, 512);
                foreach (string line in coords)
                {
                    if (line.Trim().Equals("")) continue;

                    string[] splitCoords = line.Split(',');
                    int.TryParse(splitCoords[2], out int prevX);
                    int.TryParse(splitCoords[3], out int prevY);

                    prevX = (prevX / 2) - 5;
                    prevY = (prevY / 2) - 5;

                    Image prevImage = GetIcon(splitCoords[0], splitCoords[1]);
                    gr.DrawImage(prevImage, prevX, prevY, 10, 10);
                }
            }
            map.Image = newImage;
        }

        private Image GetIcon(string team, string type)
        {
            if (team.Equals("A"))
            {
                if (type.Equals("K"))
                {
                    return Properties.Resources.redx;
                }
                else if (type.Equals("D"))
                {
                    return Properties.Resources.bluex;
                }
                else
                {
                    return Properties.Resources.redsquare;
                }
            }
            else
            {
                if (type.Equals("K"))
                {
                    return Properties.Resources.redo;
                }
                else if (type.Equals("D"))
                {
                    return Properties.Resources.blueo;
                }
                {
                    return Properties.Resources.bluesquare;
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            string mapName = mapBox.Text;
            string filename = GetFileFromName(mapName);
            Image background = Image.FromFile(filename);
            map.Image = background;
            coords.Clear();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (coords.Any())
            {
                coords.RemoveAt(coords.Count - 1);
            }
            CreateNewImage();
        }

        private void ASideButton_Click(object sender, EventArgs e)
        {
            if (ASideButton.Text.Equals("O"))
            {
                ASideButton.Text = "D";
                BSideButton.Text = "O";
            }
            else
            {
                ASideButton.Text = "O";
                BSideButton.Text = "D";
            }
        }

        private void BSideButton_Click(object sender, EventArgs e)
        {
            if (ASideButton.Text.Equals("O"))
            {
                ASideButton.Text = "D";
                BSideButton.Text = "O";
            }
            else
            {
                ASideButton.Text = "O";
                BSideButton.Text = "D";
            }
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            if (!noteTextbox.Text.Equals(""))
            {
                if (coords.Any())
                {
                    coords[coords.Count - 1] = string.Format("{0},{1}", coords.Last(), noteTextbox.Text.Replace("\n", " "));
                    noteTextbox.Text = "";
                }
                else
                {
                    MessageBox.Show("You must place a kill/death before adding a note.");
                }
            }
        }

        private void ModeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modeBox.Text.ToLower().Equals("hardpoint"))
            {
                hardpointCombobox.SelectedIndex = 0;
                hardpointCombobox.Enabled = true;
            }
            else
            {
                hardpointCombobox.SelectedIndex = -1;
                hardpointCombobox.Enabled = false;
            }
        }
    }
}
