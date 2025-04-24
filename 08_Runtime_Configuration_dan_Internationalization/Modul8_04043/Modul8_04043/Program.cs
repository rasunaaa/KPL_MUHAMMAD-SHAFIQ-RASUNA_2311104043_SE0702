using System;

class Program
{
    static void Main()
    {
        BankTransferConfig config = new BankTransferConfig();

        string promptAmount = config.lang == "id" ?
            "Masukkan jumlah uang yang akan di-transfer:" :
            "Please insert the amount of money to transfer:";
        Console.WriteLine(promptAmount);
        int amount = int.Parse(Console.ReadLine());

        int fee = amount <= config.transfer.threshold ? config.transfer.low_fee : config.transfer.high_fee;
        int total = amount + fee;

        if (config.lang == "id")
        {
            Console.WriteLine($"Biaya transfer = {fee}");
            Console.WriteLine($"Total biaya = {total}");
            Console.WriteLine("Pilih metode transfer:");
        }
        else
        {
            Console.WriteLine($"Transfer fee = {fee}");
            Console.WriteLine($"Total amount = {total}");
            Console.WriteLine("Select transfer method:");
        }

        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        Console.Write("=> ");
        int method = int.Parse(Console.ReadLine());

        string confirmationText = config.lang == "id" ? config.confirmation.id : config.confirmation.en;
        string confirmPrompt = config.lang == "id" ?
            $"Ketik \"{confirmationText}\" untuk mengkonfirmasi transaksi:" :
            $"Please type \"{confirmationText}\" to confirm the transaction:";
        Console.WriteLine(confirmPrompt);

        string userConfirm = Console.ReadLine();
        if (userConfirm.ToLower() == confirmationText.ToLower())
        {
            Console.WriteLine(config.lang == "id" ? "Proses transfer berhasil" : "The transfer is completed");
        }
        else
        {
            Console.WriteLine(config.lang == "id" ? "Transfer dibatalkan" : "Transfer is cancelled");
        }
    }
}
