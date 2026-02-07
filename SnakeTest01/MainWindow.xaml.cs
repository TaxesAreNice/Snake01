using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
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
        private int playerPos = 3;
        private string playerMovment = ""; // typo, ahhhhhh! >:(   i've used it too much now, so, oh welp....
        private string backUpPlayerMovment = "";
        private bool PlayerDead = false;
        private int applePosition = 0;
        private int mapHight = 6;
        private int mapLenght = 12;
        private char Char_Tester = ' ';

        private List<List<char>> Map = new List<List<char>>();

        Random AppleSpawn = new Random();

        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            FillingDaMapUpAtStart();
            this.Focus();

            timer.Interval = TimeSpan.FromSeconds(0.2);
            timer.Tick += Timer_Tick;
            timer.Start();

            SpawningDaApple();
        }
        
        private void FillingDaMapUpAtStart()
        {
            for (int i = 0; i < mapHight; i++)
            {
                Map.Add(new List<char>());
                for (int j = 0; j < mapLenght; j++)
                {
                    Map[i].Add('x');
                }
            }
            Map[0][0] = '1';
            Map[0][1] = '1';
            Map[0][2] = '1';
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            
            if (PlayerDead)
            {
                timer.Stop();
                Window.Close();
                return;
            }

                  if ((playerMovment == "right" && backUpPlayerMovment == "left") ||
                      (playerMovment == "left"  && backUpPlayerMovment == "right") ||
                      (playerMovment == "up"    && backUpPlayerMovment == "down") ||
                      (playerMovment == "down"  && backUpPlayerMovment == "up")
                     )
                  {
                playerMovment = backUpPlayerMovment;
                  }

                

            if (playerMovment == "right")
                {
                    SettingSpesificColor('x', playerPos);
                    playerPos++;
                    SettingSpesificColor('1', playerPos);
                    
                }
                else if (playerMovment == "left")
                {
                    SettingSpesificColor('x', playerPos);
                    playerPos--;
                    SettingSpesificColor('1', playerPos);
                    
                }
                else if (playerMovment == "up")
                {
                    SettingSpesificColor('x', playerPos);
                    playerPos -= 12;
                    SettingSpesificColor('1', playerPos);
                    
                }
                else if (playerMovment == "down")
                {
                    SettingSpesificColor('x', playerPos);
                    playerPos += 12;
                    SettingSpesificColor('1', playerPos);
                    
                }

                backUpPlayerMovment = playerMovment;
                CheckingForApples();
            }
        


       
       private void CheckingForApples()
        {
           if (playerPos == applePosition)
            {
                //SettingSpesificColor('x', applePosition);
                SpawningDaApple();
            }
        }
        private void SpawningDaApple()
        {
            bool finished = false;
            char daIdentity = ' ';

            while (!finished)
            {
                applePosition = AppleSpawn.Next(1, mapLenght * mapHight); // 72
                daIdentity = GrabingTheIdentityOfAPosition(applePosition);

                if (daIdentity != '1')
                {
                    finished = true;
                }
            }
            SettingSpesificColor('0', applePosition);
            
        }

        private char GrabingTheIdentityOfAPosition(int DaPosition)
        {
            int y = 0;
            int x = 0;
            int i = 0;
            bool notContinue = false;

            if (DaPosition < mapLenght)
            {
                y = 0;
                x = DaPosition;
            }
            else
            {
                while (!notContinue)
                {
                    DaPosition -= mapLenght;

                    if (DaPosition < mapLenght)
                    {
                        y = i;
                        x = DaPosition;
                        notContinue = true;
                    }
                    i++;
                }
            }
                return Map[y][x];
            
        }
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
            playerMovment = "right";
        }
        private void MoveDown()
        {
            playerMovment = "down";
        }
        private void MoveLeft()
        {
            playerMovment = "left";
        }
        private void MoveUp()
        {
            playerMovment = "up";
        }





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
                case 25: Block25(objectType); break;
                case 26: Block26(objectType); break;
                case 27: Block27(objectType); break;
                case 28: Block28(objectType); break;
                case 29: Block29(objectType); break;
                case 30: Block30(objectType); break;
                case 31: Block31(objectType); break;
                case 32: Block32(objectType); break;
                case 33: Block33(objectType); break;
                case 34: Block34(objectType); break;
                case 35: Block35(objectType); break;
                case 36: Block36(objectType); break;
                case 37: Block37(objectType); break;
                case 38: Block38(objectType); break;
                case 39: Block39(objectType); break;
                case 40: Block40(objectType); break;
                case 41: Block41(objectType); break;
                case 42: Block42(objectType); break;
                case 43: Block43(objectType); break;
                case 44: Block44(objectType); break;
                case 45: Block45(objectType); break;
                case 46: Block46(objectType); break;
                case 47: Block47(objectType); break;
                case 48: Block48(objectType); break;
                case 49: Block49(objectType); break;
                case 50: Block50(objectType); break;
                case 51: Block51(objectType); break;
                case 52: Block52(objectType); break;
                case 53: Block53(objectType); break;
                case 54: Block54(objectType); break;
                case 55: Block55(objectType); break;
                case 56: Block56(objectType); break;
                case 57: Block57(objectType); break;
                case 58: Block58(objectType); break;
                case 59: Block59(objectType); break;
                case 60: Block60(objectType); break;
                case 61: Block61(objectType); break;
                case 62: Block62(objectType); break;
                case 63: Block63(objectType); break;
                case 64: Block64(objectType); break;
                case 65: Block65(objectType); break;
                case 66: Block66(objectType); break;
                case 67: Block67(objectType); break;
                case 68: Block68(objectType); break;
                case 69: Block69(objectType); break;
                case 70: Block70(objectType); break;
                case 71: Block71(objectType); break;
                case 72: Block72(objectType); break;
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
        private void Block25(char o) { if (o == 'x') Block_25.Background = Brushes.Black; else if (o == '0') Block_25.Background = Brushes.Red; else if (o == '1') Block_25.Background = Brushes.Green; }
        private void Block26(char o) { if (o == 'x') Block_26.Background = Brushes.Black; else if (o == '0') Block_26.Background = Brushes.Red; else if (o == '1') Block_26.Background = Brushes.Green; }
        private void Block27(char o) { if (o == 'x') Block_27.Background = Brushes.Black; else if (o == '0') Block_27.Background = Brushes.Red; else if (o == '1') Block_27.Background = Brushes.Green; }
        private void Block28(char o) { if (o == 'x') Block_28.Background = Brushes.Black; else if (o == '0') Block_28.Background = Brushes.Red; else if (o == '1') Block_28.Background = Brushes.Green; }
        private void Block29(char o) { if (o == 'x') Block_29.Background = Brushes.Black; else if (o == '0') Block_29.Background = Brushes.Red; else if (o == '1') Block_29.Background = Brushes.Green; }
        private void Block30(char o) { if (o == 'x') Block_30.Background = Brushes.Black; else if (o == '0') Block_30.Background = Brushes.Red; else if (o == '1') Block_30.Background = Brushes.Green; }
        private void Block31(char o) { if (o == 'x') Block_31.Background = Brushes.Black; else if (o == '0') Block_31.Background = Brushes.Red; else if (o == '1') Block_31.Background = Brushes.Green; }
        private void Block32(char o) { if (o == 'x') Block_32.Background = Brushes.Black; else if (o == '0') Block_32.Background = Brushes.Red; else if (o == '1') Block_32.Background = Brushes.Green; }
        private void Block33(char o) { if (o == 'x') Block_33.Background = Brushes.Black; else if (o == '0') Block_33.Background = Brushes.Red; else if (o == '1') Block_33.Background = Brushes.Green; }
        private void Block34(char o) { if (o == 'x') Block_34.Background = Brushes.Black; else if (o == '0') Block_34.Background = Brushes.Red; else if (o == '1') Block_34.Background = Brushes.Green; }
        private void Block35(char o) { if (o == 'x') Block_35.Background = Brushes.Black; else if (o == '0') Block_35.Background = Brushes.Red; else if (o == '1') Block_35.Background = Brushes.Green; }
        private void Block36(char o) { if (o == 'x') Block_36.Background = Brushes.Black; else if (o == '0') Block_36.Background = Brushes.Red; else if (o == '1') Block_36.Background = Brushes.Green; }
        private void Block37(char o) { if (o == 'x') Block_37.Background = Brushes.Black; else if (o == '0') Block_37.Background = Brushes.Red; else if (o == '1') Block_37.Background = Brushes.Green; }
        private void Block38(char o) { if (o == 'x') Block_38.Background = Brushes.Black; else if (o == '0') Block_38.Background = Brushes.Red; else if (o == '1') Block_38.Background = Brushes.Green; }
        private void Block39(char o) { if (o == 'x') Block_39.Background = Brushes.Black; else if (o == '0') Block_39.Background = Brushes.Red; else if (o == '1') Block_39.Background = Brushes.Green; }
        private void Block40(char o) { if (o == 'x') Block_40.Background = Brushes.Black; else if (o == '0') Block_40.Background = Brushes.Red; else if (o == '1') Block_40.Background = Brushes.Green; }
        private void Block41(char o) { if (o == 'x') Block_41.Background = Brushes.Black; else if (o == '0') Block_41.Background = Brushes.Red; else if (o == '1') Block_41.Background = Brushes.Green; }
        private void Block42(char o) { if (o == 'x') Block_42.Background = Brushes.Black; else if (o == '0') Block_42.Background = Brushes.Red; else if (o == '1') Block_42.Background = Brushes.Green; }
        private void Block43(char o) { if (o == 'x') Block_43.Background = Brushes.Black; else if (o == '0') Block_43.Background = Brushes.Red; else if (o == '1') Block_43.Background = Brushes.Green; }
        private void Block44(char o) { if (o == 'x') Block_44.Background = Brushes.Black; else if (o == '0') Block_44.Background = Brushes.Red; else if (o == '1') Block_44.Background = Brushes.Green; }
        private void Block45(char o) { if (o == 'x') Block_45.Background = Brushes.Black; else if (o == '0') Block_45.Background = Brushes.Red; else if (o == '1') Block_45.Background = Brushes.Green; }
        private void Block46(char o) { if (o == 'x') Block_46.Background = Brushes.Black; else if (o == '0') Block_46.Background = Brushes.Red; else if (o == '1') Block_46.Background = Brushes.Green; }
        private void Block47(char o) { if (o == 'x') Block_47.Background = Brushes.Black; else if (o == '0') Block_47.Background = Brushes.Red; else if (o == '1') Block_47.Background = Brushes.Green; }
        private void Block48(char o) { if (o == 'x') Block_48.Background = Brushes.Black; else if (o == '0') Block_48.Background = Brushes.Red; else if (o == '1') Block_48.Background = Brushes.Green; }
        private void Block49(char o) { if (o == 'x') Block_49.Background = Brushes.Black; else if (o == '0') Block_49.Background = Brushes.Red; else if (o == '1') Block_49.Background = Brushes.Green; }
        private void Block50(char o) { if (o == 'x') Block_50.Background = Brushes.Black; else if (o == '0') Block_50.Background = Brushes.Red; else if (o == '1') Block_50.Background = Brushes.Green; }
        private void Block51(char o) { if (o == 'x') Block_51.Background = Brushes.Black; else if (o == '0') Block_51.Background = Brushes.Red; else if (o == '1') Block_51.Background = Brushes.Green; }
        private void Block52(char o) { if (o == 'x') Block_52.Background = Brushes.Black; else if (o == '0') Block_52.Background = Brushes.Red; else if (o == '1') Block_52.Background = Brushes.Green; }
        private void Block53(char o) { if (o == 'x') Block_53.Background = Brushes.Black; else if (o == '0') Block_53.Background = Brushes.Red; else if (o == '1') Block_53.Background = Brushes.Green; }
        private void Block54(char o) { if (o == 'x') Block_54.Background = Brushes.Black; else if (o == '0') Block_54.Background = Brushes.Red; else if (o == '1') Block_54.Background = Brushes.Green; }
        private void Block55(char o) { if (o == 'x') Block_55.Background = Brushes.Black; else if (o == '0') Block_55.Background = Brushes.Red; else if (o == '1') Block_55.Background = Brushes.Green; }
        private void Block56(char o) { if (o == 'x') Block_56.Background = Brushes.Black; else if (o == '0') Block_56.Background = Brushes.Red; else if (o == '1') Block_56.Background = Brushes.Green; }
        private void Block57(char o) { if (o == 'x') Block_57.Background = Brushes.Black; else if (o == '0') Block_57.Background = Brushes.Red; else if (o == '1') Block_57.Background = Brushes.Green; }
        private void Block58(char o) { if (o == 'x') Block_58.Background = Brushes.Black; else if (o == '0') Block_58.Background = Brushes.Red; else if (o == '1') Block_58.Background = Brushes.Green; }
        private void Block59(char o) { if (o == 'x') Block_59.Background = Brushes.Black; else if (o == '0') Block_59.Background = Brushes.Red; else if (o == '1') Block_59.Background = Brushes.Green; }
        private void Block60(char o) { if (o == 'x') Block_60.Background = Brushes.Black; else if (o == '0') Block_60.Background = Brushes.Red; else if (o == '1') Block_60.Background = Brushes.Green; }
        private void Block61(char o) { if (o == 'x') Block_61.Background = Brushes.Black; else if (o == '0') Block_61.Background = Brushes.Red; else if (o == '1') Block_61.Background = Brushes.Green; }
        private void Block62(char o) { if (o == 'x') Block_62.Background = Brushes.Black; else if (o == '0') Block_62.Background = Brushes.Red; else if (o == '1') Block_62.Background = Brushes.Green; }
        private void Block63(char o) { if (o == 'x') Block_63.Background = Brushes.Black; else if (o == '0') Block_63.Background = Brushes.Red; else if (o == '1') Block_63.Background = Brushes.Green; }
        private void Block64(char o) { if (o == 'x') Block_64.Background = Brushes.Black; else if (o == '0') Block_64.Background = Brushes.Red; else if (o == '1') Block_64.Background = Brushes.Green; }
        private void Block65(char o) { if (o == 'x') Block_65.Background = Brushes.Black; else if (o == '0') Block_65.Background = Brushes.Red; else if (o == '1') Block_65.Background = Brushes.Green; }
        private void Block66(char o) { if (o == 'x') Block_66.Background = Brushes.Black; else if (o == '0') Block_66.Background = Brushes.Red; else if (o == '1') Block_66.Background = Brushes.Green; }
        private void Block67(char o) { if (o == 'x') Block_67.Background = Brushes.Black; else if (o == '0') Block_67.Background = Brushes.Red; else if (o == '1') Block_67.Background = Brushes.Green; }
        private void Block68(char o) { if (o == 'x') Block_68.Background = Brushes.Black; else if (o == '0') Block_68.Background = Brushes.Red; else if (o == '1') Block_68.Background = Brushes.Green; }
        private void Block69(char o) { if (o == 'x') Block_69.Background = Brushes.Black; else if (o == '0') Block_69.Background = Brushes.Red; else if (o == '1') Block_69.Background = Brushes.Green; }
        private void Block70(char o) { if (o == 'x') Block_70.Background = Brushes.Black; else if (o == '0') Block_70.Background = Brushes.Red; else if (o == '1') Block_70.Background = Brushes.Green; }
        private void Block71(char o) { if (o == 'x') Block_71.Background = Brushes.Black; else if (o == '0') Block_71.Background = Brushes.Red; else if (o == '1') Block_71.Background = Brushes.Green; }
        private void Block72(char o) { if (o == 'x') Block_72.Background = Brushes.Black; else if (o == '0') Block_72.Background = Brushes.Red; else if (o == '1') Block_72.Background = Brushes.Green; }

    }
}