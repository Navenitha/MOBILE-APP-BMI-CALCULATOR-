using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase;
using Firebase.Database;
using Firebase.Database.Query;



namespace BMICalculator
{
    internal class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://bmicalculator-2b1e6-default-rtdb.asia-southeast1.firebasedatabase.app/");





      public async Task AddRecord(string dt, double w, double br, string bs)
      {
        await firebase
            .Child("BmiRecords")
            .PostAsync(new BmiRecord() { DateRecorded = dt, Weight = w, BmiResult = br, BmiStatus = bs });
      }


      public async Task<List<BmiRecord>> GetAllBmiRecord()
      {
        return (await firebase
            .Child("BmiRecords")
            .OnceAsync<BmiRecord>()).Select(item => new BmiRecord
            {
                DateRecorded = item.Object.DateRecorded,
                Weight = item.Object.Weight,
                BmiResult = item.Object.BmiResult,
                BmiStatus = item.Object.BmiStatus
            }).ToList();
      }
    }
}