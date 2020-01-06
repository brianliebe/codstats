using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoDGameTracker
{
    public partial class Tracker : Form
    {
        private string homeTeam = "";

        public Tracker()
        {
            InitializeComponent();
            mode1.Checked = true;
            map1.Checked = true;
            allegianceRB.Checked = true;
        }

        private void Tracker_Load(object sender, EventArgs e)
        {
            LoadTeams();
            LoadMaps();
            LoadPlayers();
            LoadDuration();
        }

        public void LoadTeams()
        {
            using (StreamReader r = new StreamReader("data/teams"))
            {
                string[] names = r.ReadToEnd().Split('\n');
                foreach (string name in names)
                {
                    teamACB.Items.Add(name.Trim());
                    teamBCB.Items.Add(name.Trim());
                }
            }
        }

        public void LoadMaps()
        {
            RadioButton[] buttons = { map1, map2, map3, map4, map5, map6, map7 };
            using (StreamReader r = new StreamReader("data/maps"))
            {
                string[] maps = r.ReadToEnd().Split('\n');
                for (int i = 0; i < maps.Length; i++)
                {
                    if (i < buttons.Length)
                    {
                        buttons[i].Text = maps[i].Trim();
                    }
                }
            }
        }

        public void LoadPlayers()
        {
            Label[] labels = { player1Label, player2Label, player3Label, player4Label, player5Label };
            using (StreamReader r = new StreamReader("data/players"))
            {
                string[] players = r.ReadToEnd().Split('\n');
                for (int i = 0; i < players.Length; i++)
                {
                    if (i == 0)
                    {
                        homeTeam = players[i].Trim();
                    }
                    else if (i - 1 < labels.Length)
                    {
                        labels[i - 1].Text = players[i].Trim();
                    }
                }
            }
        }

        public void LoadDuration()
        {
            for (int i = 0; i < 60; i++)
            {
                minsCB.Items.Add(i);
                secsCB.Items.Add(i);
            }
            minsCB.SelectedIndex = 0;
            secsCB.SelectedIndex = 0;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            // Create directories
            if (!Directory.Exists("output")) Directory.CreateDirectory("output");
            if (!Directory.Exists("output/general")) Directory.CreateDirectory("output/general");
            if (!Directory.Exists("output/results")) Directory.CreateDirectory("output/results");
            if (!Directory.Exists("output/players")) Directory.CreateDirectory("output/players");

            // Fetch the info
            string teamA = teamACB.Text;
            string teamB = teamBCB.Text;
            string scoreA = teamAScore.Text;
            string scoreB = teamBScore.Text;
            string notes = notesTB.Text;
            int duration = int.Parse(minsCB.Text) * 60 + int.Parse(secsCB.Text);

            string map = GetMap();
            string mode = GetMode();
            string side = GetSide();
            string oppSide = GetSide().ToLower().Equals("coalition") ? "Allegiance" : "Coalition";

            string date = datePicker.Value.ToString("yyyy-MM-dd");
            string matchID = DateTime.Now.ToString("yyyyMMddHHmmss");
            string filename = string.Format("{0}.{1}.{2}.{3}.{4}-{5}.{6}.txt", mode, map, teamA, teamB, scoreA, scoreB, matchID);
            filename = filename.Replace("&", "").Replace("\\", "").Replace("/", "").Replace(" ", "_");

            StringBuilder sb = new StringBuilder();

            // Build the string

            sb.Append(string.Format("{0},{1},{2},{3},{4},{5}\n", matchID, date, duration, map, mode, notes));
            File.WriteAllText("output/general/" + filename, sb.ToString());
            sb.Clear();

            sb.Append(string.Format("{0},{1},{2},{3},{4},{5}\n", matchID, teamA, teamB, scoreA, scoreB, side));
            sb.Append(string.Format("{0},{1},{2},{3},{4},{5}\n", matchID, teamB, teamA, scoreB, scoreA, oppSide));
            File.WriteAllText("output/results/" + filename, sb.ToString());
            sb.Clear();

            if (teamStats.Enabled)
            {
                string[] labels = { player1Label.Text, player2Label.Text, player3Label.Text, player4Label.Text, player5Label.Text };
                string[] kills = { p1Kills.Text, p2Kills.Text, p3Kills.Text, p4Kills.Text, p5Kills.Text };
                string[] deaths = { p1Deaths.Text, p2Deaths.Text, p3Deaths.Text, p4Deaths.Text, p5Deaths.Text };

                for (int i = 0; i < 5; i++)
                {
                    sb.Append(string.Format("{0},{1},{2},{3}\n", matchID, labels[i], kills[i], deaths[i]));
                }
                File.WriteAllText("output/players/" + filename, sb.ToString());
                sb.Clear();
            }
        }

        private string GetMap()
        {
            RadioButton[] maps = { map1, map2, map3, map4, map5, map6, map7 };
            foreach (var map in maps)
            {
                if (map.Checked) return map.Text;
            }
            return "";
        }

        private string GetMode()
        {
            RadioButton[] modes = { mode1, mode2, mode3 };
            foreach (var mode in modes)
            {
                if (mode.Checked) return mode.Text;
            }
            return "";
        }

        private string GetSide()
        {
            RadioButton[] sides = { coalitionRB, allegianceRB };
            foreach (var side in sides)
            {
                if (side.Checked) return side.Text;
            }
            return "";
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            Process.Start("output");
        }

        private void Textbox_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.SelectionStart = 0;
            tb.SelectionLength = tb.Text.Length;
            tb.Focus();
        }

        private void Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teamACB.Text.Equals(homeTeam) || teamBCB.Text.Equals(homeTeam))
            {
                teamStats.Enabled = true;
            }
            else
            {
                teamStats.Enabled = false;
            }
        }
    }
}
