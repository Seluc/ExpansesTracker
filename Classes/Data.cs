using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProj.Classes {
  public class Data {
    public long Id { get; set; }
    public int UID { get; set; }
    public int Type { get; set; } // 0 - OneTime | 1 - Monthly
    public int Account { get; set; }
    public decimal Amount { get; set; }
    public string Comment { get; set; }
    public int Currency { get; set; }
    public DateTime Date { get; set; }
  }
}
