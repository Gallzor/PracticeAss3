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

namespace PracticeAss3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BankAccount account;
        Score score;
        Dice dice;
        Dice dice2;
        public MainWindow()
        {
            account = new BankAccount();
            score = new Score(900);
            dice = new Dice();
            dice2 = new Dice();
            InitializeComponent();
            CurrentSaldoAmountTextBox.Text = account.SaldoAmount.ToString();
            resultsPointsTextBlock.Text = score.ScoreValue.ToString();

        }

        private void ChangeSaldoButton_Click(object sender, RoutedEventArgs e)
        {

            int inputSaldoAmount;

            inputSaldoAmount = Convert.ToInt32(ChangeSaldoTextbox.Text);

            if (sender.GetType() == typeof(Button))
            {
                Button button = (Button)sender; 
                if(button.Name == nameof(DepositSaldoButton))
                {
                    account.Deposit(inputSaldoAmount);
                }
                else
                {
                    account.Withdraw(inputSaldoAmount);
                }
            }
            CurrentSaldoAmountTextBox.Text = account.SaldoAmount.ToString();


        }

        //Score counter
        private void ChangePointsOfScoreButton_Click(object sender, RoutedEventArgs e)
        {
            int inputPoints;

            inputPoints = Convert.ToInt32(inputPointsTextBox.Text);

            if(sender.GetType() == typeof(Button))
            {
                Button button = (Button)sender;
                if(button.Name == nameof(AddPointsToScoreButton))
                {
                   score.AddPoints(inputPoints);
                }
                else
                {
                    score.RemovePoints(inputPoints);
                }
            }

            resultsPointsTextBlock.Text = score.ScoreValue.ToString();
        }

        private void ResetPointsOfScoreButton_Click(object sender, RoutedEventArgs e)
        {
            score.ResetScore();
            resultsPointsTextBlock.Text = score.ScoreValue.ToString();
        }

        // dices
        private void RollDicesButton_Click(object sender, RoutedEventArgs e)
        {
            int diceOne = dice.ThrowDice(7);
            int diceTwo = dice.ThrowDice(21);
            int totalDiceValue;

            dice.ThrowDiceOther(7);
            dice2.ThrowDiceOther(21);

            totalDiceValue = diceOne + diceTwo;

            DiceOneTextBlock.Text = dice.Value.ToString();
            DiceTwoTextBlock.Text = dice2.Value.ToString();

            dice.AddOtherDiceValue(dice2.Value);

            TotalDiceValueTextBox.Text = $"Total: " + totalDiceValue.ToString(); 
            TotalDiceValueTextBox.Text = $"Total: " + dice.Value.ToString(); 

        }



    }
}
