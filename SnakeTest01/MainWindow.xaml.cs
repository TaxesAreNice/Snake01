using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SnakeTest01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Focus();
        }

        int playerPos = 1;

        public void SettingSpesificColor(char objectType, int objectNumber)
        {
            switch (objectNumber)
            {
                case 1: Block1(objectType); break;
                case 2: Block2(objectType); break;
                case 3: Block3(objectType); break;
                case 4: Block4(objectType); break;
                case 5: Block5(objectType); break;
                case 6: Block6(objectType); break;
                case 7: Block7(objectType); break;
                case 8: Block8(objectType); break;
                case 9: Block9(objectType); break;
                case 10: Block10(objectType); break;
                case 11: Block11(objectType); break;
                case 12: Block12(objectType); break;
                case 13: Block13(objectType); break;
                case 14: Block14(objectType); break;
                case 15: Block15(objectType); break;
                case 16: Block16(objectType); break;
                case 17: Block17(objectType); break;
                case 18: Block18(objectType); break;
                case 19: Block19(objectType); break;
                case 20: Block20(objectType); break;
                case 21: Block21(objectType); break;
                case 22: Block22(objectType); break;
                case 23: Block23(objectType); break;
                case 24: Block24(objectType); break;
                default:
                    MessageBox.Show("Invalid block number");
                    break;
            }
        }
        private void Block1(char o) { if (o == 'x') Block_1.Background = Brushes.Black; else if (o == '0') Block_1.Background = Brushes.Red; else if (o == '1') Block_1.Background = Brushes.Green; }
        private void Block2(char o) { if (o == 'x') Block_2.Background = Brushes.Black; else if (o == '0') Block_2.Background = Brushes.Red; else if (o == '1') Block_2.Background = Brushes.Green; }
        private void Block3(char o) { if (o == 'x') Block_3.Background = Brushes.Black; else if (o == '0') Block_3.Background = Brushes.Red; else if (o == '1') Block_3.Background = Brushes.Green; }
        private void Block4(char o) { if (o == 'x') Block_4.Background = Brushes.Black; else if (o == '0') Block_4.Background = Brushes.Red; else if (o == '1') Block_4.Background = Brushes.Green; }
        private void Block5(char o) { if (o == 'x') Block_5.Background = Brushes.Black; else if (o == '0') Block_5.Background = Brushes.Red; else if (o == '1') Block_5.Background = Brushes.Green; }
        private void Block6(char o) { if (o == 'x') Block_6.Background = Brushes.Black; else if (o == '0') Block_6.Background = Brushes.Red; else if (o == '1') Block_6.Background = Brushes.Green; }
        private void Block7(char o) { if (o == 'x') Block_7.Background = Brushes.Black; else if (o == '0') Block_7.Background = Brushes.Red; else if (o == '1') Block_7.Background = Brushes.Green; }
        private void Block8(char o) { if (o == 'x') Block_8.Background = Brushes.Black; else if (o == '0') Block_8.Background = Brushes.Red; else if (o == '1') Block_8.Background = Brushes.Green; }
        private void Block9(char o) { if (o == 'x') Block_9.Background = Brushes.Black; else if (o == '0') Block_9.Background = Brushes.Red; else if (o == '1') Block_9.Background = Brushes.Green; }
        private void Block10(char o) { if (o == 'x') Block_10.Background = Brushes.Black; else if (o == '0') Block_10.Background = Brushes.Red; else if (o == '1') Block_10.Background = Brushes.Green; }
        private void Block11(char o) { if (o == 'x') Block_11.Background = Brushes.Black; else if (o == '0') Block_11.Background = Brushes.Red; else if (o == '1') Block_11.Background = Brushes.Green; }
        private void Block12(char o) { if (o == 'x') Block_12.Background = Brushes.Black; else if (o == '0') Block_12.Background = Brushes.Red; else if (o == '1') Block_12.Background = Brushes.Green; }
        private void Block13(char o) { if (o == 'x') Block_13.Background = Brushes.Black; else if (o == '0') Block_13.Background = Brushes.Red; else if (o == '1') Block_13.Background = Brushes.Green; }
        private void Block14(char o) { if (o == 'x') Block_14.Background = Brushes.Black; else if (o == '0') Block_14.Background = Brushes.Red; else if (o == '1') Block_14.Background = Brushes.Green; }
        private void Block15(char o) { if (o == 'x') Block_15.Background = Brushes.Black; else if (o == '0') Block_15.Background = Brushes.Red; else if (o == '1') Block_15.Background = Brushes.Green; }
        private void Block16(char o) { if (o == 'x') Block_16.Background = Brushes.Black; else if (o == '0') Block_16.Background = Brushes.Red; else if (o == '1') Block_16.Background = Brushes.Green; }
        private void Block17(char o) { if (o == 'x') Block_17.Background = Brushes.Black; else if (o == '0') Block_17.Background = Brushes.Red; else if (o == '1') Block_17.Background = Brushes.Green; }
        private void Block18(char o) { if (o == 'x') Block_18.Background = Brushes.Black; else if (o == '0') Block_18.Background = Brushes.Red; else if (o == '1') Block_18.Background = Brushes.Green; }
        private void Block19(char o) { if (o == 'x') Block_19.Background = Brushes.Black; else if (o == '0') Block_19.Background = Brushes.Red; else if (o == '1') Block_19.Background = Brushes.Green; }
        private void Block20(char o) { if (o == 'x') Block_20.Background = Brushes.Black; else if (o == '0') Block_20.Background = Brushes.Red; else if (o == '1') Block_20.Background = Brushes.Green; }
        private void Block21(char o) { if (o == 'x') Block_21.Background = Brushes.Black; else if (o == '0') Block_21.Background = Brushes.Red; else if (o == '1') Block_21.Background = Brushes.Green; }
        private void Block22(char o) { if (o == 'x') Block_22.Background = Brushes.Black; else if (o == '0') Block_22.Background = Brushes.Red; else if (o == '1') Block_22.Background = Brushes.Green; }
        private void Block23(char o) { if (o == 'x') Block_23.Background = Brushes.Black; else if (o == '0') Block_23.Background = Brushes.Red; else if (o == '1') Block_23.Background = Brushes.Green; }
        private void Block24(char o) { if (o == 'x') Block_24.Background = Brushes.Black; else if (o == '0') Block_24.Background = Brushes.Red; else if (o == '1') Block_24.Background = Brushes.Green; }

        

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    MoveUp();
                    break;

                case Key.A:
                    MoveLeft();
                    break;

                case Key.S:
                    MoveDown();
                    break;

                case Key.D:
                    MoveRight();
                    break;
            }
        }
        private void MoveRight()
        {
            SettingSpesificColor('x', playerPos);
            playerPos++;
            SettingSpesificColor('1', playerPos);
        }
        private void MoveDown()
        {
            SettingSpesificColor('x', playerPos);
            playerPos += 12;
            SettingSpesificColor('1', playerPos);
        }
        private void MoveLeft()
        {
            SettingSpesificColor('x', playerPos);
            playerPos--;
            SettingSpesificColor('1', playerPos);
        }
        private void MoveUp()
        {
            SettingSpesificColor('x', playerPos);
            playerPos -= 12;
            SettingSpesificColor('1', playerPos);
        }

    }
}