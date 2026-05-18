using CIPHER.Helpers;
using CIPHER.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIPHER.Forms.CustomItems
{
    public partial class ExtraFeatures : Form
    {
        public ExtraFeatures()
        {
            InitializeComponent();
        }


        private void btnGPBuy_Click(object sender, EventArgs e)
        {
            var (ok, err) = new EconomyService().DeductCoin(SessionManager.CurrentUser.UserID, 100, "Ghost Protocol Activated");
            if (!ok)
            {
                MessageBox.Show(err);
                return;
            }
            using var conn = DBHelper.Getconnection();
            new SqlCommand(
        "DELETE FROM FailedAttempts WHERE UserID=@uid", conn)
            {
                Parameters = { new("@uid", SessionManager.CurrentUser.UserID) }
            }.ExecuteNonQuery();

            new AuditService().Log(SessionManager.CurrentUser.UserID, "Ghost Protocol Activated", "User has activated Ghost Protocol, clearing all failed login attempts.");
            MessageBox.Show(@"AUDIT TRAIL WIPED. YOU ARE A GHOST.
                              Thanks for doing Buisness with us.");

        }

        private void btnMSBuy_Click(object sender, EventArgs e)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"
            SELECT TOP 1 m.MissionID From Missions m
            LEFT JOIN Progress p ON m.MissionID = p.MissionID AND p.UserID = @uid
            WHERE ISNULL(p.Solved,0) =0
            ORDER BY m.OrderIndex", conn)
            {
                Parameters = { new("@uid", SessionManager.CurrentUser.UserID) }
            };

            var result = cmd.ExecuteScalar();
            if (result == null)
            {
                MessageBox.Show("ALL MISSIONS ALREADY COMPLETED.");
                return;
            }
            int missionID= (int)result;

            var (ok, err) = new EconomyService().DeductCoin(SessionManager.CurrentUser.UserID, 200, $"Mission Skip for MissionID {missionID}");
            if (!ok) { 
                MessageBox.Show(err);
                return;
            }

            new SqlCommand(@"
            IF EXISTS (SELECT 1 FROM Progress WHERE UserID = @uid AND MissionID = @mid)
            UPDATE Progress SET Solved =1, SolvedAt = GETDATE()
            WHERE UserID = @uid AND MissionID = @mid
            ELSE 
                INSERT INTO Progress (UserID,MissionID,Solved,SolvedAt)
                VALUES (@uid,@mid,1,GETDATE())
        ",conn)
            {
                Parameters =
                {
                    new("@uid", SessionManager.CurrentUser.UserID),
                    new("@mid", missionID)
                }
            }.ExecuteNonQuery();

            SessionManager.RefreshUser();
            MessageBox.Show(@$"MISSION {missionID} SKIPPED!
                               Thanks for doing Business with us.");



        }

        private void btnXPBuy_Click(object sender, EventArgs e)
        {
            var (ok ,err) = new EconomyService().DeductCoin(SessionManager.CurrentUser.UserID, 500, "XP Boost Activated");
            if(!ok)
            {
                MessageBox.Show(err);
                return;
            }

            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"UPDATE Users SET XPBoostMissions = 3 WHERE UserID = @uid", conn);
            cmd.Parameters.AddWithValue("@uid", SessionManager.CurrentUser.UserID);
            cmd.ExecuteNonQuery();

            SessionManager.RefreshUser();
            MessageBox.Show(@"XP BOOST ACTIVATED! Your next 3 missions will grant double XP.
                              Thanks for doing Business with us.");
        }

        private void btnBBBuy_Click(object sender, EventArgs e)
        {
            using var conn = DBHelper.Getconnection();
            var cmd = new SqlCommand(@"SELECT TOP 1 Answer FROM Bounties
                                       WHERE Status ='Open' AND CreatorID != @uid 
                                       ORDER BY CreatedAt ASC", conn);
            cmd.Parameters.AddWithValue("@uid", SessionManager.CurrentUser.UserID);
            var result = cmd.ExecuteScalar()?.ToString();
            if(result == null)
            {
                MessageBox.Show("NO OPEN BOUNTIES AVAILABLE.");
                return;
            }

            var (ok, err) = new EconomyService().DeductCoin(SessionManager.CurrentUser.UserID, 300, $"Bounty Rush for Bounty with Answer {result}");
            if(!ok)
            {
                MessageBox.Show(err);
                return;
            }

            string hint = $"INTEL REPORT:\n" +
                  $"Length: {result.Length} characters\n" +
                  $"Words: {result.Split(' ').Length}\n" +
                  $"Starts with: '{result[0]}'";

            MessageBox.Show(hint, "BOUNTY RUSH ACTIVATED! Here's some intel on an open bounty answer. Thanks for doing Business with us.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Thanks for doing Business with us.", "BOUNTY RUSH ACTIVATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
