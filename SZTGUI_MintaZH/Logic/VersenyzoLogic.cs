using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SZTGUI_MintaZH.Model;

namespace SZTGUI_MintaZH.Logic
{
    public  class VersenyzoLogic
    {

        public void AddVersenyzo(IList<Versenyzo> versenyzok)
        {
            AddOrEditVersenyzoWindow win = new AddOrEditVersenyzoWindow();
            if (win.ShowDialog() == true)
            {
                if (versenyzok.FirstOrDefault(x => x.VersenyzoId == win.Versenyzo.VersenyzoId) != null)
                {
                    throw new IdUtkozesException();
                }
                versenyzok.Add(win.Versenyzo);
            }
        }

        public void EditVersenyzo(Versenyzo v)
        {
            Versenyzo copy = new Versenyzo();
            copy.CopyFrom(v);
            AddOrEditVersenyzoWindow win = new AddOrEditVersenyzoWindow(copy);
            if (win.ShowDialog() == true)
            {
                v.CopyFrom(copy);
            }
        }

        public void DeleteVersenyzo(IList<Versenyzo> versenyzok, Versenyzo v)
        {
            versenyzok.Remove(v);
        }

    }
}
