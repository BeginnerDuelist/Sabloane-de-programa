using System.Net.Mail;

namespace Builder
{
     class Program
     {
          public static void WriteInfo(MailMessage message)
          {
               Console.WriteLine("Message is from " + message.From);
               Console.WriteLine("\nMessage is for:");
               for (int i = 0; i < message.To.Count; i++)
               {
                    Console.WriteLine(message.To[i]);
               }
               Console.WriteLine("\nSubject:");
               Console.Write(message.Subject);
               Console.WriteLine("\nBody:");
               Console.WriteLine(message.Body);
               Console.WriteLine("\nAttachement:");
               Console.WriteLine(message.AttachementPath);
          }
          static void Main(string[] args)
          {
               MailMessage message = MailMessage.With()
                    .From("catalinbuza31@gmail.com")
                    .To("dima123@gmail.com")
                    .To("uevvyuvu122@mail.ru")
                    .Subject("Test Builder")
                    .Body("This is a test!!!")
                    .AttachementPath("C:\\User\\Desktop...")
                    .Build();     
               
               WriteInfo(message);
          }
     }
}