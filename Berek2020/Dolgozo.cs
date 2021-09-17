using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek2020
{
  class Dolgozo
  {
    private string nev;

    public string Nev
    {
      get { return nev; }
      set { nev = value; }
    }

    private string nem;

    public string Nem
    {
      get { return nem; }
      set { nem = value; }
    }

    private string reszleg;

    public string Reszleg
    {
      get { return reszleg; }
      set { reszleg = value; }
    }

    private int kezdes;

    public int Kezdes
    {
      get { return kezdes; }
      set { kezdes = value; }
    }

    private int fizetes;

    public int Fizetes
    {
      get { return fizetes; }
      set { fizetes = value; }
    }

    public Dolgozo(string nev, string nem, string reszleg, int kezdes, int fizetes)
    {
      this.nev = nev;
      this.nem = nem;
      this.reszleg = reszleg;
      this.kezdes = kezdes;
      this.fizetes = fizetes;
    }

    public override string ToString()
    {
      return $"\tNév: {nev}\n\tNeme: {nem}\n\tBelépés: {kezdes}\n\tBér: {fizetes:C0} Forint";
    }
  }
}
