using System;
using System.Collections.Generic;
using TabloidCLI.Models;
using System.Linq;

namespace TabloidCLI.UserInterfaceManagers
{
    public class OptionManager : IUserInterfaceManager
    {
        private readonly IUserInterfaceManager _parentUI;

        public OptionManager(IUserInterfaceManager parentUI)
        {
            _parentUI = parentUI;
        }

        public IUserInterfaceManager Execute()
        {
            Console.WriteLine("");
            Console.WriteLine("Options Menu");
            Console.WriteLine(" 1) Change Background Color");
            Console.WriteLine(" 2) Change Foreground Color");
            
            Console.WriteLine(" 0) Return To Main Menu");

            Console.Write("> ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ChangeBackground();
                    return this;
                case "2":
                    ChangeForeground();
                    return this;
                case "0":
                    return _parentUI;
                
                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }
        }
        private void ChangeBackground()
        {
            
                //ConsoleColor currentBackground = Console.BackgroundColor;
                string currentForeground = Console.ForegroundColor.ToString();
                
                ConsoleColor[] consoleColors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
                // Display the list
                // of available console colors
                int loopCounter = 1;
                Console.WriteLine("");
                Console.WriteLine("List of available " + "Console Colors:");
                foreach (var color in consoleColors)
                {
                    Console.WriteLine($"{loopCounter}){color}");
                    loopCounter++;
                }
            
            Console.WriteLine("Select A Background Color");
            Console.WriteLine("Select 0 To Return To Options Menu");
            
            Console.Write("> ");
            string colorChoice = Console.ReadLine();

            switch (colorChoice)
            {
                case "1":
                    if (currentForeground == "Black")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                            break;
                    }
                    else 
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        break;
                    }
                case "2":
                    if (currentForeground == "DarkBlue")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Clear();
                        break;
                    }
                case "3":
                    if (currentForeground == "DarkGreen")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Clear();
                        break;
                    }
                case "4":
                    if (currentForeground == "DarkCyan")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.Clear();
                        break;
                    }
                case "5":
                    if (currentForeground == "DarkRed")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Clear();
                        break;
                    }
                case "6":
                    if (currentForeground == "DarkMagenta")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        break;
                    }
                case "7":
                    if (currentForeground == "DarkYellow")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Clear();
                        break;
                    }
                case "8":
                    if (currentForeground == "Gray")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        break;
                    }
                case "9":
                    if (currentForeground == "DarkGray")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Clear();
                        break;
                    }
                case "10":
                    if (currentForeground == "Blue")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        break;
                    }
                case "11":
                    if (currentForeground == "Green")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        break;
                    }
                case "12":
                    if (currentForeground == "Cyan")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        break;
                    }
                case "13":
                    if (currentForeground == "Red")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        break;
                    }
                case "14":
                    if (currentForeground == "Magenta")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.Clear();
                        break;
                    }
                case "15":
                    if (currentForeground == "Yellow")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        break;
                    }
                case "16":
                    if (currentForeground == "White")
                    {
                        Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        break;
                    }
                case "0":
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }

            private void ChangeForeground()
            {
                
                string currentBackground = Console.BackgroundColor.ToString();
                //string currentForeground = Console.ForegroundColor.ToString();

                ConsoleColor[] consoleColors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
                    // Display the list
                    // of available console colors
                    int loopCounter = 1;
                    Console.WriteLine("");
                    Console.WriteLine("List of available " + "Console Colors:");
                    foreach (var color in consoleColors)
                    {
                        Console.WriteLine($"{loopCounter}){color}");
                        loopCounter++;
                    }
                
                Console.WriteLine("Select A Foreground Color");
                Console.WriteLine("Select 0 To Return To Options Menu");
                Console.Write("> ");
                string colorChoice = Console.ReadLine();
            switch (colorChoice)
            {
                case "1":
                    if (currentBackground == "Black")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                break;
            }
                case "2":
                    if (currentBackground == "DarkBlue")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                break;
            }
                case "3":
                    if (currentBackground == "DarkGreen")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                break;
            }
                case "4":
                    if (currentBackground == "DarkCyan")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Clear();
                break;
            }
                case "5":
                    if (currentBackground == "DarkRed")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                break;
            }
                case "6":
                    if (currentBackground == "DarkMagenta")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
                break;
            }
                case "7":
                    if (currentBackground == "DarkYellow")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                break;
            }
                case "8":
                    if (currentBackground == "Gray")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
                break;
            }
                case "9":
                    if (currentBackground == "DarkGray")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                break;
            }
                case "10":
                    if (currentBackground == "Blue")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
                break;
            }
                case "11":
                    if (currentBackground == "Green")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                break;
            }
                case "12":
                    if (currentBackground == "Cyan")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                break;
            }
                case "13":
                    if (currentBackground == "Red")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                break;
            }
                case "14":
                    if (currentBackground == "Magenta")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Clear();
                break;
            }
                case "15":
                    if (currentBackground == "Yellow")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                break;
            }
                case "16":
                    if (currentBackground == "White")
            {
                Console.WriteLine("Setting The Background Color The Same As The Text Color Is Not A Good Idea");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                break;
            }
                case "0":
                    break;
            default:
                    Console.WriteLine("Invalid Selection");
            break;
        }
            }
        }
    }
    
