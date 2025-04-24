using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class BankTransferConfig
{
    public string lang { get; set; }
    public Transfer transfer { get; set; }
    public List<string> methods { get; set; }
    public Confirmation confirmation { get; set; }

    private const string configPath = "bank_transfer_config.json";

    public BankTransferConfig()
    {
        if (File.Exists(configPath))
        {
            string json = File.ReadAllText(configPath);
            var config = JsonSerializer.Deserialize<BankTransferConfig>(json);
            this.lang = config.lang;
            this.transfer = config.transfer;
            this.methods = config.methods;
            this.confirmation = config.confirmation;
        }
        else
        {
            this.lang = "en";
            this.transfer = new Transfer() { threshold = 25000000, low_fee = 6500, high_fee = 15000 };
            this.methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
            this.confirmation = new Confirmation() { en = "yes", id = "ya" };
        }
    }
}

public class Transfer
{
    public int threshold { get; set; }
    public int low_fee { get; set; }
    public int high_fee { get; set; }
}

public class Confirmation
{
    public string en { get; set; }
    public string id { get; set; }
}
