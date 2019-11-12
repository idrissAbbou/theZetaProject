using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace EventStudy
{
    public class InputClass {
        public static void InputFunction() {
            //create objects
            MessageSender ms = new MessageSender("hello event");
            
            TheConsoleWriter cw = new TheConsoleWriter();
            TheFileWriter fw = new TheFileWriter();

            //subscribe to the event
            ms.messageHandler += fw.WriteOnAFile;
            ms.messageHandler += cw.WriteOnConsole;
            
            
            ms.SendMessage("hello event");

            int[] fl = new int[] {9,8,7,9,2,4,9,4};
            var result = fl.Where(x=> x%2 ==0).First();
            System.Console.WriteLine(result);
            // foreach (var i in result)
            // {
            //     Console.ForegroundColor = ConsoleColor.Blue;
            //     System.Console.WriteLine(i);
            // }

        }
    }
    
    public class MessageSender {
        public string Message { get; set; }
        public MessageSender(string message)
        {
            Message = message;
        }
        public delegate void MessageHandler(object sender, MessageEvent e);
        public event MessageHandler messageHandler;
        protected virtual void OnMessageSending(string message) {
            if (messageHandler != null)
            {
                //delegate invokation
                messageHandler(this, new MessageEvent() {
                     Message = message,
                     Location = "morocco",
                     Email = "hello@c.com"
                });
            }
        }

        public void SendMessage(string message) {
            this.Message = message + " new message";
            OnMessageSending(this.Message);
        }
    }

    public class TheConsoleWriter {
        public void WriteOnConsole(object sender, MessageEvent e) {
            var color = Console.ForegroundColor;
            Console.ForegroundColor =ConsoleColor.Green;
            System.Console.WriteLine(e.Email);
            System.Console.WriteLine(e.Location);
            System.Console.WriteLine("--------------------------");
            Console.ForegroundColor = color;
            System.Console.WriteLine(e.Message);
        }
    }

    public class TheFileWriter {
        public void WriteOnAFile(object sender, MessageEvent e){
            List<string> lines = new List<string>();
            lines.Add("email: " + e.Email);
            lines.Add("location: " + e.Location);
            lines.Add("-----");
            lines.Add(e.Message);
            File.WriteAllLines("./email.txt", lines);
        }
    }

    public class MessageEvent : EventArgs {
        public string Message { get; set; }
        public string Location {get; set;}
        public string Email {get; set;}
    }
}