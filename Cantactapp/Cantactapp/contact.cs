using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cantactapp
{
    class contact
    {
        string ho;
  string ten;
  string diachi;
  string sdt;

  public Contact(string ho, string ten, string diachi, string sdt)
  {
      this.ho = ho;
      this.ten = ten;
      this.diachi = diachi;
      this.sdt = sdt;
  }

  public void SetHo(string ho)
  {
      this.ho = ho;
  }

  public string GetHo()
  {
      return this.ho;
  }

  public void SetTen(string ten)
  {
      this.ten = ten;
  }

  public string GetTen()
  {
      return this.ten;
  }

  public void SetDiaChi(string diachi)
  {
      this.diachi = diachi;
  }

  public string GetDiaChi()
  {
      return this.diachi;
  }

  public void SetSDT(string sdt)
  {
      this.sdt = sdt;
  }

  public string GetSDT()
  {
      return this.sdt;
  }
    }
}
