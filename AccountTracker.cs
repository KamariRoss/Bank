using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using CsvHelper;

namespace Bank
{
  public class AccountTracker
  {
    public List<Account> Accounts { get; set; } = new List<Account>();
    public Account AccountReader()
    {
      var reader = new StreamReader("Account.csv");
      var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
      var acctList = csvReader.GetRecords<Account>().ToList();
      var acct1 = acctList[0];
      return acct1;
    }

    public void Deposit()
    {
      if (bankRequest == )
    }
    public void Remove()
    {

    }
  }
}