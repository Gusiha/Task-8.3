using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Task_8._3
{
    class Messenger<I, O>
    where I : User
    where O : Reciever
    {
        public I Person { get; set; }
        public O Reciever { get; set; }
        public string Message { get; set; }

        public bool IsCorrect(string message)
        {
            string[] strings = Message.Split('\n');
            for (int i = 0; i < strings.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            if (Regex.IsMatch(strings[i], @"^Name: [a-zA-Z]{3,14}$"))
                            {
                                break;
                            }
                            else
                            {
                                Debug.WriteLine($"Name is not correct");
                                return false;
                            }

                        }

                    case 1:
                        {
                            if (Regex.IsMatch(strings[i], @"^Password: (?=.*\d).{4,12}$"))
                            {
                                break;
                            }
                            else
                            {
                                Debug.WriteLine($"Password is not correct");
                                return false;
                            }
                            
                        }

                    case 2:
                        {
                            if (Regex.IsMatch(strings[i], @"^Email: \w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
                            {
                                break;
                            }
                            else
                            {
                                Debug.WriteLine($"Email is not correct");
                                return false;
                            }
                        }
                    default:
                        break;
                }


            }
            return true;
        }

        public void SendMessage()
        {
            if (IsCorrect(Message)) Reciever.WriteInFile(Message);
            else throw new Exception("Incorrect information about User");
        }

        public Messenger(I person, O reciever)
        {
            Person = person;
            Reciever = reciever;
            Message = Person.GetFullInformation();
        }

    }
}
