using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicToeWebsite.Models
{
    public static class TicToe
    {
      public static int[]gameBoard= new int[16] { -2,-1,-1, -1,-1,-1,-1,-1,-1, -1, -2, -2, -2, -2, -2, -2};
        public static List<string> players=new List<string>();
        public static Dictionary<string, int>currentPlayers =
        new Dictionary<string,int>();
        public static int Moves = 0;
     //   public int flag = 0;
        public static string StatusOfGame(int boxId, string apiKey)
        {
            if (Moves == -1)
                throw new Exception("Game Over Cannot Play Again");
            if (Moves >= 9)
            {
                return "Game Is Drawn";

            }

            AddPlayersToGame(apiKey);
            string res = "";
            if (IsValidTurn(apiKey))
            {
                currentPlayers[apiKey] = 1;
                if (players[0] == apiKey)
                {
                    if (gameBoard[boxId] == -1 &&gameBoard[boxId] != -2)
                    {
                       
                        
                        Moves++;
                        gameBoard[boxId] = 0;
                        res = (CheckStatus(0));
                     
                    }
                    else
                        throw new Exception("InValid Move Made By Player");
                }
                else
                {
                    if (TicToe.gameBoard[boxId] == -1 && TicToe.gameBoard[boxId] != -2)
                    {
                   

                        TicToe.Moves++;
                        TicToe.gameBoard[boxId] = 1;
                        res = (CheckStatus(1));
                    }
                    else
                        throw new Exception("InValid Move Made By Player");
                }
            }
            TicToe.currentPlayers[apiKey] = 0;
            return res;
        }
        public static string CheckStatus(int playerId)
        {
            if (TicToe.gameBoard[1] == playerId && TicToe.gameBoard[2] == playerId && TicToe.gameBoard[3] == playerId
                || TicToe.gameBoard[4] == playerId && TicToe.gameBoard[5] == playerId && TicToe.gameBoard[6] == playerId
                || TicToe.gameBoard[7] == playerId && TicToe.gameBoard[8] == playerId && TicToe.gameBoard[9] == playerId)
            {
                TicToe.Moves = -1;
                return "Win";
            }
            if (TicToe.gameBoard[1] == playerId && TicToe.gameBoard[4] == playerId && TicToe.gameBoard[7] == playerId
                || TicToe.gameBoard[2] == playerId && TicToe.gameBoard[5] == playerId && TicToe.gameBoard[8] == playerId
                || TicToe.gameBoard[3] == playerId && TicToe.gameBoard[6] == playerId && TicToe.gameBoard[9] == playerId)
            {
                TicToe.Moves = -1;
                return "Win";

            }


            if (TicToe.gameBoard[1] == playerId && TicToe.gameBoard[5] == playerId && TicToe.gameBoard[9] == playerId || (TicToe.gameBoard[3] == playerId && TicToe.gameBoard[5] == playerId && TicToe.gameBoard[7] == playerId))
            {
                TicToe.Moves = -1;
                return "Win";


            }
            return "InProgress";
        }
        public static void AddPlayersToGame(string apiKey)
        {
            if (TicToe.players.Count <= 1)
            {
                TicToe.players.Add(apiKey);
                if (TicToe.currentPlayers.ContainsKey(apiKey) == false)
                    TicToe.currentPlayers.Add(apiKey, -1);
            }
            else if (TicToe.players.Count > 2)
            {
                throw new Exception("No more users can Be added");
            }

        }


        public static Boolean IsValidTurn(string apiKey)
        {
              if (TicToe.currentPlayers.ContainsKey(apiKey) == true)
            {
                if (TicToe.currentPlayers[apiKey] == 1)
                {
                    return false;
                }
            }

            return true;

        }


    }
}
