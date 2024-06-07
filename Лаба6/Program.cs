using System;
using System.Collections.Generic;

public class EmailMessage
{
    public string Text { get; set; }
    public string Subject { get; set; }
    public string Recipient { get; set; }
    public string Cc { get; set; }
    public string Bcc { get; set; }
    public bool SendSeparately { get; set; }

    public EmailMessage(string text, string subject, string recipient, string cc = "", string bcc = "", bool sendSeparately = false)
    {
        Text = text;
        Subject = subject;
        Recipient = recipient;
        Cc = cc;
        Bcc = bcc;
        SendSeparately = sendSeparately;
    }

    public void SendEmail()
    {
        // Здесь должен быть код для отправки электронной почты.
        // Для тестирования мы просто выводим параметры в консоль.
        Console.WriteLine($"Отправка сообщения: {Subject}");
        Console.WriteLine($"Текст: {Text}");
        Console.WriteLine($"Получатель: {Recipient}");
        Console.WriteLine($"Копия: {Cc}");
        Console.WriteLine($"Скрытая копия: {Bcc}");
        Console.WriteLine($"Отправлять отдельно: {SendSeparately}");
    }
}

class Program
{
    static void Main()
    {
        // Создание и отправка тестового сообщения электронной почты.
        EmailMessage email = new EmailMessage(
            text: "Привет, это тестовое сообщение.",
            subject: "Тестовое Сообщение",
            recipient: "recipient@example.com",
            cc: "cc@example.com",
            bcc: "bcc@example.com",
            sendSeparately: true);

        email.SendEmail();
    }
}