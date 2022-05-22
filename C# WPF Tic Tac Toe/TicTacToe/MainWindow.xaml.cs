using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Array to store if the cell is active
        private MarkType[] mResults;

        // True if its player 1 turn (x) or player 2 turn (o)
        private bool Player1Turn;

        // Determine if the game ended
        private bool gameEnded;
        public MainWindow()
        {
            InitializeComponent();

            NewGame();
        }

        private void NewGame()
        {
            // Creating an object from the MarkType class.
            mResults = new MarkType[9];

            // for loop that iterate the 9 buttons and set them to free.
            for (int i = 0; i < mResults.Length; i++)
            {
                mResults[i] = MarkType.Free;
            }

            // To make sure player 1 start the game
            Player1Turn = true;

            // Iterate every button on the grid.
            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {
                // When Starting a new game I want to clear the content of the button aka the X and O
                button.Content = string.Empty;
                // I want also to color in diffrent colors the X and the O, so when a new game is started,  I want to rebrush them to white background.
                button.Background = Brushes.White;
                button.Foreground = Brushes.DarkCyan;

                gameEnded = false;

            }
            );


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // heck if game is ended, and if true, starts a new game.
            if (gameEnded)
            {
                NewGame();
                return;
            }

            // Looking for a button position in the array and return an index of that position.
            var button = (Button)sender; // Cast the button to the sender.
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);
            var index = column + (row * 3);

            // if the cell is not free, do nothing.
            if (mResults[index] != MarkType.Free)
            {
                return; 
            }
            //                            if              else
            mResults[index] = Player1Turn ? MarkType.Cross : MarkType.Nought;

            // check if it is player 1 turn, if true, X is the content, else the O is the content.
            button.Content = Player1Turn ? "X" : "O";

            // Chanme the O to green
            if (!Player1Turn)
                button.Foreground = Brushes.Red;

            // if Player 1 turn is true, then set it to false. (now the o will appear), the next time it will be false, and then it will be set to true, and to button content will return to be x.
            if (Player1Turn)
                Player1Turn = false;
            else
                Player1Turn = true;

            // Check for Winner
            CheckForWinner();
        }

        private void CheckForWinner()
        {
            // Horizontal Winner 
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[1] & mResults[2]) == mResults[0])
            {
                gameEnded = true;
                Button0_0.Background = Button0_1.Background = Button0_2.Background = Brushes.Green;
                if (mResults[0] == MarkType.Cross && (mResults[0] & mResults[1] & mResults[2]) == mResults[0])
                {
                    MessageBox.Show("Player 1 won!");
                    NewGame();
                }
                else { MessageBox.Show("Player 2 won!"); NewGame(); }
            }

            else if (mResults[3] != MarkType.Free && (mResults[3] & mResults[4] & mResults[5]) == mResults[3])
            {
                gameEnded = true;
                Button1_0.Background = Button1_1.Background = Button1_2.Background = Brushes.Green;
                if (mResults[3] == MarkType.Cross && (mResults[3] & mResults[4] & mResults[5]) == mResults[3])
                {
                    MessageBox.Show("Player 1 won!");
                    NewGame();
                }
                else { MessageBox.Show("Player 2 won!"); NewGame(); }
            }

            else if (mResults[6] != MarkType.Free && (mResults[6] & mResults[7] & mResults[8]) == mResults[6])
            {
                gameEnded = true;
                Button2_0.Background = Button2_1.Background = Button2_2.Background = Brushes.Green;
                if (mResults[6] == MarkType.Cross && (mResults[6] & mResults[7] & mResults[8]) == mResults[6])
                {
                    MessageBox.Show("Player 1 won!");
                    NewGame();
                }
                else { MessageBox.Show("Player 2 won!"); NewGame(); }
            }

            // Check for Vertical winner

            else if (mResults[0] != MarkType.Free && (mResults[0] & mResults[3] & mResults[6]) == mResults[0])
            {
                gameEnded = true;
                Button0_0.Background = Button1_0.Background = Button2_0.Background = Brushes.Green;
                if (mResults[0] == MarkType.Cross && (mResults[0] & mResults[3] & mResults[6]) == mResults[0])
                {
                    MessageBox.Show("Player 1 won!");
                    NewGame();
                }
                else { MessageBox.Show("Player 2 won!"); NewGame(); }
            }

            else if (mResults[1] != MarkType.Free && (mResults[1] & mResults[4] & mResults[7]) == mResults[1])
            {
                gameEnded = true;
                Button0_1.Background = Button1_1.Background = Button2_1.Background = Brushes.Green;
                if (mResults[1] == MarkType.Cross && (mResults[1] & mResults[4] & mResults[7]) == mResults[1])
                {
                    MessageBox.Show("Player 1 won!");
                    NewGame();
                }
                else { MessageBox.Show("Player 2 won!"); NewGame(); }
            }

            else if (mResults[2] != MarkType.Free && (mResults[2] & mResults[5] & mResults[8]) == mResults[2])
            {
                gameEnded = true;
                Button0_2.Background = Button1_2.Background = Button2_2.Background = Brushes.Green;
                if (mResults[2] == MarkType.Cross && (mResults[2] & mResults[5] & mResults[8]) == mResults[2])
                {
                    MessageBox.Show("Player 1 won!");
                    NewGame();
                }
                else { MessageBox.Show("Player 2 won!"); NewGame(); }
            }

            // Check for Multi Cross
            else if (mResults[0] != MarkType.Free && (mResults[0] & mResults[4] & mResults[8]) == mResults[0])
            {
                gameEnded = true;
                Button0_0.Background = Button1_1.Background = Button2_2.Background = Brushes.Green;
                if (mResults[0] == MarkType.Cross && (mResults[0] & mResults[4] & mResults[8]) == mResults[0])
                {
                    MessageBox.Show("Player 1 won!");
                    NewGame();
                }
                else { MessageBox.Show("Player 2 won!"); NewGame(); }
            }

            else if (mResults[2] != MarkType.Free && (mResults[2] & mResults[4] & mResults[6]) == mResults[2])
            {
                gameEnded = true;
                Button0_2.Background = Button1_1.Background = Button2_0.Background = Brushes.Green;
                if (mResults[2] == MarkType.Cross && (mResults[2] & mResults[4] & mResults[6]) == mResults[2])
                {
                    MessageBox.Show("Player 1 won!");
                    NewGame();
                }
                else { MessageBox.Show("Player 2 won!"); NewGame(); }
            }

            //Check for Draw
            if (!mResults.Any(f => f == MarkType.Free))
            {
                MessageBox.Show("Draw");
                gameEnded = true;
                NewGame();
            }
        }
    }
}
