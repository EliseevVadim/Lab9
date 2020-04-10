using System;

namespace _9._5
{
    public struct Game
    {
        public string team1;
        public int score1;
        public string team2;
        public int score2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree game = PlayGame();
            game.PreOrderTraversal();
        }
        public static int GetScore()
        {
            Random random = new Random();
            return random.Next(0, 15);
        }
        public static BinaryTree PlayGame()
        {
            BinaryTree play = new BinaryTree();
            var final = play.AddRoot(new Game() { team1 = "test", score1 = 0, team2 = "test", score2 = 0 });
            var semifinal1 = play.AddLeft(final, new Game() { team1 = "test", score1 = 0, team2 = "test", score2 = 0 });
            var semifinal2 = play.AddRight(final, new Game() { team1 = "test", score1 = 0, team2 = "test", score2 = 0 });
            var qarterfinal1 = play.AddLeft(semifinal1, new Game() { team1 = "test", score1 = 0, team2 = "test", score2 = 0 });
            var qarterfinal2 = play.AddRight(semifinal1, new Game() { team1 = "test", score1 = 0, team2 = "test", score2 = 0 });
            var qarterfinal3 = play.AddLeft(semifinal2, new Game() { team1 = "test", score1 = 0, team2 = "test", score2 = 0 });
            var qarterfinal4 = play.AddRight(semifinal2, new Game() { team1 = "test", score1 = 0, team2 = "test", score2 = 0 });
            var game1=play.AddLeft(qarterfinal1, new Game() { team1 = "ARG", score1 = GetScore(), team2 = "SWI", score2 = GetScore() });
            var game2=play.AddRight(qarterfinal1, new Game() { team1 = "BEL", score1 = GetScore(), team2 = "USA", score2 = GetScore() });
            var game3 = play.AddLeft(qarterfinal2, new Game() { team1 = "NED", score1 = GetScore(), team2 = "MEX", score2 = GetScore() });
            var game4 = play.AddRight(qarterfinal2, new Game() { team1 = "CRC", score1 = GetScore(), team2 = "GRE", score2 = GetScore() });
            var game5 = play.AddLeft(qarterfinal3, new Game() { team1 = "FRA", score1 = GetScore(), team2 = "NIG", score2 = GetScore() });
            var game6 = play.AddRight(qarterfinal3, new Game() { team1 = "GER", score1 = GetScore(), team2 = "ALG", score2 = GetScore() });
            var game7 = play.AddLeft(qarterfinal4, new Game() { team1 = "BRA", score1 = GetScore(), team2 = "CHI", score2 = GetScore() });
            var game8 = play.AddRight(qarterfinal4, new Game() { team1 = "COL", score1 = GetScore(), team2 = "URU", score2 = GetScore() });
            qarterfinal1.data = GetWinner(game1, game2);
            qarterfinal2.data = GetWinner(game3, game4);
            qarterfinal3.data = GetWinner(game5, game6);
            qarterfinal4.data = GetWinner(game7, game8);
            semifinal1.data = GetWinner(qarterfinal1, qarterfinal2);
            semifinal2.data = GetWinner(qarterfinal3, qarterfinal4);
            final.data = GetWinner(semifinal1, semifinal2);
            return play;
        }
        public static Game GetWinner(BinaryTreeNode node1, BinaryTreeNode node2)
        {
            Game winners;
            string t1;
            string t2;
            if (node1.data.score1 > node1.data.score2)
            {
                t1 = node1.data.team1;
            }
            else
            {
                t1 = node1.data.team2;
            }
            if (node2.data.score1 > node2.data.score2)
            {
                t2 = node2.data.team1;
            }
            else
            {
                t2 = node2.data.team2;
            }
            winners = new Game() { team1 = t1, score1 = GetScore(), team2 = t2, score2 = GetScore() };
            return winners;
        }
    }
}
