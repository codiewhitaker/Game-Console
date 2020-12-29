﻿using System;
namespace GameConsole
{
    public abstract class TwoPlayerGame : Game
    {
        protected User _playerTwo;

        public TwoPlayerGame(User player, string title) : base(player, title)
        {
        }

        public void LogInSecondPlayer()
        {
            UI.DisplaySuccess("\r\nYou need to log in with a second user to play a two player game.");
            UI.Continue();
            _playerTwo = User.LogIn();
            UI.DisplayTitle("Player 2 Loaded");
            UI.DisplaySuccess($"Welcome, {_playerTwo.Username}, you are Player Two!");
            UI.Continue();
        }

        protected void DisplayUserStats()
        {
            UI.ComingSoon();
        }

        protected abstract string CheckWinner();

        protected virtual void DisplayWinner(string winner)
        {
            UI.DisplayTitle("Match Results...");
            //Display winner
            if (winner != "stalemate")
            {
                UI.DisplaySuccess($"Winner: {winner}!");
                UI.Continue();
            }
            else if (winner == "stalemate")
            {
                UI.DisplayError("Oops, looks like a Stalemate!");
                UI.Continue();

            }
        }
    }
}
